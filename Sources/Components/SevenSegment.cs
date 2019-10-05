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
            SevenSegment _component;

            public SevenSegmentControl(SevenSegment component) : base(component)
            {
                _component = component;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                Pen penB = new Pen(Color.Black, 3);
                Pen penM = new Pen(Color.FromArgb(64, 32, 32), 3);
                Pen penR = new Pen(Color.Red, 3);

                Rectangle rect = new Rectangle(15, 5, Width - 22, Height - 10);

                for (int i = 0; i < _component.Connections.Length - 1; ++i)
                {
                    Color c = _component.GetValue(i) ? Color.Red : Color.Black;
                    g.DrawEllipse(new Pen(c, 1), new Rectangle(Point.Subtract(_component.Connections[i].Location, new Size(2, 2)), new Size(4, 4)));
                    g.DrawLine(penB, new Point(8, _component.Connections[i].Location.Y), new Point(rect.Left, _component.Connections[i].Location.Y));
                }

                g.FillRectangle(Brushes.Black, rect);
                g.DrawRectangle(penB, rect);

                g.DrawRectangle(_component.GetValue(0) ? penR : penM, new Rectangle(30, 40, 27, 3));
                g.DrawRectangle(_component.GetValue(1) ? penR : penM, new Rectangle(62, 42, 3, 35));
                g.DrawRectangle(_component.GetValue(2) ? penR : penM, new Rectangle(62, 82, 3, 35));
                g.DrawRectangle(_component.GetValue(3) ? penR : penM, new Rectangle(30, 116, 27, 3));
                g.DrawRectangle(_component.GetValue(4) ? penR : penM, new Rectangle(22, 82, 3, 35));
                g.DrawRectangle(_component.GetValue(5) ? penR : penM, new Rectangle(22, 42, 3, 35));
                g.DrawRectangle(_component.GetValue(6) ? penR : penM, new Rectangle(30, 78, 27, 3));
                g.DrawRectangle(_component.GetValue(7) ? penR : penM, new Rectangle(70, 116, 3, 3));
            }
        }
    }
}