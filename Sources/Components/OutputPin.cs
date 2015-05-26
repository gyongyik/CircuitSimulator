using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    class OutputPin : Component
    {
        public OutputPin() : base(1, 0)
        {
            Bounds = new Rectangle(0, 0, 30, 20);
            Connections[0].Location = new Point(5, 10);
        }

        public override void Execute()
        {
            base.Execute();
        }

        protected override ComponentControl CreateComponentControl()
        {
            return new OutputPinControl(this);
        }

        class OutputPinControl : ComponentControl
        {
            OutputPin fParent;

            public OutputPinControl(OutputPin parent) : base(parent)
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
                g.DrawLine(pen, new Point(8, 10), new Point(15, 10));
                Rectangle rect = new Rectangle(15, 5, 10, 10);
                g.FillRectangle(fComponent.GetComponent().GetValue(0) ? Brushes.Red : Brushes.Black, rect);
                g.DrawRectangle(pen, rect);
            }
        }
    }
}