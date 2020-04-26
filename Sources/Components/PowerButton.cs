using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    internal class PowerButton : Component
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

        private class PowerButtonControl : ComponentControl
        {
            public PowerButtonControl(PowerButton _) : base(_)
            {
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Pen pen = new Pen(Color.DimGray, 3);
                g.DrawLine(pen, new Point(25, 15), new Point(32, 15));
                Rectangle rect = new Rectangle(5, 5, 20, 20);
                g.FillEllipse(Component.GetComponent().GetValue(0) ? Brushes.Tomato : Brushes.White, rect);
                g.DrawEllipse(pen, rect);
                g.DrawLine(pen, new Point(15, 2), new Point(15, 10));

                DrawConnections(g);
            }
        }
    }
}
