using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    class Xnor : Component
    {
        public Xnor() : base(2, 1)
        {
            Bounds = new Rectangle(0, 0, 100, 50);

            Connections[0].Location = new Point(5, 15);
            Connections[1].Location = new Point(5, 35);
            Connections[2].Location = new Point(95, 25);
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

        class XnorControl : ComponentControl
        {
            Xnor fParent;

            public XnorControl(Xnor parent) : base(parent)
            {
                fParent = parent;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;

                for (int i = 0; i < fComponent.GetComponent().Connections.Length; ++i)
                {
                    Color c = fComponent.GetComponent().GetValue(i) ? Color.Red : Color.Black;
                    int w = fComponent.GetComponent().Connections[i].Connections.Count > 0 ? 3 : 1;
                    g.DrawEllipse(new Pen(c, w), new Rectangle(Point.Subtract(fComponent.GetComponent().Connections[i].Location, new Size(2, 2)), new Size(4, 4)));
                }

                Pen pen = new Pen(Color.Black, 3);
                g.DrawLine(pen, new Point(8, 15), new Point(32, 15));
                g.DrawLine(pen, new Point(8, 35), new Point(32, 35));
                g.DrawLine(pen, new Point(85, 25), new Point(93, 25));
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawBezier(pen, new Point(25, 5), new Point(55, 5), new Point(65, 10), new Point(75, 25));
                g.DrawBezier(pen, new Point(25, 45), new Point(55, 45), new Point(65, 40), new Point(75, 25));
                g.DrawBezier(pen, new Point(25, 5), new Point(35, 20), new Point(35, 30), new Point(25, 45));
                g.DrawBezier(pen, new Point(19, 5), new Point(29, 20), new Point(29, 30), new Point(19, 45));
                g.DrawEllipse(pen, new Rectangle(new Point(75, 20), new Size(10, 10)));
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            }
        }
    }
}