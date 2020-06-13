using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CircuitSimulator.Components
{
    internal class TrafficLight : Component
    {
        public TrafficLight() : base()
        {
            Initialize();
        }

        public void Initialize()
        {
            Reinitalize(3, 1);

            Bounds = new Rectangle(0, 0, 85, 160);

            Connections[0].Location = new Point(5, 10);
            Connections[1].Location = new Point(5, 30);
            Connections[2].Location = new Point(5, 50);
        }

        protected override ComponentControl CreateComponentControl()
        {
            return new TrafficLightControl(this);
        }

        private class TrafficLightControl : ComponentControl
        {
            public TrafficLightControl(TrafficLight _) : base(_)
            {
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Pen pen = new Pen(Color.DimGray, 3);
                Rectangle rect = new Rectangle(15, 5, Width - 22, Height - 10);

                for (int i = 0; i < Component.Connections.Length - 1; ++i)
                {
                    Color c = Component.GetValue(i) ? Color.Tomato : Color.DimGray;
                    g.DrawLine(pen, new Point(8, Component.Connections[i].Location.Y), new Point(rect.Left, Component.Connections[i].Location.Y));
                    g.DrawEllipse(new Pen(c, 1), new Rectangle(Point.Subtract(Component.Connections[i].Location, new Size(3, 3)), new Size(6, 6)));
                }

                g.DrawRectangle(pen, rect);

                Rectangle rectRed = new Rectangle(26, 10, 42, 42);
                g.FillEllipse(Component.GetValue(0) ? Brushes.Tomato : Brushes.DimGray, rectRed);
                g.DrawEllipse(Component.GetValue(0) ? new Pen(Color.Tomato, 1) : pen, rectRed);

                Rectangle rectYellow = new Rectangle(26, 59, 42, 42);
                g.FillEllipse(Component.GetValue(1) ? Brushes.Gold : Brushes.DimGray, rectYellow);
                g.DrawEllipse(Component.GetValue(1) ? new Pen(Color.Gold, 1) : pen, rectYellow);

                Rectangle rectGreen = new Rectangle(26, 108, 42, 42);
                g.FillEllipse(Component.GetValue(2) ? Brushes.Chartreuse : Brushes.DimGray, rectGreen);
                g.DrawEllipse(Component.GetValue(2) ? new Pen(Color.Chartreuse, 1) : pen, rectGreen);
            }
        }
    }
}