
namespace LINQ_
{
    internal class Ex2
    {
        static readonly Random rand = new();
        public static void RunExcercise2()
        {
            Console.WriteLine("EX 2");
            ReadNumbers(out int N, out int M);
            Excercise2(N, M);
        }

        public static void Excercise2(int N, int M)
        {
            IEnumerable<IEnumerable<int>> matrix = Enumerable.Range(0, N)
                .Select(_ => Enumerable.Range(0, M)
                    .Select(__ => rand.Next(1, 10)));

            int sum = matrix.SelectMany(row => row).Sum();

            Console.WriteLine($"Suma: {sum}");

            PrintList(matrix);

        }
        static void ReadNumbers(out int N, out int M)
        {
            Console.WriteLine("Musis podać dwie liczby.");
            Console.WriteLine("Wysokosc:");
            string? number = Console.ReadLine();
            bool f = int.TryParse(number, out N);
            if (!f) { N = 0; }

            Console.WriteLine("Szerokosc:");
            number = Console.ReadLine();
            f = int.TryParse(number, out M);
            if (!f) { M = 0; }
        }

        static void PrintList(IEnumerable<IEnumerable<int>> list)
        {
            Console.WriteLine("Sprawdzenie:");
            foreach (var n in list)
            {
                foreach (int x in n)
                {
                    Console.Write(x+"\t");
                }
                Console.Write("\n");
            }
        }
    }
}
