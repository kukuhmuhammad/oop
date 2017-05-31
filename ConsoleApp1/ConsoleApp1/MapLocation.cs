using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MapLocation : Point //inheritance
    {
        public MapLocation(int x, int y,Map map) : base(x,y)
        {
          if (!map.onMap (this)) //apakah map ada dalam on map , this itu menunjuk ke point
                throw new OutOfBoundsException("gada pointnya");
        }

    }
}
