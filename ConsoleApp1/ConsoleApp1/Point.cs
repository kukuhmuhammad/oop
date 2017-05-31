using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int distanceTo(int x, int y)
        {
            var selisihX = X - x;
            var selisihY = Y - y;

            var selisihXkuadrat = selisihX * selisihX;
            var selisihYkuadrat = Math.Pow(selisihY, 2);

            var jumlah = selisihXkuadrat + selisihYkuadrat;
            var akar = Math.Sqrt(jumlah);

            return (int)akar;
        }
 
    }
}
