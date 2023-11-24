using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMethods
{
    internal class Rectangle
    {
        public Rectangle(Point topLeft, int width, int height)
            : this(topLeft: topLeft,
                    bottomRight: new Point(topLeft.X + width, topLeft.Y + height),
                    width: width,
                    height: height)
        {
        }

        public Rectangle(Point topLeft, Point bottomRight)
            : this(topLeft: topLeft,
                    bottomRight: bottomRight,
                    width: bottomRight.X - topLeft.X,
                    height: bottomRight.Y - topLeft.Y)
        {
        }

        private Rectangle(Point topLeft, Point bottomRight, int width, int height)
        {
            if (topLeft.X > bottomRight.X || topLeft.Y > bottomRight.Y)
            {
                throw new ArgumentException("Coordinates are not in the correct order");
            }

            if (bottomRight.X - topLeft.X != width)
            {
                throw new ArgumentException("Rectangle width not sent correctly");
            }

            if (bottomRight.Y - topLeft.Y != height)
            {
                throw new ArgumentException("Rectangle height not sent correctly");
            }


            TopLeft = topLeft;
            BottomRight = bottomRight;
            Width = width;
            Height = height;
            TopRight = new Point(topLeft.X + Width, topLeft.Y);
            BottomLeft = new Point(topLeft.X, topLeft.Y + Height);
        }

        public Point TopLeft { get; }
        public Point TopRight { get; }
        public Point BottomLeft { get; }
        public Point BottomRight { get; }
        public int Width {  get; }
        public int Height { get; }
    }
}
