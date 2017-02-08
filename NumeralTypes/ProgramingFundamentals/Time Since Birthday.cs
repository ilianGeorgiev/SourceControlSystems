
using System;

namespace ProgramingFundamentals
{
    class Program
    
    {
        static void Main(string[] args)
        {


            double years = double.Parse(Console.ReadLine());

            var days = years * 365;
            var hours = days * 24;
            var minutes = hours * 60;

            Console.WriteLine($"{years} years = {days} days = {hours} hours = {minutes} minutes.");
        }
    }
}