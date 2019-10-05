using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    internal class DigitalClock : Component
    {
        private System.Timers.Timer _timer;
        private double _interval;

        public DigitalClock() : base(0, 1)
        {
            Bounds = new Rectangle(0, 0, 100, 50);

            Connections[0].Location = new Point(Width - 5, Height / 2);

            Interval = 1000;
        }

        public DigitalClock(double interval) : base(0, 1)
        {
            Bounds = new Rectangle(0, 0, 100, 50);

            Connections[0].Location = new Point(Width - 5, Height / 2);

            Interval = interval;
        }

        public override void Dispose()
        {
            base.Dispose();
            if (_timer != null)
            {
                _timer.Stop();
                _timer.Dispose();
                _timer = null;
            }
        }

        public override void Execute()
        {
            base.Execute();
        }

        public override void Write(System.Xml.XmlWriter writer)
        {
            writer.WriteElementString("interval", Interval.ToString());
        }

        public override void Read(System.Xml.XmlReader reader)
        {
            reader.ReadToDescendant("interval");
            if (reader.IsStartElement("interval"))
            {
                Interval = reader.ReadElementContentAsDouble();
            }
        }

        protected override ComponentControl CreateComponentControl()
        {
            return new DigitalClockControl(this);
        }

        private class DigitalClockControl : ComponentControl
        {
            private DigitalClock _component;

            public DigitalClockControl(DigitalClock component) : base(component)
            {
                _component = component;
            }

            public override void ShowContextMenu(ContextMenuStrip menu, CancelEventArgs ce)
            {
                ToolStripItem si = new ToolStripButton("Set Interval");
                si.Click += new EventHandler(delegate (object sender, EventArgs e)
                {
                    string value = Convert.ToString(_component.Interval);
                    if (InputBox("Set Interval", "Interval [ms]:", ref value) == DialogResult.OK)
                    {
                        _component.Interval = Convert.ToInt32(value);
                        _component.Circuit.ConnectComponent(_component);
                    }
                });
                menu.Items.Add(si);
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

                Pen penB = new Pen(Color.Black, 3);
                g.DrawLine(penB, new Point(66, 25), new Point(93, 25));
                Rectangle rect = new Rectangle(5, 5, 75, Height - 10);
                g.FillRectangle(Brushes.Black, rect);
                g.DrawRectangle(penB, rect);

                Pen penW = new Pen(Color.White, 3);
                g.DrawLine(penW, new Point(14, 35), new Point(34, 35));
                g.DrawLine(penW, new Point(32, 35), new Point(32, 15));
                g.DrawLine(penW, new Point(32, 15), new Point(54, 15));
                g.DrawLine(penW, new Point(53, 15), new Point(53, 35));
                g.DrawLine(penW, new Point(52, 35), new Point(72, 35));
            }
        }

        public double Interval
        {
            get
            {
                return _interval;
            }
            set
            {
                _interval = value;
                if (_interval > 0)
                {
                    if (_timer != null)
                    {
                        _timer.Dispose();
                    }
                    _timer = new System.Timers.Timer(_interval);
                    _timer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimerElapsed);
                    _timer.Enabled = true;
                    _timer.Start();
                }
                else
                {
                    // 0 means stay on
                    _timer.Dispose();
                    SetState(true);
                }
            }
        }

        void OnTimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            SetState(!GetState());
        }

        private void SetState(bool state)
        {
            Connections[0].Value = state;
        }

        private bool GetState()
        {
            return Connections[0].Value;
        }
    }
}
