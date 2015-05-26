using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    class PowerButton : Component
    {
        public PowerButton() : base(0, 1)
        {
            Bounds = new Rectangle(0, 0, 40, 30);

            Connections[0].Location = new Point(Width - 5, 15);
            Connections[0].Value = true;
         }

        public override void Execute()
        {
            base.Execute();
        }

        public override void Write(System.Xml.XmlWriter writer)
        {
            writer.WriteStartElement("state");
            writer.WriteValue(Connections[0].Value);
            writer.WriteEndElement();
        }

        public override void Read(System.Xml.XmlReader reader)
        {
            reader.ReadToFollowing("state");
            if (reader.IsStartElement("state"))
            {
                Connections[0].Value = reader.ReadElementContentAsBoolean();
            }
        }

        public override void OnMouseClick(MouseEventArgs e)
        {
            Connections[0].Value = !Connections[0].Value;
        }

        protected override ComponentControl CreateComponentControl()
        {
            return new PowerButtonControl(this);
        }

        class PowerButtonControl : ComponentControl
        {
            PowerButton fParent;

            public PowerButtonControl(PowerButton parent) : base(parent)
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

                Pen penB = new Pen(Color.Black, 3);
                g.DrawLine(penB, new Point(25, 15), new Point(33, 15));
                Rectangle rect = new Rectangle(5, 5, 20, 20);
                g.FillEllipse(fComponent.GetComponent().GetValue(0) ? Brushes.Red : Brushes.Black, rect);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawEllipse(penB, rect);
                g.DrawEllipse(new Pen(Color.White, 3), new Rectangle(9, 9, 12, 12));
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                Pen penW = new Pen(fComponent.GetComponent().GetValue(0) ? Brushes.Red : Brushes.Black, 1);
                Rectangle rect2 = new Rectangle(13, 7, 4, 10);
                g.FillRectangle(Brushes.White, rect2);
                g.DrawRectangle(penW, rect2);
            }
        }
    }
}
