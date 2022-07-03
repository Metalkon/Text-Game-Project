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
        public double Health { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }
        public string[] Skills { get; set; }

        public static Fighter ChooseWarrior()
        {
            return new Fighter
            {
                Name = "Warrior",
                Level = 1,
                Exp = 0,
                Health = 35,
                Damage = 5,
                Armor = 0.3,
                Skills = new[] { "Attack", "Charge", "Block", "Item", "Run" },
            };
        }

        public static Fighter ChooseArcher()
        {
            return new Fighter
            {
                Name = "Archer",
                Level = 1,
                Exp = 0,
                Health = 25,
                Damage = 7,
                Armor = 0.2,
                Skills = new[] { "Attack", "Power Shot", "Evading Shot", "Item", "Run" },
            };
        }

        public static Fighter ChooseWizard()
        {
            return new Fighter
            {
                Name = "Wizard",
                Level = 1,
                Exp = 0,
                Health = 25,
                Damage = 10,
                Armor = 0.1,
                Skills = new[] { "Fireball", "Ice Blast", "Lightning", "Item", "Run" },
            };
        }
    }
}
