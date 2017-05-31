using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Map
    {
        public readonly int Height;
        public readonly int Width;

        public Map(int width,int height)
        {
            Height = height;
            Width = width;
        }
        
        public bool  onMap(Point point)
        {
            bool panjang = point.X < Width && point.X >= 0;
            bool lebar = point.Y < Height && point.Y >= 0;

            return panjang && lebar;
        }
    }
}
