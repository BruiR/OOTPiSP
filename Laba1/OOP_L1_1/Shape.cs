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
        
    }
}
