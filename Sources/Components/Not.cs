using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    internal class Not : Component
    {
        public Not() : base(1, 1)
        {
            Bounds = new Rectangle(0, 0, 100, 50);

            Connections[0].Location = new Point(5, 25);
            Connections[1].Location = new Point(95, 25);
        }

        public override void Execute()
        {
            SetValue(1, !GetValue(0));
            base.Execute();
        }

        protected override ComponentControl CreateComponentControl()
        {
            return new NotControl(this);
        }

        private class NotControl : ComponentControl
        {
            public NotControl(Not _) : base(_)
            {
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Pen pen = new Pen(Color.DimGray, 3);
                g.DrawLine(pen, new Point(8, 25), new Point(33, 25));
                g.DrawLine(pen, new Point(85, 25), new Point(92, 25));
                g.DrawLine(pen, new Point(33, 5), new Point(33, 45));
                g.DrawLine(pen, new Point(33, 5), new Point(75, 25));
                g.DrawLine(pen, new Point(33, 45), new Point(75, 25));
                g.DrawEllipse(pen, new Rectangle(new Point(75, 20), new Size(10, 10)));

                DrawConnections(g);
            }
        }
    }
}
