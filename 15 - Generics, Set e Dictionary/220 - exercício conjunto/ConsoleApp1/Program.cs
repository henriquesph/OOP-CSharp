using System;
using System.IO;
using ConsoleApp1.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>(); // A ordem não interessa 

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        //string line = sr.ReadLine();
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { Username = name, Instant = instant }); // Semântica alternativa, poderia ter usado construtor na classe LogRecord;
                        // Se já nome igual no hashset, não será adicionado (Implementação do Equals na classe)
                    }
                    Console.WriteLine(set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}