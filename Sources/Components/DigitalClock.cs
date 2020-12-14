using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Timers;
using System.Windows.Forms;
using System.Xml;

namespace CircuitSimulator.Components
{
    internal class DigitalClock : Component
    {
        private const string INTERVAL = "interval";

        private System.Timers.Timer _timer;
        private double _interval;

        public DigitalClock() : base(0, 1)
        {
            Bounds = new(0, 0, 100, 50);

            Connections[0].Location = new(Width - 5, Height / 2);

            Interval = 1000;
        }

        public DigitalClock(double interval) : base(0, 1)
        {
            Bounds = new(0, 0, 100, 50);

            Connections[0].Location = new(Width - 5, Height / 2);

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

        public override void Write(XmlWriter writer)
        {
            writer.WriteElementString(INTERVAL, Interval.ToString());
        }

        public override void Read(XmlReader reader)
        {
            reader.ReadToDescendant(INTERVAL);
            if (reader.IsStartElement(INTERVAL))
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
                const string SET_INTERVAL = "Set Interval";
                ToolStripItem si = new ToolStripButton(SET_INTERVAL);
                si.Click += new((object sender, EventArgs e) =>
                {
                    string value = Convert.ToString(_component.Interval);
                    if (InputBox(SET_INTERVAL, "Interval [ms]:", ref value) == DialogResult.OK)
                    {
                        _component.Interval = Convert.ToInt32(value);
                        _component.Controller.ConnectComponent(_component);
                    }
                });
                menu.Items.Add(si);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Pen pen = new(Color.DimGray, 3);
                g.DrawLine(pen, new(80, 25), new (93, 25));
                g.DrawRectangle(pen, new(5, 5, 75, Height - 10));
                g.DrawLine(pen, new(14, 35), new(33, 35));
                g.DrawLine(pen, new(32, 35), new(32, 14));
                g.DrawLine(pen, new(32, 15), new(54, 15));
                g.DrawLine(pen, new(53, 15), new(53, 35));
                g.DrawLine(pen, new(52, 35), new(72, 35));

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
                    _timer = new(_interval);
                    _timer.Elapsed += new(OnTimerElapsed);
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

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
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
