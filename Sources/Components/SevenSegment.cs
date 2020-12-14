using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CircuitSimulator.Components
{
    internal class SevenSegment : Component
    {
        public SevenSegment() : base()
        {
            Initialize();
        }

        public void Initialize()
        {
            Reinitalize(8, 1);

            int inputOffset = 20;
            int inputLocation = 10;

            int height = inputOffset * 8;
            Bounds = new(0, 0, 85, height);

            for (int i = 0; i < 8; ++i)
            {
                Connections[i].Location = new(5, inputLocation);
                inputLocation += inputOffset;
            }
        }
        
        protected override ComponentControl CreateComponentControl()
        {
            return new SevenSegmentControl(this);
        }

        private class SevenSegmentControl : ComponentControl
        {
            public SevenSegmentControl(SevenSegment _) : base(_)
            {
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Pen penDimGray = new(Color.DimGray, 3);
                Pen penTomato = new(Color.Tomato, 3);

                Rectangle rect = new(15, 5, Width - 22, Height - 10);

                for (int i = 0; i < Component.Connections.Length - 1; ++i)
                {
                    g.DrawLine(penDimGray, 
                        new(8, Component.Connections[i].Location.Y), 
                        new(rect.Left, Component.Connections[i].Location.Y));

                    Color color = Component.GetValue(i) ? Color.Tomato : Color.DimGray;
                    Point point = Point.Subtract(Component.Connections[i].Location, new(3, 3));
                    g.DrawEllipse(new(color, 1), new(point, new(6, 6)));
                }

                g.DrawRectangle(penDimGray, rect);

                g.DrawRectangle(Component.GetValue(0) ? penTomato : penDimGray, new(30, 40, 27, 3));
                g.DrawRectangle(Component.GetValue(1) ? penTomato : penDimGray, new(62, 42, 3, 35));
                g.DrawRectangle(Component.GetValue(2) ? penTomato : penDimGray, new(62, 82, 3, 35));
                g.DrawRectangle(Component.GetValue(3) ? penTomato : penDimGray, new(30, 116, 27, 3));
                g.DrawRectangle(Component.GetValue(4) ? penTomato : penDimGray, new(22, 82, 3, 35));
                g.DrawRectangle(Component.GetValue(5) ? penTomato : penDimGray, new(22, 42, 3, 35));
                g.DrawRectangle(Component.GetValue(6) ? penTomato : penDimGray, new(30, 78, 27, 3));
                g.DrawRectangle(Component.GetValue(7) ? penTomato : penDimGray, new(70, 116, 3, 3));
            }
        }
    }
}