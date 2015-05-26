using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    class InputPin : Component
    {
        public InputPin() : base(0, 1)
        {
            Bounds = new Rectangle(0, 0, 30, 20);

            Connections[0].Location = new Point(Width - 5, 10);
            Connections[0].Value = false;
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
            return new InputPinControl(this);
        }

        class InputPinControl : ComponentControl
        {
            InputPin fParent;

            public InputPinControl(InputPin parent) : base(parent)
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
                g.DrawLine(pen, new Point(15, 10), new Point(23, 10));
                Rectangle rect = new Rectangle(5, 5, 10, 10);
                g.FillRectangle(fComponent.GetComponent().GetValue(0) ? Brushes.Red : Brushes.Black, rect);
                g.DrawRectangle(pen, rect);
            }
        }
    }
}
