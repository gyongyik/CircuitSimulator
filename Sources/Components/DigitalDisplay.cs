using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Xml;

namespace CircuitSimulator.Components
{
    internal class DigitalDisplay : Component
    {
        private const string INPUTS = "inputs";
        private const string HEXADECIMAL = "hexadecimal";
        private const string SHOWCOLOR = "showcolor";
        private const string SHOWCAR = "showchar";

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
            Bounds = new(0, 0, 85, height);

            for (int i = 0; i < inputs; ++i)
            {
                Connections[i].Location = new(5, inputLocation);
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

        public override void Write(XmlWriter writer)
        {
            writer.WriteElementString(INPUTS, (Connections.Length - 1).ToString());
            writer.WriteElementString(HEXADECIMAL, _isHexadecimal.ToString());
            writer.WriteElementString(SHOWCOLOR, _showColor.ToString());
            writer.WriteElementString(SHOWCAR, _showChar.ToString());
        }

        public override void Read(XmlReader reader)
        {
            reader.ReadToDescendant(INPUTS);
            if (reader.IsStartElement(INPUTS))
            {
                int inputs = reader.ReadElementContentAsInt();
                Initialize(inputs);
            }

            reader.ReadToFollowing(HEXADECIMAL);
            if (reader.IsStartElement(HEXADECIMAL))
            {
                _isHexadecimal = reader.ReadElementContentAsBoolean();
            }

            reader.ReadToFollowing(SHOWCOLOR);
            if (reader.IsStartElement(SHOWCOLOR))
            {
                _showColor = reader.ReadElementContentAsBoolean();
            }

            reader.ReadToFollowing(SHOWCAR);
            if (reader.IsStartElement(SHOWCAR))
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
                hex.Click += new((object sender, EventArgs e) =>
                {
                    _component._isHexadecimal = !_component._isHexadecimal;
                    _component.Controller.ConnectComponent(_component);
                });
                menu.Items.Add(hex);

                if (_component.Connections.Length >= 8)
                {
                    ToolStripItem chr = new ToolStripButton(_component._showChar ? "Hide Char" : "Show Char");
                    chr.Click += new((object sender, EventArgs e) =>
                    {
                        _component._showChar = !_component._showChar;
                        _component.Controller.ConnectComponent(_component);
                    });
                    menu.Items.Add(chr);
                }
                else
                {
                    ToolStripItem cbg = new ToolStripButton(_component._showColor ? "Hide Color" : "Show Color");
                    cbg.Click += new((object sender, EventArgs e) =>
                    {
                        _component._showColor = !_component._showColor;
                        _component.Controller.ConnectComponent(_component);
                    });
                    menu.Items.Add(cbg);
                    
                }
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Pen pen = new(Color.DimGray, 3);
                Rectangle rect = new(15, 5, Width - 22, Height - 10);

                Brush textColor;
                Brush rectColor;

                if (_component._showColor)
                {
                    (Brush textColor, Brush rectColor) brushes = GetBrushes(_component._value);
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

                Font font = new("Consolas", 16, FontStyle.Bold);
                if (_component._isHexadecimal)
                {
                    string str = (_component._value < 16 ? "0x0" : "0x").ToString() + 
                        Convert.ToString(_component._value, 16).ToUpper();
                    g.DrawString(str, font, textColor, rect);
                }
                else
                {
                    g.DrawString(Convert.ToString(_component._value), font, textColor, rect);
                }

                if (_component._showChar)
                {
                    string str = Convert.ToString($"'{Convert.ToChar(_component._value)}'");
                    Rectangle rect2 = new(rect.X + 10, rect.Y + 60, rect.Width - 10, rect.Height - 60);
                    g.DrawString(str, font, Brushes.Tomato, rect2);
                }
  
                for (int i = 0; i < _component.Connections.Length - 1; ++i)
                {
                    g.DrawLine(pen, new(8, _component.Connections[i].Location.Y), 
                        new(rect.Left, _component.Connections[i].Location.Y));

                    Color color = _component.GetValue(i) ? Color.Tomato : Color.DimGray;
                    Point point = Point.Subtract(_component.Connections[i].Location, new(3, 3));
                    g.DrawEllipse(new(color, 1), new(point, new(6, 6)));
                }
            }

            private (Brush textColor, Brush rectColor) GetBrushes(int value) => value switch
            {
                1 => (Brushes.Khaki, Brushes.MidnightBlue),
                2 => (Brushes.Orchid, Brushes.Green),
                3 => (Brushes.Tomato, Brushes.DarkCyan),
                4 => (Brushes.Cyan, Brushes.Firebrick),
                5 => (Brushes.Chartreuse, Brushes.DarkMagenta),
                6 => (Brushes.RoyalBlue, Brushes.DarkGoldenrod),
                7 => (Brushes.Green, Brushes.LightGray),
                8 => (Brushes.Chartreuse, Brushes.DarkGray),
                9 => (Brushes.DarkGoldenrod, Brushes.RoyalBlue),
                10 => (Brushes.DarkMagenta, Brushes.Chartreuse),
                11 => (Brushes.Firebrick, Brushes.Cyan),
                12 => (Brushes.DarkCyan, Brushes.Tomato),
                13 => (Brushes.Green, Brushes.Orchid),
                14 => (Brushes.MidnightBlue, Brushes.Khaki),
                15 => (Brushes.Green, Brushes.White),
                _ => (Brushes.Chartreuse, Brushes.DimGray),
            };
        }
    }
}