using System;

namespace num2
{
    class Program
    {
        static String Repeat(String stringToRepeat, int times)
        {
            var builder = new System.Text.StringBuilder(times * stringToRepeat.Length);
            for (int i = 0; i < times; i++)
            {
                builder.Append(stringToRepeat);
            }
            return builder.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину лестницы: ");
            int length = Convert.ToInt32(Console.ReadLine());
            
            if (length == 0 || length < 0)
            {
                Console.WriteLine("К сожалению это невозможно");
            } else
            {
                String gridSymbol = "#";
                String whitespace = " ";

                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(Repeat(whitespace, length - i) + gridSymbol);
                    gridSymbol += "#";
                }
            }

            Console.ReadKey();
        }
    }
}
