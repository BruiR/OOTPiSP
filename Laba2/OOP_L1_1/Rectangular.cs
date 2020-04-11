using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_L1_1
{
    abstract class Rectangular : Shape
    {
        public abstract override void Draw(Graphics graphic);
        public Rectangular(Pen PenColor, Point FirstPoint, Point SecondPoint) : base(PenColor, FirstPoint, SecondPoint) { }
        public int Width => Math.Abs(FirstPoint.X - SecondPoint.X);
        public int Height => Math.Abs(FirstPoint.Y - SecondPoint.Y);

        public Point RectangularPoint(Point FirstPoint, Point SecondPoint)
        {
            Point LeftPoint = new Point(0, 0);
            //Point RightPoint = new Point(0, 0);
            if (FirstPoint.X < SecondPoint.X)
            {
                //RightPoint.X = SecondPoint.X;
                LeftPoint.X = FirstPoint.X;
            }
            else
            {
                // RightPoint.X = FirstPoint.X;
                LeftPoint.X = SecondPoint.X;
                // TopPoint.X = SecondPoint.X + Math.Abs(FirstPoint.X - SecondPoint.X) / 2;
            }

            if (FirstPoint.Y < SecondPoint.Y)
            {
                //  RightPoint.Y = SecondPoint.Y;
                LeftPoint.Y = FirstPoint.Y;
                // TopPoint.Y = FirstPoint.Y;
            }
            else
            {
                //  RightPoint.Y = FirstPoint.Y;
                LeftPoint.Y = SecondPoint.Y;
                //  TopPoint.Y = SecondPoint.Y;
            }
            return LeftPoint;
        }
    }
}
