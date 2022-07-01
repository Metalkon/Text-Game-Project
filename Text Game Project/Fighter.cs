using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Game_Project
{
    public class Fighter
    {
        public string Name = "";
        public int Level;
        public int Exp;
        public double Health;
        public double Damage;
        public double Armor;
        public string[] Skills = new string[5];

        public static Fighter CreateWarrior()
        {
            Fighter Warrior = new Fighter();
            {
                Warrior.Name = "Warrior";
                Warrior.Level = 1;
                Warrior.Exp = 0;
                Warrior.Health = 35;
                Warrior.Damage = 5;
                Warrior.Armor = 0.2;
                Warrior.Skills[0] = "Attack";
                Warrior.Skills[1] = "Charge";
                Warrior.Skills[2] = "Block";
                Warrior.Skills[3] = "Item";
                Warrior.Skills[4] = "Run";
            }
            return Warrior;
        }
        public static Fighter CreateArcher()
        {
            Fighter Archer = new Fighter();
            {
                Archer.Name = "Archer";
                Archer.Level = 1;
                Archer.Exp = 0;
                Archer.Health = 25;
                Archer.Damage = 7;
                Archer.Armor = 0.1;
                Archer.Skills[0] = "Attack";
                Archer.Skills[1] = "Power Shot";
                Archer.Skills[2] = "Evading Shot";
                Archer.Skills[3] = "Item";
                Archer.Skills[4] = "Run";
            }
            return Archer;
        }
        public static Fighter CreateWizard()
        {
            Fighter Wizard = new Fighter();
            {
                Wizard.Name = "Wizard";
                Wizard.Level = 1;
                Wizard.Exp = 0;
                Wizard.Health = 25;
                Wizard.Damage = 10;
                Wizard.Armor = 0.1;
                Wizard.Skills[0] = "Fireball";
                Wizard.Skills[1] = "Ice Blast";
                Wizard.Skills[2] = "Lightning";
                Wizard.Skills[3] = "Item";
                Wizard.Skills[4] = "Run";
            }
            return Wizard;
        }
    }
}
