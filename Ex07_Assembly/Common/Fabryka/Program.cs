using Common;

using System.Reflection;

namespace Fabryka
{
    public class ProcesWykonywalny
    {
        static void Main(string[] args)
        {
            foreach (var argument in args)
            {
                string[] parts = argument.Split(';');
                if (parts.Length == 2)
                {
                    string assemblyPath = parts[0];
                    string orderTitle = parts[1];

                    LoadAndRunProcessor(assemblyPath, orderTitle);
                }
                else
                {
                    Console.WriteLine($"Invalid argument format: {argument}");
                }
            }
        }

        static void LoadAndRunProcessor(string assemblyPath, string orderTitle)
        {
            try
            {
                Assembly assembly = Assembly.LoadFrom(assemblyPath);

                foreach (Type type in assembly.GetTypes())
                {
                    if (type.GetInterface("Izlecenie") != null)
                    {
                        dynamic processor = Activator.CreateInstance(type);
                        processor.Tytul = orderTitle;
                        processor.Process();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading or running processor from {assemblyPath}: {ex.Message}");
            }
        }
    }
}
