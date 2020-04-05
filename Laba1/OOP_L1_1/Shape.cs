using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_L1_1
{
    abstract class Shape
    {
        public abstract void Draw(Graphics graphic);
        public Point FirstPoint, SecondPoint;
        public Pen PenColor;
        public Shape(Pen PenColor, Point FirstPoint, Point SecondPoint)
        {
            this.PenColor = PenColor;
            this.FirstPoint = FirstPoint;
            this.SecondPoint = SecondPoint;
        }
        /*        public Point TopLeftPoint(Point FirstPoint, Point SecondPoint)
                {
                    int x = Math.Min(FirstPoint.X, SecondPoint.X);
                    int y = Math.Min(FirstPoint.Y, SecondPoint.Y);
                    return new Point(x, y);
                }
                public Point BottomRightPoint(Point FirstPoint, Point SecondPoint)
                {
                    int x = Math.Max(FirstPoint.X, SecondPoint.X);
                    int y = Math.Max(FirstPoint.Y, SecondPoint.Y);
                    return new Point(x, y);
                }
        */
    }
}
