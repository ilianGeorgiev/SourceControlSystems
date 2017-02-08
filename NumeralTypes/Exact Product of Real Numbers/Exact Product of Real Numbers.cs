using System;

namespace Exact_Product_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());

            decimal product = 0;

            for (int i = 0; i < n; i++)
                product *= decimal.Parse(Console.ReadLine());
            Console.WriteLine(product);
        }
    }
}
