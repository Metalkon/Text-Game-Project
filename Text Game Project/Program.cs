using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;


namespace Text_Game_Project
{
    public class Program
    {
        public string song;
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            ConsoleHelper.SetCurrentFont("Consolas", 18);

            //music stuff
            SoundPlayer menu = new SoundPlayer(@"SFX\Menu.wav");
            SoundPlayer battle = new SoundPlayer(@"SFX\Battle.wav");
            string song = "Battle";
            Thread musicThread = new Thread(() => Music(song, menu, battle));
            musicThread.Start();

            //game stuff
            var player = Game.ChooseFighter();

            //test stuff
            Console.WriteLine($"\nYou have Chosen the {player.Name}!\nLevel: {player.Level}\nEXP: {player.Exp}\nHP: {player.MaxHealth}\nDMG: {player.Damage}\nDEF: {player.Armor}\nSKILLS: {player.Skills[0]} {player.Skills[1]} {player.Skills[2]} {player.Skills[3]} {player.Skills[4]}");
            Console.ReadLine();

        }
        public static void Music(string song, SoundPlayer menu, SoundPlayer battle)
        {
            if (song == "Menu")
            {
                menu.PlayLooping();
            }
            if (song == "Battle")
            {
                battle.PlayLooping();
            }
        }
    }
}

