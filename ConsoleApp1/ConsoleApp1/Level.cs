using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Level
    {
        private Invader[] _invaders;
        public Tower[] Towers { get; set; }

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }
        public bool Play()
        {
            //looing sampai semua invader mati atau invader menang
            int remainingInvaders = _invaders.Length;
            while(remainingInvaders>0)
            {
                // tower cek jarak dengan invader
                foreach (Tower tower in Towers)
                {

                   
                    tower.FireToInvader(_invaders);
                }
                // kalau masih invader, invader maju
                remainingInvaders = 0;
                foreach (Invader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();

                        if(invader.HasScored)
                        {
                            return false;
                        }

                        remainingInvaders++;
                    }
                }
            }
            return true;
        }
       
    }
}
