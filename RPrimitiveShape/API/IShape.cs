using System;
using System.Collections.Generic;
using System.Text;

namespace RUtil.Shape
{
    public interface IShape
    {
        public abstract bool IsInside(IPoint p);
    }
}
