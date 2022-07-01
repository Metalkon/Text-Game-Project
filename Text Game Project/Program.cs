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


        static void Main()
        {
            Fighter player = new Fighter();
            ConsoleHelper.SetCurrentFont("Consolas", 20); Console.Clear();
            Game myGame = new Game();
            myGame.Start();



            //test stuff
            Console.WriteLine($"You have Chosen the {player.Name}");
            Console.WriteLine(player.Level);
            Console.WriteLine(player.Exp);
            Console.WriteLine(player.Health);
            Console.WriteLine(player.Damage);
            Console.WriteLine(player.Armor);
            Console.WriteLine(player.Skills[0]);
            Console.ReadLine();

        }

    }

}
