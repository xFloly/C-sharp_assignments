using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    internal class Pings
    {
        internal static void SequentialPing(List<string[]> servers)
        {
            foreach (var server in servers)
            {
                CheckServerAvailability(server);
            }
        }

        internal static void ParallelPingAsParallel(List<string[]> servers)
        {
            servers.AsParallel().WithDegreeOfParallelism(4).ForAll(server =>
            {
                CheckServerAvailability(server);
            });
        }

        internal static void ParallelPingTasks(List<string[]> servers)
        {
            var timeout = TimeSpan.FromMilliseconds(50);
            IEnumerator<string[]> serverEnumerator = servers.GetEnumerator();
            List<Task> tasks = new List<Task>();

            for (int numb_tasks = 0; numb_tasks < 4; numb_tasks++)
            {
                tasks.Add(Task.Run(async () =>
                {
                    string[] server;
                    while (true)
                    {
                        if (Monitor.TryEnter(serverEnumerator, timeout))
                        {
                            try
                            {
                                if (serverEnumerator.MoveNext())
                                {
                                    server = serverEnumerator.Current;
                                }
                                else
                                {
                                    return;
                                }
                            }
                            finally
                            {
                                Monitor.Exit(serverEnumerator);

                            }
                            CheckServerAvailability(server);
                        }
                    }
                }));
            }
            Task.WaitAll(tasks.ToArray());
        }

        static void CheckServerAvailability(string[] server)
        {
            var country = server[0];
            var address = server[1];

            Ping ping = new Ping();
            PingReply reply = ping.Send(address);

            Console.WriteLine($"Kraj: {country}, Adres: {address}, Dostępny: {reply.Status == IPStatus.Success}");
        }
    }
}
