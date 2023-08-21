namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.WriteLine("How many students in course A");
            int n = int.Parse(Console.ReadLine()); 
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("student " + i);
                int code = int.Parse(Console.ReadLine());
                courseA.Add(code);
            }


            Console.WriteLine("How many students in course B");
            int nb = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nb; i++)
            {
                Console.WriteLine("student " + i);
                int code = int.Parse(Console.ReadLine());
                courseB.Add(code);
            }

            Console.WriteLine("How many students in course C");
            int nc = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nc; i++)
            {
                Console.WriteLine("student " + i);
                int code = int.Parse(Console.ReadLine());
                courseC.Add(code);
            }

            // uniaoWith exclui os repetidos
            // quando tentei somar todos os counts de cada hashset ele contou com os repetidos
            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);
            Console.WriteLine("Total students: " + all.Count);
        }
    }
}