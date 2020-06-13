using System.Drawing;
using System.Windows.Forms;

namespace CircuitSimulator.Components
{
    public class Component
    {
        private bool[] _previousValues;
        private Rectangle _bounds;
        private Point _location;

        public Component()
        {
            Reinitalize(0, 0);
        }

        public Component(int inputs, int outputs)
        {
            Reinitalize(inputs, outputs);
        }

        public void Reinitalize(int inputs, int outputs)
        {
            Connections = new Connection[inputs + outputs];
            _previousValues = new bool[inputs + outputs];
            for (int i = 0; i < Connections.Length; ++i)
            {
                Connections[i] = new Connection(this);
                _previousValues[i] = false;
            }
        }

        public virtual void Dispose()
        {
            if (Control != null)
            {
                Control.Dispose();
            }

            for (int i = 0; i < Connections.Length; ++i)
            {
                Connections[i] = null;
            }
            Connections = null;
        }

        public void Show(Control parent, ContextMenuStrip menuStrip)
        {
            if (Control == null || Control.IsDisposed)
            {
                Control = CreateComponentControl();
            }
            Control.Bounds = _bounds;
            Control.Location = _location;
            Control.Parent = parent;
            Control.ContextMenuStrip = menuStrip;
        }

        protected virtual ComponentControl CreateComponentControl()
        {
            return new ComponentControl(this);
        }

        public virtual void Setup()
        {
        }

        public virtual void Execute()
        {
            if (ValuesDiffer())
            {
                InvalidateEx();
            }
        }

        internal virtual void ConnectInput(int index, Connection c)
        {
            Connections[index].Connections.Add(c);
            OnConnect();
        }

        internal virtual void ConnectOutput(int index, Connection c)
        {
            Connections[index].Connections.Add(c);
            OnConnect();
        }

        public virtual void Disconnect()
        {
            for (int i = 0; i < Connections.Length; ++i )
            {
                foreach (Connection c in Connections[i].Connections)
                {
                    if (c.Connections.Remove(Connections[i]))
                    {
                        c.Parent.OnDisconnect();
                    }
                }
                Connections[i].Connections.Clear();
            }
            OnDisconnect();
        }

        public virtual bool GetValue(int index)
        {
            bool result = Connections[index].Value;
            foreach (Connection c in Connections[index].Connections)
            {
                result |= c.Value;
            }
            return result;
        }

        public virtual void SetValue(int index, bool value)
        {
            Connections[index].Value = value;
        }

        public virtual void Write(System.Xml.XmlWriter writer)
        {
        }

        public virtual void Read(System.Xml.XmlReader reader)
        {
        }

        public virtual void OnMouseClick(MouseEventArgs e)
        {
        }

        public Rectangle Bounds
        {
            get => _bounds;
            set
            {
                if (Control != null)
                {
                    Control.Bounds = value;
                }
                _bounds = value;
            }
        }

        public int Width => Bounds.Width;

        public int Height => Bounds.Height;

        public Point Location
        {
            get
            {
                if (Control != null)
                {
                    _location = Control.Location;
                }
                return _location;
            }
            set
            {
                if (Control != null)
                {
                    Control.Location = value;
                }
                _location = value;
            }
        }

        internal virtual Connection[] Connections { get; private set; }

        internal virtual ComponentController Circuit { get; set; }

        public ComponentControl Control { get; private set; }

        protected virtual void OnDisconnect()
        {
            InvalidateEx();
        }

        protected virtual void OnConnect()
        {
            InvalidateEx();
        }

        private bool ValuesDiffer()
        {
            bool dirty = false;
            for (int i = 0; i < Connections.Length; ++i )
            {
                bool value = GetValue(i);
                if (_previousValues[i] != value)
                {
                    dirty = true;
                    _previousValues[i] = value;
                }
            }
            return dirty;
        }

        private void InvalidateEx()
        {
            if (Control != null)
            {
                Control.InvalidateEx();
            }
        }
    }
}
