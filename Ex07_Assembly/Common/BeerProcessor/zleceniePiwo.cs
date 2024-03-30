using Common;
using System;

namespace BeerProcessor
{
    public class zleceniePiwo : Izlecenie
    {
        private string? _title ;
        public string Tytul
        {
            get => _title ?? "";
            set => _title = value;
        }

        public void Process()
        {
            Console.WriteLine(Tytul);

            string[] stages = {
                "Zacieranie",
                "Gotowanie (60 minut)",
                "Fermentacja burzliwa 9 dni (odermentoawało do 2,5 blg)",
                "Fermentacja cicha 6 dni (chmiel poszedł na 4 ostatnie dni)"
            };

            foreach (var stage in stages)
            {
                Console.WriteLine($"Etap: {stage}");
                Thread.Sleep(2000);
            }
        }

    }
}
