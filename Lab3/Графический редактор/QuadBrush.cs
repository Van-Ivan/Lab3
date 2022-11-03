using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Графический_редактор
{
    class QuadBrush : Brush
    {
        public QuadBrush(Color brushColor, int size) : base (brushColor, size) { }

        public override void Draw(BitMap image, int x, int y)
        {
            for (int y0 = y - Size; y0 < y+Size; y0++)
            {
                for (int x0 = x - Size; x0 < x + Size; x0++)
                {
                    image.SetPixel(x0, y0, BrushColor);
                }
            }
        }

    }
}
