using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_L1_1
{
    class Square : Rectangular
    {
        public Square(Pen PenColor, Point FirstPoint, Point SecondPoint) : base(PenColor, FirstPoint, SecondPoint) { }
        public override void Draw(Graphics graphic)
        {
            Point LeftPoint = RectangularPoint(FirstPoint, SecondPoint);
            graphic.DrawRectangle(PenColor, LeftPoint.X, LeftPoint.Y, Width, Width);
        }
    }
}
