using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Xml;

namespace CircuitSimulator.Components
{
    internal class InputPin : Component
    {
        private const string STATE = "state";

        public InputPin() : base(0, 1)
        {
            Bounds = new(0, 0, 30, 20);

            Connections[0].Location = new(Width - 5, 10);
            Connections[0].Value = false;
        }

        public override void Write(XmlWriter writer)
        {
            writer.WriteStartElement(STATE);
            writer.WriteValue(Connections[0].Value);
            writer.WriteEndElement();
        }

        public override void Read(XmlReader reader)
        {
            reader.ReadToFollowing(STATE);
            if (reader.IsStartElement(STATE))
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
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Pen pen = new(Color.DimGray, 3);
                g.DrawLine(pen, new(15, 10), new(22, 10));
                Rectangle rect = new(5, 5, 10, 10);
                g.FillRectangle(Component.GetValue(0) ? Brushes.Tomato : Brushes.White, rect);
                g.DrawRectangle(pen, rect);

                DrawConnections(g);
            }
        }
    }
}
