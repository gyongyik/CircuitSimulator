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

        private void timer1_Tick(object sender, EventArgs e)
        {
            _components.Run();
        }

        private void funcSaveAs()
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

        private void funcSave()
        {
            var s = File.Create(_fileName);
            _components.Write(s);
            s.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_fileName == UNTITLED)
            {
                funcSaveAs();
            }
            else
            {
                funcSave();
            }
        }

        private void funcOpen()
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcOpen();
        }

        private void funcNew()
        {
            _fileName = UNTITLED;
            Text = "CircuitSimulator - " + UNTITLED;
            _components.Clear();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcNew();
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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            Components.ComponentControl c = contextMenuStrip1.SourceControl as Components.ComponentControl;
            contextMenuStrip1.Items.Clear();
            ToolStripItem delete = new MyToolStripButton("Delete", c);
            delete.Click += new EventHandler(delete_Click);
            delete.AutoToolTip = false;
            contextMenuStrip1.Items.Add(delete);
            c.ShowContextMenu(contextMenuStrip1, e);
            e.Cancel = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            MyToolStripButton b = sender as MyToolStripButton;
            b.Component.DeleteComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Circuit Simulator - Simulation of logical circuits\n" +
            "Copyright (C) 2009 Péter Gyöngyik\n\n" +
            "Version 0.3.0\n\n" +
            "This program is free software: you can redistribute it and/or modify\n" +
            "it under the terms of the GNU General Public License as published by\n" +
            "the Free Software Foundation, either version 3 of the License, or\n" +
            "(at your option) any later version.\n\n" +
            "This program is distributed in the hope that it will be useful,\n" +
            "but WITHOUT ANY WARRANTY; without even the implied warranty of\n" +
            "MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the\n" +
            "GNU General Public License for more details.\n\n" +
            "You should have received a copy of the GNU General Public License\n" +
            "along with this program. If not, see <http://www.gnu.org/licenses/>.", "About...");
        }

        private void bufferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Buffer()));
        }

        private void notToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Not()));
        }

        private void andToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.And()));
        }

        private void nandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Nand()));
        }

        private void orToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Or()));
        }

        private void norToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Nor()));
        }

        private void xorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Xor()));
        }

        private void xnorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Xnor()));
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcSaveAs();
        }

        private void ledLampToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.LEDLamp()));
        }

        private void digitalDisplay8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.DigitalDisplay(8)));
        }

        private void digitalClockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.DigitalClock()));
        }

        private void sevenSegmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.SevenSegment()));
        }

        private void trafficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.TrafficLight()));
        }

        private void outputPinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.OutputPin()));
        }

        private void digitalDisplay4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.DigitalDisplay(4)));
        }

        private void wireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Wire()));
        }

        private void powerButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.PowerButton()));
        }

        private void inputPinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.InputPin()));
        }

        private void icToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcIC();
        }

        private void funcIC()
        {
            OpenFileDialog d = new OpenFileDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                Stream s;
                if ((s = d.OpenFile()) != null)
                {
                    Components.IC ic = new Components.IC(GetNameWithoutExtension(d.FileName));
                    ic.LoadCircuit(s);
                    s.Close();

                    _components.Add(ShowComponent(ic));
                }
            }
        }

        private void switchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Switch()));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            funcNew();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void toolStripOpen_Click(object sender, EventArgs e)
        {
            funcOpen();
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (_fileName == UNTITLED)
            {
                funcSaveAs();
            }
            else
            {
                funcSave();
            }
        }

        private void toolStripInputPin_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.InputPin()));
        }

        private void toolStripPowerButton_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.PowerButton()));
        }

        private void toolStripDigitalClock_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.DigitalClock()));
        }

        private void toolStripSwitch_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Switch()));
        }

        private void toolStripWire_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Wire()));
        }

        private void toolStripBuffer_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Buffer()));
        }

        private void toolStripNot_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Not()));
        }

        private void toolStripAnd_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.And()));
        }

        private void toolStripNand_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Nand()));
        }

        private void toolStripOr_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Or()));
        }

        private void toolStripNor_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Nor()));
        }

        private void toolStripXor_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Xor()));
        }

        private void toolStripXnor_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.Xnor()));
        }

        private void toolStripOutPin_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.OutputPin()));
        }

        private void toolStripLEDLamp_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.LEDLamp()));
        }

        private void toolStripDigitalDisplay4_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.DigitalDisplay(4)));
        }

        private void toolStripDigitalDisplay8_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.DigitalDisplay(8)));
        }

        private void toolStripSevenSegment_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.SevenSegment()));
        }

        private void toolStripTrafficLight_Click(object sender, EventArgs e)
        {
            _components.Add(ShowComponent(new Components.TrafficLight()));
        }

        private void toolStripIC_Click(object sender, EventArgs e)
        {
            funcIC();
        }
    }
}