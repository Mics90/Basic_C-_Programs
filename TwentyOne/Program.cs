﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Heri is some text.";
            //File.WriteAllText(@"C:\Users\Nauris\Desktop\Nauris_studijas\C_SHARP\Basic_C-_Programs\logs\log.txt", text);

           
            //string text = File.ReadAllText(@"C:\Users\Nauris\Desktop\Nauris_studijas\C_SHARP\Basic_C-_Programs\logs\log.txt");



            Console.WriteLine("Welcome to the Grand Hotel and Casino. Lets start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would yoy like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying || player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");

            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();



        }

    }
}
