using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serenity
{
    public class Player
    {
        public Player(string name, int hitPoints = 100, int attackStrength = 20)
        {
            Name = name;
            HitPoints = 100;
            AttackStrength = 20;
            DefenceStrength = 20;
        }

        //Member Variables
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int AttackStrength { get; set; }
        public int DefenceStrength { get; set; }
        public int CurrentX { get; set; }
        public int CurrentY { get; set; }
        public int CurrentZ { get; set; }
        public Bag PlayerBag { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + " Hit Points: " + HitPoints.ToString() + " Attack Strength: " + AttackStrength.ToString();
        }

        public static void Move(string direction)
        {
            // Move player
        }

        public static void Attack()
        {
            // Attack NPC
        }

        public Room ChangeRoom(int x, int y, int z)
        {
            CurrentX = x;
            CurrentY = y;
            CurrentZ = z;
            return Building.GetRoom(x, y, z);
        }
    }
}
