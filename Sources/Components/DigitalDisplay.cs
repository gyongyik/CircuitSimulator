using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    class DigitalDisplay : Component
    {
        int Value;
        int NumberBase;

        public DigitalDisplay() : base()
        {
            NumberBase = 10;
            Initialize(8);
        }

        public DigitalDisplay(int inputs) : base()
        {
            NumberBase = 10;
            Initialize(inputs);
        }

        public void Initialize(int inputs)
        {
            Reinitalize(inputs, 1);

            Value = 0;

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
            Value = 0;
            for (int i = Connections.Length - 1; i >= 0; --i)
            {
                Value = Value << 1;
                if (GetValue(i))
                {
                    Value += 1;
                }
            }
            base.Execute();
        }
        
        public override void Write(System.Xml.XmlWriter writer)
        {
            writer.WriteElementString("inputs", (fConnections.Length - 1).ToString());
            writer.WriteElementString("base", (NumberBase).ToString());
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
                NumberBase = reader.ReadElementContentAsInt();
            }
        }

        protected override ComponentControl CreateComponentControl()
        {
            return new DigitalDisplayControl(this);
        }

        class DigitalDisplayControl : ComponentControl
        {
            DigitalDisplay fParent;

            public DigitalDisplayControl(DigitalDisplay parent) : base(parent)
            {
                fParent = parent;
            }

            public override void ShowContextMenu(ContextMenuStrip menu, CancelEventArgs ce)
            {
                ToolStripItem dec = new ToolStripButton("Decimal");
                dec.Click += new EventHandler(delegate (object sender, EventArgs e)
                {
                    fParent.NumberBase = 10;
                    fParent.Circuit.ConnectComponent(fParent);
                });
                menu.Items.Add(dec);

                ToolStripItem hex = new ToolStripButton("Hexidecimal");
                hex.Click += new EventHandler(delegate (object sender, EventArgs e)
                {
                    fParent.NumberBase = 16;
                    fParent.Circuit.ConnectComponent(fParent);
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
                g.DrawString(" " + Convert.ToString(fParent.Value, fParent.NumberBase), new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Lime, rect);

                for (int i = 0; i < fParent.Connections.Length - 1; ++i)
                {
                    Color c = fParent.GetValue(i) ? Color.Red : Color.Black;
                    g.DrawEllipse(new Pen(c, 1), new Rectangle(Point.Subtract(fParent.Connections[i].Location, new Size(2, 2)), new Size(4, 4)));
                    g.DrawLine(pen, new Point(8, fParent.Connections[i].Location.Y), new Point(rect.Left, fParent.Connections[i].Location.Y));
                }
            }
        }
    }
}