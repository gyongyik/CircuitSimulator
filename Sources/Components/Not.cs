using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CircuitSimulator.Components
{
    internal class Not : Component
    {
        public Not() : base(1, 1)
        {
            Bounds = new(0, 0, 100, 50);

            Connections[0].Location = new(5, 25);
            Connections[1].Location = new(95, 25);
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
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Pen pen = new(Color.DimGray, 3);
                g.DrawLine(pen, new(8, 25), new(33, 25));
                g.DrawLine(pen, new(85, 25), new(92, 25));
                g.DrawLine(pen, new(33, 5), new(33, 45));
                g.DrawLine(pen, new(33, 5), new(75, 25));
                g.DrawLine(pen, new(33, 45), new(75, 25));
                g.DrawEllipse(pen, new(new(75, 20), new(10, 10)));

                DrawConnections(g);
            }
        }
    }
}
