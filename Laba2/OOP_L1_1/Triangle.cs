using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_L1_1
{
    class Triangle : Shape
    {
        public Triangle(Pen PenColor, Point FirstPoint, Point SecondPoint) : base(PenColor, FirstPoint, SecondPoint) { }
        public Point[] TrianglePoints(Point FirstPoint, Point SecondPoint)
        {
            Point TopPoint = new Point(0, 0);
            Point LeftPoint = new Point(0, 0);
            Point RightPoint = new Point(0, 0);
            if (FirstPoint.X < SecondPoint.X) 
            {
               RightPoint.X = SecondPoint.X;
               LeftPoint.X = FirstPoint.X;
               TopPoint.X = FirstPoint.X + Math.Abs(SecondPoint.X - FirstPoint.X)/2;
            }
            else 
            {
                RightPoint.X = FirstPoint.X;
                LeftPoint.X = SecondPoint.X;
                TopPoint.X = SecondPoint.X + Math.Abs(FirstPoint.X - SecondPoint.X) / 2;
            }

            if (FirstPoint.Y < SecondPoint.Y)
            {
                RightPoint.Y = SecondPoint.Y;
                LeftPoint.Y = SecondPoint.Y;
                TopPoint.Y = FirstPoint.Y;
            }
            else
            {
                RightPoint.Y = FirstPoint.Y;
                LeftPoint.Y = FirstPoint.Y;
                TopPoint.Y = SecondPoint.Y;
            }
            return new Point[] { TopPoint, LeftPoint, RightPoint };
        }
        public override void Draw(Graphics graphic)
        {
            graphic.DrawPolygon(PenColor, TrianglePoints(FirstPoint, SecondPoint));
        }
    }
}
