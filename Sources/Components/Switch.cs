using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    internal class Switch : Component
    {
        public bool State { get; private set; }

        public Switch() : base(1, 1)
        {
            Bounds = new Rectangle(0, 0, 100, 50);
            Connections[0] = new SwitchConnection(this, 0);
            Connections[1] = new SwitchConnection(this, 1);
            Connections[0].Location = new Point(5, 25);
            Connections[1].Location = new Point(Width - 5, 25);
        }

        public override void OnMouseClick(MouseEventArgs e)
        {
            State = !State;

            if (State)
            {
                var value0 = GetValue(0);
                var value1 = GetValue(1);
                SetValue(0, value0);
                SetValue(1, value1);
            }
            else
            {
                SetValue(0, false);
                SetValue(1, false);
            }
        }

        public override bool GetValue(int index)
        {
            bool result = false;
            foreach (Connection c in Connections[index].Connections)
            {
                result |= c.Value;
            }
            if (State)
            {
                foreach (Connection c in Connections[1 - index].Connections)
                {
                    result |= c.Value;
                }
            }
            return result;
        }

        public override void Write(System.Xml.XmlWriter writer)
        {
            writer.WriteStartElement("state");
            writer.WriteValue(State);
            writer.WriteEndElement();
        }

        public override void Read(System.Xml.XmlReader reader)
        {
            reader.ReadToFollowing("state");
            if (reader.IsStartElement("state"))
            {
                State = reader.ReadElementContentAsBoolean();
            }
        }

        protected override ComponentControl CreateComponentControl()
        {
            return new SwitchControl(this);
        }

        private class SwitchControl : ComponentControl
        {
            private Switch _component;

            public SwitchControl(Switch component) : base(component)
            {
                _component = component;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;

                for (int i = 0; i < Component.GetComponent().Connections.Length; ++i)
                {
                    Color c = Component.GetComponent().GetValue(i) ? Color.Red : Color.Black;
                    int w = Component.GetComponent().Connections[i].Connections.Count > 0 ? 3 : 1;
                    g.DrawEllipse(new Pen(c, w), new Rectangle(Point.Subtract(Component.GetComponent().Connections[i].Location, new Size(2, 2)), new Size(4, 4)));
                }

                Pen pen = new Pen(Color.Black, 3);
                g.DrawLine(pen, new Point(8, 25), new Point(34, 25));
                g.DrawLine(pen, new Point(66, 25), new Point(93, 25));

                if (_component.State)
                {
                    g.DrawLine(pen, new Point(33, 25), new Point(66, 25));
                }
                else
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.DrawLine(pen, new Point(33, 25), new Point(60, 5));
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                }
            }
        }

        private class SwitchConnection : Connection
        {
            private bool _processing;
            private int _index;

            public SwitchConnection(Component component, int index) : base(component)
            {
                _processing = false;
                _index = index;
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
                        bool value = Parent.GetValue(_index);
                        _processing = false;
                        return value;
                    }               
                }
            }
        }
    }
}