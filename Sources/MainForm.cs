using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace CircuitSimulator
{
    public partial class MainForm : Form
    {
        const string UNTITLED = "Untitled.csx";
        const string FILTER = "CircuitSimulator XML (*.csx)|*.csx";
        private string _fileName;
        private Components.ComponentController _components;

        public MainForm()
        {
            InitializeComponent();
            _fileName = UNTITLED;
            _components = new Components.ComponentController();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            _components.Run();
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
                    _components.Write(s);
                    s.Close();
                }
            }
        }

        private Components.Component ShowComponent(Components.Component c)
        {
            c.Show(panel1, contextMenuStrip1);
            return c;
        }

        private string GetNameWithoutExtension(string filename)
        {
            FileInfo info = new FileInfo(filename);
            return info.Name.Remove(info.Name.Length - info.Extension.Length);
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
            _components.Clear();
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
                    _components.Read(s);
                    s.Close();
                    foreach (Components.Component c in _components.Components)
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
                _components.Write(s);
                s.Close();
            }
        }

        private void ToolStripInputPin_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.InputPin()));
        }

        private void ToolStripPowerButton_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.PowerButton()));
        }

        private void ToolStripDigitalClock_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.DigitalClock()));
        }

        private void ToolStripSwitch_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Switch()));
        }

        private void ToolStripWire_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Wire()));
        }

        private void ToolStripBuffer_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Buffer()));
        }

        private void ToolStripNot_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Not()));
        }

        private void ToolStripAnd_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.And()));
        }

        private void ToolStripNand_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Nand()));
        }

        private void ToolStripOr_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Or()));
        }

        private void ToolStripNor_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Nor()));
        }

        private void ToolStripXor_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Xor()));
        }

        private void ToolStripXnor_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Xnor()));
        }

        private void ToolStripOutPin_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.OutputPin()));
        }

        private void ToolStripLedLamp_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.LedLamp()));
        }

        private void ToolStripDigitalDisplay4_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.DigitalDisplay(4)));
        }

        private void ToolStripDigitalDisplay8_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.DigitalDisplay(8)));
        }

        private void ToolStripSevenSegment_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.SevenSegment()));
        }

        private void ToolStripTrafficLight_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.TrafficLight()));
        }

        private void ToolStripIc_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                Stream s;
                if ((s = d.OpenFile()) != null)
                {
                    Components.Ic ic = new Components.Ic(GetNameWithoutExtension(d.FileName));
                    ic.LoadCircuit(s);
                    s.Close();

                    _components.Add(ShowComponent(ic));
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
                "Version 0.5.0\n\n" +
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}