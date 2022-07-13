using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Text_Game_Project
{

    public class GameClass
    {

        public static void Game()
        {
            string gameTitle = @"
██████   █████  ████████ ████████ ██      ███████      ██████   █████  ███    ███ ███████ 
██   ██ ██   ██    ██       ██    ██      ██          ██       ██   ██ ████  ████ ██      
██████  ███████    ██       ██    ██      █████       ██   ███ ███████ ██ ████ ██ █████   
██   ██ ██   ██    ██       ██    ██      ██          ██    ██ ██   ██ ██  ██  ██ ██      
██████  ██   ██    ██       ██    ███████ ███████      ██████  ██   ██ ██      ██ ███████ ";
            //Game Loop
            string menu = "Main Menu";
            while (menu == "Main Menu")
            {
                menu = MainMenu();
                Fighter player = new Fighter();
                if (menu == "New Game")
                {
                    player = ChooseFighter();
                    menu = "Game Menu";
                }
                if (menu == "Load Game")
                {
                    //load json for player object instead
                    player = ChooseFighter();
                    menu = "Game Menu";
                }
                //----------------------------------------------------
                while (menu == "Game Menu")
                {
                    menu = GameMenu();
                    if (menu == "World Map")
                    {
                        //select zones to battle monsters, include more while loops for areas and battle mechanics with random monsters encountered
                        menu = "Game Menu";
                    }
                    if (menu == "Shop")
                    {
                        //shop for items and gear (potions and armor/weapons)
                        menu = "Game Menu";
                    }
                    if (menu == "Status")
                    {
                        Clear();
                        WriteLine(gameTitle);
                        Console.WriteLine($"\nCharacter Class: {player.Name}!\nLevel: {player.Level}\nEXP: {player.Exp}\nEXP Next LV: {player.NextExp}\nHP: {player.MaxHealth}\nDMG: {player.Damage}\nDEF: {player.Armor}\nSKILLS: {player.Skills[0]} {player.Skills[1]} {player.Skills[2]} {player.Skills[3]} {player.Skills[4]}");
                        //show items/equipment as well
                        Console.ReadLine();
                        menu = "Game Menu";
                    }
                     if (menu == "Save Game")
                    {
                        //save json file that will be used to load game, possibly restart game with the load on death
                        menu = "Game Menu";
                    }
                    if (menu == "Exit")
                    {
                        menu = "Main Menu";
                    }
                }

            }







            //Console.WriteLine($"\nCharacter Class: {player.Name}!\nLevel: {player.Level}\nEXP: {player.Exp}\nEXP Next LV: {player.NextExp}\nHP: {player.MaxHealth}\nDMG: {player.Damage}\nDEF: {player.Armor}\nSKILLS: {player.Skills[0]} {player.Skills[1]} {player.Skills[2]} {player.Skills[3]} {player.Skills[4]}");

        }

        public static string MainMenu()
        {
            string prompt = "Welcome to Battle Game!";
            string[] options = { "New Game", "Load Game" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    return "New Game"; 
                case 1:
                    return "Load Game";
                default:
                    return "";
            }
        }
        public static string GameMenu()
        {
            string prompt = "What would you like to do?";
            string[] options = { "World Map", "Shop", "Status", "Save Game", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    return "World Map";
                case 1:
                    return "Shop";
                case 2:
                    return "Status";
                case 3:
                    return "Save Game";
                case 4:
                    return "Exit";
                default:
                    return "";
            }
        }
        public static Fighter ChooseFighter()
        {
            string prompt = "Welcome to Battle Game, Choose Your Fighter!";
            string[] options = { "Warrior", "Archer", "Wizard" };
            Menu fighterSelection = new Menu(prompt, options);
            int selectedIndex = fighterSelection.Run();
        
            switch (selectedIndex)
            {
                case 0:
                    return Player.ChooseWarrior(); 
                case 1:
                    return Player.ChooseArcher();
                case 2:
                    return Player.ChooseWizard();
                default:
                    return Player.ChooseWarrior();
            }

        }
        public static void NewGame()
        {

        }
    }
}
