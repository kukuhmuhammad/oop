using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Path
    {
        private readonly MapLocation[] _path; //kalo private pake underscore
        public int length
        {
            get
            {
                return _path.Length;
            }
        }

        public Path(MapLocation[] path)
        {
            _path = path;
        }
        public MapLocation getLocationAt(int pathStep)
        {
            return pathStep < _path.Length ? _path[pathStep] : null; // cara cepat if else "syntax sugar
            //if (pathStep < _path.Length)
            //    return _path[pathStep];
            //else
            //    return null;
        }
    }
}   
