using System;
using System.Text.RegularExpressions;

namespace homework1
{
    public static class HeroCreatingWindow
    {
        public static Hero CreateHero()
        {
            Hero hero = new Hero();
            hero.Name = ChooseName();
            hero.Class = ChooseClass(hero.Name);
            return hero;

        }

        static string ChooseName()
        {
            Console.Clear();

            Console.WriteLine("Wybierz imie dla bohatera");

            while (true)
            {
                string name = Console.ReadLine() ?? "";
                name = Regex.Replace(name, @"\s", "");
                bool isAllAlphabetical = Regex.IsMatch(name, "^[a-zA-Z ]+$");

                if (!isAllAlphabetical) 
                {
                    Console.WriteLine("Nazwa nie mo¿e mieæ symboli spoza alfabetu");
                    continue;
                }
                if (name.Length < 2)
                {
                    Console.WriteLine("Nazwa musi sk³adaæ siê conajmneij z dwóch liter");
                    continue;
                }
                return name;
            }
        }

        static EHeroClass ChooseClass(string name)
        {
            Console.Clear();

            Console.WriteLine($"Witaj {name}, wybierz Pan klase ");

            foreach(EHeroClass character in Enum.GetValues(typeof(EHeroClass)))
            {
                Console.WriteLine($"[{(int)character+1}]{character}");
            }

            while (true)
            {
                string choise = Console.ReadLine() ?? "";

                switch (choise)
                {
                    case "1":
                        return EHeroClass.Barbarzynca;
                    case "2":
                        return EHeroClass.Paladyn;
                    case "3":
                        return EHeroClass.Amazonka;
                    default:
                        Console.WriteLine("wybrana opcja jest niew³aœciwa");
                        Console.WriteLine("ponów wybór");
                        break;
                }
            }
        }
    }
}