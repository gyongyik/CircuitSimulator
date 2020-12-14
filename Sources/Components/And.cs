using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CircuitSimulator.Components
{
    internal class And : Component
    {
        public And() : base(2, 1)
        {
            Bounds = new(0, 0, 100, 50);

            Connections[0].Location = new(5, 15);
            Connections[1].Location = new(5, 35);
            Connections[2].Location = new(95, 25);
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
            public AndControl(And _) : base(_)
            {
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Pen pen = new(Color.DimGray, 3);
                g.DrawLine(pen, new(8, 15), new(33, 15));
                g.DrawLine(pen, new(8, 35), new(33, 35));
                g.DrawLine(pen, new(75, 25), new(92, 25));
                g.DrawLine(pen, new(33, 5), new(33, 45));
                g.DrawLine(pen, new(32, 5), new(56, 5));
                g.DrawLine(pen, new(32, 45), new(56, 45));
                g.DrawArc(pen, new(35, 5, 40, 40), 90, -180);

                DrawConnections(g);
            }
        }
    }
}
