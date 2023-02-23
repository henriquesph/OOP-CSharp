using Aula131.Entities;
using System.Security.Cryptography;

namespace Aula131
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow, that's awesome!");
            
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling new Zeland",
                "I'm going to visit this wonderful country",
                15
                );
            p1.AddComment(c1);
            p1.AddComment(c2);


            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force with you");

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "good night guys",
                "see you tomorrow",
                5
                );
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}