﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CircuitSimulator.Components
{
    internal class Ic : Component
    {
        private const string NAME = "name";
        private const string SUBCIRCUIT = "subcircuit";

        public Ic()
        {
            Bounds = new Rectangle(0, 0, 110, 50);
            InternalCircuit = new ComponentController();
            Name = "unknown";
        }

        public Ic(string name) : this()
        {
            Name = name;
        }

        public void LoadCircuit(System.Xml.XmlReader reader)
        {
            InternalCircuit.Read(reader);
            InitializeFromCircuit();
        }

        public void LoadCircuit(System.IO.Stream stream)
        {
            System.Xml.XmlReader reader = System.Xml.XmlReader.Create(stream);
            LoadCircuit(reader);
        }

        public override void Execute()
        {
            InternalCircuit.Run();
            base.Execute();
        }

        protected override ComponentControl CreateComponentControl()
        {
            return new IcComponentControl(this);
        }

        public override void Write(System.Xml.XmlWriter writer)
        {
            writer.WriteElementString(NAME, Name);
            writer.WriteStartElement(SUBCIRCUIT);
            InternalCircuit.Write(writer);
            writer.WriteEndElement();
        }

        public override void Read(System.Xml.XmlReader reader)
        {
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case System.Xml.XmlNodeType.Element:
                        if (reader.Name == NAME)
                        {
                            Name = reader.ReadElementContentAsString();
                        }
                        else if (reader.Name == SUBCIRCUIT)
                        {
                            System.Xml.XmlReader subreader = reader.ReadSubtree();
                            LoadCircuit(subreader);
                        }
                        break;
                }
            }
        }

        public ComponentController InternalCircuit { get; }

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
            List<Component> componentList = new List<Component>();

            int inputCount = 0;
            int outputCount = 0;

            foreach (Component c in InternalCircuit.Components)
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
                    Input input = new Input(componentList[i], Connections[i]);
                    InternalCircuit.Remove(componentList[i]);
                    InternalCircuit.Add(input);
                    InternalCircuit.ConnectComponent(input);

                    Connections[i].Location = new Point(5, inputLocation);
                    inputLocation += inputOffset;
                }

                // Add output to the right side
                if (IsOutput(componentList[i]))
                {
                    // Replace OutputPin with Output
                    Output output = new Output(componentList[i], Connections[i]);
                    InternalCircuit.Remove(componentList[i]);
                    InternalCircuit.Add(output);
                    InternalCircuit.ConnectComponent(output);

                    Connections[i].Location = new Point(Width - 5, outputLocation);
                    outputLocation += outputOffset;
                }
            }
        }

        private class IcComponentControl : ComponentControl
        {
            private Ic _component;

            public IcComponentControl(Ic component) : base(component)
            {
                _component = component;
            }

            class IcForm : Form
            {
                public IcForm()
                {
                    BackColor = Color.White;
                }
            }

            public override void ShowContextMenu(ContextMenuStrip menu, CancelEventArgs ce)
            {
                ToolStripItem show = new ToolStripButton("Show");
                show.Click += new EventHandler(delegate (object sender, EventArgs e)
                {
                    ShowIcForm();
                });
                menu.Items.Add(show);
            }

            protected override void OnMouseDoubleClick(MouseEventArgs e)
            {
                base.OnMouseDoubleClick(e);

                ShowIcForm();
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(15, 5, Width - 30, Height - 10);
                Pen pen = new Pen(Color.DimGray, 3);

                for (int i = 0; i < _component.Connections.Length; ++i)
                {
                    if (_component.Connections[i].Location.X < rect.Left)
                    {
                        g.DrawLine(pen, new Point(_component.Connections[i].Location.X + 3, _component.Connections[i].Location.Y), new Point(rect.Left, _component.Connections[i].Location.Y));
                    }
                    else
                    {
                        g.DrawLine(pen, new Point(_component.Connections[i].Location.X - 3, _component.Connections[i].Location.Y), new Point(rect.Right, _component.Connections[i].Location.Y));
                    }

                    Color c = _component.GetValue(i) ? Color.Tomato : Color.DimGray;
                    int w = _component.Connections[i].Connections.Count > 0 ? 3 : 1;
                    g.DrawEllipse(new Pen(c, w), new Rectangle(Point.Subtract(_component.Connections[i].Location, new Size(3, 3)), new Size(6, 6)));
                }

                g.DrawRectangle(pen, rect);
                g.DrawString(_component.Name, new Font("Consolas", 12, FontStyle.Bold), Brushes.DimGray, rect);
            }

            private void ShowIcForm()
            {
                Form form = new IcForm();

                Rectangle boundingBox = new Rectangle();
                foreach (Component c in _component.InternalCircuit.Components)
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
                Bounds = new Rectangle(0, 0, 105, 50);
                Connections[0].Location = new Point(this.Width - 5, this.Height / 2);
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
                        Color c = Component.GetValue(i) ? Color.Red : Color.Black;
                        int w = Component.Connections[i].Connections.Count > 0 ? 3 : 1;
                        g.DrawEllipse(new Pen(c, w), new Rectangle(Point.Subtract(Component.Connections[i].Location, new Size(2, 2)), new Size(4, 4)));
                    }

                    Pen pen = new Pen(Color.Black, 3);
                    g.DrawLine(pen, new Point(15, 10), new Point(23, 10));
                    Rectangle rect = new Rectangle(5, 5, 10, 10);
                    g.FillRectangle(Component.GetValue(0) ? Brushes.Red : Brushes.Black, rect);
                    g.DrawRectangle(pen, rect);
                }
            }
        }

        private class Output : IOComponent
        {
            public Output() : base()
            {
                Bounds = new Rectangle(0, 0, 30, 20);
                Connections[0].Location = new Point(5, this.Height / 2);
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
                        Color c = Component.GetValue(i) ? Color.Red : Color.Black;
                        int w = Component.Connections[i].Connections.Count > 0 ? 3 : 1;
                        g.DrawEllipse(new Pen(c, w), new Rectangle(Point.Subtract(Component.Connections[i].Location, new Size(2, 2)), new Size(4, 4)));
                    }

                    Pen pen = new Pen(Color.Black, 3);
                    g.DrawLine(pen, new Point(8, 10), new Point(15, 10));
                    Rectangle rect = new Rectangle(15, 5, 10, 10);
                    g.FillRectangle(Component.GetValue(0) ? Brushes.Red : Brushes.Black, rect);
                    g.DrawRectangle(pen, rect);
                }
            }
        }
    }
}
