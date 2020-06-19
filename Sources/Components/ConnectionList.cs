using System;
using System.Collections.Generic;

namespace CircuitSimulator.Components
{
    internal class ConnectionList : List<WeakReference>
    {
        public void Add(Connection connection)
        {
            Add(new WeakReference(connection));
        }

        public bool Remove(Connection conncection)
        {
            bool result = false;
            WeakReference weakReference = Find(delegate (WeakReference r)
            {
                if (r.Target == conncection)
                {
                    return true;
                }
                return false;
            });
            if (weakReference != null)
            {
                result = Remove(weakReference);
            }
            return result;
        }

        public new ConnectionEnumerator GetEnumerator()
        {
            return new ConnectionEnumerator(base.GetEnumerator());
        }

        public class ConnectionEnumerator
        {
            private Enumerator _enumerator;

            public ConnectionEnumerator(Enumerator e)
            {
                _enumerator = e;
            }

            public bool MoveNext()
            {
                bool result;

                do
                {
                    result = _enumerator.MoveNext();
                }
                while (result && (_enumerator.Current.Target == null));

                return result;
            }

            public Connection Current => _enumerator.Current.Target as Connection;
        }
    }
}
