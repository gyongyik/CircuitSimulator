using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CircuitSimulator.Components
{
    internal class OutputPin : Component
    {
        public OutputPin() : base(1, 0)
        {
            Bounds = new Rectangle(0, 0, 30, 20);
            Connections[0].Location = new Point(5, 10);
        }

        protected override ComponentControl CreateComponentControl()
        {
            return new OutputPinControl(this);
        }

        private class OutputPinControl : ComponentControl
        {
            public OutputPinControl(OutputPin _) : base(_)
            {
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Pen pen = new Pen(Color.DimGray, 3);
                g.DrawLine(pen, new Point(8, 10), new Point(15, 10));
                Rectangle rect = new Rectangle(15, 5, 10, 10);
                g.FillRectangle(Component.GetValue(0) ? Brushes.Tomato : Brushes.White, rect);
                g.DrawRectangle(pen, rect);

                DrawConnections(g);
            }
        }
    }
}