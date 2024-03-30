namespace LINQ_
{
    internal class Ex1
    {
        public static void RunExcercise1()
        {
            Console.WriteLine("EX 1");
            ReadNumber(out int N);
            Excercise1(N);
        }

        static void ReadNumber(out int N)
        {
            Console.WriteLine("podaj liczbe:");
            string? number = Console.ReadLine();
            bool f = int.TryParse(number, out N);
            if (!f) { N = 0; }
        }

        static void Excercise1(int N)
        {
            IEnumerable<int> powers = System.Linq.Enumerable.Range(1, N)
                .Where(n => (n != 5) & (n != 9) & (n % 2 == 1 | n % 7 == 0))
                .Select (n => n*n);

            int sum = powers.Sum();
            int len = powers.Count();
            int first = powers.First();
            int last = powers.Last();

            Console.WriteLine($"Sum: {sum}, Length: {len} \nFirst element: {first} \nLast element: {last}");

            PrintList(powers);
        }

        static void PrintList(IEnumerable<int> list)
        {
            Console.WriteLine("Sprawdzenie:");
            foreach (int n in list)
            {
                Console.WriteLine(n);
            }
        }
    }
}
