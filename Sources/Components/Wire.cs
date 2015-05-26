using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    public class WireConnection : Connection
    {
        bool fProcessing;

        public WireConnection(Component parent) : base(parent)
        {
            fProcessing = false;
        }

        public override bool Value
        {
            get
            {
                if (!fProcessing)
                {
                    fProcessing = true;
                    bool value = Parent.GetValue(0); // || Parent.GetValue(1);
                    fProcessing = false;
                    return value;
                }
                else
                {
                    return false;
                }
            }
        }
    }

    public class Wire : Component
    {
        private bool fCalculated;
        private bool fValue;

        public Wire() : base(1, 1)
        {
            Point in0 = new Point(5, 5);
            Point in1 = new Point(95, 45);

            Bounds = new Rectangle(0, 0, Math.Max(in0.X, in1.X) + 5, Math.Max(in0.Y, in1.Y) + 5);

            Connections[0] = new WireConnection(this);
            Connections[1] = new WireConnection(this);
            Connections[0].Location = in0;
            Connections[1].Location = in1;
        }

        public Wire(Point in0, Point in1) : base(1, 1)
        {
            Bounds = new Rectangle(0, 0, Math.Max(in0.X, in1.X) + 5, Math.Max(in0.Y, in1.Y) + 5);

            Connections[0] = new WireConnection(this);
            Connections[1] = new WireConnection(this);
            Connections[0].Location = in0;
            Connections[1].Location = in1;
        }

        public override void Setup()
        {
            fCalculated = false;
            fValue = false;
        }

        public override void Execute()
        {
            base.Execute();
        }

        public override void Write(System.Xml.XmlWriter writer)
        {
            writer.WriteStartElement("width");
            writer.WriteValue(Width - 10);
            writer.WriteEndElement();

            writer.WriteStartElement("height");
            writer.WriteValue(Height - 10);
            writer.WriteEndElement();
        }

        public override void Read(System.Xml.XmlReader reader)
        {
            reader.ReadToFollowing("width");
            if (reader.IsStartElement("width"))
            {
                SetWidth(reader.ReadElementContentAsInt());
            }

            reader.ReadToFollowing("height");
            if (reader.IsStartElement("height"))
            {
                SetHeight(reader.ReadElementContentAsInt());
            }
        }

        public void SetWidth(int value)
        {
            if (Connections[1].Location.X < Connections[0].Location.X)
            {
                Connections[0].Location = new Point(Connections[1].Location.X + value, Connections[0].Location.Y);
            }
            else
            {
                Connections[1].Location = new Point(Connections[0].Location.X + value, Connections[1].Location.Y);
            }
            Bounds = new Rectangle(Location.X, Location.Y, Math.Max(Connections[0].Location.X, Connections[1].Location.X) + 5, Math.Max(Connections[0].Location.Y, Connections[1].Location.Y) + 5);
        }

        public void SetHeight(int value)
        {
            if (Connections[1].Location.Y < Connections[0].Location.Y)
            {
                Connections[0].Location = new Point(Connections[0].Location.X, Connections[1].Location.Y + Convert.ToInt32(value));
            }
            else
            {
                Connections[1].Location = new Point(Connections[1].Location.X, Connections[0].Location.Y + Convert.ToInt32(value));
            }
            Bounds = new Rectangle(Location.X, Location.Y, Math.Max(Connections[0].Location.X, Connections[1].Location.X) + 5, Math.Max(Connections[0].Location.Y, Connections[1].Location.Y) + 5);
        }

        public override bool GetValue(int index)
        {
            if (fCalculated)
            {
                return fValue;
            }

            bool result = false;

            foreach (Connection c in Connections[0].Connections)
            {
                result |= c.Value;
            }

            foreach (Connection c in Connections[1].Connections)
            {
                result |= c.Value;
            }

            return result;
        }

        protected override void OnDisconnect()
        {
            SetValue(0, false);
            SetValue(1, false);
            base.OnDisconnect();
        }

        protected override ComponentControl CreateComponentControl()
        {
            return new WireControl(this);
        }

        class WireControl : ComponentControl
        {
            Wire fParent;

            public WireControl(Wire parent) : base(parent)
            {
                fParent = parent;
            }

            public override void ShowContextMenu(ContextMenuStrip menu, CancelEventArgs ce)
            {
                ToolStripItem cw = new ToolStripButton("Change Width");
                cw.Click += new EventHandler(delegate (object sender, EventArgs e)
                {
                    string value = Convert.ToString(fParent.Width - 10);
                    if (InputBox("Change Width", "Width:", ref value) == DialogResult.OK)
                    {
                        fParent.SetWidth(Convert.ToInt32(value));
                        fParent.Circuit.ConnectComponent(fParent);
                    }
                });
                menu.Items.Add(cw);

                ToolStripItem ch = new ToolStripButton("Change Height");
                ch.Click += new EventHandler(delegate (object sender, EventArgs e)
                {
                    string value = Convert.ToString(fParent.Height - 10);
                    if (InputBox("Change Height", "Height:", ref value) == DialogResult.OK)
                    {
                        fParent.SetHeight(Convert.ToInt32(value));
                        fParent.Circuit.ConnectComponent(fParent);
                    }
                });
                menu.Items.Add(ch);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Black, 3);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawLine(pen, new Point(fComponent.GetComponent().Connections[0].Location.X, fComponent.GetComponent().Connections[0].Location.Y), new Point(fComponent.GetComponent().Connections[1].Location.X, fComponent.GetComponent().Connections[1].Location.Y));
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

                for (int i = 0; i < fComponent.GetComponent().Connections.Length; ++i)
                {
                    Color c = fComponent.GetComponent().GetValue(i) ? Color.Red : Color.Black;
                    int w = fComponent.GetComponent().Connections[i].Connections.Count > 0 ? 3 : 1;
                    Rectangle rect = new Rectangle(Point.Subtract(fComponent.GetComponent().Connections[i].Location, new Size(2, 2)), new Size(4, 4));
                    g.FillEllipse(Brushes.White, rect);
                    g.DrawEllipse(new Pen(c, w), rect);
                }
            }
        }
    }
}
