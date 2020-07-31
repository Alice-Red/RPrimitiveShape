using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace RUtil.Shape.Base
{
    public struct Point : IPoint
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double W {
            get => X;
            set => X = value;
        }
        public double H {
            get => Y;
            set => Y = value;
        }

        public Point operator +(Point left, Point right) {

        }
    }
}
