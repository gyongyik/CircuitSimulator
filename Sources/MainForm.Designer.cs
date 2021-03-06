﻿namespace CircuitSimulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripWire = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripInputPin = new System.Windows.Forms.ToolStripButton();
            this.toolStripPowerButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDigitalClock = new System.Windows.Forms.ToolStripButton();
            this.toolStripSwitch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBuffer = new System.Windows.Forms.ToolStripButton();
            this.toolStripNot = new System.Windows.Forms.ToolStripButton();
            this.toolStripAnd = new System.Windows.Forms.ToolStripButton();
            this.toolStripNand = new System.Windows.Forms.ToolStripButton();
            this.toolStripOr = new System.Windows.Forms.ToolStripButton();
            this.toolStripNor = new System.Windows.Forms.ToolStripButton();
            this.toolStripXor = new System.Windows.Forms.ToolStripButton();
            this.toolStripXnor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripOutPin = new System.Windows.Forms.ToolStripButton();
            this.toolStripLedLamp = new System.Windows.Forms.ToolStripButton();
            this.toolStripDigitalDisplay4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDigitalDisplay8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSevenSegment = new System.Windows.Forms.ToolStripButton();
            this.toolStripTrafficLight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAdder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSubtractor = new System.Windows.Forms.ToolStripButton();
            this.toolStripMultiplier = new System.Windows.Forms.ToolStripButton();
            this.toolStripDivider = new System.Windows.Forms.ToolStripButton();
            this.toolStripShiftLeft = new System.Windows.Forms.ToolStripButton();
            this.toolStripShiftRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripBitwiseNot = new System.Windows.Forms.ToolStripButton();
            this.toolStripBitwiseAnd = new System.Windows.Forms.ToolStripButton();
            this.toolStripBitwiseOr = new System.Windows.Forms.ToolStripButton();
            this.toolStripBitwiseXor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripCustomComponent = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 510);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.Panel1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(36, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1304, 556);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNew,
            this.toolStripOpen,
            this.toolStripSave,
            this.toolStripSaveAs,
            this.toolStripSeparator1,
            this.toolStripAbout,
            this.toolStripSeparator2,
            this.toolStripWire,
            this.toolStripSeparator3,
            this.toolStripInputPin,
            this.toolStripPowerButton,
            this.toolStripDigitalClock,
            this.toolStripSwitch,
            this.toolStripSeparator4,
            this.toolStripBuffer,
            this.toolStripNot,
            this.toolStripAnd,
            this.toolStripNand,
            this.toolStripOr,
            this.toolStripNor,
            this.toolStripXor,
            this.toolStripXnor,
            this.toolStripSeparator5,
            this.toolStripOutPin,
            this.toolStripLedLamp,
            this.toolStripDigitalDisplay4,
            this.toolStripDigitalDisplay8,
            this.toolStripSevenSegment,
            this.toolStripTrafficLight,
            this.toolStripSeparator6,
            this.toolStripAdder,
            this.toolStripSubtractor,
            this.toolStripMultiplier,
            this.toolStripDivider,
            this.toolStripShiftLeft,
            this.toolStripShiftRight,
            this.toolStripBitwiseNot,
            this.toolStripBitwiseAnd,
            this.toolStripBitwiseOr,
            this.toolStripBitwiseXor,
            this.toolStripSeparator7,
            this.toolStripCustomComponent});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1304, 39);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripNew
            // 
            this.toolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNew.Image")));
            this.toolStripNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNew.Name = "toolStripNew";
            this.toolStripNew.Size = new System.Drawing.Size(36, 36);
            this.toolStripNew.Text = "New";
            this.toolStripNew.Click += new System.EventHandler(this.ToolStripNew_Click);
            // 
            // toolStripOpen
            // 
            this.toolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpen.Image")));
            this.toolStripOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpen.Name = "toolStripOpen";
            this.toolStripOpen.Size = new System.Drawing.Size(36, 36);
            this.toolStripOpen.Text = "Open...";
            this.toolStripOpen.Click += new System.EventHandler(this.ToolStripOpen_Click);
            // 
            // toolStripSave
            // 
            this.toolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
            this.toolStripSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(36, 36);
            this.toolStripSave.Text = "Save";
            this.toolStripSave.Click += new System.EventHandler(this.ToolStripSave_Click);
            // 
            // toolStripSaveAs
            // 
            this.toolStripSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveAs.Image")));
            this.toolStripSaveAs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveAs.Name = "toolStripSaveAs";
            this.toolStripSaveAs.Size = new System.Drawing.Size(36, 36);
            this.toolStripSaveAs.Text = "Save As...";
            this.toolStripSaveAs.Click += new System.EventHandler(this.ToolStripSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripAbout
            // 
            this.toolStripAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAbout.Image")));
            this.toolStripAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAbout.Name = "toolStripAbout";
            this.toolStripAbout.Size = new System.Drawing.Size(36, 36);
            this.toolStripAbout.Text = "toolStripButton1";
            this.toolStripAbout.ToolTipText = "About...";
            this.toolStripAbout.Click += new System.EventHandler(this.ToolStripAbout_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripWire
            // 
            this.toolStripWire.Checked = true;
            this.toolStripWire.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripWire.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripWire.Image = ((System.Drawing.Image)(resources.GetObject("toolStripWire.Image")));
            this.toolStripWire.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripWire.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripWire.Name = "toolStripWire";
            this.toolStripWire.Size = new System.Drawing.Size(36, 36);
            this.toolStripWire.Text = "Wire";
            this.toolStripWire.Click += new System.EventHandler(this.ToolStripWire_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripInputPin
            // 
            this.toolStripInputPin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripInputPin.Image = ((System.Drawing.Image)(resources.GetObject("toolStripInputPin.Image")));
            this.toolStripInputPin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripInputPin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripInputPin.Name = "toolStripInputPin";
            this.toolStripInputPin.Size = new System.Drawing.Size(36, 36);
            this.toolStripInputPin.Text = "Input Pin";
            this.toolStripInputPin.Click += new System.EventHandler(this.ToolStripInputPin_Click);
            // 
            // toolStripPowerButton
            // 
            this.toolStripPowerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPowerButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPowerButton.Image")));
            this.toolStripPowerButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripPowerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPowerButton.Name = "toolStripPowerButton";
            this.toolStripPowerButton.Size = new System.Drawing.Size(36, 36);
            this.toolStripPowerButton.Text = "Power Button";
            this.toolStripPowerButton.Click += new System.EventHandler(this.ToolStripPowerButton_Click);
            // 
            // toolStripDigitalClock
            // 
            this.toolStripDigitalClock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDigitalClock.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDigitalClock.Image")));
            this.toolStripDigitalClock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDigitalClock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDigitalClock.Name = "toolStripDigitalClock";
            this.toolStripDigitalClock.Size = new System.Drawing.Size(36, 36);
            this.toolStripDigitalClock.Text = "Digital Clock";
            this.toolStripDigitalClock.Click += new System.EventHandler(this.ToolStripDigitalClock_Click);
            // 
            // toolStripSwitch
            // 
            this.toolStripSwitch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSwitch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSwitch.Image")));
            this.toolStripSwitch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSwitch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSwitch.Name = "toolStripSwitch";
            this.toolStripSwitch.Size = new System.Drawing.Size(36, 36);
            this.toolStripSwitch.Text = "Switch";
            this.toolStripSwitch.Click += new System.EventHandler(this.ToolStripSwitch_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripBuffer
            // 
            this.toolStripBuffer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBuffer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBuffer.Image")));
            this.toolStripBuffer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBuffer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBuffer.Name = "toolStripBuffer";
            this.toolStripBuffer.Size = new System.Drawing.Size(36, 36);
            this.toolStripBuffer.Text = "Buffer";
            this.toolStripBuffer.Click += new System.EventHandler(this.ToolStripBuffer_Click);
            // 
            // toolStripNot
            // 
            this.toolStripNot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNot.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNot.Image")));
            this.toolStripNot.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripNot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNot.Name = "toolStripNot";
            this.toolStripNot.Size = new System.Drawing.Size(36, 36);
            this.toolStripNot.Text = "Not";
            this.toolStripNot.Click += new System.EventHandler(this.ToolStripNot_Click);
            // 
            // toolStripAnd
            // 
            this.toolStripAnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAnd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAnd.Image")));
            this.toolStripAnd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripAnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAnd.Name = "toolStripAnd";
            this.toolStripAnd.Size = new System.Drawing.Size(36, 36);
            this.toolStripAnd.Text = "And";
            this.toolStripAnd.Click += new System.EventHandler(this.ToolStripAnd_Click);
            // 
            // toolStripNand
            // 
            this.toolStripNand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNand.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNand.Image")));
            this.toolStripNand.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripNand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNand.Name = "toolStripNand";
            this.toolStripNand.Size = new System.Drawing.Size(36, 36);
            this.toolStripNand.Text = "Nand";
            this.toolStripNand.Click += new System.EventHandler(this.ToolStripNand_Click);
            // 
            // toolStripOr
            // 
            this.toolStripOr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOr.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOr.Image")));
            this.toolStripOr.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripOr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOr.Name = "toolStripOr";
            this.toolStripOr.Size = new System.Drawing.Size(36, 36);
            this.toolStripOr.Text = "Or";
            this.toolStripOr.Click += new System.EventHandler(this.ToolStripOr_Click);
            // 
            // toolStripNor
            // 
            this.toolStripNor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNor.Image")));
            this.toolStripNor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripNor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNor.Name = "toolStripNor";
            this.toolStripNor.Size = new System.Drawing.Size(36, 36);
            this.toolStripNor.Text = "Nor";
            this.toolStripNor.Click += new System.EventHandler(this.ToolStripNor_Click);
            // 
            // toolStripXor
            // 
            this.toolStripXor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripXor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripXor.Image")));
            this.toolStripXor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripXor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripXor.Name = "toolStripXor";
            this.toolStripXor.Size = new System.Drawing.Size(36, 36);
            this.toolStripXor.Text = "Xor";
            this.toolStripXor.Click += new System.EventHandler(this.ToolStripXor_Click);
            // 
            // toolStripXnor
            // 
            this.toolStripXnor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripXnor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripXnor.Image")));
            this.toolStripXnor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripXnor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripXnor.Name = "toolStripXnor";
            this.toolStripXnor.Size = new System.Drawing.Size(36, 36);
            this.toolStripXnor.Text = "Xnor";
            this.toolStripXnor.Click += new System.EventHandler(this.ToolStripXnor_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripOutPin
            // 
            this.toolStripOutPin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOutPin.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOutPin.Image")));
            this.toolStripOutPin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripOutPin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOutPin.Name = "toolStripOutPin";
            this.toolStripOutPin.Size = new System.Drawing.Size(36, 36);
            this.toolStripOutPin.Text = "Output Pin";
            this.toolStripOutPin.Click += new System.EventHandler(this.ToolStripOutPin_Click);
            // 
            // toolStripLedLamp
            // 
            this.toolStripLedLamp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLedLamp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLedLamp.Image")));
            this.toolStripLedLamp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLedLamp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLedLamp.Name = "toolStripLedLamp";
            this.toolStripLedLamp.Size = new System.Drawing.Size(36, 36);
            this.toolStripLedLamp.Text = "LED Lamp";
            this.toolStripLedLamp.Click += new System.EventHandler(this.ToolStripLedLamp_Click);
            // 
            // toolStripDigitalDisplay4
            // 
            this.toolStripDigitalDisplay4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDigitalDisplay4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDigitalDisplay4.Image")));
            this.toolStripDigitalDisplay4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDigitalDisplay4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDigitalDisplay4.Name = "toolStripDigitalDisplay4";
            this.toolStripDigitalDisplay4.Size = new System.Drawing.Size(36, 36);
            this.toolStripDigitalDisplay4.Text = "4 Bit Display";
            this.toolStripDigitalDisplay4.Click += new System.EventHandler(this.ToolStripDigitalDisplay4_Click);
            // 
            // toolStripDigitalDisplay8
            // 
            this.toolStripDigitalDisplay8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDigitalDisplay8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDigitalDisplay8.Image")));
            this.toolStripDigitalDisplay8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDigitalDisplay8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDigitalDisplay8.Name = "toolStripDigitalDisplay8";
            this.toolStripDigitalDisplay8.Size = new System.Drawing.Size(36, 36);
            this.toolStripDigitalDisplay8.Text = "8 Bit Display";
            this.toolStripDigitalDisplay8.Click += new System.EventHandler(this.ToolStripDigitalDisplay8_Click);
            // 
            // toolStripSevenSegment
            // 
            this.toolStripSevenSegment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSevenSegment.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSevenSegment.Image")));
            this.toolStripSevenSegment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSevenSegment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSevenSegment.Name = "toolStripSevenSegment";
            this.toolStripSevenSegment.Size = new System.Drawing.Size(36, 36);
            this.toolStripSevenSegment.Text = "Seven Segment";
            this.toolStripSevenSegment.Click += new System.EventHandler(this.ToolStripSevenSegment_Click);
            // 
            // toolStripTrafficLight
            // 
            this.toolStripTrafficLight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripTrafficLight.Image = ((System.Drawing.Image)(resources.GetObject("toolStripTrafficLight.Image")));
            this.toolStripTrafficLight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripTrafficLight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripTrafficLight.Name = "toolStripTrafficLight";
            this.toolStripTrafficLight.Size = new System.Drawing.Size(36, 36);
            this.toolStripTrafficLight.Text = "Traffic Light";
            this.toolStripTrafficLight.Click += new System.EventHandler(this.ToolStripTrafficLight_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripAdder
            // 
            this.toolStripAdder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAdder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAdder.Image")));
            this.toolStripAdder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripAdder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAdder.Name = "toolStripAdder";
            this.toolStripAdder.Size = new System.Drawing.Size(36, 36);
            this.toolStripAdder.Text = "Adder";
            this.toolStripAdder.ToolTipText = "Adder";
            this.toolStripAdder.Click += new System.EventHandler(this.ToolStripAdder_Click);
            // 
            // toolStripSubtractor
            // 
            this.toolStripSubtractor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSubtractor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSubtractor.Image")));
            this.toolStripSubtractor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSubtractor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSubtractor.Name = "toolStripSubtractor";
            this.toolStripSubtractor.Size = new System.Drawing.Size(36, 36);
            this.toolStripSubtractor.Text = "Subtractor";
            this.toolStripSubtractor.ToolTipText = "Subtractor";
            this.toolStripSubtractor.Click += new System.EventHandler(this.ToolStripSubtractor_Click);
            // 
            // toolStripMultiplier
            // 
            this.toolStripMultiplier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMultiplier.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMultiplier.Image")));
            this.toolStripMultiplier.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMultiplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMultiplier.Name = "toolStripMultiplier";
            this.toolStripMultiplier.Size = new System.Drawing.Size(36, 36);
            this.toolStripMultiplier.Text = "Multiplier";
            this.toolStripMultiplier.ToolTipText = "Multiplier";
            this.toolStripMultiplier.Click += new System.EventHandler(this.ToolStripMultiplier_Click);
            // 
            // toolStripDivider
            // 
            this.toolStripDivider.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDivider.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDivider.Image")));
            this.toolStripDivider.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDivider.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDivider.Name = "toolStripDivider";
            this.toolStripDivider.Size = new System.Drawing.Size(36, 36);
            this.toolStripDivider.Text = "Divider";
            this.toolStripDivider.Click += new System.EventHandler(this.ToolStripDivider_Click);
            // 
            // toolStripShiftLeft
            // 
            this.toolStripShiftLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripShiftLeft.Image = ((System.Drawing.Image)(resources.GetObject("toolStripShiftLeft.Image")));
            this.toolStripShiftLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripShiftLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripShiftLeft.Name = "toolStripShiftLeft";
            this.toolStripShiftLeft.Size = new System.Drawing.Size(36, 36);
            this.toolStripShiftLeft.Text = "Left Shift";
            this.toolStripShiftLeft.Click += new System.EventHandler(this.ToolStripShiftLeft_Click);
            // 
            // toolStripShiftRight
            // 
            this.toolStripShiftRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripShiftRight.Image = ((System.Drawing.Image)(resources.GetObject("toolStripShiftRight.Image")));
            this.toolStripShiftRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripShiftRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripShiftRight.Name = "toolStripShiftRight";
            this.toolStripShiftRight.Size = new System.Drawing.Size(36, 36);
            this.toolStripShiftRight.Text = "Right Shift";
            this.toolStripShiftRight.Click += new System.EventHandler(this.ToolStripShiftRight_Click);
            // 
            // toolStripBitwiseNot
            // 
            this.toolStripBitwiseNot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBitwiseNot.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBitwiseNot.Image")));
            this.toolStripBitwiseNot.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBitwiseNot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBitwiseNot.Name = "toolStripBitwiseNot";
            this.toolStripBitwiseNot.Size = new System.Drawing.Size(36, 36);
            this.toolStripBitwiseNot.Text = "Bitwise Not";
            this.toolStripBitwiseNot.Click += new System.EventHandler(this.ToolStripBitwiseNot_Click);
            // 
            // toolStripBitwiseAnd
            // 
            this.toolStripBitwiseAnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBitwiseAnd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBitwiseAnd.Image")));
            this.toolStripBitwiseAnd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBitwiseAnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBitwiseAnd.Name = "toolStripBitwiseAnd";
            this.toolStripBitwiseAnd.Size = new System.Drawing.Size(36, 36);
            this.toolStripBitwiseAnd.Text = "Bitwise And";
            this.toolStripBitwiseAnd.Click += new System.EventHandler(this.ToolStripBitwiseAnd_Click);
            // 
            // toolStripBitwiseOr
            // 
            this.toolStripBitwiseOr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBitwiseOr.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBitwiseOr.Image")));
            this.toolStripBitwiseOr.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBitwiseOr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBitwiseOr.Name = "toolStripBitwiseOr";
            this.toolStripBitwiseOr.Size = new System.Drawing.Size(36, 36);
            this.toolStripBitwiseOr.Text = "Bitwise Or";
            this.toolStripBitwiseOr.Click += new System.EventHandler(this.ToolStripBitwiseOr_Click);
            // 
            // toolStripBitwiseXor
            // 
            this.toolStripBitwiseXor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBitwiseXor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBitwiseXor.Image")));
            this.toolStripBitwiseXor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBitwiseXor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBitwiseXor.Name = "toolStripBitwiseXor";
            this.toolStripBitwiseXor.Size = new System.Drawing.Size(36, 36);
            this.toolStripBitwiseXor.Text = "Bitwise Xor";
            this.toolStripBitwiseXor.Click += new System.EventHandler(this.ToolStripBitwiseXor_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripCustomComponent
            // 
            this.toolStripCustomComponent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCustomComponent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCustomComponent.Image")));
            this.toolStripCustomComponent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCustomComponent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCustomComponent.Name = "toolStripCustomComponent";
            this.toolStripCustomComponent.Size = new System.Drawing.Size(36, 36);
            this.toolStripCustomComponent.Text = "Custom Component...";
            this.toolStripCustomComponent.Click += new System.EventHandler(this.ToolStripCustomCircuit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1304, 556);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "CircuitSimulator - Untitled.csx";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.ToolStripButton toolStripLedLamp;
        private System.Windows.Forms.ToolStripButton toolStripDigitalDisplay4;
        private System.Windows.Forms.ToolStripButton toolStripDigitalDisplay8;
        private System.Windows.Forms.ToolStripButton toolStripSevenSegment;
        private System.Windows.Forms.ToolStripButton toolStripTrafficLight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripCustomComponent;
        private System.Windows.Forms.ToolStripButton toolStripSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripAbout;
        private System.Windows.Forms.ToolStripButton toolStripAdder;
        private System.Windows.Forms.ToolStripButton toolStripSubtractor;
        private System.Windows.Forms.ToolStripButton toolStripMultiplier;
        private System.Windows.Forms.ToolStripButton toolStripDivider;
        private System.Windows.Forms.ToolStripButton toolStripShiftLeft;
        private System.Windows.Forms.ToolStripButton toolStripShiftRight;
        private System.Windows.Forms.ToolStripButton toolStripBitwiseNot;
        private System.Windows.Forms.ToolStripButton toolStripBitwiseAnd;
        private System.Windows.Forms.ToolStripButton toolStripBitwiseOr;
        private System.Windows.Forms.ToolStripButton toolStripBitwiseXor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}
