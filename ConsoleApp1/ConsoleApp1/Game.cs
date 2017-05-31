using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Game
    {
        static void Main(string[] args)
        {
            Map map = new Map(8,5);


            //Point point = new Point(4, 2);
            //bool isOnMap = map.onMap(point);
            //Console.WriteLine(isOnMap);

            try
            {
               // MapLocation point2 = new MapLocation(8, 5, map);

                Path path = new Path(
                new[]
                
                {
                    new MapLocation(0,2,map),
                    new MapLocation(1,2,map),
                    new MapLocation(2,2,map),
                    new MapLocation(3,2,map),
                    new MapLocation(4,2,map),
                    new MapLocation(5,2,map),
                    new MapLocation(6,2,map),
                    new MapLocation(7,2,map)

                });
                Invader[] invaders =
                {
                        new Invader(path),
                        new Invader(path),
                        new Invader(path),
                        new Invader(path)
                };

                Tower[] towers =
                {
                    new Tower (new MapLocation(1,3,map)),
                    new Tower (new MapLocation(1,3,map)),
                    new Tower (new MapLocation(0,2,map))
                };
                Level level = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerStatus = level.Play();
                Console.WriteLine( "Player " +(playerStatus ? "won" : "lost"));
                //MapLocation location = path.getLocationAt(0);
                //Console.WriteLine(location.X + "," + location.Y);
            
            }
            catch(OutOfBoundsException ex) //bikin exception sendiri
            {
                Console.WriteLine(ex.Message); //message dilempar dari throw exception di MapLocation
            }
            catch (MDException ex)
            {
                Console.WriteLine("Exception level 2" +ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception level 3" +ex.Message);
            }
        }
    }
}
