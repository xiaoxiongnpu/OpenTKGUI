﻿using System;
using System.Collections.Generic;
using System.Drawing;

using OpenTK;

namespace OpenTKGUI
{
    /// <summary>
    /// An orthagonal rectangle defined by a point and a size (described as a point offset).
    /// </summary>
    public struct Rectangle
    {
        public Rectangle(double X, double Y, double Width, double Height)
        {
            this.Location = new Point(X, Y);
            this.Size = new Point(Width, Height);
        }

        public Rectangle(Point Location, Point Size)
        {
            this.Location = Location;
            this.Size = Size;
        }

        public Rectangle(Point Size)
        {
            this.Location = new Point();
            this.Size = Size;
        }

        /// <summary>
        /// Gets the intersection of two rectangles.
        /// </summary>
        public static Rectangle Intersection(Rectangle A, Rectangle B)
        {
            Point loc = new Point(
               Math.Max(A.Location.X, B.Location.X),
               Math.Max(A.Location.Y, B.Location.Y));
            Point size = new Point(
                Math.Min(A.Location.X + A.Size.X, B.Location.X + B.Size.X) - loc.X,
                Math.Min(A.Location.Y + A.Size.Y, B.Location.Y + B.Size.Y) - loc.Y);
            return new Rectangle(loc, size);
        }

        /// <summary>
        /// The location of the top-left corner of the rectangle.
        /// </summary>
        public Point Location;

        /// <summary>
        /// The size of the rectangle.
        /// </summary>
        public Point Size;
    }
}