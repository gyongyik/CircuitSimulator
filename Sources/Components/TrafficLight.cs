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

            Bounds = new(0, 0, 85, 160);

            Connections[0].Location = new(5, 10);
            Connections[1].Location = new(5, 30);
            Connections[2].Location = new(5, 50);
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

                Pen pen = new(Color.DimGray, 3);
                Rectangle rect = new(15, 5, Width - 22, Height - 10);

                for (int i = 0; i < Component.Connections.Length - 1; ++i)
                {
                    g.DrawLine(pen, 
                        new(8, Component.Connections[i].Location.Y), 
                        new(rect.Left, Component.Connections[i].Location.Y));

                    Color color = Component.GetValue(i) ? Color.Tomato : Color.DimGray;
                    Point point = Point.Subtract(Component.Connections[i].Location, new(3, 3));
                    g.DrawEllipse(new(color, 1), new(point, new(6, 6)));
                }

                g.DrawRectangle(pen, rect);

                Rectangle rectRed = new(26, 10, 42, 42);
                g.FillEllipse(Component.GetValue(0) ? Brushes.Tomato : Brushes.DimGray, rectRed);
                g.DrawEllipse(Component.GetValue(0) ? new(Color.Tomato, 1) : pen, rectRed);

                Rectangle rectYellow = new(26, 59, 42, 42);
                g.FillEllipse(Component.GetValue(1) ? Brushes.Gold : Brushes.DimGray, rectYellow);
                g.DrawEllipse(Component.GetValue(1) ? new(Color.Gold, 1) : pen, rectYellow);

                Rectangle rectGreen = new(26, 108, 42, 42);
                g.FillEllipse(Component.GetValue(2) ? Brushes.Chartreuse : Brushes.DimGray, rectGreen);
                g.DrawEllipse(Component.GetValue(2) ? new(Color.Chartreuse, 1) : pen, rectGreen);
            }
        }
    }
}