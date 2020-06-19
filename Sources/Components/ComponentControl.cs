using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CircuitSimulator.Components
{
    public class ComponentControl : Control
    {
        protected Component Component { get; set; }
        protected bool IsMouseDown { get; set; }
        protected Point MouseLocation { get; set; }
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

            Component.Controller.Remove(Component);
            Component = null;
        }

        void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsMouseDown = true;
                MouseLocation = new Point(e.X, e.Y);
                MouseDownLocation = Location;
                BringToFront();
            }
        }

        void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsMouseDown = false;

                int grid = 5;
                Component.Location = new Point((Component.Location.X + (grid / 2)) / grid * grid, (Component.Location.Y + (grid / 2)) / grid * grid);
                Component.Controller.ConnectComponent(Component);

                if ((Math.Abs(Location.X - MouseDownLocation.X) < grid) && (Math.Abs(Location.Y - MouseDownLocation.Y) < grid))
                {
                    Component.OnMouseClick(e);
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                SetBounds(Location.X + e.X - MouseLocation.X, Location.Y + e.Y - MouseLocation.Y, Bounds.Width, Bounds.Height);
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

        protected void DrawConnections(Graphics g)
        {
            for (int i = 0; i < Component.Connections.Length; ++i)
            {
                Color c = Component.GetValue(i) ? Color.Tomato : Color.DimGray;
                int w = Component.Connections[i].Connections.Count > 0 ? 3 : 1;
                g.DrawEllipse(new Pen(c, w), new Rectangle(Point.Subtract(Component.Connections[i].Location, new Size(3, 3)), new Size(6, 6)));
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.DrawRectangle(new Pen(Color.DimGray, 1), 0, 0, Width - 1, Height - 1);
            DrawConnections(g);
        }
    }
}
