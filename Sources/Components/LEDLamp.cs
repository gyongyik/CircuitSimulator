using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CircuitSimulator.Components
{
    internal class LedLamp : Component
    {
        public LedLamp() : base(1, 0)
        {
            Bounds = new(0, 0, 40, 30);
            Connections[0].Location = new(5, 15);
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
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Pen pen = new(Color.DimGray, 3);
                g.DrawLine(pen, new(8, 15), new(15, 15));
                Rectangle rect = new(15, 5, 20, 20);
                g.FillEllipse(Component.GetValue(0) ? Brushes.Tomato : Brushes.White, rect);
                g.DrawEllipse(pen, rect);

                DrawConnections(g);
            }
        }
    }
}
