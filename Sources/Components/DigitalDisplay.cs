using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    internal class DigitalDisplay : Component
    {
        private int _value;
        private int _numberBase;

        public DigitalDisplay() : base()
        {
            _numberBase = 10;
            Initialize(8);
        }

        public DigitalDisplay(int inputs) : base()
        {
            _numberBase = 10;
            Initialize(inputs);
        }

        public void Initialize(int inputs)
        {
            Reinitalize(inputs, 1);

            _value = 0;

            int inputOffset = 20;
            int inputLocation = 10;

            int height = inputOffset * inputs;
            height = Math.Max(height, 50);
            Bounds = new Rectangle(0, 0, 85, height);

            for (int i = 0; i < inputs; ++i)
            {
                Connections[i].Location = new Point(5, inputLocation);
                inputLocation += inputOffset;
            }
        }

        public override void Execute()
        {
            _value = 0;
            for (int i = Connections.Length - 1; i >= 0; --i)
            {
                _value = _value << 1;
                if (GetValue(i))
                {
                    _value += 1;
                }
            }
            base.Execute();
        }
        
        public override void Write(System.Xml.XmlWriter writer)
        {
            writer.WriteElementString("inputs", (Connections.Length - 1).ToString());
            writer.WriteElementString("base", _numberBase.ToString());
        }

        public override void Read(System.Xml.XmlReader reader)
        {
            reader.ReadToDescendant("inputs");
            if (reader.IsStartElement("inputs"))
            {
                int inputs = reader.ReadElementContentAsInt();
                Initialize(inputs);
            }

            reader.ReadToFollowing("base");
            if (reader.IsStartElement("base"))
            {
                _numberBase = reader.ReadElementContentAsInt();
            }
        }

        protected override ComponentControl CreateComponentControl()
        {
            return new DigitalDisplayControl(this);
        }

        private class DigitalDisplayControl : ComponentControl
        {
            DigitalDisplay _parent;

            public DigitalDisplayControl(DigitalDisplay parent) : base(parent)
            {
                _parent = parent;
            }

            public override void ShowContextMenu(ContextMenuStrip menu, CancelEventArgs ce)
            {
                ToolStripItem dec = new ToolStripButton("Decimal");
                dec.Click += new EventHandler(delegate (object sender, EventArgs e)
                {
                    _parent._numberBase = 10;
                    _parent.Circuit.ConnectComponent(_parent);
                });
                menu.Items.Add(dec);

                ToolStripItem hex = new ToolStripButton("Hexidecimal");
                hex.Click += new EventHandler(delegate (object sender, EventArgs e)
                {
                    _parent._numberBase = 16;
                    _parent.Circuit.ConnectComponent(_parent);
                });
                menu.Items.Add(hex);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Black, 3);
                Rectangle rect = new Rectangle(15, 5, Width - 22, Height - 10);

                g.FillRectangle(Brushes.Black, rect);
                g.DrawRectangle(pen, rect);
                g.DrawString(" " + Convert.ToString(_parent._value, _parent._numberBase), new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Lime, rect);

                for (int i = 0; i < _parent.Connections.Length - 1; ++i)
                {
                    Color c = _parent.GetValue(i) ? Color.Red : Color.Black;
                    g.DrawEllipse(new Pen(c, 1), new Rectangle(Point.Subtract(_parent.Connections[i].Location, new Size(2, 2)), new Size(4, 4)));
                    g.DrawLine(pen, new Point(8, _parent.Connections[i].Location.Y), new Point(rect.Left, _parent.Connections[i].Location.Y));
                }
            }
        }
    }
}