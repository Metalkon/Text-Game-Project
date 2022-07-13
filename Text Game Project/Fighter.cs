using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Game_Project
{
    public class Fighter
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Exp { get; set; }
        public int NextExp { get; set; }
        public double MaxHealth { get; set; }
        public double Health { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }
        public string[] Skills { get; set; }
    }
    public class Player : Fighter
    {
        public static Fighter ChooseWarrior()
        {
            int level = 1;
            return new Fighter
            {
                Name = "Warrior",
                Level = level,
                Exp = 0,
                NextExp = 50,
                MaxHealth = 35 + ((level - 1) * 20),
                Health = 35,
                Damage = 6 + ((level - 1) * 3),
                Armor = 0.3 + ((level - 1) * 0.003),
                Skills = new[] { "Attack", "Charge", "Block", "Item", "Run" },
            };
        }
        public static Fighter ChooseArcher()
        {
            int level = 1;
            return new Fighter
            {
                Name = "Archer",
                Level = level,
                Exp = 0,
                NextExp = 50,
                MaxHealth = 25 + ((level - 1) * 15),
                Health = 25,
                Damage = 8 + ((level - 1) * 4),
                Armor = 0.2 + ((level - 1) * 0.002),
                Skills = new[] { "Attack", "Power Shot", "Evading Shot", "Item", "Run" },
            };
        }
        public static Fighter ChooseWizard()
        {
            int level = 1;
            return new Fighter
            {
                Name = "Wizard",
                Level = level,
                Exp = 0,
                NextExp = 50,
                MaxHealth = 25 + ((level - 1) * 15),
                Health = 25,
                Damage = 10 + ((level - 1) * 5),
                Armor = 0.1 + ((level - 1) * 0.001),
                Skills = new[] { "Fireball", "Ice Blast", "Lightning", "Item", "Run" },
            };
        }
    }       
}
