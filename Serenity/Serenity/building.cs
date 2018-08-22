using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serenity
{
    public class Building
    {
        public Building(string name)
        {
            Thing innRoom = new Thing("man", "table", "bar");
            List<Thing> inn = new List<Thing>();
            inn.Add(innRoom);

            //public Room(int x, int y, int z, string description, bool north, bool east, bool west, bool south, bool up)
            Rooms = new List<Room>();
            Name = name;

            Loot sword = new Loot("sword", "a stone sword", 2);
            Loot lute = new Loot("lute", "a musical instrument", 0);

            List<Loot> impossible = new List<Loot>();
            impossible.Add(sword);

            List<Loot> treasureRoom1 = new List<Loot>();
            treasureRoom1.Add(sword);
            treasureRoom1.Add(lute);

            Rooms.Add(new Room(1, -1, 1, "impossible room", true, true, true, true, true, impossible));

             #region FloorOne
            Rooms.Add(new Room(1, 0, 1, "The tavern is grimy, with cobwebs everywhere. A wizened old man is slumped over a table but he perks up as you approach and says 'I think you need to go through the door like all the other adventurers did! Let me know if you find anyone!!'. He vanishes in a puff of smoke and leaves you looking at the only other door - in the north wall", true, false, false, false, false));
            //row 0
            Rooms.Add(new Room(1, 1, 1, "the room is old with crumbling floor boards and stone brick walls", true, true, false, true, false));
            Rooms.Add(new Room(2, 1, 1, "", false, true, true, false, false));
            Rooms.Add(new Room(3, 1, 1, "", true, false, true, false, false));
            Rooms.Add(new Room(4, 1, 1, "", true, true, false, false, false));
            Rooms.Add(new Room(5, 1, 1, "TREASURE", true, false, true, false, false, treasureRoom1));
            //row 1
            Rooms.Add(new Room(1, 2, 1, "DEATH", false, true, false, true, false));
            Rooms.Add(new Room(2, 2, 1, "", true, true, true, false, false));
            Rooms.Add(new Room(3, 2, 1, "", false, false, true, true, false));
            Rooms.Add(new Room(4, 2, 1, "", true, false, false, true, false));
            Rooms.Add(new Room(5, 2, 1, "WARP", false, false, false, true, false));
            //row 2
            Rooms.Add(new Room(1, 3, 1, "DEATH", true, false, false, false, false));
            Rooms.Add(new Room(2, 3, 1, "", true, false, false, true, false));
            Rooms.Add(new Room(3, 3, 1, "Theres a ladder", true, true, false, false, true));
            Rooms.Add(new Room(4, 3, 1, "", false, true, true, true, false));
            Rooms.Add(new Room(5, 3, 1, "", true, false, true, false, false));
            //row 3
            Rooms.Add(new Room(1, 4, 1, "", true, true, true, true, false));
            Rooms.Add(new Room(2, 4, 1, "", false, false, true, true, false));
            Rooms.Add(new Room(3, 4, 1, "DEATH", true, true, true, false, false));
            Rooms.Add(new Room(4, 4, 1, "", true, true, true, false, false));
            Rooms.Add(new Room(5, 4, 1, "", true, false, true, true, false));
            //row 4
            Rooms.Add(new Room(1, 5, 1, "", true, true, false, false, false));
            Rooms.Add(new Room(2, 5, 1, "", true, true, false, false, false));
            Rooms.Add(new Room(3, 5, 1, "", true, true, false, false, false));
            Rooms.Add(new Room(4, 5, 1, "", true, true, false, false, false));
            Rooms.Add(new Room(5, 5, 1, "DEATH", true, true, false, false, false));
            #endregion
             #region FloorTwo
            //row 1
            Rooms.Add(new Room(1, 1, 2, "DEATH", true, true, true, true, false));
            Rooms.Add(new Room(2, 1, 2, "", true, true, true, true, false));
            Rooms.Add(new Room(3, 1, 2, "DEATH", true, true, true, true, false));
            Rooms.Add(new Room(4, 1, 2, "", true, true, true, true, false));
            Rooms.Add(new Room(5, 1, 2, "DEATH", true, true, true, true, false));
            Rooms.Add(new Room(6, 1, 2, "", true, true, true, true, false));
            //row 2
            Rooms.Add(new Room(1, 2, 2, "", true, true, true, true, false));
            Rooms.Add(new Room(1, 2, 2, "", true, true, true, true, false));
            Rooms.Add(new Room(1, 2, 2, "ladder", true, true, true, true, false));
            Rooms.Add(new Room(1, 2, 2, "DEATH", true, true, true, true, false));
            Rooms.Add(new Room(1, 2, 2, "", true, true, true, true, false));
            Rooms.Add(new Room(1, 2, 2, "", true, true, true, true, false));
            //row 3
            Rooms.Add(new Room(1, 3, 2, "", true, true, true, true, false));
            Rooms.Add(new Room(1, 3, 2, "", true, true, true, true, false));
            Rooms.Add(new Room(1, 3, 2, "", true, true, true, true, false));
            Rooms.Add(new Room(1, 3, 2, "", true, true, true, true, false));
            Rooms.Add(new Room(1, 3, 2, "", true, true, true, true, false));
            Rooms.Add(new Room(1, 3, 2, "", true, true, true, true, false));
            #endregion
        }
        public string Name { get; set; }
        public int NumberOfRooms { get; set; }
        public static List<Room> Rooms { get; set; }

        public static Room GetRoom(int x, int y, int z)
        {
            foreach (Room room in Rooms)
            {
                if (x == room.Xcoord && y == room.Ycoord && z == room.Zcoord)
                    return room;
            }
            return new Room();
        }
    }
}