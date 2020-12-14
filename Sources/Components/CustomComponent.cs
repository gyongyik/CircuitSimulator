using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace CircuitSimulator.Components
{
    internal class CustomComponent : Component
    {
        private const string NAME = "name";
        private const string SUBCOMPONENT = "subcomponent";

        public CustomComponent()
        {
            Bounds = new(0, 0, 110, 50);
            CustomController = new();
            Name = "unknown";
        }

        public CustomComponent(string name) : this()
        {
            Name = name;
        }

        public void LoadCircuit(XmlReader reader)
        {
            CustomController.Read(reader);
            InitializeFromCircuit();
        }

        public void LoadCircuit(Stream stream)
        {
            XmlReader reader = XmlReader.Create(stream);
            LoadCircuit(reader);
        }

        public override void Execute()
        {
            CustomController.Run();
            base.Execute();
        }

        protected override ComponentControl CreateComponentControl()
        {
            return new CustomComponentControl(this);
        }

        public override void Write(XmlWriter writer)
        {
            writer.WriteElementString(NAME, Name);
            writer.WriteStartElement(SUBCOMPONENT);
            CustomController.Write(writer);
            writer.WriteEndElement();
        }

        public override void Read(XmlReader reader)
        {
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name == NAME)
                        {
                            Name = reader.ReadElementContentAsString();
                        }
                        else if (reader.Name == SUBCOMPONENT)
                        {
                            XmlReader subreader = reader.ReadSubtree();
                            LoadCircuit(subreader);
                        }
                        break;
                }
            }
        }

        public ComponentController CustomController{ get; }

        public string Name { get; private set; }

        private bool IsInput(Component c)
        {
            return (c.GetType() == typeof(InputPin)) || (c.GetType() == typeof(Input));
        }

        private bool IsOutput(Component c)
        {
            return (c.GetType() == typeof(OutputPin)) || (c.GetType() == typeof(Output));
        }

        private void InitializeFromCircuit()
        {
            List<Component> componentList = new();

            int inputCount = 0;
            int outputCount = 0;

            foreach (Component c in CustomController.Components)
            {
                if (IsInput(c))
                {
                    inputCount++;
                    componentList.Add(c);
                }
                if (IsOutput(c))
                {
                    outputCount++;
                    componentList.Add(c);
                }
            }

            int inputOffset = 20;
            int inputLocation = 10;
            int outputOffset = 20;
            int outputLocation = 10;

            int height = 20 + inputOffset * Math.Max(inputCount - 1, outputCount - 1);
            height = Math.Max(height, 50);
            Bounds = new Rectangle(0, 0, 110, height);
            Reinitalize(inputCount, outputCount);

            for (int i = 0; i < componentList.Count; ++i)
            {
                // Add input to the left side
                if (IsInput(componentList[i]))
                {
                    // Replace InputPin with Input
                    Input input = new(componentList[i], Connections[i]);
                    CustomController.Remove(componentList[i]);
                    CustomController.Add(input);
                    CustomController.ConnectComponent(input);

                    Connections[i].Location = new(5, inputLocation);
                    inputLocation += inputOffset;
                }

                // Add output to the right side
                if (IsOutput(componentList[i]))
                {
                    // Replace OutputPin with Output
                    Output output = new(componentList[i], Connections[i]);
                    CustomController.Remove(componentList[i]);
                    CustomController.Add(output);
                    CustomController.ConnectComponent(output);

                    Connections[i].Location = new(Width - 5, outputLocation);
                    outputLocation += outputOffset;
                }
            }
        }

        private class CustomComponentControl : ComponentControl
        {
            private CustomComponent _component;

            public CustomComponentControl(CustomComponent component) : base(component)
            {
                _component = component;
            }

            class CustomComponentForm : Form
            {
                public CustomComponentForm()
                {
                    BackColor = Color.White;
                }
            }

            public override void ShowContextMenu(ContextMenuStrip menu, CancelEventArgs ce)
            {
                ToolStripItem show = new ToolStripButton("Show");
                show.Click += new((object sender, EventArgs e) =>
                {
                    ShowCustomComponentForm();
                });
                menu.Items.Add(show);
            }

            protected override void OnMouseDoubleClick(MouseEventArgs e)
            {
                base.OnMouseDoubleClick(e);

                ShowCustomComponentForm();
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = new(15, 5, Width - 30, Height - 10);
                Pen pen = new(Color.DimGray, 3);

                for (int i = 0; i < _component.Connections.Length; ++i)
                {
                    if (_component.Connections[i].Location.X < rect.Left)
                    {
                        g.DrawLine(pen, 
                            new(_component.Connections[i].Location.X + 3, _component.Connections[i].Location.Y), 
                            new(rect.Left, _component.Connections[i].Location.Y));
                    }
                    else
                    {
                        g.DrawLine(pen, 
                            new(_component.Connections[i].Location.X - 3, _component.Connections[i].Location.Y),
                            new(rect.Right, _component.Connections[i].Location.Y));
                    }

                    Color color = _component.GetValue(i) ? Color.Tomato : Color.DimGray;
                    int width = _component.Connections[i].Connections.Count > 0 ? 3 : 1;
                    Point point = Point.Subtract(_component.Connections[i].Location, new(3, 3));
                    g.DrawEllipse(new(color, width), new(point, new(6, 6)));
                }

                g.DrawRectangle(pen, rect);
                g.DrawString(_component.Name, new("Consolas", 12, FontStyle.Bold), Brushes.DimGray, rect);
            }

            private void ShowCustomComponentForm()
            {
                Form form = new CustomComponentForm();

                Rectangle boundingBox = new();
                foreach (Component c in _component.CustomController.Components)
                {
                    c.Show(form, null);
                    Rectangle controlBounds = c.Bounds;
                    controlBounds.Offset(c.Location);
                    if (boundingBox.IsEmpty)
                    {
                        boundingBox = controlBounds;
                    }
                    else
                    {
                        boundingBox = Rectangle.Union(boundingBox, controlBounds);
                    }
                }
                form.Width = boundingBox.Right + boundingBox.Left;
                form.Height = boundingBox.Bottom + boundingBox.Top + 35;
                form.Text = _component.Name;
                form.ShowDialog();
                form.Dispose();
            }
        }

        private class IOComponent : Component
        {
            protected Connection IOConnection { get; set; }

            public IOComponent() : base(1, 0)
            {
                Connections[0] = new WireConnection(this);
            }

            public IOComponent(Component copy, Connection connection) : base(copy.Connections.Length, 0)
            {
                IOConnection = connection;
                Bounds = copy.Bounds;
                Connections[0] = new WireConnection(this);
                Connections[0].Location = copy.Connections[0].Location;
                Location = copy.Location;
            }
        }

        private class Input : IOComponent
        {
            public Input() : base()
            {
                Bounds = new(0, 0, 105, 50);
                Connections[0].Location = new(this.Width - 5, this.Height / 2);
            }

            public Input(Component copy, Connection connection) : base(copy, connection)
            {
            }

            public override bool GetValue(int index)
            {
                bool result = false;
                foreach (Connection c in IOConnection.Connections)
                {
                    result |= c.Value;
                }

                return result;
            }

            protected override ComponentControl CreateComponentControl()
            {
                return new InputControl(this);
            }

            private class InputControl : ComponentControl
            {
                public InputControl(Input _) : base(_)
                {
                }

                protected override void OnPaint(PaintEventArgs e)
                {
                    Graphics g = e.Graphics;

                    for (int i = 0; i < Component.Connections.Length; ++i)
                    {
                        Color color = Component.GetValue(i) ? Color.Red : Color.Black;
                        int width = Component.Connections[i].Connections.Count > 0 ? 3 : 1;
                        Point point = Point.Subtract(Component.Connections[i].Location, new(2, 2));
                        g.DrawEllipse(new(color, width), new(point, new(4, 4)));
                    }

                    Pen pen = new(Color.Black, 3);
                    g.DrawLine(pen, new(15, 10), new(23, 10));

                    Rectangle rect = new(5, 5, 10, 10);
                    g.FillRectangle(Component.GetValue(0) ? Brushes.Red : Brushes.Black, rect);
                    g.DrawRectangle(pen, rect);
                }
            }
        }

        private class Output : IOComponent
        {
            public Output() : base()
            {
                Bounds = new(0, 0, 30, 20);
                Connections[0].Location = new(5, this.Height / 2);
            }

            public Output(Component copy, Connection connection) : base(copy, connection)
            {
            }

            public override void Execute()
            {
                bool result = false;
                foreach (Connection c in Connections[0].Connections)
                {
                    result |= c.Value;
                }

                IOConnection.Value = result;
                base.Execute();
            }

            protected override ComponentControl CreateComponentControl()
            {
                return new OutputControl(this);
            }

            private class OutputControl : ComponentControl
            {
                public OutputControl(Output _) : base(_)
                {
                }

                protected override void OnPaint(PaintEventArgs e)
                {
                    Graphics g = e.Graphics;
                    g.SmoothingMode = SmoothingMode.AntiAlias;

                    for (int i = 0; i < Component.Connections.Length; ++i)
                    {
                        Color color = Component.GetValue(i) ? Color.Red : Color.Black;
                        int width = Component.Connections[i].Connections.Count > 0 ? 3 : 1;
                        Point point = Point.Subtract(Component.Connections[i].Location, new(2, 2));
                        g.DrawEllipse(new(color, width), new(point, new(4, 4)));
                    }

                    Pen pen = new(Color.Black, 3);
                    g.DrawLine(pen, new(8, 10), new(15, 10));

                    Rectangle rect = new(15, 5, 10, 10);
                    g.FillRectangle(Component.GetValue(0) ? Brushes.Red : Brushes.Black, rect);
                    g.DrawRectangle(pen, rect);
                }
            }
        }
    }
}
