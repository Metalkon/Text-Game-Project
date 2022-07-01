using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Game_Project
{
public class Program
    {

        static void Main()
        {
            Fighter player = Fighter.CreateWarrior();
            Console.WriteLine(player.Name);
            Console.WriteLine(player.Level);
            Console.WriteLine(player.Exp);
            Console.WriteLine(player.Health);
            Console.WriteLine(player.Damage);
            Console.WriteLine(player.Armor);
            Console.WriteLine(player.Skills);
            Console.ReadLine();
        }

    }

}
