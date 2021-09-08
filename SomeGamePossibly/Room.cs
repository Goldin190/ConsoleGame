using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeGamePossibly
{
    class Room
    {
        public int x { get; set; }
        public int y { get; set; }
        public int xPos { get; set; }
        public int yPos { get; set; }
        public int id { get; set; }
        public int volume { get => (this.x * this.y) ;}
        public char [,] roomCharTable { get; set; }

        public Room(int p_x, int p_y, int p_id, char [,] p_CharTable)
        {
            this.x = p_x;
            this.y = p_y;
            this.id = p_id;
            this.roomCharTable = p_CharTable;
        }
    }
}
