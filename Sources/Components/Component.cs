using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    public class Component
    {
        protected Connection[] fConnections;
        private ComponentController fCircuits;
        private bool[] fPreviousValues;
        private ComponentControl fControl;
        private Rectangle fBounds;
        private Point fLocation;

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
            fConnections = new Connection[inputs + outputs];
            fPreviousValues = new bool[inputs + outputs];
            for (int i = 0; i < fConnections.Length; ++i)
            {
                fConnections[i] = new Connection(this);
                fPreviousValues[i] = false;
            }
        }

        public virtual void Dispose()
        {
            if (fControl != null)
            {
                fControl.Dispose();
            }

            for (int i = 0; i < fConnections.Length; ++i)
            {
                fConnections[i] = null;
            }
            fConnections = null;
        }

        public const string nameSpace = "CircuitSimulator.Components";

        public void Show(Control parent, ContextMenuStrip menuStrip)
        {
            if (fControl == null || fControl.IsDisposed)
            {
                fControl = CreateComponentControl();
            }
            fControl.Bounds = fBounds;
            fControl.Location = fLocation;
            fControl.Parent = parent;
            fControl.ContextMenuStrip = menuStrip;
        }

        protected virtual ComponentControl CreateComponentControl()
        {
            return new ComponentControl(this);
        }

        public virtual void Setup()
        {
            //
        }

        public virtual void Execute()
        {
            if (ValuesDiffer())
            {
                InvalidateEx();
            }
        }

        public virtual void ConnectInput(int index, Connection c)
        {
            fConnections[index].Connections.Add(c);
            OnConnect();
        }

        public virtual void ConnectOutput(int index, Connection c)
        {
            fConnections[index].Connections.Add(c);
            OnConnect();
        }

        public virtual void Disconnect()
        {
            for (int c = 0; c < fConnections.Length; ++c )
            {
                foreach (Connection comp in fConnections[c].Connections)
                {
                    if (comp.Connections.Remove(fConnections[c]))
                    {
                        comp.Parent.OnDisconnect();
                    }
                }
                fConnections[c].Connections.Clear();
            }
            OnDisconnect();
        }

        public virtual bool GetValue(int index)
        {
            bool result = fConnections[index].Value;
            foreach (Connection c in fConnections[index].Connections)
            {
                result |= c.Value;
            }
            return result;
        }

        public virtual void SetValue(int index, bool value)
        {
            fConnections[index].Value = value;
        }

        public virtual void Write(System.Xml.XmlWriter writer)
        {
            //
        }

        public virtual void Read(System.Xml.XmlReader reader)
        {
            //
        }

        public virtual void OnMouseClick(MouseEventArgs e)
        {
            //
        }

        public Component GetComponent()
        {
            return this;
        }

        public Rectangle Bounds
        {
            get
            {
                return fBounds;
            }
            set
            {
                if (fControl != null)
                {
                    fControl.Bounds = value;
                }
                fBounds = value;
            }
        }

        public int Width
        {
            get
            {
                return Bounds.Width;
            }
        }

        public int Height
        {
            get
            {
                return Bounds.Height;
            }
        }

        public Point Location
        {
            get
            {
                if (fControl != null)
                {
                    fLocation = fControl.Location;
                }
                return fLocation;
            }
            set
            {
                if (fControl != null)
                {
                    fControl.Location = value;
                }
                fLocation = value;
            }
        }

        public virtual Connection[] Connections
        {
            get
            {
                return fConnections;
            }
        }

        public virtual ComponentController Circuit
        {
            set
            {
                fCircuits = value;
            }
            get
            {
                return fCircuits;
            }
        }

        public ComponentControl Control
        {
            get
            {
                return fControl;
            }
        }

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
                if (fPreviousValues[i] != value)
                {
                    dirty = true;
                    fPreviousValues[i] = value;
                }
            }
            return dirty;
        }

        private void InvalidateEx()
        {
            if (fControl != null)
            {
                fControl.InvalidateEx();
            }
        }
    }
}
