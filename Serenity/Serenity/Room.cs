using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serenity
{
    public class Room
    {
        public Room(int x, int y, int z, string description, bool north, bool east, bool west, bool south, bool up) //all rooms
        {
            Doors = new List<Door>();
            Description = description;
            Doors.Add(new Door("north", north));
            Doors.Add(new Door("east", east));
            Doors.Add(new Door("west", west));
            Doors.Add(new Door("south", south));
            Doors.Add(new Door("up", up));
            Xcoord = x;
            Ycoord = y;
            Zcoord = z;

        }
        public Room(int x, int y, int z, string description, bool north, bool east, bool west, bool south, bool up, List<Loot> loots) //all rooms
        {
            Doors = new List<Door>();
            Description = description;
            Doors.Add(new Door("north", north));
            Doors.Add(new Door("east", east));
            Doors.Add(new Door("west", west));
            Doors.Add(new Door("south", south));
            Doors.Add(new Door("up", up));
            Xcoord = x;
            Ycoord = y;
            Zcoord = z;
            Loots = loots;
        }
        public Room()
        {

        }

        public string Description { get; set; }
        public int Xcoord { get; set; }
        public int Ycoord { get; set; }
        public int Zcoord { get; set; }
        public List<Door> Doors { get; set; }
        public List<Loot> Loots { get; set; }
    }
}
