using System;
using System.Drawing;

namespace CircuitSimulator
{
    internal static class AutoConnect
    {
        public static Point Connect(Point originalLocation, Components.ComponentController componentController)
        {
            int grid = 5;
            Point finalLocation = new(originalLocation.X / grid * grid, originalLocation.Y / grid * grid);
            double actualDistance = 20;

            foreach (Components.Component component in componentController.Components)
            {
                if (Distance(originalLocation, new(component.Location.X + component.Width / 2, component.Location.Y + component.Height / 2)) > (component.Width + component.Height) / 2)
                {
                    continue;
                }

                foreach (Components.Connection connection in component.Connections)
                {
                    Point connectionLocation = new(component.Location.X + connection.Location.X, component.Location.Y + connection.Location.Y);
                    double d = Distance(originalLocation, connectionLocation);

                    if (d < actualDistance)
                    {
                        actualDistance = d;
                        finalLocation = connectionLocation;
                    }
                }
            }

            return finalLocation;
        }

        private static double Distance(Point location1, Point location2)
        {
            return Math.Sqrt((location1.X - location2.X) * (location1.X - location2.X) + (location1.Y - location2.Y) * (location1.Y - location2.Y));
        }
    }
}
