using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    internal class InputPin : Component
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

        private class InputPinControl : ComponentControl
        {
            public InputPinControl(InputPin _) : base(_)
            {
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Pen pen = new Pen(Color.DimGray, 3);
                g.DrawLine(pen, new Point(15, 10), new Point(22, 10));
                Rectangle rect = new Rectangle(5, 5, 10, 10);
                g.FillRectangle(Component.GetComponent().GetValue(0) ? Brushes.Tomato : Brushes.White, rect);
                g.DrawRectangle(pen, rect);

                DrawConnections(g);
            }
        }
    }
}
