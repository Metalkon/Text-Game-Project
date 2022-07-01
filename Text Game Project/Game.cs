using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Text_Game_Project
{
    internal class Game
    {
        public void Start()
        {
            Title = "Battle Game";
            RunMainMenu();

            WriteLine("Press any key to continue");
            ReadKey(true);
        }

        private void RunMainMenu()
        {
            string prompt = @"
██████   █████  ████████ ████████ ██      ███████      ██████   █████  ███    ███ ███████ 
██   ██ ██   ██    ██       ██    ██      ██          ██       ██   ██ ████  ████ ██      
██████  ███████    ██       ██    ██      █████       ██   ███ ███████ ██ ████ ██ █████   
██   ██ ██   ██    ██       ██    ██      ██          ██    ██ ██   ██ ██  ██  ██ ██      
██████  ██   ██    ██       ██    ███████ ███████      ██████  ██   ██ ██      ██ ███████ 
                                                                                                                                                                                    
Welcome to Battle Game, Choose Your Class!";
            string[] options = { "Warrior", "Archer", "Wizard" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    ChoiceWarrior();
                    break;
                case 1:
                    ChoiceArcher();
                    break;
                case 2:
                    ChoiceWizard();
                    break;
            }
        }

        public static void ChoiceWarrior()
        {
            Fighter player = Fighter.CreateWarrior();
        }
        public static void ChoiceArcher()
        {
            Fighter player = Fighter.CreateArcher();
        }
        public static void ChoiceWizard()
        {
            Fighter player = Fighter.CreateWizard();
        }
    }
}
