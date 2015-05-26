namespace CircuitSimulator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputPinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalClockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bufferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.andToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.norToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xnorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputPinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalDisplay4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalDisplay8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sevenSegmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trafficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.icToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelSep1 = new System.Windows.Forms.Label();
            this.buttonInputPin = new System.Windows.Forms.Button();
            this.buttonPowerButton = new System.Windows.Forms.Button();
            this.buttonDigitalClock = new System.Windows.Forms.Button();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.labelSep2 = new System.Windows.Forms.Label();
            this.buttonWire = new System.Windows.Forms.Button();
            this.labelSep3 = new System.Windows.Forms.Label();
            this.buttonBuffer = new System.Windows.Forms.Button();
            this.buttonNot = new System.Windows.Forms.Button();
            this.buttonAnd = new System.Windows.Forms.Button();
            this.buttonNand = new System.Windows.Forms.Button();
            this.buttonOr = new System.Windows.Forms.Button();
            this.buttonNor = new System.Windows.Forms.Button();
            this.buttonXor = new System.Windows.Forms.Button();
            this.buttonXnor = new System.Windows.Forms.Button();
            this.labelSep4 = new System.Windows.Forms.Label();
            this.buttonOutputPin = new System.Windows.Forms.Button();
            this.buttonLEDLamp = new System.Windows.Forms.Button();
            this.buttonDigitalDisplay4 = new System.Windows.Forms.Button();
            this.buttonDigitalDisplay8 = new System.Windows.Forms.Button();
            this.buttonSevenSegment = new System.Windows.Forms.Button();
            this.buttonTrafficLight = new System.Windows.Forms.Button();
            this.labelSep5 = new System.Windows.Forms.Label();
            this.buttonIC = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 401);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStripMenuItem,
            this.createToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(882, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileStripMenuItem
            // 
            this.fileStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripMenuItem9,
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileStripMenuItem.Name = "fileStripMenuItem";
            this.fileStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(192, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(192, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem,
            this.wireToolStripMenuItem,
            this.gatesToolStripMenuItem,
            this.outputToolStripMenuItem,
            this.toolStripMenuItem3,
            this.icToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputPinToolStripMenuItem,
            this.powerButtonToolStripMenuItem,
            this.digitalClockToolStripMenuItem,
            this.switchToolStripMenuItem});
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.inputToolStripMenuItem.Text = "Input";
            // 
            // inputPinToolStripMenuItem
            // 
            this.inputPinToolStripMenuItem.Name = "inputPinToolStripMenuItem";
            this.inputPinToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.inputPinToolStripMenuItem.Text = "Input Pin";
            this.inputPinToolStripMenuItem.Click += new System.EventHandler(this.inputPinToolStripMenuItem_Click);
            // 
            // powerButtonToolStripMenuItem
            // 
            this.powerButtonToolStripMenuItem.Name = "powerButtonToolStripMenuItem";
            this.powerButtonToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.powerButtonToolStripMenuItem.Text = "Power Button";
            this.powerButtonToolStripMenuItem.Click += new System.EventHandler(this.powerButtonToolStripMenuItem_Click);
            // 
            // digitalClockToolStripMenuItem
            // 
            this.digitalClockToolStripMenuItem.Name = "digitalClockToolStripMenuItem";
            this.digitalClockToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.digitalClockToolStripMenuItem.Text = "Digital Clock";
            this.digitalClockToolStripMenuItem.Click += new System.EventHandler(this.digitalClockToolStripMenuItem_Click);
            // 
            // switchToolStripMenuItem
            // 
            this.switchToolStripMenuItem.Name = "switchToolStripMenuItem";
            this.switchToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.switchToolStripMenuItem.Text = "Switch";
            this.switchToolStripMenuItem.Click += new System.EventHandler(this.switchToolStripMenuItem_Click);
            // 
            // wireToolStripMenuItem
            // 
            this.wireToolStripMenuItem.Name = "wireToolStripMenuItem";
            this.wireToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.wireToolStripMenuItem.Text = "Wire";
            this.wireToolStripMenuItem.Click += new System.EventHandler(this.wireToolStripMenuItem_Click);
            // 
            // gatesToolStripMenuItem
            // 
            this.gatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bufferToolStripMenuItem,
            this.notToolStripMenuItem,
            this.andToolStripMenuItem,
            this.nandToolStripMenuItem,
            this.orToolStripMenuItem,
            this.norToolStripMenuItem1,
            this.xorToolStripMenuItem,
            this.xnorToolStripMenuItem1});
            this.gatesToolStripMenuItem.Name = "gatesToolStripMenuItem";
            this.gatesToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.gatesToolStripMenuItem.Text = "Gate";
            // 
            // bufferToolStripMenuItem
            // 
            this.bufferToolStripMenuItem.Name = "bufferToolStripMenuItem";
            this.bufferToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.bufferToolStripMenuItem.Text = "Buffer";
            this.bufferToolStripMenuItem.Click += new System.EventHandler(this.bufferToolStripMenuItem_Click);
            // 
            // notToolStripMenuItem
            // 
            this.notToolStripMenuItem.Name = "notToolStripMenuItem";
            this.notToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.notToolStripMenuItem.Text = "Not";
            this.notToolStripMenuItem.Click += new System.EventHandler(this.notToolStripMenuItem_Click);
            // 
            // andToolStripMenuItem
            // 
            this.andToolStripMenuItem.Name = "andToolStripMenuItem";
            this.andToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.andToolStripMenuItem.Text = "And";
            this.andToolStripMenuItem.Click += new System.EventHandler(this.andToolStripMenuItem_Click);
            // 
            // nandToolStripMenuItem
            // 
            this.nandToolStripMenuItem.Name = "nandToolStripMenuItem";
            this.nandToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.nandToolStripMenuItem.Text = "Nand";
            this.nandToolStripMenuItem.Click += new System.EventHandler(this.nandToolStripMenuItem_Click);
            // 
            // orToolStripMenuItem
            // 
            this.orToolStripMenuItem.Name = "orToolStripMenuItem";
            this.orToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.orToolStripMenuItem.Text = "Or";
            this.orToolStripMenuItem.Click += new System.EventHandler(this.orToolStripMenuItem_Click);
            // 
            // norToolStripMenuItem1
            // 
            this.norToolStripMenuItem1.Name = "norToolStripMenuItem1";
            this.norToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.norToolStripMenuItem1.Text = "Nor";
            this.norToolStripMenuItem1.Click += new System.EventHandler(this.norToolStripMenuItem1_Click);
            // 
            // xorToolStripMenuItem
            // 
            this.xorToolStripMenuItem.Name = "xorToolStripMenuItem";
            this.xorToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.xorToolStripMenuItem.Text = "Xor";
            this.xorToolStripMenuItem.Click += new System.EventHandler(this.xorToolStripMenuItem_Click);
            // 
            // xnorToolStripMenuItem1
            // 
            this.xnorToolStripMenuItem1.Name = "xnorToolStripMenuItem1";
            this.xnorToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.xnorToolStripMenuItem1.Text = "Xnor";
            this.xnorToolStripMenuItem1.Click += new System.EventHandler(this.xnorToolStripMenuItem1_Click);
            // 
            // outputToolStripMenuItem
            // 
            this.outputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputPinToolStripMenuItem,
            this.ledToolStripMenuItem,
            this.digitalDisplay4ToolStripMenuItem,
            this.digitalDisplay8ToolStripMenuItem,
            this.sevenSegmentToolStripMenuItem,
            this.trafficToolStripMenuItem});
            this.outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            this.outputToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.outputToolStripMenuItem.Text = "Output";
            // 
            // outputPinToolStripMenuItem
            // 
            this.outputPinToolStripMenuItem.Name = "outputPinToolStripMenuItem";
            this.outputPinToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.outputPinToolStripMenuItem.Text = "Output Pin";
            this.outputPinToolStripMenuItem.Click += new System.EventHandler(this.outputPinToolStripMenuItem_Click);
            // 
            // ledToolStripMenuItem
            // 
            this.ledToolStripMenuItem.Name = "ledToolStripMenuItem";
            this.ledToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ledToolStripMenuItem.Text = "LED Lamp";
            this.ledToolStripMenuItem.Click += new System.EventHandler(this.ledToolStripMenuItem_Click);
            // 
            // digitalDisplay4ToolStripMenuItem
            // 
            this.digitalDisplay4ToolStripMenuItem.Name = "digitalDisplay4ToolStripMenuItem";
            this.digitalDisplay4ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.digitalDisplay4ToolStripMenuItem.Text = "4 Bit Display";
            this.digitalDisplay4ToolStripMenuItem.Click += new System.EventHandler(this.digitalDisplay4ToolStripMenuItem_Click);
            // 
            // digitalDisplay8ToolStripMenuItem
            // 
            this.digitalDisplay8ToolStripMenuItem.Name = "digitalDisplay8ToolStripMenuItem";
            this.digitalDisplay8ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.digitalDisplay8ToolStripMenuItem.Text = "8 Bit Display";
            this.digitalDisplay8ToolStripMenuItem.Click += new System.EventHandler(this.digitalDisplayToolStripMenuItem_Click);
            // 
            // sevenSegmentToolStripMenuItem
            // 
            this.sevenSegmentToolStripMenuItem.Name = "sevenSegmentToolStripMenuItem";
            this.sevenSegmentToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.sevenSegmentToolStripMenuItem.Text = "Seven Segment";
            this.sevenSegmentToolStripMenuItem.Click += new System.EventHandler(this.sevenSegmentToolStripMenuItem_Click);
            // 
            // trafficToolStripMenuItem
            // 
            this.trafficToolStripMenuItem.Name = "trafficToolStripMenuItem";
            this.trafficToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.trafficToolStripMenuItem.Text = "Traffic Light";
            this.trafficToolStripMenuItem.Click += new System.EventHandler(this.trafficToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(109, 6);
            // 
            // icToolStripMenuItem
            // 
            this.icToolStripMenuItem.Name = "icToolStripMenuItem";
            this.icToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.icToolStripMenuItem.Text = "IC...";
            this.icToolStripMenuItem.Click += new System.EventHandler(this.icToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(36, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(882, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.buttonNew);
            this.flowLayoutPanel1.Controls.Add(this.buttonOpen);
            this.flowLayoutPanel1.Controls.Add(this.buttonSave);
            this.flowLayoutPanel1.Controls.Add(this.labelSep1);
            this.flowLayoutPanel1.Controls.Add(this.buttonInputPin);
            this.flowLayoutPanel1.Controls.Add(this.buttonPowerButton);
            this.flowLayoutPanel1.Controls.Add(this.buttonDigitalClock);
            this.flowLayoutPanel1.Controls.Add(this.buttonSwitch);
            this.flowLayoutPanel1.Controls.Add(this.labelSep2);
            this.flowLayoutPanel1.Controls.Add(this.buttonWire);
            this.flowLayoutPanel1.Controls.Add(this.labelSep3);
            this.flowLayoutPanel1.Controls.Add(this.buttonBuffer);
            this.flowLayoutPanel1.Controls.Add(this.buttonNot);
            this.flowLayoutPanel1.Controls.Add(this.buttonAnd);
            this.flowLayoutPanel1.Controls.Add(this.buttonNand);
            this.flowLayoutPanel1.Controls.Add(this.buttonOr);
            this.flowLayoutPanel1.Controls.Add(this.buttonNor);
            this.flowLayoutPanel1.Controls.Add(this.buttonXor);
            this.flowLayoutPanel1.Controls.Add(this.buttonXnor);
            this.flowLayoutPanel1.Controls.Add(this.labelSep4);
            this.flowLayoutPanel1.Controls.Add(this.buttonOutputPin);
            this.flowLayoutPanel1.Controls.Add(this.buttonLEDLamp);
            this.flowLayoutPanel1.Controls.Add(this.buttonDigitalDisplay4);
            this.flowLayoutPanel1.Controls.Add(this.buttonDigitalDisplay8);
            this.flowLayoutPanel1.Controls.Add(this.buttonSevenSegment);
            this.flowLayoutPanel1.Controls.Add(this.buttonTrafficLight);
            this.flowLayoutPanel1.Controls.Add(this.labelSep5);
            this.flowLayoutPanel1.Controls.Add(this.buttonIC);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(876, 35);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // buttonNew
            // 
            this.buttonNew.BackgroundImage = global::CircuitSimulator.Properties.Resources.New;
            this.buttonNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNew.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonNew.FlatAppearance.BorderSize = 0;
            this.buttonNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.Location = new System.Drawing.Point(0, 0);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(32, 32);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Tag = "";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackgroundImage = global::CircuitSimulator.Properties.Resources.Open;
            this.buttonOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpen.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonOpen.FlatAppearance.BorderSize = 0;
            this.buttonOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.Location = new System.Drawing.Point(32, 0);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(32, 32);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackgroundImage = global::CircuitSimulator.Properties.Resources.Save;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(64, 0);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(32, 32);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelSep1
            // 
            this.labelSep1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSep1.Location = new System.Drawing.Point(99, 0);
            this.labelSep1.Name = "labelSep1";
            this.labelSep1.Size = new System.Drawing.Size(2, 32);
            this.labelSep1.TabIndex = 2;
            // 
            // buttonInputPin
            // 
            this.buttonInputPin.BackgroundImage = global::CircuitSimulator.Properties.Resources.InputPin;
            this.buttonInputPin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonInputPin.FlatAppearance.BorderSize = 0;
            this.buttonInputPin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonInputPin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonInputPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInputPin.Location = new System.Drawing.Point(104, 0);
            this.buttonInputPin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonInputPin.Name = "buttonInputPin";
            this.buttonInputPin.Size = new System.Drawing.Size(32, 32);
            this.buttonInputPin.TabIndex = 20;
            this.buttonInputPin.UseVisualStyleBackColor = true;
            this.buttonInputPin.Click += new System.EventHandler(this.buttonInputPin_Click);
            // 
            // buttonPowerButton
            // 
            this.buttonPowerButton.BackgroundImage = global::CircuitSimulator.Properties.Resources.PowerButton;
            this.buttonPowerButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonPowerButton.FlatAppearance.BorderSize = 0;
            this.buttonPowerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonPowerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonPowerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPowerButton.Location = new System.Drawing.Point(136, 0);
            this.buttonPowerButton.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPowerButton.Name = "buttonPowerButton";
            this.buttonPowerButton.Size = new System.Drawing.Size(32, 32);
            this.buttonPowerButton.TabIndex = 21;
            this.buttonPowerButton.UseVisualStyleBackColor = true;
            this.buttonPowerButton.Click += new System.EventHandler(this.buttonPowerButton_Click);
            // 
            // buttonDigitalClock
            // 
            this.buttonDigitalClock.BackgroundImage = global::CircuitSimulator.Properties.Resources.DigitalClock;
            this.buttonDigitalClock.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonDigitalClock.FlatAppearance.BorderSize = 0;
            this.buttonDigitalClock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonDigitalClock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonDigitalClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigitalClock.Location = new System.Drawing.Point(168, 0);
            this.buttonDigitalClock.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDigitalClock.Name = "buttonDigitalClock";
            this.buttonDigitalClock.Size = new System.Drawing.Size(32, 32);
            this.buttonDigitalClock.TabIndex = 22;
            this.buttonDigitalClock.UseVisualStyleBackColor = true;
            this.buttonDigitalClock.Click += new System.EventHandler(this.buttonDigitalClock_Click);
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.BackgroundImage = global::CircuitSimulator.Properties.Resources.Switch;
            this.buttonSwitch.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonSwitch.FlatAppearance.BorderSize = 0;
            this.buttonSwitch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonSwitch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwitch.Location = new System.Drawing.Point(200, 0);
            this.buttonSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(32, 32);
            this.buttonSwitch.TabIndex = 23;
            this.buttonSwitch.UseVisualStyleBackColor = true;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // labelSep2
            // 
            this.labelSep2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSep2.Location = new System.Drawing.Point(235, 0);
            this.labelSep2.Name = "labelSep2";
            this.labelSep2.Size = new System.Drawing.Size(2, 32);
            this.labelSep2.TabIndex = 27;
            // 
            // buttonWire
            // 
            this.buttonWire.BackgroundImage = global::CircuitSimulator.Properties.Resources.Wire;
            this.buttonWire.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonWire.FlatAppearance.BorderSize = 0;
            this.buttonWire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonWire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonWire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWire.Location = new System.Drawing.Point(240, 0);
            this.buttonWire.Margin = new System.Windows.Forms.Padding(0);
            this.buttonWire.Name = "buttonWire";
            this.buttonWire.Size = new System.Drawing.Size(32, 32);
            this.buttonWire.TabIndex = 28;
            this.buttonWire.UseVisualStyleBackColor = true;
            this.buttonWire.Click += new System.EventHandler(this.buttonWire_Click);
            // 
            // labelSep3
            // 
            this.labelSep3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSep3.Location = new System.Drawing.Point(275, 0);
            this.labelSep3.Name = "labelSep3";
            this.labelSep3.Size = new System.Drawing.Size(2, 32);
            this.labelSep3.TabIndex = 12;
            // 
            // buttonBuffer
            // 
            this.buttonBuffer.BackgroundImage = global::CircuitSimulator.Properties.Resources.Buffer;
            this.buttonBuffer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBuffer.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonBuffer.FlatAppearance.BorderSize = 0;
            this.buttonBuffer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonBuffer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonBuffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuffer.Location = new System.Drawing.Point(280, 0);
            this.buttonBuffer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBuffer.Name = "buttonBuffer";
            this.buttonBuffer.Size = new System.Drawing.Size(32, 32);
            this.buttonBuffer.TabIndex = 4;
            this.buttonBuffer.UseVisualStyleBackColor = true;
            this.buttonBuffer.Click += new System.EventHandler(this.buttonBuffer_Click);
            // 
            // buttonNot
            // 
            this.buttonNot.BackgroundImage = global::CircuitSimulator.Properties.Resources.Not;
            this.buttonNot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNot.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonNot.FlatAppearance.BorderSize = 0;
            this.buttonNot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonNot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonNot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNot.Location = new System.Drawing.Point(312, 0);
            this.buttonNot.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNot.Name = "buttonNot";
            this.buttonNot.Size = new System.Drawing.Size(32, 32);
            this.buttonNot.TabIndex = 5;
            this.buttonNot.UseVisualStyleBackColor = true;
            this.buttonNot.Click += new System.EventHandler(this.buttonNot_Click);
            // 
            // buttonAnd
            // 
            this.buttonAnd.BackgroundImage = global::CircuitSimulator.Properties.Resources.And;
            this.buttonAnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAnd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonAnd.FlatAppearance.BorderSize = 0;
            this.buttonAnd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonAnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonAnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnd.Location = new System.Drawing.Point(344, 0);
            this.buttonAnd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAnd.Name = "buttonAnd";
            this.buttonAnd.Size = new System.Drawing.Size(32, 32);
            this.buttonAnd.TabIndex = 6;
            this.buttonAnd.UseVisualStyleBackColor = true;
            this.buttonAnd.Click += new System.EventHandler(this.buttonAnd_Click);
            // 
            // buttonNand
            // 
            this.buttonNand.BackgroundImage = global::CircuitSimulator.Properties.Resources.Nand;
            this.buttonNand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNand.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonNand.FlatAppearance.BorderSize = 0;
            this.buttonNand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonNand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonNand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNand.Location = new System.Drawing.Point(376, 0);
            this.buttonNand.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNand.Name = "buttonNand";
            this.buttonNand.Size = new System.Drawing.Size(32, 32);
            this.buttonNand.TabIndex = 7;
            this.buttonNand.UseVisualStyleBackColor = true;
            this.buttonNand.Click += new System.EventHandler(this.buttonNand_Click);
            // 
            // buttonOr
            // 
            this.buttonOr.BackgroundImage = global::CircuitSimulator.Properties.Resources.Or;
            this.buttonOr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOr.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonOr.FlatAppearance.BorderSize = 0;
            this.buttonOr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonOr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonOr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOr.Location = new System.Drawing.Point(408, 0);
            this.buttonOr.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOr.Name = "buttonOr";
            this.buttonOr.Size = new System.Drawing.Size(32, 32);
            this.buttonOr.TabIndex = 8;
            this.buttonOr.UseVisualStyleBackColor = true;
            this.buttonOr.Click += new System.EventHandler(this.buttonOr_Click);
            // 
            // buttonNor
            // 
            this.buttonNor.BackgroundImage = global::CircuitSimulator.Properties.Resources.Nor;
            this.buttonNor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNor.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonNor.FlatAppearance.BorderSize = 0;
            this.buttonNor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonNor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonNor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNor.Location = new System.Drawing.Point(440, 0);
            this.buttonNor.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNor.Name = "buttonNor";
            this.buttonNor.Size = new System.Drawing.Size(32, 32);
            this.buttonNor.TabIndex = 9;
            this.buttonNor.UseVisualStyleBackColor = true;
            this.buttonNor.Click += new System.EventHandler(this.buttonNor_Click);
            // 
            // buttonXor
            // 
            this.buttonXor.BackgroundImage = global::CircuitSimulator.Properties.Resources.Xor;
            this.buttonXor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonXor.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonXor.FlatAppearance.BorderSize = 0;
            this.buttonXor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonXor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonXor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXor.Location = new System.Drawing.Point(472, 0);
            this.buttonXor.Margin = new System.Windows.Forms.Padding(0);
            this.buttonXor.Name = "buttonXor";
            this.buttonXor.Size = new System.Drawing.Size(32, 32);
            this.buttonXor.TabIndex = 10;
            this.buttonXor.UseVisualStyleBackColor = true;
            this.buttonXor.Click += new System.EventHandler(this.buttonXor_Click);
            // 
            // buttonXnor
            // 
            this.buttonXnor.BackgroundImage = global::CircuitSimulator.Properties.Resources.Xnor;
            this.buttonXnor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonXnor.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonXnor.FlatAppearance.BorderSize = 0;
            this.buttonXnor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonXnor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonXnor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXnor.Location = new System.Drawing.Point(504, 0);
            this.buttonXnor.Margin = new System.Windows.Forms.Padding(0);
            this.buttonXnor.Name = "buttonXnor";
            this.buttonXnor.Size = new System.Drawing.Size(32, 32);
            this.buttonXnor.TabIndex = 11;
            this.buttonXnor.UseVisualStyleBackColor = true;
            this.buttonXnor.Click += new System.EventHandler(this.buttonXnor_Click);
            // 
            // labelSep4
            // 
            this.labelSep4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSep4.Location = new System.Drawing.Point(539, 0);
            this.labelSep4.Name = "labelSep4";
            this.labelSep4.Size = new System.Drawing.Size(2, 32);
            this.labelSep4.TabIndex = 19;
            // 
            // buttonOutputPin
            // 
            this.buttonOutputPin.BackgroundImage = global::CircuitSimulator.Properties.Resources.OutputPin;
            this.buttonOutputPin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOutputPin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonOutputPin.FlatAppearance.BorderSize = 0;
            this.buttonOutputPin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonOutputPin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonOutputPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOutputPin.Location = new System.Drawing.Point(544, 0);
            this.buttonOutputPin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOutputPin.Name = "buttonOutputPin";
            this.buttonOutputPin.Size = new System.Drawing.Size(32, 32);
            this.buttonOutputPin.TabIndex = 17;
            this.buttonOutputPin.UseVisualStyleBackColor = true;
            this.buttonOutputPin.Click += new System.EventHandler(this.buttonOutputPin_Click);
            // 
            // buttonLEDLamp
            // 
            this.buttonLEDLamp.BackgroundImage = global::CircuitSimulator.Properties.Resources.LEDLamp;
            this.buttonLEDLamp.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonLEDLamp.FlatAppearance.BorderSize = 0;
            this.buttonLEDLamp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonLEDLamp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonLEDLamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLEDLamp.Location = new System.Drawing.Point(576, 0);
            this.buttonLEDLamp.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLEDLamp.Name = "buttonLEDLamp";
            this.buttonLEDLamp.Size = new System.Drawing.Size(32, 32);
            this.buttonLEDLamp.TabIndex = 13;
            this.buttonLEDLamp.UseVisualStyleBackColor = true;
            this.buttonLEDLamp.Click += new System.EventHandler(this.buttonLED_Click);
            // 
            // buttonDigitalDisplay4
            // 
            this.buttonDigitalDisplay4.BackgroundImage = global::CircuitSimulator.Properties.Resources.DigitalDisplay4;
            this.buttonDigitalDisplay4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonDigitalDisplay4.FlatAppearance.BorderSize = 0;
            this.buttonDigitalDisplay4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonDigitalDisplay4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonDigitalDisplay4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigitalDisplay4.Location = new System.Drawing.Point(608, 0);
            this.buttonDigitalDisplay4.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDigitalDisplay4.Name = "buttonDigitalDisplay4";
            this.buttonDigitalDisplay4.Size = new System.Drawing.Size(32, 32);
            this.buttonDigitalDisplay4.TabIndex = 18;
            this.buttonDigitalDisplay4.UseVisualStyleBackColor = true;
            this.buttonDigitalDisplay4.Click += new System.EventHandler(this.buttonDigitalDisplay4_Click);
            // 
            // buttonDigitalDisplay8
            // 
            this.buttonDigitalDisplay8.BackgroundImage = global::CircuitSimulator.Properties.Resources.DigitalDisplay8;
            this.buttonDigitalDisplay8.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonDigitalDisplay8.FlatAppearance.BorderSize = 0;
            this.buttonDigitalDisplay8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonDigitalDisplay8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonDigitalDisplay8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigitalDisplay8.Location = new System.Drawing.Point(640, 0);
            this.buttonDigitalDisplay8.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDigitalDisplay8.Name = "buttonDigitalDisplay8";
            this.buttonDigitalDisplay8.Size = new System.Drawing.Size(32, 32);
            this.buttonDigitalDisplay8.TabIndex = 14;
            this.buttonDigitalDisplay8.UseVisualStyleBackColor = true;
            this.buttonDigitalDisplay8.Click += new System.EventHandler(this.buttonDigitalDisplay8_Click);
            // 
            // buttonSevenSegment
            // 
            this.buttonSevenSegment.BackgroundImage = global::CircuitSimulator.Properties.Resources.SevenSegment;
            this.buttonSevenSegment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSevenSegment.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonSevenSegment.FlatAppearance.BorderSize = 0;
            this.buttonSevenSegment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonSevenSegment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonSevenSegment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSevenSegment.Location = new System.Drawing.Point(672, 0);
            this.buttonSevenSegment.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSevenSegment.Name = "buttonSevenSegment";
            this.buttonSevenSegment.Size = new System.Drawing.Size(32, 32);
            this.buttonSevenSegment.TabIndex = 15;
            this.buttonSevenSegment.UseVisualStyleBackColor = true;
            this.buttonSevenSegment.Click += new System.EventHandler(this.buttonSevenSegment_Click);
            // 
            // buttonTrafficLight
            // 
            this.buttonTrafficLight.BackgroundImage = global::CircuitSimulator.Properties.Resources.TrafficLight;
            this.buttonTrafficLight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonTrafficLight.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonTrafficLight.FlatAppearance.BorderSize = 0;
            this.buttonTrafficLight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonTrafficLight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonTrafficLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrafficLight.Location = new System.Drawing.Point(704, 0);
            this.buttonTrafficLight.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTrafficLight.Name = "buttonTrafficLight";
            this.buttonTrafficLight.Size = new System.Drawing.Size(32, 32);
            this.buttonTrafficLight.TabIndex = 16;
            this.buttonTrafficLight.UseVisualStyleBackColor = true;
            this.buttonTrafficLight.Click += new System.EventHandler(this.buttonTrafficLight_Click);
            // 
            // labelSep5
            // 
            this.labelSep5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSep5.Location = new System.Drawing.Point(739, 0);
            this.labelSep5.Name = "labelSep5";
            this.labelSep5.Size = new System.Drawing.Size(2, 33);
            this.labelSep5.TabIndex = 25;
            // 
            // buttonIC
            // 
            this.buttonIC.BackgroundImage = global::CircuitSimulator.Properties.Resources.IC;
            this.buttonIC.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonIC.FlatAppearance.BorderSize = 0;
            this.buttonIC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonIC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.buttonIC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIC.Location = new System.Drawing.Point(744, 0);
            this.buttonIC.Margin = new System.Windows.Forms.Padding(0);
            this.buttonIC.Name = "buttonIC";
            this.buttonIC.Size = new System.Drawing.Size(32, 32);
            this.buttonIC.TabIndex = 26;
            this.buttonIC.UseVisualStyleBackColor = true;
            this.buttonIC.Click += new System.EventHandler(this.buttonIC_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 436);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(882, 482);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "CircuitSimulator - Untitled.csx";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem icToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label labelSep1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem gatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bufferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem andToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem norToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xnorToolStripMenuItem1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBuffer;
        private System.Windows.Forms.Button buttonNot;
        private System.Windows.Forms.Button buttonAnd;
        private System.Windows.Forms.Button buttonNand;
        private System.Windows.Forms.Button buttonOr;
        private System.Windows.Forms.Button buttonNor;
        private System.Windows.Forms.Button buttonXor;
        private System.Windows.Forms.Button buttonXnor;
        private System.Windows.Forms.ToolStripMenuItem outputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalDisplay8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sevenSegmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalClockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trafficToolStripMenuItem;
        private System.Windows.Forms.Button buttonLEDLamp;
        private System.Windows.Forms.Label labelSep3;
        private System.Windows.Forms.Button buttonDigitalDisplay8;
        private System.Windows.Forms.Button buttonSevenSegment;
        private System.Windows.Forms.Button buttonTrafficLight;
        private System.Windows.Forms.Button buttonOutputPin;
        private System.Windows.Forms.ToolStripMenuItem outputPinToolStripMenuItem;
        private System.Windows.Forms.Button buttonDigitalDisplay4;
        private System.Windows.Forms.ToolStripMenuItem digitalDisplay4ToolStripMenuItem;
        private System.Windows.Forms.Button buttonInputPin;
        private System.Windows.Forms.Label labelSep4;
        private System.Windows.Forms.Button buttonPowerButton;
        private System.Windows.Forms.Button buttonDigitalClock;
        private System.Windows.Forms.Button buttonSwitch;
        private System.Windows.Forms.ToolStripMenuItem inputPinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wireToolStripMenuItem;
        private System.Windows.Forms.Label labelSep5;
        private System.Windows.Forms.Button buttonIC;
        private System.Windows.Forms.Button buttonWire;
        private System.Windows.Forms.Label labelSep2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem switchToolStripMenuItem;
    }
}

