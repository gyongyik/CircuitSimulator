using System.Windows.Forms;
using System.Drawing;

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
            Bounds = new Rectangle(0, 0, 85, height);

            for (int i = 0; i < 8; ++i)
            {
                Connections[i].Location = new Point(5, inputLocation);
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
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Pen penDimGray = new Pen(Color.DimGray, 3);
                Pen penTomato = new Pen(Color.Tomato, 3);

                Rectangle rect = new Rectangle(15, 5, Width - 22, Height - 10);

                for (int i = 0; i < Component.Connections.Length - 1; ++i)
                {
                    Color c = Component.GetValue(i) ? Color.Tomato : Color.DimGray;
                    g.DrawLine(penDimGray, new Point(8, Component.Connections[i].Location.Y), new Point(rect.Left, Component.Connections[i].Location.Y));
                    g.DrawEllipse(new Pen(c, 1), new Rectangle(Point.Subtract(Component.Connections[i].Location, new Size(3, 3)), new Size(6, 6)));
                }

                g.DrawRectangle(penDimGray, rect);

                g.DrawRectangle(Component.GetValue(0) ? penTomato : penDimGray, new Rectangle(30, 40, 27, 3));
                g.DrawRectangle(Component.GetValue(1) ? penTomato : penDimGray, new Rectangle(62, 42, 3, 35));
                g.DrawRectangle(Component.GetValue(2) ? penTomato : penDimGray, new Rectangle(62, 82, 3, 35));
                g.DrawRectangle(Component.GetValue(3) ? penTomato : penDimGray, new Rectangle(30, 116, 27, 3));
                g.DrawRectangle(Component.GetValue(4) ? penTomato : penDimGray, new Rectangle(22, 82, 3, 35));
                g.DrawRectangle(Component.GetValue(5) ? penTomato : penDimGray, new Rectangle(22, 42, 3, 35));
                g.DrawRectangle(Component.GetValue(6) ? penTomato : penDimGray, new Rectangle(30, 78, 27, 3));
                g.DrawRectangle(Component.GetValue(7) ? penTomato : penDimGray, new Rectangle(70, 116, 3, 3));
            }
        }
    }
}