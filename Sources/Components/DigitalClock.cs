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
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Pen pen = new Pen(Color.DimGray, 3);
                g.DrawLine(pen, new Point(80, 25), new Point(93, 25));
                Rectangle rect = new Rectangle(5, 5, 75, Height - 10);
                g.DrawRectangle(pen, new Rectangle(5, 5, 75, Height - 10));
                g.DrawLine(pen, new Point(14, 35), new Point(33, 35));
                g.DrawLine(pen, new Point(32, 35), new Point(32, 14));
                g.DrawLine(pen, new Point(32, 15), new Point(54, 15));
                g.DrawLine(pen, new Point(53, 15), new Point(53, 35));
                g.DrawLine(pen, new Point(52, 35), new Point(72, 35));

                DrawConnections(g);
            }
        }

        public double Interval
        {
            get => _interval;
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
