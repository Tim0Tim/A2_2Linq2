using System;
using System.Linq;
using System.Collections.Generic;

namespace A2_2_Linq2
{
    class Program
    {
        static void Main()
        {
            var cha = new List<char> ();
            Random rnd = new Random();

            for (int x = 0; x < 30; x++)
            {
                char thing = (char)rnd.Next('a', 'z');
                cha.Add(thing);
            }

            var abc =
                from e in cha
                orderby e ascending
                select e;

            Console.WriteLine("Acending\n{");
            foreach (var element in abc)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("}\n\n");

            var zyx =
                from e in cha
                orderby e descending
                select e;

            Console.WriteLine("Decending\n{");
            foreach(var element in zyx)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("}\n");

            var abcdi =
                from e in cha
                orderby e ascending
                select e;

            Console.WriteLine("distinct\n{");
            foreach( var element in abcdi.Distinct())
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("}");
        }
    }
}
