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
                Warrior.Skills[0] = "Attack"; //standard attack
                Warrior.Skills[1] = "Charge"; //strong attack with recoil
                Warrior.Skills[2] = "Block"; //reduce damage and heal small amount ()
                Warrior.Skills[3] = "Item"; //use item from inventory
                Warrior.Skills[4] = "Run"; //end battle
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
                Archer.Skills[0] = "Attack"; //standard attack
                Archer.Skills[1] = "Power Shot"; //strong attack and lose armor
                Archer.Skills[2] = "Evading Shot"; //attack with a chance to dodge, recieve more damage when hit
                Archer.Skills[3] = "Item"; //use item from inventory
                Archer.Skills[4] = "Run"; //end battle
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
                Wizard.Skills[0] = "Fireball"; //use against fire weak enemies
                Wizard.Skills[1] = "Ice Blast"; //use against ice weak enemies
                Wizard.Skills[2] = "Lightning"; //use against lightning weak enemies
                Wizard.Skills[3] = "Item"; //use item from inventory
                Wizard.Skills[4] = "Run"; //end battle
            }
            return Wizard;
        }
    }
}
