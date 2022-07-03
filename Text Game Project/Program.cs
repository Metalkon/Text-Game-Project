using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Text_Game_Project
{
    public class Program
    {

        static void Main(string[] args)
        {
            ConsoleHelper.SetCurrentFont("Consolas", 18); Console.Clear();

            var player = Game.ChooseFighter();

            



            //test stuff
            Console.WriteLine($"\nYou have Chosen the {player.Name}");
            Console.WriteLine("Level: " + player.Level);
            Console.WriteLine("EXP: " + player.Exp);
            Console.WriteLine("HP: " + player.Health);
            Console.WriteLine("DMG: " + player.Damage);
            Console.WriteLine("DEF: " + player.Armor);
            Console.WriteLine($"SKILLS: {player.Skills[0]} {player.Skills[1]} {player.Skills[2]} {player.Skills[3]} {player.Skills[4]}");
            Console.ReadLine();

        }

    }

}
