using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace CircuitSimulator.Components
{
    public class ComponentControl : Control
    {
        protected Component fComponent;
        protected bool fMouseDown;
        protected int fMouseX;
        protected int fMouseY;
        protected Point fMouseDownLocation;

        public ComponentControl(Component component)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            DoubleBuffered = false;

            fComponent = component;
            fMouseDown = false;

            MouseDown += OnMouseDown;
            MouseUp += OnMouseUp;
        }

        public void DeleteComponent()
        {
            if (Parent != null)
            {
                if (Parent.Controls.Contains(this))
                {
                    Parent.Controls.Remove(this);
                }
            }
            Dispose();
            Parent = null;

            fComponent.Circuit.Remove(fComponent);
            fComponent = null;
        }

        void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                fMouseDown = true;
                fMouseX = e.X;
                fMouseY = e.Y;
                fMouseDownLocation = Location;
                BringToFront();
            }
        }

        void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                fMouseDown = false;

                // Snap
                int gridSize = 5;
                fComponent.Location = new Point((fComponent.Location.X + (gridSize / 2)) / gridSize * gridSize, (fComponent.Location.Y + (gridSize / 2)) / gridSize * gridSize);

                // Reconnect
                fComponent.Circuit.ConnectComponent(fComponent);

                if ((Math.Abs(Location.X - fMouseDownLocation.X) < gridSize) && (Math.Abs(Location.Y - fMouseDownLocation.Y) < gridSize))
                {
                    fComponent.OnMouseClick(e);
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (fMouseDown)
            {
                SetBounds(Location.X + e.X - fMouseX, Location.Y + e.Y - fMouseY, Bounds.Width, Bounds.Height);
                base.OnMouseMove(e);
                InvalidateEx();
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; //WS_EX_TRANSPARENT
                return cp;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // Not allowed
        }

        public void InvalidateEx()
        {
            if (Parent == null)
                return;

            Rectangle rc = new Rectangle(this.Location, this.Size);
            Parent.Invalidate(rc, true);
        }

        public virtual void ShowContextMenu(ContextMenuStrip menu, CancelEventArgs e)
        {
            // Individual context menu
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            for (int i = 0; i < fComponent.GetComponent().Connections.Length; ++i)
            {
                Color c = fComponent.GetComponent().GetValue(i) ? Color.Red : Color.Black;
                int w = fComponent.GetComponent().Connections[i].Connections.Count > 0 ? 3 : 1;
                Pen pen = new Pen(c, w);

                g.DrawEllipse(pen, new Rectangle(Point.Subtract(fComponent.GetComponent().Connections[i].Location, new Size(2, 2)), new Size(4, 4)));
            }

            g.DrawRectangle(new Pen(Color.Black, 1), 0, 0, Width - 1, Height - 1);
        }
    }
}
