using Common;

namespace SandwichProcessor
{
    public class zlcenieKanapka : Izlecenie
    {
        private string? _title;
        public string Tytul
        {
            get => _title ?? "";
            set => _title = value;
        }

        public void Process()
        {
            Console.WriteLine(Tytul);

            string[] stages = {
                "Piekarnik rozgrzewany do 180 stopni.",
                "Pokrojony pomidor w plastry.",
                "Posiekana sałata.",
                "Ułożenie salami na kromkach chleba.",
                "Dodanie pomidora i sałaty.",
                "Połączenie obu kromek w całość."
            };

            foreach (var stage in stages)
            {
                Console.WriteLine($"Etap: {stage}");
                Thread.Sleep(1000);
            }
        }
    }
}
