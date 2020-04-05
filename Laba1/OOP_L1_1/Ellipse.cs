using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_L1_1
{
    class Ellipse : Rectangular
    {
        public Ellipse(Pen PenColor, Point FirstPoint, Point SecondPoint) : base(PenColor, FirstPoint, SecondPoint) { }
 /*       public int Width
        {
            get
            {
                return Math.Abs(FirstPoint.X - SecondPoint.X);
            }
        }
        public int Height
        {
            get
            {
                return Math.Abs(FirstPoint.Y - SecondPoint.Y);
            }
        } */
        public override void Draw(Graphics graphic)
        {
            graphic.DrawEllipse(PenColor, FirstPoint.X, FirstPoint.Y, Width, Height);
        }
    }
}
