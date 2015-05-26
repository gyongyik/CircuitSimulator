using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    class IC : Component
    {
        private ComponentController fCircuit;
        private string fName;

        public IC()
        {
            Bounds = new Rectangle(0, 0, 105, 50);
            fCircuit = new ComponentController();
            fName = "unknown";
        }

        public IC(string name) : this()
        {
            fName = name;
        }

        public void LoadCircuit(System.Xml.XmlReader reader)
        {
            fCircuit.Read(reader);
            InitializeFromCircuit();
        }

        public void LoadCircuit(System.IO.Stream stream)
        {
            System.Xml.XmlReader reader = System.Xml.XmlReader.Create(stream);
            LoadCircuit(reader);
        }

        public override void Execute()
        {
            fCircuit.Run();
            base.Execute();
        }

        protected override ComponentControl CreateComponentControl()
        {
            return new ICComponentControl(this);
        }

        public override void Write(System.Xml.XmlWriter writer)
        {
            writer.WriteElementString("name", fName);
            writer.WriteStartElement("subcircuit");
            fCircuit.Write(writer);
            writer.WriteEndElement();
        }

        public override void Read(System.Xml.XmlReader reader)
        {
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case System.Xml.XmlNodeType.Element:
                        if (reader.Name == "name")
                        {
                            fName = reader.ReadElementContentAsString();
                        }
                        else if (reader.Name == "subcircuit")
                        {
                            System.Xml.XmlReader subreader = reader.ReadSubtree();
                            LoadCircuit(subreader);
                        }
                        break;
                }
            }
        }

        public ComponentController InternalCircuit
        {
            get
            {
                return fCircuit;
            }
        }

        public string Name
        {
            get
            {
                return fName;
            }
        }

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

            foreach (Component c in fCircuit.Components)
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
            Bounds = new Rectangle(0, 0, 105, height);
            Reinitalize(inputCount, outputCount);

            for (int i = 0; i < componentList.Count; ++i)
            {
                // Add input to the left side
                if (IsInput(componentList[i]))
                {
                    // Replace InputPin with Input
                    Input input = new Input(componentList[i], fConnections[i]);
                    fCircuit.Remove(componentList[i]);
                    fCircuit.Add(input);
                    fCircuit.ConnectComponent(input);

                    fConnections[i].Location = new Point(5, inputLocation);
                    inputLocation += inputOffset;
                }

                // Add output to the right side
                if (IsOutput(componentList[i]))
                {
                    // Replace OutputPin with Output
                    Output output = new Output(componentList[i], fConnections[i]);
                    fCircuit.Remove(componentList[i]);
                    fCircuit.Add(output);
                    fCircuit.ConnectComponent(output);

                    fConnections[i].Location = new Point(Width - 5, outputLocation);
                    outputLocation += outputOffset;
                }
            }
        }

        private class ICComponentControl : ComponentControl
        {
            private IC fComp;

            public ICComponentControl(IC component) : base(component)
            {
                fComp = component;
            }

            class ICForm : Form
            {
                public ICForm()
                {
                    BackColor = Color.White;
                }
            }

            protected override void OnMouseDoubleClick(MouseEventArgs e)
            {
                base.OnMouseDoubleClick(e);

                Form f = new ICForm();

                Rectangle boundingBox = new Rectangle();
                foreach (Component c in fComp.InternalCircuit.Components)
                {
                    c.Show(f, null);
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
                f.Width = boundingBox.Right + 50;
                f.Height = boundingBox.Bottom + 50;
                f.Text = fComp.Name;
                f.ShowDialog();
                f.Dispose();
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                Rectangle rect = new Rectangle(15, 5, Width - 30, Height - 10);
                Pen pen = new Pen(Color.Black, 3);

                for (int i = 0; i < fComp.Connections.Length; ++i)
                {
                    if (fComp.Connections[i].Location.X < rect.Left)
                    {
                        g.DrawLine(pen, new Point(fComp.Connections[i].Location.X + 2, fComp.Connections[i].Location.Y), new Point(rect.Left, fComp.Connections[i].Location.Y));
                    }
                    else
                    {
                        g.DrawLine(pen, new Point(fComp.Connections[i].Location.X - 2, fComp.Connections[i].Location.Y), new Point(rect.Right, fComp.Connections[i].Location.Y));
                    }

                    Color c = fComp.GetValue(i) ? Color.Red : Color.Black;
                    int w = fComp.Connections[i].Connections.Count > 0 ? 3 : 1;
                    g.DrawEllipse(new Pen(c, w), new Rectangle(Point.Subtract(fComp.Connections[i].Location, new Size(2, 2)), new Size(4, 4)));
                }

                g.FillRectangle(Brushes.Black, rect);
                g.DrawRectangle(pen, rect);
                g.DrawString(fComp.Name, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.White, rect);
            }

        }

        private class IOComponent : Component
        {
            protected Connection fIOConnection;

            public IOComponent() : base(1, 0)
            {
                Connections[0] = new WireConnection(this);
            }

            public IOComponent(Component copy, Connection conn) : base(copy.Connections.Length, 0)
            {
                fIOConnection = conn;
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
                Bounds = new Rectangle(0, 0, 100, 50);
                Connections[0].Location = new Point(this.Width - 5, this.Height / 2);
            }

            public Input(Component copy, Connection conn) : base(copy, conn)
            {
                //
            }

            public override bool GetValue(int index)
            {
                bool result = false;
                foreach (Connection c in fIOConnection.Connections)
                {
                    result |= c.Value;
                }

                return result;
            }

            public override void Execute()
            {
                //bool result = false;
                //foreach (Connection c in fIOConnection.Connections)
                //{
                //    result |= c.Value;
                //}

                //SetValue(0, result);
                base.Execute();
            }

            protected override ComponentControl CreateComponentControl()
            {
                return new InputControl(this);
            }

            class InputControl : ComponentControl
            {
                Input fParent;

                public InputControl(Input parent) : base(parent)
                {
                    fParent = parent;
                }

                protected override void OnPaint(PaintEventArgs e)
                {
                    Graphics g = e.Graphics;

                    for (int i = 0; i < fComponent.GetComponent().Connections.Length; ++i)
                    {
                        Color c = fComponent.GetComponent().GetValue(i) ? Color.Red : Color.Black;
                        int w = fComponent.GetComponent().Connections[i].Connections.Count > 0 ? 3 : 1;
                        g.DrawEllipse(new Pen(c, w), new Rectangle(Point.Subtract(fComponent.GetComponent().Connections[i].Location, new Size(2, 2)), new Size(4, 4)));
                    }

                    Pen pen = new Pen(Color.Black, 3);
                    g.DrawLine(pen, new Point(15, 10), new Point(23, 10));
                    Rectangle rect = new Rectangle(5, 5, 10, 10);
                    g.FillRectangle(fComponent.GetComponent().GetValue(0) ? Brushes.Red : Brushes.Black, rect);
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

            public Output(Component copy, Connection conn) : base(copy, conn)
            {
                //
            }

            public override void Execute()
            {
                bool result = false;
                foreach (Connection c in Connections[0].Connections)
                {
                    result |= c.Value;
                }

                fIOConnection.Value = result;
                base.Execute();
            }

            protected override ComponentControl CreateComponentControl()
            {
                return new OutputControl(this);
            }

            class OutputControl : ComponentControl
            {
                Output fParent;

                public OutputControl(Output parent) : base(parent)
                {
                    fParent = parent;
                }

                protected override void OnPaint(PaintEventArgs e)
                {
                    Graphics g = e.Graphics;

                    for (int i = 0; i < fComponent.GetComponent().Connections.Length; ++i)
                    {
                        Color c = fComponent.GetComponent().GetValue(i) ? Color.Red : Color.Black;
                        int w = fComponent.GetComponent().Connections[i].Connections.Count > 0 ? 3 : 1;
                        g.DrawEllipse(new Pen(c, w), new Rectangle(Point.Subtract(fComponent.GetComponent().Connections[i].Location, new Size(2, 2)), new Size(4, 4)));
                    }

                    Pen pen = new Pen(Color.Black, 3);
                    g.DrawLine(pen, new Point(8, 10), new Point(15, 10));
                    Rectangle rect = new Rectangle(15, 5, 10, 10);
                    g.FillRectangle(fComponent.GetComponent().GetValue(0) ? Brushes.Red : Brushes.Black, rect);
                    g.DrawRectangle(pen, rect);
                }
            }
        }
    }
}
