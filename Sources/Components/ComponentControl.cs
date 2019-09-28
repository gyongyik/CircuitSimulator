using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    public class ComponentControl : Control
    {
        protected Component Component { get; set; }
        protected bool IsMouseDown { get; set; }
        protected int MouseX { get; set; }
        protected int MouseY { get; set; }
        protected Point MouseDownLocation { get; set; }

        public ComponentControl(Component component)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            DoubleBuffered = false;

            Component = component;
            IsMouseDown = false;

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

            Component.Circuit.Remove(Component);
            Component = null;
        }

        void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsMouseDown = true;
                MouseX = e.X;
                MouseY = e.Y;
                MouseDownLocation = Location;
                BringToFront();
            }
        }

        void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsMouseDown = false;

                // Snap
                int gridSize = 5;
                Component.Location = new Point((Component.Location.X + (gridSize / 2)) / gridSize * gridSize, (Component.Location.Y + (gridSize / 2)) / gridSize * gridSize);

                // Reconnect
                Component.Circuit.ConnectComponent(Component);

                if ((Math.Abs(Location.X - MouseDownLocation.X) < gridSize) && (Math.Abs(Location.Y - MouseDownLocation.Y) < gridSize))
                {
                    Component.OnMouseClick(e);
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                SetBounds(Location.X + e.X - MouseX, Location.Y + e.Y - MouseY, Bounds.Width, Bounds.Height);
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

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Not allowed
        }

        public void InvalidateEx()
        {
            if (Parent == null)
                return;

            Rectangle rect = new Rectangle(this.Location, this.Size);
            Parent.Invalidate(rect, true);
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

            for (int i = 0; i < Component.GetComponent().Connections.Length; ++i)
            {
                Color c = Component.GetComponent().GetValue(i) ? Color.Red : Color.Black;
                int w = Component.GetComponent().Connections[i].Connections.Count > 0 ? 3 : 1;
                Pen pen = new Pen(c, w);

                g.DrawEllipse(pen, new Rectangle(Point.Subtract(Component.GetComponent().Connections[i].Location, new Size(2, 2)), new Size(4, 4)));
            }

            g.DrawRectangle(new Pen(Color.Black, 1), 0, 0, Width - 1, Height - 1);
        }
    }
}
