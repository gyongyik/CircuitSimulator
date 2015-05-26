﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace CircuitSimulator.Components
{
    class TrafficLight : Component
    {
        public TrafficLight() : base()
        {
            Initialize();
        }

        public void Initialize()
        {
            Reinitalize(3, 1);

            Bounds = new Rectangle(0, 0, 85, 160);

            Connections[0].Location = new Point(5, 10);
            Connections[1].Location = new Point(5, 30);
            Connections[2].Location = new Point(5, 50);
        }

        protected override ComponentControl CreateComponentControl()
        {
            return new TrafficLightControl(this);
        }

        class TrafficLightControl : ComponentControl
        {
            TrafficLight fParent;

            public TrafficLightControl(TrafficLight parent) : base(parent)
            {
                fParent = parent;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                Pen penB = new Pen(Color.Black, 3);
                Pen penM = new Pen(Color.Maroon, 1);
                Pen penR = new Pen(Color.Red, 1);
                Pen penO = new Pen(Color.Olive, 1);
                Pen penY = new Pen(Color.Yellow, 1);
                Pen penG = new Pen(Color.Green, 1);
                Pen penL = new Pen(Color.Lime, 1);

                Rectangle rect = new Rectangle(15, 5, Width - 22, Height - 10);

                for (int i = 0; i < fParent.Connections.Length - 1; ++i)
                {
                    Color c = fParent.GetValue(i) ? Color.Red : Color.Black;
                    g.DrawEllipse(new Pen(c, 1), new Rectangle(Point.Subtract(fParent.Connections[i].Location, new Size(2, 2)), new Size(4, 4)));
                    g.DrawLine(penB, new Point(8, fParent.Connections[i].Location.Y), new Point(rect.Left, fParent.Connections[i].Location.Y));
                }

                g.FillRectangle(Brushes.Black, rect);
                g.DrawRectangle(penB, rect);

                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Rectangle redRect = new Rectangle(26, 10, 42, 42);
                g.FillEllipse(fParent.GetValue(0) ? Brushes.Red : Brushes.Maroon, redRect);
                g.DrawEllipse(fParent.GetValue(0) ? penR : penM, redRect);

                Rectangle yellowRect = new Rectangle(26, 59, 42, 42);
                g.FillEllipse(fParent.GetValue(1) ? Brushes.Yellow : Brushes.Olive, yellowRect);
                g.DrawEllipse(fParent.GetValue(1) ? penY : penO, yellowRect);

                Rectangle greenRect = new Rectangle(26, 108, 42, 42);
                g.FillEllipse(fParent.GetValue(2) ? Brushes.Lime: Brushes.Green, greenRect);
                g.DrawEllipse(fParent.GetValue(2) ? penL : penG, greenRect);

                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            }
        }
    }
}