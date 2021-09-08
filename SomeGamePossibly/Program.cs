using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeGamePossibly
{
    class Program
    {
        static void Main(string[] args)
        {
            Tests testInstance = new Tests();
            testInstance.Generate_and_Display(20, 6);
            testInstance.Test_Map_Generation(1, 3);
            testInstance.Test_Map_Generation(2, 3);
            testInstance.Test_Map_Generation(3, 3);
        }
    }
}
