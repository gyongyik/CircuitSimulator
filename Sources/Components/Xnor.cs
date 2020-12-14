using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CircuitSimulator.Components
{
    internal class Xnor : Component
    {
        public Xnor() : base(2, 1)
        {
            Bounds = new(0, 0, 100, 50);

            Connections[0].Location = new(5, 15);
            Connections[1].Location = new(5, 35);
            Connections[2].Location = new(95, 25);
        }

        public override void Execute()
        {
            SetValue(2, !(GetValue(0) ^ GetValue(1)));
            base.Execute();
        }

        protected override ComponentControl CreateComponentControl()
        {
            return new XnorControl(this);
        }

        private class XnorControl : ComponentControl
        {
            public XnorControl(Xnor _) : base(_)
            {
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Pen pen = new(Color.DimGray, 3);
                g.DrawLine(pen, new(8, 15), new(32, 15));
                g.DrawLine(pen, new(8, 35), new(32, 35));
                g.DrawLine(pen, new(85, 25), new(92, 25));
                g.DrawBezier(pen, new(25, 5), new(55, 5), new(65, 10), new(75, 25));
                g.DrawBezier(pen, new(25, 45), new(55, 45), new(65, 40), new(75, 25));
                g.DrawBezier(pen, new(25, 5), new(35, 20), new(35, 30), new(25, 45));
                g.DrawBezier(pen, new(19, 5), new(29, 20), new(29, 30), new(19, 45));
                g.DrawEllipse(pen, new(new(75, 20), new(10, 10)));

                DrawConnections(g);
            }
        }
    }
}