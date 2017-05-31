using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tower
    {
        private MapLocation _location;
        private const int _range = 1;
        public Tower (MapLocation Location)
        {
            _location = Location;
        }
        public void FireToInvader(Invader[] invaders)
        {
            foreach (var satuInvader in invaders)
            {
                if(satuInvader.IsActive && _location.inRangeof(satuInvader.Location,_range))
                {
                    satuInvader.decreaseHealth(1);
                    break;
                }
            }
        }
    }
   
}
