using System;


namespace Exchange_Variable_Values
{
   public class Program
    {
       public static void Main()
        {
            int a, b, temp;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            temp = a;
            a = b;
            b = temp;
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
