using System;


namespace Circle_Perimeter__12_Digits_Precision_
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f12}",2 * Math.PI * radius);
        }
    }
}
