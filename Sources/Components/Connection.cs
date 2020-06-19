using System.Drawing;

namespace CircuitSimulator.Components
{
    internal class Connection
    {
        public ConnectionList Connections { get; set; }
        public Component Parent { get; set; }
        public Point Location { get; set; }
        public virtual bool Value { get; set; }

        public Connection(Component parent)
        {
            Connections = new ConnectionList();
            Parent = parent;
        }
    }
}
