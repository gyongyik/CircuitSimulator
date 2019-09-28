using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml;

namespace CircuitSimulator.Components
{
    internal class ComponentController
    {
        private const string nameSpace = "CircuitSimulator.Components";

        public ComponentController()
        {
            Components = new List<Component>();
        }

        public void Clear()
        {
            foreach (Component c in Components)
            {
                c.Dispose();
            }
            Components.Clear();
        }

        public void Add(Component component)
        {
            component.Circuit = this;
            Components.Add(component);
        }

        public bool Remove(Component component)
        {
            component.Disconnect();
            return Components.Remove(component);
        }

        public void ConnectComponent(Component component)
        {
            component.Disconnect();

            foreach (Component c in Components)
            {
                if (c != component)
                {
                    for (int i = 0; i < c.Connections.Length; ++i)
                    {
                        Point p1 = c.Location;
                        p1.Offset(c.Connections[i].Location);
                        for (int j = 0; j < component.Connections.Length; ++j)
                        {
                            Point p2 = component.Location;
                            p2.Offset(component.Connections[j].Location);

                            Point diff = Point.Subtract(p1, new Size(p2));
                            if ((Math.Abs(diff.X) < 5) && (Math.Abs(diff.Y) < 5))
                            {
                                c.ConnectOutput(i, component.Connections[j]);
                                component.ConnectInput(j, c.Connections[i]);
                            }
                        }
                    }
                }
            }
        }

        public void Run()
        {
            foreach (Component c in Components)
            {
                c.Setup();
            }

            foreach (Component c in Components)
            {
                c.Execute();
            }
        }

        public void Write(XmlWriter writer)
        {
            writer.WriteStartElement("circuit");
            foreach (Component c in Components)
            {
                writer.WriteStartElement("component");
                string type = c.GetType().ToString();
                writer.WriteAttributeString("type", type.Substring(nameSpace.Length + 1));
                writer.WriteAttributeString("x", c.Location.X.ToString());
                writer.WriteAttributeString("y", c.Location.Y.ToString());
                c.Write(writer);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        public void Write(System.IO.Stream stream)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter writer = XmlWriter.Create(stream, settings);
            writer.WriteStartDocument();
            Write(writer);
            writer.Close();
        }

        public void Read(XmlReader reader)
        {
            Clear();

            while (reader.Read())
            {
                if (reader.IsStartElement("component"))
                {
                    string type = reader.GetAttribute("type");
                    type = nameSpace + "." + type;
                    int x = int.Parse(reader.GetAttribute("x"));
                    int y = int.Parse(reader.GetAttribute("y"));
                    object[] param = new object[0];
                    Type[] types = new Type[0];
                    System.Reflection.ConstructorInfo info = Type.GetType(type).GetConstructor(types);
                    Component c = (Component)info.Invoke(param);
                    c.Read(reader.ReadSubtree());
                    c.Location = new Point(x, y);
                    Add(c);
                    ConnectComponent(c);
                }
            }
        }

        public void Read(System.IO.Stream stream)
        {
            XmlReader reader = XmlReader.Create(stream);
            Read(reader);
        }

        public List<Component> Components { get; }
    }
}
