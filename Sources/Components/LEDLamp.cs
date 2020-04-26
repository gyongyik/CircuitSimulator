using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    internal class LedLamp : Component
    {
        public LedLamp() : base(1, 0)
        {
            Bounds = new Rectangle(0, 0, 40, 30);
            Connections[0].Location = new Point(5, 15);
        }

        public override void Execute()
        {
            base.Execute();
        }

        protected override ComponentControl CreateComponentControl()
        {
            return new LedLampControl(this);
        }

        private class LedLampControl : ComponentControl
        {
            public LedLampControl(LedLamp _) : base(_)
            {
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Pen pen = new Pen(Color.DimGray, 3);
                g.DrawLine(pen, new Point(8, 15), new Point(15, 15));
                Rectangle rect = new Rectangle(15, 5, 20, 20);
                g.FillEllipse(Component.GetComponent().GetValue(0) ? Brushes.Tomato : Brushes.White, rect);
                g.DrawEllipse(pen, rect);

                DrawConnections(g);
            }
        }
    }
}
