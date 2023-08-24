using System;
using System.Collections.Generic;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();

                    while(!sr.EndOfStream)
                    {
                        string[] votinRecord = sr.ReadLine().Split(',');
                        string candidate = votinRecord[0];
                        int votes = int.Parse(votinRecord[1]);

                        if(dictionary.ContainsKey(candidate))
                        {
                            dictionary[candidate] += votes;
                        }
                        else
                        {
                            dictionary[candidate] = votes;
                            //dictionary[candidate] = votes; também poderia ser usado, caso não tenha ele cria par chave/valor, diferente do de cima que daria erro ao adicionar uma chave já existente
                        }
                    }

                    foreach(var item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}