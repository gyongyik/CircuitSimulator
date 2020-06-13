﻿using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CircuitSimulator.Components
{
    internal class Xnor : Component
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

        private class XnorControl : ComponentControl
        {
            public XnorControl(Xnor _) : base(_)
            {
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Pen pen = new Pen(Color.DimGray, 3);
                g.DrawLine(pen, new Point(8, 15), new Point(32, 15));
                g.DrawLine(pen, new Point(8, 35), new Point(32, 35));
                g.DrawLine(pen, new Point(85, 25), new Point(92, 25));
                g.DrawBezier(pen, new Point(25, 5), new Point(55, 5), new Point(65, 10), new Point(75, 25));
                g.DrawBezier(pen, new Point(25, 45), new Point(55, 45), new Point(65, 40), new Point(75, 25));
                g.DrawBezier(pen, new Point(25, 5), new Point(35, 20), new Point(35, 30), new Point(25, 45));
                g.DrawBezier(pen, new Point(19, 5), new Point(29, 20), new Point(29, 30), new Point(19, 45));
                g.DrawEllipse(pen, new Rectangle(new Point(75, 20), new Size(10, 10)));

                DrawConnections(g);
            }
        }
    }
}