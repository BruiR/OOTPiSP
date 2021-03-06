﻿using System;
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
    }
}
