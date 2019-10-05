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

                for (int i = 0; i < Component.GetComponent().Connections.Length; ++i)
                {
                    Color c = Component.GetComponent().GetValue(i) ? Color.Red : Color.Black;
                    int w = Component.GetComponent().Connections[i].Connections.Count > 0 ? 3 : 1;
                    g.DrawEllipse(new Pen(c, w), new Rectangle(Point.Subtract(Component.GetComponent().Connections[i].Location, new Size(2, 2)), new Size(4, 4)));
                }

                Pen penB = new Pen(Color.Black, 3);
                g.DrawLine(penB, new Point(25, 15), new Point(33, 15));
                Rectangle rect = new Rectangle(5, 5, 20, 20);
                g.FillEllipse(Component.GetComponent().GetValue(0) ? Brushes.Red : Brushes.Black, rect);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawEllipse(penB, rect);
                g.DrawEllipse(new Pen(Color.White, 3), new Rectangle(9, 9, 12, 12));
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                Pen penW = new Pen(Component.GetComponent().GetValue(0) ? Brushes.Red : Brushes.Black, 1);
                Rectangle rect2 = new Rectangle(13, 7, 4, 10);
                g.FillRectangle(Brushes.White, rect2);
                g.DrawRectangle(penW, rect2);
            }
        }
    }
}
