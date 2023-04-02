using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM_WINFORM_PAINT
{
    enum DrawingMode
    {
        line,
        rec,
        ellipse,
        circle,
        polygon,
        move,
        group,
        ungroup
    }

    enum DrawingState
    {
        none,
        isDrawingPolygon
    }
}
