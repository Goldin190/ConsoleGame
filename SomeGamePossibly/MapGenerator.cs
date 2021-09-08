using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeGamePossibly
{
    class MapGenerator
    {
        private int roomsCount;
        private int lootChestCount; // if it will be rouge like;
        private char[] symbolsMap = new char[] { '|', '_', '/', '\\', '-', ' ' };
        private char[,] map;
        private List<Room> rooms;
        private int mapx;
        private int mapy;

        public char[,] Generate_room(int x, int y) {
            x += 1;
            y += 1;
            char[,] room = new char[y + 1, x + 1];
            for (int i = 0; i < y + 1; i++) {
                if (i == 0)
                {
                    for (int i2 = 0; i2 < x + 1; i2++)
                    {

                        if (i2 == 0 || i2 == x)
                        {
                            room[i, i2] = symbolsMap[5];
                        }
                        else
                        {
                            room[i, i2] = symbolsMap[1];
                        }

                    }
                } else if (i == y)
                {
                    for (int i2 = 0; i2 < x + 1; i2++)
                    {
                        if (i2 == 0 || i2 == x) {
                            room[i, i2] = symbolsMap[0];
                        }
                        else
                        {
                            room[i, i2] = symbolsMap[4];
                        }

                    }
                }
                else
                {
                    for (int i2 = 0; i2 < x + 1; i2++)
                    {
                        if (i2 == 0 || i2 == x)
                        {
                            room[i, i2] = symbolsMap[0];
                        }
                        else
                        {
                            room[i, i2] = symbolsMap[5];
                        }

                    }
                }
            }
            return room;
        }

        public char[,] Generate_Map(int size, int complexityLvl)
        {
            //size = map size 1 small , 2 medium , 3 BIG

            //size = map size (% of map taken by rooms)
            //complexityLvl = amount of maximum rooms possible
            int max_volume;
            
            switch (size)
            {
                case 1:
                    {
                        this.mapx = 80;
                        this.mapy = 20;

                        break;
                    }
                case 2:
                    {
                        this.mapx = 120;
                        this.mapy = 30;                        
                        break;
                    }
                case 3:
                    {
                        this.mapx = 140;
                        this.mapy = 35;
                        break;
                    }
            }
            this.map = new char[mapy, mapx];
            max_volume = ((mapx * mapy) / 10) * complexityLvl;
            Random rand = new Random();
            int max_rooms = (max_volume) / (20 * 6);
            this.roomsCount = rand.Next(max_rooms/3,max_rooms);
            Console.WriteLine("Max amount of rooms to generate :" + max_rooms);
            Console.WriteLine("Amount of rooms to generate :" + this.roomsCount);

            for(int iy = 0; iy < mapy; iy++)
            {
                for(int ix = 0; ix < mapx; ix++)
                {
                    map[iy, ix] = ' ';
                }
            }
            return new char[0,0];
        }
        
        public bool Is_Room_Possbile_To_Place(Room room)
        {
            return false;
        }
        
    }
}
/*3 x 4
 *0 123 4
 *  ___ 0
 * |   |1
 * |   |2
 * |   |3
 * |   |4
 * |---|5
 */