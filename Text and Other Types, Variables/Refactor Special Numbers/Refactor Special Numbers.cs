using System;


namespace Refactor_Special_Numbers
{
   public class Program
    {
       public static void Main(string[] args)
        {

            int maxNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentNumbera = 0;
            bool toe = false;
            for (int ch = 1; ch <= kolkko; ch++)
            {
                currentNumbera = ch;
                while (ch > 0)
                {
                    obshto += ch % 10;
                    ch = ch / 10;
                }
                toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
                Console.WriteLine($"{currentNumbera} -> {toe}");
                obshto = 0;
                ch = currentNumbera;
            }

        }
    }
}
