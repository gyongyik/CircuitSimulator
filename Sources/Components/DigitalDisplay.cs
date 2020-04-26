using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    internal class DigitalDisplay : Component
    {
        private int _value;
        private bool _isHexadecimal;
        private bool _showColor;
        private bool _showChar;

        public DigitalDisplay() : base()
        {
            _isHexadecimal = false;
            _showColor = false;
            _showChar = false;
            Initialize(8);
        }

        public DigitalDisplay(int inputs) : base()
        {
            _isHexadecimal = false;
            _showColor = false;
            _showChar = false;
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
            writer.WriteElementString("hexadecimal", _isHexadecimal.ToString());
            writer.WriteElementString("showcolor", _showColor.ToString());
            writer.WriteElementString("showchar", _showChar.ToString());
        }

        public override void Read(System.Xml.XmlReader reader)
        {
            reader.ReadToDescendant("inputs");
            if (reader.IsStartElement("inputs"))
            {
                int inputs = reader.ReadElementContentAsInt();
                Initialize(inputs);
            }

            reader.ReadToFollowing("hexadecimal");
            if (reader.IsStartElement("hexadecimal"))
            {
                _isHexadecimal = reader.ReadElementContentAsBoolean();
            }

            reader.ReadToFollowing("showcolor");
            if (reader.IsStartElement("showcolor"))
            {
                _showColor = reader.ReadElementContentAsBoolean();
            }

            reader.ReadToFollowing("showchar");
            if (reader.IsStartElement("showchar"))
            {
                _showChar = reader.ReadElementContentAsBoolean();
            }
        }

        protected override ComponentControl CreateComponentControl()
        {
            return new DigitalDisplayControl(this);
        }

        private class DigitalDisplayControl : ComponentControl
        {
            DigitalDisplay _component;

            public DigitalDisplayControl(DigitalDisplay component) : base(component)
            {
                _component = component;
            }

            public override void ShowContextMenu(ContextMenuStrip menu, CancelEventArgs ce)
            {
                ToolStripItem hex = new ToolStripButton(_component._isHexadecimal ? "Decimal" : "Hexadecimal");
                hex.Click += new EventHandler(delegate (object sender, EventArgs e)
                {
                    _component._isHexadecimal = !_component._isHexadecimal;
                    _component.Circuit.ConnectComponent(_component);
                });
                menu.Items.Add(hex);

                if (_component.Connections.Length >= 8)
                {
                    ToolStripItem chr = new ToolStripButton(_component._showChar ? "Hide Char" : "Show Char");
                    chr.Click += new EventHandler(delegate (object sender, EventArgs e)
                    {
                        _component._showChar = !_component._showChar;
                        _component.Circuit.ConnectComponent(_component);
                    });
                    menu.Items.Add(chr);
                }
                else
                {
                    ToolStripItem cbg = new ToolStripButton(_component._showColor ? "Hide Color" : "Show Color");
                    cbg.Click += new EventHandler(delegate (object sender, EventArgs e)
                    {
                        _component._showColor = !_component._showColor;
                        _component.Circuit.ConnectComponent(_component);
                    });
                    menu.Items.Add(cbg);
                    
                }
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Pen pen = new Pen(Color.DimGray, 3);
                Rectangle rect = new Rectangle(15, 5, Width - 22, Height - 10);

                Brush textColor;
                Brush rectColor;

                if (_component._showColor)
                {
                    var brushes = GetBrushes(_component._value);
                    textColor = brushes.textColor;
                    rectColor = brushes.rectColor;
                }
                else
                {
                    textColor = Brushes.Tomato;
                    rectColor = Brushes.White;
                }
                
                g.FillRectangle(rectColor, rect);
                g.DrawRectangle(pen, rect);

                Font font = new Font("Consolas", 16, FontStyle.Bold);
                if (_component._isHexadecimal)
                {
                    g.DrawString((_component._value < 16 ? "0x0" : "0x").ToString() + Convert.ToString(_component._value, 16).ToUpper(), font, textColor, rect);
                }
                else
                {
                    g.DrawString(Convert.ToString(_component._value), font, textColor, rect);
                }

                if (_component._showChar)
                {
                    g.DrawString(Convert.ToString($"'{Convert.ToChar(_component._value)}'"), font, Brushes.Tomato, new Rectangle(rect.X + 10, rect.Y + 60, rect.Width - 10, rect.Height - 60));
                }
  
                for (int i = 0; i < _component.Connections.Length - 1; ++i)
                {
                    Color c = _component.GetValue(i) ? Color.Tomato : Color.DimGray;
                    g.DrawLine(pen, new Point(8, _component.Connections[i].Location.Y), new Point(rect.Left, _component.Connections[i].Location.Y));
                    g.DrawEllipse(new Pen(c, 1), new Rectangle(Point.Subtract(_component.Connections[i].Location, new Size(3, 3)), new Size(6, 6)));

                }
            }

            private (Brush textColor, Brush rectColor) GetBrushes(int value)
            {
                switch (value)
                {
                    case 1:
                        return (Brushes.Khaki, Brushes.MidnightBlue);
                    case 2:
                        return (Brushes.Orchid, Brushes.Green);
                    case 3:
                        return (Brushes.Tomato, Brushes.DarkCyan);
                    case 4:
                        return (Brushes.Cyan, Brushes.Firebrick);
                    case 5:
                        return (Brushes.Chartreuse, Brushes.DarkMagenta);
                    case 6:
                        return (Brushes.RoyalBlue, Brushes.DarkGoldenrod);
                    case 7:
                        return (Brushes.Green, Brushes.LightGray);
                    case 8:
                        return (Brushes.Chartreuse, Brushes.DarkGray);
                    case 9:
                        return (Brushes.DarkGoldenrod, Brushes.RoyalBlue);
                    case 10:
                        return (Brushes.DarkMagenta, Brushes.Chartreuse);
                    case 11:
                        return (Brushes.Firebrick, Brushes.Cyan);
                    case 12:
                        return (Brushes.DarkCyan, Brushes.Tomato);
                    case 13:
                        return (Brushes.Green, Brushes.Orchid);
                    case 14:
                        return (Brushes.MidnightBlue, Brushes.Khaki);
                    case 15:
                        return (Brushes.Green, Brushes.White);
                    default:
                        return (Brushes.Chartreuse, Brushes.DimGray);
                }
            }
        }
    }
}