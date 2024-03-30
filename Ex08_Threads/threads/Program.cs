using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Threading;

namespace ex8;
class Program
{
    public static void Main()
    {
        var filePath = "C:\\Users\\FILIP\\Documents\\Studia\\5\\C-sharp_assignments\\Ex08_Threads\\threads\\ping.txt";
        var list = readFile(filePath);

        var time1 = ex1(list);
        var time2 = ex2(list);
        var time3 = ex3(list);
        Console.WriteLine($"Czas wykonania sekwencyjnego: {time1} ms");
        Console.WriteLine($"Czas wykonania równoległego z użyciem AllParallel: {time2} ms");
        Console.WriteLine($"Czas wykonania równoległego z użyciem Tasków: {time3} ms");
    }


    public static List<string[]> readFile(string filePath)
    {
        List<string> server = File.ReadAllLines(filePath).ToList();
        List<string[]> servers = server.Select(p => p.Split(';')).ToList();
        servers.RemoveAt(0);
        
        return servers;
    }

    public static long ex1(List<string[]> servers)
    {
        Stopwatch sequentialWatch = Stopwatch.StartNew();
        Pings.SequentialPing(servers);
        sequentialWatch.Stop();
        return sequentialWatch.ElapsedMilliseconds;
    }
    public static long ex2(List<string[]> servers)
    {
        Stopwatch sequentialWatch = Stopwatch.StartNew();
        Pings.ParallelPingAsParallel(servers);
        sequentialWatch.Stop();
        return sequentialWatch.ElapsedMilliseconds;
    }
    public static long ex3(List<string[]> servers)
    {
        Stopwatch sequentialWatch = Stopwatch.StartNew();
        Pings.ParallelPingTasks(servers);
        sequentialWatch.Stop();
        return sequentialWatch.ElapsedMilliseconds;
    }
}

