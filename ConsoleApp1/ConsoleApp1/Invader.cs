﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;
        public int Health { get; private set; } = 2;

        public MapLocation Location
        {
            get
            {
                return _path.getLocationAt(_pathStep);
            }
        }

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move()
        {
            _pathStep += 1;
        }
        public void decreaseHealth(int factor)
        {
            Health -= factor;
        }

        public bool HasScored
        {
            get
            {
                return _pathStep >= _path.length;
            }
        }

        public bool IsNeutralized
        {
            get
            {
                return Health <= 0;
            }
        }
        public bool IsActive
        {
            get
            {
                return(IsNeutralized || HasScored);
             }
        }
        //public MapLocation getLocation()
        //{
        //    return _location;
        //}
        //public void setLocation (MapLocation value)
        //{
        //    _location = value;
        //}
    }
}
