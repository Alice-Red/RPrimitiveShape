using System;
using System.Collections.Generic;
using System.Text;

namespace RUtil.Shape
{
    public interface IShape
    {
        bool IsInside(IPoint p);
        double AreaSize();

    }
}
