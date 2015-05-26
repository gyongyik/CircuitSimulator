using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CircuitSimulator
{
    public partial class MainForm : Form
    {
        const string cTitle = "CircuitSimulator";
        const string cUntitled = "Untitled.csx";
        const string cFilter = "CircuitSimulator XML (*.csx)|*.csx";
        private string fFileName;
        private Components.ComponentController fComponents;

        public MainForm()
        {
            InitializeComponent();
            fFileName = cUntitled;
            fComponents = new Components.ComponentController();
            createToolTips();
        }

        private void createToolTips()
        {
            ToolTip tipNew = new ToolTip(); tipNew.SetToolTip(buttonNew, "New");
            ToolTip tipOpen = new ToolTip(); tipOpen.SetToolTip(buttonOpen, "Open...");
            ToolTip tipSave = new ToolTip(); tipSave.SetToolTip(buttonSave, "Save");

            ToolTip tipInputPin = new ToolTip(); tipInputPin.SetToolTip(buttonInputPin, "Input Pin");
            ToolTip tipPowerButton = new ToolTip(); tipPowerButton.SetToolTip(buttonPowerButton, "Power Button");
            ToolTip tipDigitalClock = new ToolTip(); tipDigitalClock.SetToolTip(buttonDigitalClock, "Digital Clock");
            ToolTip tipSwitch = new ToolTip(); tipSwitch.SetToolTip(buttonSwitch, "Switch");

            ToolTip tipWire = new ToolTip(); tipWire.SetToolTip(buttonWire, "Wire");

            ToolTip tipBuffer = new ToolTip(); tipBuffer.SetToolTip(buttonBuffer, "Buffer");
            ToolTip tipNot = new ToolTip(); tipNot.SetToolTip(buttonNot, "Not");
            ToolTip tipAnd = new ToolTip(); tipAnd.SetToolTip(buttonAnd, "And");
            ToolTip tipNand = new ToolTip(); tipNand.SetToolTip(buttonNand, "Nand");
            ToolTip tipOr = new ToolTip(); tipOr.SetToolTip(buttonOr, "Or");
            ToolTip tipNor = new ToolTip(); tipNor.SetToolTip(buttonNor, "Nor");
            ToolTip tipXor = new ToolTip(); tipXor.SetToolTip(buttonXor, "Xor");
            ToolTip tipXnor = new ToolTip(); tipXnor.SetToolTip(buttonXnor, "Xnor");

            ToolTip tipOutputPin = new ToolTip(); tipOutputPin.SetToolTip(buttonOutputPin, "Output Pin");
            ToolTip tipLEDLamp = new ToolTip(); tipLEDLamp.SetToolTip(buttonLEDLamp, "LED Lamp");
            ToolTip tipDigitalDisplay4 = new ToolTip(); tipDigitalDisplay4.SetToolTip(buttonDigitalDisplay4, "4 Bit Display");
            ToolTip tipDigitalDisplay8 = new ToolTip(); tipDigitalDisplay8.SetToolTip(buttonDigitalDisplay8, "8 Bit Display");
            ToolTip tipSevenSegment = new ToolTip(); tipSevenSegment.SetToolTip(buttonSevenSegment, "Seven Segment");
            ToolTip tipTrafficLight = new ToolTip(); tipTrafficLight.SetToolTip(buttonTrafficLight, "Traffic Light");

            ToolTip tipIC = new ToolTip(); tipIC.SetToolTip(buttonIC, "IC...");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fComponents.Run();
        }

        private void funcSaveAs()
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = cFilter;
            if (d.ShowDialog() == DialogResult.OK)
            {
                fFileName = d.FileName;
                Text = "CircuitSimulator - " + d.FileName;
                Stream s;
                if ((s = d.OpenFile()) != null)
                {
                    fComponents.Write(s);
                    s.Close();
                }
            }
        }

        private void funcSave()
        {
            var s = File.Create(fFileName);
            fComponents.Write(s);
            s.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fFileName == cUntitled)
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
            d.Filter = cFilter;
            //d.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            if (d.ShowDialog() == DialogResult.OK)
            {
                fFileName = d.FileName;
                Text = "CircuitSimulator - " + d.FileName;
                Stream s;
                if ((s = d.OpenFile()) != null)
                {
                    fComponents.Read(s);
                    s.Close();
                    foreach (Components.Component c in fComponents.Components)
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
            fFileName = cUntitled;
            Text = "CircuitSimulator - " + cUntitled;
            fComponents.Clear();
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

        class MyToolStripButton : ToolStripButton
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

        void delete_Click(object sender, EventArgs e)
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
            "Version 0.2.0\n\n" +
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
            fComponents.Add(ShowComponent(new Components.Buffer()));
        }

        private void buttonBuffer_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.Buffer()));
        }

        private void notToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.Not()));
        }

        private void buttonNot_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.Not()));
        }

        private void andToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.And()));
        }

        private void buttonAnd_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.And()));
        }

        private void nandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.Nand()));
        }

        private void buttonNand_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.Nand()));
        }

        private void orToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.Or()));
        }

        private void buttonOr_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.Or()));
        }

        private void norToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.Nor()));
        }

        private void buttonNor_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.Nor()));
        }

        private void xorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.Xor()));
        }

        private void buttonXor_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.Xor()));
        }

        private void xnorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.Xnor()));
        }

        private void buttonXnor_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.Xnor()));
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            funcNew();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            funcOpen();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcSaveAs();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (fFileName == cUntitled)
            {
                funcSaveAs();
            }
            else
            {
                funcSave();
            }
        }

        private void ledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.LEDLamp()));
        }

        private void digitalDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.DigitalDisplay(8)));
        }

        private void digitalClockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.DigitalClock()));
        }

        private void sevenSegmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.SevenSegment()));
        }

        private void trafficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.TrafficLight()));
        }

        private void buttonLED_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.LEDLamp()));
        }

        private void buttonDigitalDisplay8_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.DigitalDisplay(8)));
        }

        private void buttonSevenSegment_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.SevenSegment()));
        }

        private void buttonTrafficLight_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.TrafficLight()));
        }

        private void buttonOutputPin_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.OutputPin()));
        }

        private void outputPinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.OutputPin()));
        }

        private void buttonDigitalDisplay4_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.DigitalDisplay(4)));
        }

        private void digitalDisplay4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.DigitalDisplay(4)));
        }

        private void buttonInputPin_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.InputPin()));
        }

        private void wireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.Wire()));
        }

        private void buttonPowerButton_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.PowerButton()));
        }

        private void buttonDigitalClock_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.DigitalClock()));
        }

        private void powerButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.PowerButton()));
        }

        private void inputPinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.InputPin()));
        }

        private void icToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcIC();
        }

        private void buttonIC_Click(object sender, EventArgs e)
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

                    fComponents.Add(ShowComponent(ic));
                }
            }
        }

        private void buttonWire_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.Wire()));
        }

        private void switchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.Switch()));
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            fComponents.Add(ShowComponent(new Components.Switch()));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //
        }
    }
}