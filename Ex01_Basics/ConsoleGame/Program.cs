using System;
using System.Data.Common;
using System.Text.RegularExpressions;

namespace homework1
{

    public class Program
    {
        static Hero? hero;
        static Location actualLocation = LocationCreater.createMiodowyLas();

        public static void Main()
        {
            StartGame();
            return;
        }

        public static void StartGame()
        {
            Console.Clear();

            Console.WriteLine("Witaj w grze Twoja własna przygoda PogU");
            Console.WriteLine("[1] Zacznij nową grę");
            Console.WriteLine("[X] Zamknij program");
            while (true)
            {
                string choice = Console.ReadLine() ?? "";
                if (choice == "1")
                {
                    Program.hero = HeroCreatingWindow.CreateHero();
                    
                    Console.Clear();
                    Console.WriteLine($"{hero.Class} {hero.Name} wyrusza na przygodę");
                    Console.WriteLine("(press any button)");
                    Console.ReadKey();

                    LocationWindow.ShowLocation(actualLocation);
                }
                else if (choice == "X" || choice == "x")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("wybrana opcja jest niewłaściwa");
                    Console.WriteLine("ponów wybór");
                }
            }
        }

        public static string ParseDialog(IDialogPart Dialog)
        {
            return Dialog.sentence.Replace("#HERONAME#", $"{hero.Name}");
        }


    }
}