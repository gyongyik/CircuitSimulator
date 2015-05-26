using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    public class ConnectionList : List<WeakReference>
    {
        public void Add(Connection c)
        {
            Add(new WeakReference(c));
        }

        public bool Remove(Connection c)
        {
            bool result = false;
            WeakReference wr = this.Find(delegate (WeakReference r)
            {
                if (r.Target == c)
                {
                    return true;
                }
                return false;
            });
            if (wr != null)
            {
                result = this.Remove(wr);
            }
            return result;
        }

        public new ConnectionEnumerator GetEnumerator()
        {
            return new ConnectionEnumerator(base.GetEnumerator());
        }

        public class ConnectionEnumerator
        {
            private Enumerator fEnumerator;

            public ConnectionEnumerator(Enumerator e)
            {
                fEnumerator = e;
            }

            public bool MoveNext()
            {
                bool result = false;

                do
                {
                    result = fEnumerator.MoveNext();
                }
                while (result && (fEnumerator.Current.Target == null));

                return result;
            }

            public Connection Current
            {
                get
                {
                    return fEnumerator.Current.Target as Connection;
                }
            }
        }
    }

    public class Connection
    {
        bool fValue;
        public Point Location;
        public ConnectionList Connections;
        public Component Parent;

        public Connection(Component parent)
        {
            Connections = new ConnectionList();
            Parent = parent;
            fValue = false;
        }

        public virtual bool Value
        {
            get
            {
                return fValue;
            }
            set
            {
                fValue = value;
            }
        }
    }
}
