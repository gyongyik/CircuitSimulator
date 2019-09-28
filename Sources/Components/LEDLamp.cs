using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    internal class LEDLamp : Component
    {
        public LEDLamp() : base(1, 0)
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
            return new LEDLampControl(this);
        }

        private class LEDLampControl : ComponentControl
        {
            public LEDLampControl(LEDLamp parent) : base(parent)
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
                g.DrawLine(pen, new Point(8, 15), new Point(15, 15));
                Rectangle rect = new Rectangle(15, 5, 20, 20);
                g.FillEllipse(Component.GetComponent().GetValue(0) ? Brushes.Red : Brushes.Black, rect);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawEllipse(pen, rect);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            }
        }
    }
}
