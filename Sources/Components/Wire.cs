using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Xml;

namespace CircuitSimulator.Components
{
    internal class WireConnection : Connection
    {
        private bool _processing;

        public WireConnection(Component component) : base(component)
        {
            _processing = false;
        }

        public override bool Value
        {
            get
            {
                if (_processing)
                {
                    return false;
                }
                else
                {
                    _processing = true;
                    bool value = Parent.GetValue(0) || Parent.GetValue(1);
                    _processing = false;
                    return value;
                }
            }
        }
    }

    internal class Wire : Component
    {
        private const string WIDTH = "width";
        private const string HEIGHT = "height";
        private const string FLIPPED = "flipped";

        public bool Flipped { get; set; }

        public Wire() : base(1, 1)
        {
            Point in0 = new(5, 5);
            Point in1 = new(95, 45);

            Bounds = new(0, 0, Math.Max(in0.X, in1.X) + 5, Math.Max(in0.Y, in1.Y) + 5);

            Connections[0] = new WireConnection(this);
            Connections[1] = new WireConnection(this);
            Connections[0].Location = in0;
            Connections[1].Location = in1;
        }

        public Wire(Point in0, Point in1) : base(1, 1)
        {
            int direction = 0;

            if (in0.X < in1.X)
            {
                in0.X += 5;
                in1.X -= 5;
            }
            else
            {
                in0.X -= 5;
                in1.X += 5;

                direction++;
            }

            if (in0.Y < in1.Y)
            {
                in0.Y += 5;
                in1.Y -= 5;
            }
            else
            {
                in0.Y -= 5;
                in1.Y += 5;

                direction++;
            }

            if (direction == 1)
            {
                Flipped = true;
            }

            Bounds = new(0, 0, Math.Max(in0.X, in1.X) + 5, Math.Max(in0.Y, in1.Y) + 5);

            Connections[0] = new WireConnection(this);
            Connections[1] = new WireConnection(this);
            Connections[0].Location = in0;
            Connections[1].Location = in1;
        }

        public override void Write(XmlWriter writer)
        {
            writer.WriteStartElement(WIDTH);
            writer.WriteValue(Width - 10);
            writer.WriteEndElement();

            writer.WriteStartElement(HEIGHT);
            writer.WriteValue(Height - 10);
            writer.WriteEndElement();

            writer.WriteStartElement(FLIPPED);
            writer.WriteValue(Flipped);
            writer.WriteEndElement();
        }

        public override void Read(XmlReader reader)
        {
            reader.ReadToFollowing(WIDTH);
            if (reader.IsStartElement(WIDTH))
            {
                SetWidth(reader.ReadElementContentAsInt());
            }

            reader.ReadToFollowing(HEIGHT);
            if (reader.IsStartElement(HEIGHT))
            {
                SetHeight(reader.ReadElementContentAsInt());
            }

            reader.ReadToFollowing(FLIPPED);
            if (reader.IsStartElement(FLIPPED))
            {
                Flipped = reader.ReadElementContentAsBoolean();
                if (Flipped)
                {
                    Flip();
                }
            }
        }

        public void SetWidth(int value)
        {
            if (Connections[1].Location.X < Connections[0].Location.X)
            {
                Connections[0].Location = new(Connections[1].Location.X + value, Connections[0].Location.Y);
            }
            else
            {
                Connections[1].Location = new(Connections[0].Location.X + value, Connections[1].Location.Y);
            }
            Bounds = new(Location.X, Location.Y, 
                Math.Max(Connections[0].Location.X, Connections[1].Location.X) + 5, 
                Math.Max(Connections[0].Location.Y, Connections[1].Location.Y) + 5);
        }

        public void SetHeight(int value)
        {
            if (Connections[1].Location.Y < Connections[0].Location.Y)
            {
                Connections[0].Location = new(Connections[0].Location.X, Connections[1].Location.Y + value);
            }
            else
            {
                Connections[1].Location = new(Connections[1].Location.X, Connections[0].Location.Y + value);
            }
            Bounds = new(Location.X, Location.Y, 
                Math.Max(Connections[0].Location.X, Connections[1].Location.X) + 5, 
                Math.Max(Connections[0].Location.Y, Connections[1].Location.Y) + 5);
        }

        public void Flip()
        {
            int x = Connections[0].Location.X;
            Connections[0].Location = new(Connections[1].Location.X, Connections[0].Location.Y);
            Connections[1].Location = new(x, Connections[1].Location.Y);
        }

        public override bool GetValue(int index)
        {
            bool result = false;

            foreach (Connection c in Connections[0].Connections)
            {
                result |= c.Value;
            }

            foreach (Connection c in Connections[1].Connections)
            {
                result |= c.Value;
            }

            return result;
        }

        protected override void OnDisconnect()
        {
            SetValue(0, false);
            SetValue(1, false);
            base.OnDisconnect();
        }

        protected override ComponentControl CreateComponentControl()
        {
            return new WireControl(this);
        }

        private class WireControl : ComponentControl
        {
            Wire _component;

            public WireControl(Wire component) : base(component)
            {
                _component = component;
            }

            public override void ShowContextMenu(ContextMenuStrip menu, CancelEventArgs ce)
            {
                ToolStripItem f = new ToolStripButton("Flip");
                f.Click += new((object sender, EventArgs e) =>
                {
                    _component.Flip();
                    _component.Controller.ConnectComponent(_component);
                    _component.Flipped = !_component.Flipped;
                });
                menu.Items.Add(f);

                const string SET_WIDTH = "Set Width";
                ToolStripItem cw = new ToolStripButton(SET_WIDTH);
                cw.Click += new((object sender, EventArgs e) =>
                {
                    string value = Convert.ToString(_component.Width - 10);
                    if (InputBox(SET_WIDTH, "Width:", ref value) == DialogResult.OK)
                    {
                        _component.SetWidth(Math.Abs(Convert.ToInt32(value)));
                        _component.Controller.ConnectComponent(_component);
                    }
                });
                menu.Items.Add(cw);

                const string SET_HEIGHT = "Set Height";
                ToolStripItem ch = new ToolStripButton(SET_HEIGHT);
                ch.Click += new((object sender, EventArgs e) =>
                {
                    string value = Convert.ToString(_component.Height - 10);
                    if (InputBox(SET_HEIGHT, "Height:", ref value) == DialogResult.OK)
                    {
                        _component.SetHeight(Math.Abs(Convert.ToInt32(value)));
                        _component.Controller.ConnectComponent(_component);
                    }
                });
                menu.Items.Add(ch);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                g.DrawLine(
                    new(Color.DimGray, 3), 
                    new(_component.Connections[0].Location.X, _component.Connections[0].Location.Y), 
                    new(_component.Connections[1].Location.X, _component.Connections[1].Location.Y));

                DrawConnections(g); for (int i = 0; i < _component.Connections.Length; ++i)
                {
                    Color color = _component.GetValue(i) ? Color.Tomato : Color.DimGray;
                    int width = _component.Connections[i].Connections.Count > 0 ? 3 : 1;
                    Rectangle rect = new(Point.Subtract(_component.Connections[i].Location, new(3, 3)), new(6, 6));
                    g.FillEllipse(Brushes.White, rect);
                    g.DrawEllipse(new(color, width), rect);
                }
            }
        }
    }
}
