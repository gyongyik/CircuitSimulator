using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CircuitSimulator
{
    public partial class MainForm : Form
    {
        const string UNTITLED = "Untitled.csx";
        const string FILTER = "CircuitSimulator XML (*.csx)|*.csx";
        private string _fileName;
        private Components.ComponentController _componentController;
        private ToolStripButton _checkedButton;
        private Point _wireStartLocation = new Point(int.MinValue, int.MinValue);

        public MainForm()
        {
            InitializeComponent();
            _fileName = UNTITLED;
            _componentController = new Components.ComponentController();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            _componentController.Run();
        }

        private void SaveAs()
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = FILTER;
            if (d.ShowDialog() == DialogResult.OK)
            {
                _fileName = d.FileName;
                Text = "CircuitSimulator - " + d.FileName;
                Stream s;
                if ((s = d.OpenFile()) != null)
                {
                    _componentController.Write(s);
                    s.Close();
                }
            }
        }

        private void AddComponent(Components.Component component, Point location)
        {
            if (toolStripWire.Checked || toolStripIc.Checked)
            {
                component.Location = location;
            }
            else
            {
                int grid = 5;
                component.Location = new Point((location.X - component.Width / 2) / grid * grid, (location.Y - component.Height / 2) / grid * grid);
            }

            component.Show(panel1, contextMenuStrip1);

            _componentController.Add(component);
            _componentController.ConnectComponent(component);
        }

        private class MyToolStripButton : ToolStripButton
        {
            public Components.ComponentControl Component;

            public MyToolStripButton(string name, Components.ComponentControl component) : base(name)
            {
                Component = component;
            }
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            Components.ComponentControl c = contextMenuStrip1.SourceControl as Components.ComponentControl;
            contextMenuStrip1.Items.Clear();
            ToolStripItem delete = new MyToolStripButton("Delete", c);
            delete.Click += new EventHandler(Delete_Click);
            delete.AutoToolTip = false;
            contextMenuStrip1.Items.Add(delete);
            c.ShowContextMenu(contextMenuStrip1, e);
            e.Cancel = false;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MyToolStripButton b = sender as MyToolStripButton;
            b.Component.DeleteComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            _fileName = UNTITLED;
            Text = "CircuitSimulator - " + UNTITLED;
            _componentController.Clear();
        }

        private void ToolStripOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = FILTER;
            if (d.ShowDialog() == DialogResult.OK)
            {
                _fileName = d.FileName;
                Text = "CircuitSimulator - " + d.FileName;
                Stream s;
                if ((s = d.OpenFile()) != null)
                {
                    _componentController.Read(s);
                    s.Close();
                    foreach (Components.Component c in _componentController.Components)
                    {
                        c.Show(panel1, contextMenuStrip1);
                    }
                }
            }
        }

        private void ToolStripSave_Click(object sender, EventArgs e)
        {
            if (_fileName == UNTITLED)
            {
                SaveAs();
            }
            else
            {
                FileStream s = File.Create(_fileName);
                _componentController.Write(s);
                s.Close();
            }
        }

        private void ToolStripInputPin_Click(object sender, EventArgs e)
        {
            SetCheckState((ToolStripButton)sender);
        }

        private void ToolStripPowerButton_Click(object sender, EventArgs e)
        {
            SetCheckState((ToolStripButton)sender);
        }

        private void ToolStripDigitalClock_Click(object sender, EventArgs e)
        {
            SetCheckState((ToolStripButton)sender);
        }

        private void ToolStripSwitch_Click(object sender, EventArgs e)
        {
            SetCheckState((ToolStripButton)sender);
        }

        private void ToolStripWire_Click(object sender, EventArgs e)
        {
            SetCheckState((ToolStripButton)sender);
        }

        private void ToolStripBuffer_Click(object sender, EventArgs e)
        {
            SetCheckState((ToolStripButton)sender);
        }

        private void ToolStripNot_Click(object sender, EventArgs e)
        {
            SetCheckState((ToolStripButton)sender);
        }

        private void ToolStripAnd_Click(object sender, EventArgs e)
        {
            SetCheckState((ToolStripButton)sender);
        }

        private void ToolStripNand_Click(object sender, EventArgs e)
        {
            SetCheckState((ToolStripButton)sender);
        }

        private void ToolStripOr_Click(object sender, EventArgs e)
        {
            SetCheckState((ToolStripButton)sender);
        }

        private void ToolStripNor_Click(object sender, EventArgs e)
        {
            SetCheckState((ToolStripButton)sender);
        }

        private void ToolStripXor_Click(object sender, EventArgs e)
        {
            SetCheckState((ToolStripButton)sender);
        }

        private void ToolStripXnor_Click(object sender, EventArgs e)
        {
            SetCheckState((ToolStripButton)sender);
        }

        private void ToolStripOutPin_Click(object sender, EventArgs e)
        {
            SetCheckState((ToolStripButton)sender);
        }

        private void ToolStripLedLamp_Click(object sender, EventArgs e)
        {
            SetCheckState((ToolStripButton)sender);
        }

        private void ToolStripDigitalDisplay4_Click(object sender, EventArgs e)
        {
            SetCheckState((ToolStripButton)sender);
        }

        private void ToolStripDigitalDisplay8_Click(object sender, EventArgs e)
        {
            SetCheckState((ToolStripButton)sender);
        }

        private void ToolStripSevenSegment_Click(object sender, EventArgs e)
        {
            SetCheckState((ToolStripButton)sender);
        }

        private void ToolStripTrafficLight_Click(object sender, EventArgs e)
        {
            SetCheckState((ToolStripButton)sender);
        }

        private void ToolStripIc_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                Stream s;
                if ((s = d.OpenFile()) != null)
                {
                    FileInfo fileInfo = new FileInfo(d.FileName);
                    string nameWithoutExtension = fileInfo.Name.Remove(fileInfo.Name.Length - fileInfo.Extension.Length);
                    Components.Ic ic = new Components.Ic(nameWithoutExtension);
                    ic.LoadCircuit(s);
                    s.Close();

                    ic.Show(panel1, contextMenuStrip1);
                    _componentController.Add(ic);
                }
            }
        }

        private void toolStripSaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void toolStripAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Circuit Simulator - Simulation of logical circuits\n" +
                "Copyright (C) 2009 Péter Gyöngyik\n\n" +
                "Version 0.8\n\n" +
                "This program is free software: you can redistribute it and/or modify\n" +
                "it under the terms of the GNU General Public License as published by\n" +
                "the Free Software Foundation, either version 3 of the License, or\n" +
                "(at your option) any later version.\n\n" +
                "This program is distributed in the hope that it will be useful,\n" +
                "but WITHOUT ANY WARRANTY; without even the implied warranty of\n" +
                "MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the\n" +
                "GNU General Public License for more details.\n\n" +
                "You should have received a copy of the GNU General Public License\n" +
                "along with this program. If not, see <http://www.gnu.org/licenses/>.",
                "About...");
        }

        private void toolStripMove_Click(object sender, EventArgs e)
        {
            SetCheckState((ToolStripButton)sender);
        }

        private void SetCheckState(ToolStripButton newCheckedButton)
        {
            if (_checkedButton != null)
            {
                _checkedButton.Checked = false;
            }
            else
            {
                toolStripWire.Checked = false;
            }
            _checkedButton = newCheckedButton;
            _checkedButton.Checked = true;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Point location = panel1.PointToClient(Cursor.Position);

            if (toolStripWire.Checked)
            {
                Graphics g = panel1.CreateGraphics();
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                if (_wireStartLocation.X == int.MinValue)
                {
                    _wireStartLocation = AutoConnect.Connect(location, _componentController);
                    g.DrawEllipse(new Pen(Color.DimGray, 1), new Rectangle(_wireStartLocation.X - 3, _wireStartLocation.Y - 3, 6, 6));
                }
                else
                {
                    location = AutoConnect.Connect(location, _componentController);
                    g.DrawEllipse(new Pen(Color.White, 3), new Rectangle(_wireStartLocation.X - 3, _wireStartLocation.Y - 3, 6, 6));
                   
                    int left = Math.Min(_wireStartLocation.X, location.X);
                    int top = Math.Min(_wireStartLocation.Y, location.Y);

                    AddComponent(new Components.Wire(
                            new Point(_wireStartLocation.X - left + 10 * ((location.X < _wireStartLocation.X) ? 1 : 0), _wireStartLocation.Y - top + 10 * ((location.Y < _wireStartLocation.Y) ? 1 : 0)),
                            new Point(location.X - left + 10 * ((_wireStartLocation.X < location.X) ? 1 : 0), location.Y - top + 10 * ((_wireStartLocation.Y < location.Y) ? 1 : 0))),
                            new Point(left - 5, top - 5));

                    _wireStartLocation = new Point(int.MinValue, int.MinValue);
                }
            }
            else if (toolStripInputPin.Checked)
            {
                AddComponent(new Components.InputPin(), location);
            }
            else if (toolStripPowerButton.Checked)
            {
                AddComponent(new Components.PowerButton(), location);
            }
            else if (toolStripDigitalClock.Checked)
            {
                AddComponent(new Components.DigitalClock(), location);
            }
            else if (toolStripSwitch.Checked)
            {
                AddComponent(new Components.Switch(), location);
            }
            else if (toolStripBuffer.Checked)
            {
                AddComponent(new Components.Buffer(), location);
            }
            else if (toolStripNot.Checked)
            {
                AddComponent(new Components.Not(), location);
            }
            else if (toolStripAnd.Checked)
            {
                AddComponent(new Components.And(), location);
            }
            else if (toolStripNand.Checked)
            {
                AddComponent(new Components.Nand(), location);
            }
            else if (toolStripOr.Checked)
            {
                AddComponent(new Components.Or(), location);
            }
            else if (toolStripNor.Checked)
            {
                AddComponent(new Components.Nor(), location);
            }
            else if (toolStripXor.Checked)
            {
                AddComponent(new Components.Xor(), location);
            }
            else if (toolStripXnor.Checked)
            {
                AddComponent(new Components.Xnor(), location);
            }
            else if (toolStripOutPin.Checked)
            {
                AddComponent(new Components.OutputPin(), location);
            }
            else if (toolStripLedLamp.Checked)
            {
                AddComponent(new Components.LedLamp(), location);
            }
            else if (toolStripDigitalDisplay4.Checked)
            {
                AddComponent(new Components.DigitalDisplay(4), location);
            }
            else if (toolStripDigitalDisplay8.Checked)
            {
                AddComponent(new Components.DigitalDisplay(8), location);
            }
            else if (toolStripSevenSegment.Checked)
            {
                AddComponent(new Components.SevenSegment(), location);
            }
            else if (toolStripTrafficLight.Checked)
            {
               AddComponent(new Components.TrafficLight(), location);
            }
        }
    }
}