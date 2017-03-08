using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());

            var numberRaisedToPower = RaiseToPower(number, power);
            Console.WriteLine(numberRaisedToPower);
        }

        static double RaiseToPower(double num, int power)
        {
            var result = 1d;

            for (int i = 0; i < power; i++)
            {
                result *= num;
            }

            return result;
        }
    }
}
