using System;
using System.Linq;
using System.Linq.Expressions;
using System.Linq.Dynamic.Core;

namespace dynLinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var values = new[] { -1, 2, 3, 4, 5, 6, 10 }.AsQueryable();

            var result = values.Where("it = 2").ToArray();

            foreach (var r in result)
                Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
