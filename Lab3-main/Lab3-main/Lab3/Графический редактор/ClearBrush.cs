﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Графический_редактор
{
    class ClearBrush : Brush
    {
        public ClearBrush(Color brushColor, int size) : base(brushColor, size) { }

        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = y - Size; y0 < y + Size; y0++)
            {
                for (int x0 = x - Size; x0 < x + Size; x0++)
                {
                    if (x0 > 0 & y0 > 0 & x0 < W & y0 < H)
                    {
                        image.SetPixel(x0, y0, BrushColor);
                    }
                }
            }
        }

    }
}
