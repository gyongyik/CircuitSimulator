using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    internal class And : Component
    {
        public And() : base(2, 1)
        {
            Bounds = new Rectangle(0, 0, 100, 50);

            Connections[0].Location = new Point(5, 15);
            Connections[1].Location = new Point(5, 35);
            Connections[2].Location = new Point(95, 25);
        }

        public override void Execute()
        {
            SetValue(2, GetValue(0) && GetValue(1));
            base.Execute();
        }

        protected override ComponentControl CreateComponentControl()
        {
            return new AndControl(this);
        }

        private class AndControl : ComponentControl
        {
            public AndControl(And parent) : base(parent)
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
                g.DrawLine(pen, new Point(8, 15), new Point(33, 15));
                g.DrawLine(pen, new Point(8, 35), new Point(33, 35));
                g.DrawLine(pen, new Point(75, 25), new Point(93, 25));
                g.DrawLine(pen, new Point(33, 5), new Point(33, 45));
                g.DrawLine(pen, new Point(32, 5), new Point(56, 5));
                g.DrawLine(pen, new Point(32, 45), new Point(56, 45));
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawArc(pen, new Rectangle(35, 5, 40, 40), 90, -180);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            }
        }
    }
}
