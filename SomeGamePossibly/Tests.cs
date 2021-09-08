using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeGamePossibly
{
    class Tests
    {
        public void Generate_and_Display(int x,int y)
        {
            MapGenerator mapGenerator = new MapGenerator();
            char[,] room = mapGenerator.Generate_room(x, y);
            for(int i = 0; i<= y + 1; i++)
            {
                for (int i2 = 0; i2 <= x +1; i2++)
                {
                    Console.Write(room[i, i2]);
                }
                Console.Write('\n');
            }
            Console.WriteLine("Room Generated press anykey to end test ...");
            Console.ReadLine();
        }
        public void Generate_Rand_and_Display(int maxX, int maxY)
        {
            MapGenerator mapGenerator = new MapGenerator();
            Random rand = new Random();
            int x = rand.Next(1, maxX);
            int y = rand.Next(1, maxY);
            char[,] room = mapGenerator.Generate_room(x, y);
            Console.WriteLine("x == " + x + "\ny == " + y);
            for (int i = 0; i <= y + 1; i++)
            {
                for (int i2 = 0; i2 <= x + 1; i2++)
                {
                    Console.Write(room[i, i2]);
                }
                Console.Write('\n');
            }
            Console.WriteLine("Press 1 to generate next or 0 to EXIT...");
            ConsoleKeyInfo keyInfo =  Console.ReadKey();
            if(keyInfo.KeyChar == '1')
            {
                Console.WriteLine();
                Generate_Rand_and_Display(maxX, maxY);
            }
        }
        public void Test_Map_Generation(int size, int complexityLvl)
        {
            MapGenerator mapGenerator = new MapGenerator();
            mapGenerator.Generate_Map(size,complexityLvl);
            Console.WriteLine();
            Console.WriteLine("Map Generated press anykey to end test ...");
            Console.ReadLine();
        }
    }
}
