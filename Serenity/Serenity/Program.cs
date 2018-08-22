using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serenity
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = GetPlayerDetails();
            World serenityValley = BuildWorld();

            StartGame(player1, serenityValley);
        }

        public static Player GetPlayerDetails()
        {
            Console.Write("Enter Your Characters Name: ");
            string playerName = (Console.ReadLine());
            Player player1 = new Player(playerName);
            return player1;
        }

        public static World BuildWorld()
        {
            World serenityValley = new World();
            return serenityValley;
        }

        public static void StartGame(Player player1, World serenityValley)
        {
            Console.WriteLine(player1);
            Console.WriteLine("You enter a Tavern by a door in the south wall");
            Console.WriteLine("The room has 4 walls [type look to investigate the room and find interactable objects]");
            Room newRoom = Building.GetRoom(1, 0, 1);
            WhatNext(newRoom);
        }

        public static void WhatNext(Room currentRoom)
        {

            string instruction = Console.ReadLine();
            instruction = instruction.ToLower();
            bool isValid = IsValid(instruction);

            if (currentRoom.Description == "DEATH")
            {
                Console.WriteLine("Something lunges out of the darkness and suddenly you are knocked out.");
                Console.WriteLine("You regaiin consciousness in the tavern where you started");

                Room deathRoom = Building.GetRoom(1, 0, 1);

                WhatNext(deathRoom);
            }


                if (!isValid)
            {
                Console.WriteLine("Sorry I don't understand!");
                WhatNext(currentRoom);
            }

            List<Door> doors = currentRoom.Doors;
            Door northDoor = doors[0];
            Door eastDoor = doors[1];
            Door westDoor = doors[2];
            Door southDoor = doors[3];
            Door upDoor = doors[4];

            if ("use ladder" == instruction && upDoor.IsExists == true)
            {
                Console.WriteLine("You open the door in the upper wall and walk into a new room.");
                int newX = currentRoom.Xcoord;
                int newY = currentRoom.Ycoord;
                int newZ = currentRoom.Zcoord + 1;
                Room newRoom = Building.GetRoom(newX, newY,newZ);
                WhatNext(newRoom);
            }
            if ("go north" == instruction && northDoor.IsExists == true)
            {
                Console.WriteLine("You open the door in the north wall and walk into a new room.");
                int newX = currentRoom.Xcoord;
                int newY = currentRoom.Ycoord + 1;
                int newZ = currentRoom.Zcoord;
                Room newRoom = Building.GetRoom(newX, newY, newZ);
                WhatNext(newRoom);
            }

            if ("go east" == instruction && eastDoor.IsExists == true)
            {
                Console.WriteLine("You open the door in the east wall and walk into a new room.");
                int newX = currentRoom.Xcoord + 1;
                int newY = currentRoom.Ycoord;
                int newZ = currentRoom.Zcoord;
                Room newRoom = Building.GetRoom(newX, newY, newZ);
                WhatNext(newRoom);
            }

            if ("go west" == instruction && westDoor.IsExists == true)
            {
                Console.WriteLine("You open the door in the west wall and walk into a new room.");
                int newX = currentRoom.Xcoord - 1;
                int newY = currentRoom.Ycoord;
                int newZ = currentRoom.Zcoord;
                Room newRoom = Building.GetRoom(newX, newY, newZ);
                WhatNext(newRoom);
            }

            if ("go south" == instruction && southDoor.IsExists == true)
            {
                Console.WriteLine("You open the door in the south wall and walk into a new room.");
                int newX = currentRoom.Xcoord;
                int newY = currentRoom.Ycoord - 1;
                int newZ = currentRoom.Zcoord;
                Room newRoom = Building.GetRoom(newX, newY, newZ);
                WhatNext(newRoom);
            }

            if ("go end" == instruction && currentRoom.Zcoord == 1)
            {
                Console.WriteLine("You go to the end of the level.");
                int newX = 3;
                int newY = 3;
                int newZ = 1;
                Room newRoom = Building.GetRoom(newX, newY, newZ);
                WhatNext(newRoom);
            }

            if ("look" == instruction)
            {
                Console.WriteLine(currentRoom.Description);
                Console.WriteLine(northDoor.IsExists ? "There is a door in the north wall" : "The north wall is blank");
                Console.WriteLine(eastDoor.IsExists ? "There is a door in the east wall" : "The east wall is blank");
                Console.WriteLine(westDoor.IsExists ? "There is a door in the west wall" : "The west wall is blank");
                Console.WriteLine(southDoor.IsExists ? "There is a door in the south wall" : "The south wall is blank");
                Console.WriteLine(upDoor.IsExists ? "There is a ladder leading to a trapdoor in the ceiling" : "");
                WhatNext(currentRoom);
            }
            else
            {
                Console.WriteLine("Sorry you can't do that!!");
                WhatNext(currentRoom);
            }

        }

        public static bool IsValid(string instruction)
        {
            List<string> valid = new List<string>();
            valid.Add("go north");
            valid.Add("go south");
            valid.Add("go west");
            valid.Add("go east");
            valid.Add("look");
            valid.Add("use ladder");

            var match = valid.Where(x => x == instruction);
            return (match != null) ? true : false;
        }
    }
}
