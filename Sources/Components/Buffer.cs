using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    internal class Buffer : Component
    {
        public Buffer() : base(1, 1)
        {
            Bounds = new Rectangle(0, 0, 100, 50);

            Connections[0].Location = new Point(5, 25);
            Connections[1].Location = new Point(95, 25);
        }

        public override void Execute()
        {
            SetValue(1, GetValue(0));
            base.Execute();
        }

        protected override ComponentControl CreateComponentControl()
        {
            return new BufferControl(this);
        }

        private class BufferControl : ComponentControl
        {
            public BufferControl(Buffer parent) : base(parent)
            {
                //
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
                g.DrawLine(pen, new Point(8, 25), new Point(33, 25));
                g.DrawLine(pen, new Point(75, 25), new Point(93, 25));
                g.DrawLine(pen, new Point(33, 5), new Point(33, 45));
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawLine(pen, new Point(33, 5), new Point(75, 25));
                g.DrawLine(pen, new Point(33, 45), new Point(75, 25));
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            }
        }
    }
}
