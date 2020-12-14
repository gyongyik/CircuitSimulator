using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Xml;

namespace CircuitSimulator.Components
{
    internal class Switch : Component
    {
        private const string STATE = "state";

        public bool State { get; private set; }

        public Switch() : base(1, 1)
        {
            Bounds = new(0, 0, 100, 50);
            Connections[0] = new SwitchConnection(this, 0);
            Connections[1] = new SwitchConnection(this, 1);
            Connections[0].Location = new(5, 25);
            Connections[1].Location = new(Width - 5, 25);
        }

        public override void OnMouseClick(MouseEventArgs e)
        {
            State = !State;

            if (State)
            {
                bool value0 = GetValue(0);
                bool value1 = GetValue(1);
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

        public override void Write(XmlWriter writer)
        {
            writer.WriteStartElement(STATE);
            writer.WriteValue(State);
            writer.WriteEndElement();
        }

        public override void Read(XmlReader reader)
        {
            reader.ReadToFollowing(STATE);
            if (reader.IsStartElement(STATE))
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
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Pen pen = new(Color.DimGray, 3);
                g.DrawLine(pen, new(8, 25), new(34, 25));
                g.DrawLine(pen, new(65, 25), new(92, 25));

                if (_component.State)
                {
                    g.DrawLine(pen, new(33, 25), new(66, 25));
                }
                else
                {
                    g.DrawLine(pen, new(33, 25), new(60, 5));
                }

                DrawConnections(g);
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