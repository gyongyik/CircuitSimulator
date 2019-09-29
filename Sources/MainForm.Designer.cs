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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripInputPin = new System.Windows.Forms.ToolStripButton();
            this.toolStripPowerButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDigitalClock = new System.Windows.Forms.ToolStripButton();
            this.toolStripSwitch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripWire = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBuffer = new System.Windows.Forms.ToolStripButton();
            this.toolStripNot = new System.Windows.Forms.ToolStripButton();
            this.toolStripAnd = new System.Windows.Forms.ToolStripButton();
            this.toolStripNand = new System.Windows.Forms.ToolStripButton();
            this.toolStripOr = new System.Windows.Forms.ToolStripButton();
            this.toolStripNor = new System.Windows.Forms.ToolStripButton();
            this.toolStripXor = new System.Windows.Forms.ToolStripButton();
            this.toolStripXnor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripOutPin = new System.Windows.Forms.ToolStripButton();
            this.toolStripLEDLamp = new System.Windows.Forms.ToolStripButton();
            this.toolStripDigitalDisplay4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDigitalDisplay8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSevenSegment = new System.Windows.Forms.ToolStripButton();
            this.toolStripTrafficLight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripIC = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(905, 401);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.menuStrip1.Size = new System.Drawing.Size(905, 24);
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
            this.ledToolStripMenuItem.Click += new System.EventHandler(this.ledLampToolStripMenuItem_Click);
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
            this.digitalDisplay8ToolStripMenuItem.Click += new System.EventHandler(this.digitalDisplay8ToolStripMenuItem_Click);
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
            this.statusStrip1.Size = new System.Drawing.Size(905, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(905, 436);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNew,
            this.toolStripOpen,
            this.toolStripSave,
            this.toolStripSeparator1,
            this.toolStripInputPin,
            this.toolStripPowerButton,
            this.toolStripDigitalClock,
            this.toolStripSwitch,
            this.toolStripSeparator2,
            this.toolStripWire,
            this.toolStripSeparator3,
            this.toolStripBuffer,
            this.toolStripNot,
            this.toolStripAnd,
            this.toolStripNand,
            this.toolStripOr,
            this.toolStripNor,
            this.toolStripXor,
            this.toolStripXnor,
            this.toolStripSeparator4,
            this.toolStripOutPin,
            this.toolStripLEDLamp,
            this.toolStripDigitalDisplay4,
            this.toolStripDigitalDisplay8,
            this.toolStripSevenSegment,
            this.toolStripTrafficLight,
            this.toolStripSeparator5,
            this.toolStripIC});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(905, 39);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripNew
            // 
            this.toolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNew.Image = global::CircuitSimulator.Properties.Resources.New;
            this.toolStripNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNew.Name = "toolStripNew";
            this.toolStripNew.Size = new System.Drawing.Size(36, 36);
            this.toolStripNew.Text = "New";
            this.toolStripNew.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripOpen
            // 
            this.toolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpen.Image = global::CircuitSimulator.Properties.Resources.Open;
            this.toolStripOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpen.Name = "toolStripOpen";
            this.toolStripOpen.Size = new System.Drawing.Size(36, 36);
            this.toolStripOpen.Text = "Open...";
            this.toolStripOpen.Click += new System.EventHandler(this.toolStripOpen_Click);
            // 
            // toolStripSave
            // 
            this.toolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSave.Image = global::CircuitSimulator.Properties.Resources.Save;
            this.toolStripSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(36, 36);
            this.toolStripSave.Text = "Save";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripInputPin
            // 
            this.toolStripInputPin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripInputPin.Image = global::CircuitSimulator.Properties.Resources.InputPin;
            this.toolStripInputPin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripInputPin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripInputPin.Name = "toolStripInputPin";
            this.toolStripInputPin.Size = new System.Drawing.Size(36, 36);
            this.toolStripInputPin.Text = "Input Pin";
            this.toolStripInputPin.Click += new System.EventHandler(this.toolStripInputPin_Click);
            // 
            // toolStripPowerButton
            // 
            this.toolStripPowerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPowerButton.Image = global::CircuitSimulator.Properties.Resources.PowerButton;
            this.toolStripPowerButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripPowerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPowerButton.Name = "toolStripPowerButton";
            this.toolStripPowerButton.Size = new System.Drawing.Size(36, 36);
            this.toolStripPowerButton.Text = "Power Button";
            this.toolStripPowerButton.Click += new System.EventHandler(this.toolStripPowerButton_Click);
            // 
            // toolStripDigitalClock
            // 
            this.toolStripDigitalClock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDigitalClock.Image = global::CircuitSimulator.Properties.Resources.DigitalClock;
            this.toolStripDigitalClock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDigitalClock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDigitalClock.Name = "toolStripDigitalClock";
            this.toolStripDigitalClock.Size = new System.Drawing.Size(36, 36);
            this.toolStripDigitalClock.Text = "Digital Clock";
            this.toolStripDigitalClock.Click += new System.EventHandler(this.toolStripDigitalClock_Click);
            // 
            // toolStripSwitch
            // 
            this.toolStripSwitch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSwitch.Image = global::CircuitSimulator.Properties.Resources.Switch;
            this.toolStripSwitch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSwitch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSwitch.Name = "toolStripSwitch";
            this.toolStripSwitch.Size = new System.Drawing.Size(36, 36);
            this.toolStripSwitch.Text = "Switch";
            this.toolStripSwitch.Click += new System.EventHandler(this.toolStripSwitch_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripWire
            // 
            this.toolStripWire.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripWire.Image = global::CircuitSimulator.Properties.Resources.Wire;
            this.toolStripWire.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripWire.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripWire.Name = "toolStripWire";
            this.toolStripWire.Size = new System.Drawing.Size(36, 36);
            this.toolStripWire.Text = "Wire";
            this.toolStripWire.Click += new System.EventHandler(this.toolStripWire_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripBuffer
            // 
            this.toolStripBuffer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBuffer.Image = global::CircuitSimulator.Properties.Resources.Buffer;
            this.toolStripBuffer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBuffer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBuffer.Name = "toolStripBuffer";
            this.toolStripBuffer.Size = new System.Drawing.Size(36, 36);
            this.toolStripBuffer.Text = "Buffer";
            this.toolStripBuffer.Click += new System.EventHandler(this.toolStripBuffer_Click);
            // 
            // toolStripNot
            // 
            this.toolStripNot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNot.Image = global::CircuitSimulator.Properties.Resources.Not;
            this.toolStripNot.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripNot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNot.Name = "toolStripNot";
            this.toolStripNot.Size = new System.Drawing.Size(36, 36);
            this.toolStripNot.Text = "Not";
            this.toolStripNot.Click += new System.EventHandler(this.toolStripNot_Click);
            // 
            // toolStripAnd
            // 
            this.toolStripAnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAnd.Image = global::CircuitSimulator.Properties.Resources.And;
            this.toolStripAnd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripAnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAnd.Name = "toolStripAnd";
            this.toolStripAnd.Size = new System.Drawing.Size(36, 36);
            this.toolStripAnd.Text = "And";
            this.toolStripAnd.Click += new System.EventHandler(this.toolStripAnd_Click);
            // 
            // toolStripNand
            // 
            this.toolStripNand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNand.Image = global::CircuitSimulator.Properties.Resources.Nand;
            this.toolStripNand.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripNand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNand.Name = "toolStripNand";
            this.toolStripNand.Size = new System.Drawing.Size(36, 36);
            this.toolStripNand.Text = "Nand";
            this.toolStripNand.Click += new System.EventHandler(this.toolStripNand_Click);
            // 
            // toolStripOr
            // 
            this.toolStripOr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOr.Image = global::CircuitSimulator.Properties.Resources.Or;
            this.toolStripOr.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripOr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOr.Name = "toolStripOr";
            this.toolStripOr.Size = new System.Drawing.Size(36, 36);
            this.toolStripOr.Text = "Or";
            this.toolStripOr.Click += new System.EventHandler(this.toolStripOr_Click);
            // 
            // toolStripNor
            // 
            this.toolStripNor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNor.Image = global::CircuitSimulator.Properties.Resources.Nor;
            this.toolStripNor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripNor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNor.Name = "toolStripNor";
            this.toolStripNor.Size = new System.Drawing.Size(36, 36);
            this.toolStripNor.Text = "Nor";
            this.toolStripNor.Click += new System.EventHandler(this.toolStripNor_Click);
            // 
            // toolStripXor
            // 
            this.toolStripXor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripXor.Image = global::CircuitSimulator.Properties.Resources.Xor;
            this.toolStripXor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripXor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripXor.Name = "toolStripXor";
            this.toolStripXor.Size = new System.Drawing.Size(36, 36);
            this.toolStripXor.Text = "Xor";
            this.toolStripXor.Click += new System.EventHandler(this.toolStripXor_Click);
            // 
            // toolStripXnor
            // 
            this.toolStripXnor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripXnor.Image = global::CircuitSimulator.Properties.Resources.Xnor;
            this.toolStripXnor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripXnor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripXnor.Name = "toolStripXnor";
            this.toolStripXnor.Size = new System.Drawing.Size(36, 36);
            this.toolStripXnor.Text = "Xnor";
            this.toolStripXnor.Click += new System.EventHandler(this.toolStripXnor_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripOutPin
            // 
            this.toolStripOutPin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOutPin.Image = global::CircuitSimulator.Properties.Resources.OutputPin;
            this.toolStripOutPin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripOutPin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOutPin.Name = "toolStripOutPin";
            this.toolStripOutPin.Size = new System.Drawing.Size(36, 36);
            this.toolStripOutPin.Text = "Output Pin";
            this.toolStripOutPin.Click += new System.EventHandler(this.toolStripOutPin_Click);
            // 
            // toolStripLEDLamp
            // 
            this.toolStripLEDLamp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLEDLamp.Image = global::CircuitSimulator.Properties.Resources.LEDLamp;
            this.toolStripLEDLamp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLEDLamp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLEDLamp.Name = "toolStripLEDLamp";
            this.toolStripLEDLamp.Size = new System.Drawing.Size(36, 36);
            this.toolStripLEDLamp.Text = "LED Lamp";
            this.toolStripLEDLamp.Click += new System.EventHandler(this.toolStripLEDLamp_Click);
            // 
            // toolStripDigitalDisplay4
            // 
            this.toolStripDigitalDisplay4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDigitalDisplay4.Image = global::CircuitSimulator.Properties.Resources.DigitalDisplay4;
            this.toolStripDigitalDisplay4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDigitalDisplay4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDigitalDisplay4.Name = "toolStripDigitalDisplay4";
            this.toolStripDigitalDisplay4.Size = new System.Drawing.Size(36, 36);
            this.toolStripDigitalDisplay4.Text = "4 Bit Display";
            this.toolStripDigitalDisplay4.Click += new System.EventHandler(this.toolStripDigitalDisplay4_Click);
            // 
            // toolStripDigitalDisplay8
            // 
            this.toolStripDigitalDisplay8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDigitalDisplay8.Image = global::CircuitSimulator.Properties.Resources.DigitalDisplay8;
            this.toolStripDigitalDisplay8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDigitalDisplay8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDigitalDisplay8.Name = "toolStripDigitalDisplay8";
            this.toolStripDigitalDisplay8.Size = new System.Drawing.Size(36, 36);
            this.toolStripDigitalDisplay8.Text = "8 Bit Display";
            this.toolStripDigitalDisplay8.Click += new System.EventHandler(this.toolStripDigitalDisplay8_Click);
            // 
            // toolStripSevenSegment
            // 
            this.toolStripSevenSegment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSevenSegment.Image = global::CircuitSimulator.Properties.Resources.SevenSegment;
            this.toolStripSevenSegment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSevenSegment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSevenSegment.Name = "toolStripSevenSegment";
            this.toolStripSevenSegment.Size = new System.Drawing.Size(36, 36);
            this.toolStripSevenSegment.Text = "Seven Segment";
            this.toolStripSevenSegment.Click += new System.EventHandler(this.toolStripSevenSegment_Click);
            // 
            // toolStripTrafficLight
            // 
            this.toolStripTrafficLight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripTrafficLight.Image = global::CircuitSimulator.Properties.Resources.TrafficLight;
            this.toolStripTrafficLight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripTrafficLight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripTrafficLight.Name = "toolStripTrafficLight";
            this.toolStripTrafficLight.Size = new System.Drawing.Size(36, 36);
            this.toolStripTrafficLight.Text = "Traffic Light";
            this.toolStripTrafficLight.Click += new System.EventHandler(this.toolStripTrafficLight_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripIC
            // 
            this.toolStripIC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripIC.Image = global::CircuitSimulator.Properties.Resources.IC;
            this.toolStripIC.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripIC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripIC.Name = "toolStripIC";
            this.toolStripIC.Size = new System.Drawing.Size(36, 36);
            this.toolStripIC.Text = "IC...";
            this.toolStripIC.Click += new System.EventHandler(this.toolStripIC_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(905, 482);
            this.Controls.Add(this.toolStrip1);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.ToolStripMenuItem outputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalDisplay8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sevenSegmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalClockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trafficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputPinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalDisplay4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputPinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wireToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem switchToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripNew;
        private System.Windows.Forms.ToolStripButton toolStripOpen;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripInputPin;
        private System.Windows.Forms.ToolStripButton toolStripPowerButton;
        private System.Windows.Forms.ToolStripButton toolStripDigitalClock;
        private System.Windows.Forms.ToolStripButton toolStripSwitch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripWire;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripBuffer;
        private System.Windows.Forms.ToolStripButton toolStripNot;
        private System.Windows.Forms.ToolStripButton toolStripAnd;
        private System.Windows.Forms.ToolStripButton toolStripNand;
        private System.Windows.Forms.ToolStripButton toolStripOr;
        private System.Windows.Forms.ToolStripButton toolStripNor;
        private System.Windows.Forms.ToolStripButton toolStripXor;
        private System.Windows.Forms.ToolStripButton toolStripXnor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripOutPin;
        private System.Windows.Forms.ToolStripButton toolStripLEDLamp;
        private System.Windows.Forms.ToolStripButton toolStripDigitalDisplay4;
        private System.Windows.Forms.ToolStripButton toolStripDigitalDisplay8;
        private System.Windows.Forms.ToolStripButton toolStripSevenSegment;
        private System.Windows.Forms.ToolStripButton toolStripTrafficLight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripIC;
    }
}

