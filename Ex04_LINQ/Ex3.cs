
namespace LINQ_
{
    internal class Ex3
    {

        public static void RunExcercise3()
        {
            ReadCityList(out var cityList);
            var sortedCityList = CityListToSortedDict(cityList);
            PrintCity(sortedCityList);
        }

        static void ReadCityList(out IEnumerable<string> cityList)
        {
            List<string> tempList = new();
            while (true)
            {
                string input = Console.ReadLine() ?? "X";
                if (input.ToUpper() == "X")
                {
                    break;
                }
                tempList.Add(input);
            }
            cityList= tempList;
        }

        static IDictionary<char, List<string>> CityListToSortedDict(IEnumerable<string> cityList)
        {
            IDictionary<char, List<string>> sorted = cityList
                .GroupBy        (city => city[0])
                .ToDictionary   (grouping => grouping.Key, grouping => grouping
                                                                    .OrderBy    (city => city)
                                                                    .ToList());
            return sorted;
        }

        static void PrintCity(IDictionary<char, List<string>> dict)
        {
            while (true)
            {
                string input = Console.ReadLine()?.ToUpper() ?? "X";
                if (input == "X")
                {
                    break;
                }
                if (dict.TryGetValue(input[0], out var cities)) { 
                    Console.WriteLine($"Miasta zaczynajace się na {input}");
                    foreach(var city in cities)
                    {
                        Console.WriteLine(city);
                    }
                }
                else
                {
                    Console.WriteLine("Nie ma żadnych miast na tą litere");
                }
            }
        }
        /*
        static IEnumerable<string> SortCityList(IEnumerable<string> cityList) {
            IEnumerable<string> sorted = cityList
                .GroupBy    (city => city[0])
                .OrderBy    (grouping => grouping.Key)
                .SelectMany (grouping => grouping
                    .OrderBy(city => city));
            return sorted;
        }
        */
    }
}
