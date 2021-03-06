using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Text_Game_Project
{
    internal class Menu
    {
        public string gameTitle = @"
██████   █████  ████████ ████████ ██      ███████      ██████   █████  ███    ███ ███████ 
██   ██ ██   ██    ██       ██    ██      ██          ██       ██   ██ ████  ████ ██      
██████  ███████    ██       ██    ██      █████       ██   ███ ███████ ██ ████ ██ █████   
██   ██ ██   ██    ██       ██    ██      ██          ██    ██ ██   ██ ██  ██  ██ ██      
██████  ██   ██    ██       ██    ███████ ███████      ██████  ██   ██ ██      ██ ███████ 

";
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }

        private void DisplayOptions()
        {
            //Show Prompt Message, Options, and Highlight.
            WriteLine(gameTitle + Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;

                if (i == SelectedIndex)
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"{prefix} << {currentOption} >>");
            }
            ResetColor();
        }

        public int Run()

        {
            //Selecting the different options based on key presses.
            ConsoleKey keyPressed;
            do
            {
                Clear();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                // Update SelectedIndex based on arrow keys pressed.
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    Beep();
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    Beep();
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }

            }
            //Enter to choose your option and return value.
            while (keyPressed != ConsoleKey.Enter);

            return SelectedIndex;
        }
    }
}
