using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Text_Game_Project
{
    public static class Game
    {
        public static Fighter ChooseFighter()
        {
            Title = "Battle Game";
            string prompt = "Welcome to Battle Game, Choose Your Fighter!";

            string[] options = { "Warrior", "Archer", "Wizard" };
            Menu fighterSelection = new Menu(prompt, options);
            int selectedIndex = fighterSelection.Run();
        
            switch (selectedIndex)
            {
                case 0:
                    return Fighter.ChooseWarrior(); 
                case 1:
                    return Fighter.ChooseArcher();
                case 2:
                    return Fighter.ChooseWizard();
                default:
                    return Fighter.ChooseWarrior();
            }

        }
    }
}
