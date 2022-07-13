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
            Console.Title = "Battle Game";
            GameClass.Game();


            //game stuff
            //var player = Game.ChooseFighter();
            //var enemy = Game.ChooseFighter();

            //test stuff
            //PlayerTest(player, enemy);
            //player.Exp = player.Exp + Convert.ToInt32(Console.ReadLine());
            //PlayerTest(player, enemy);



            Console.ReadLine();
        }





















        //-----------------------------------------------------------------------------------------------------------
        /*public static void Music(string song, SoundPlayer menu, SoundPlayer battle)
        {
            if (song == "Menu")
            {
                menu.PlayLooping();
            }
            if (song == "Battle")
            {
                battle.PlayLooping();
            }
        }*/

        //music stuff
        /*SoundPlayer menu = new SoundPlayer(@"SFX\Menu.wav");
        SoundPlayer battle = new SoundPlayer(@"SFX\Battle.wav");
        string song = "Battle";
        Thread musicThread = new Thread(() => Music(song, menu, battle));
        musicThread.Start();*/

        //check for updates to player object.
        public static void PlayerTest(Fighter player, Fighter enemy)
        {
            Console.WriteLine($"\nCharacter Class: {player.Name}!\nLevel: {player.Level}\nEXP: {player.Exp}\nEXP Next LV: {player.NextExp}\nHP: {player.MaxHealth}\nDMG: {player.Damage}\nDEF: {player.Armor}\nSKILLS: {player.Skills[0]} {player.Skills[1]} {player.Skills[2]} {player.Skills[3]} {player.Skills[4]}");
            Console.WriteLine($"\nOpponent's Character Class: {enemy.Name}!\nLevel: {enemy.Level}\nEXP: {enemy.Exp}\nEXP Next LV: {enemy.NextExp}\nHP: {enemy.MaxHealth}\nDMG: {enemy.Damage}\nDEF: {enemy.Armor}\nSKILLS: {enemy.Skills[0]} {enemy.Skills[1]} {enemy.Skills[2]} {enemy.Skills[3]} {enemy.Skills[4]}");

        }
    }
}

