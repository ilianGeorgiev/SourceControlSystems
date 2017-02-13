using System;


namespace Refactor_Volume_of_Pyramid
{
   public class Program
    {
        public static void Main()
        {

            double sum = 0;
            //double length = double.Parse(Console.ReadLine());
            //Console.Write("Length: ");

            double width = double.Parse(Console.ReadLine());
            Console.Write("Width: ");

            double heigth = double.Parse(Console.ReadLine());
            Console.Write("Height: ");

            sum = (width + heigth)/3;
            Console.WriteLine("Pyramid Volume: {0:F2}", sum);


        }
    }
}
