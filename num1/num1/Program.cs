using System;

namespace num1
{
    class Program
    {
        static int[] InitArray()
        {
            Console.WriteLine("Введите число элементов.");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];
            Console.WriteLine("Введите элементы массива через Enter.");

            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }

        static int CalculateOddsSum(int[] bum)
        {
            int sum = 0;
            for (int i = 0; i < bum.Length; i++)
            {
                if (bum[i] % 2 != 0)
                {
                    sum += bum[i];
                }
            }

            return sum;
        }

        static int CalculateEvensSum(int[] bum) {
            int sum = 0;
            for (int i = 0; i < bum.Length; i++)
            {
                if (bum[i] % 2 == 0)
                {
                    sum += bum[i];
                }
            }

            return sum;
        }

        static int[] BubbleSort(int[] bum)
        {
            int temp;
            for (int i = 0; i < bum.Length; i++)
            {
                for (int j = i + 1; j < bum.Length; j++)
                {
                    if (bum[i] > bum[j])
                    {
                        temp = bum[i];
                        bum[i] = bum[j];
                        bum[j] = temp;
                    }
                }
            }
            return bum;
        }

        static void PrintArray(int[] bum)
        {
            for (int i = 0; i < bum.Length; i++)
            {
                Console.Write(bum[i] + " ");
            }

        }

        static Boolean GetIsEven(String userInput) {
            String even = "четные";
            return even.Equals(userInput.ToLower());
        }

        static void Main(string[] args)
        {
            int[] bum = InitArray();
            Console.WriteLine("Введенный массив:");
            PrintArray(bum);

            bum = BubbleSort(bum);
            Console.WriteLine("\nОтсортированный массив:");
            PrintArray(bum);

            Console.WriteLine("\nВведите какие числа вам нужно сложить:");
            String str = Console.ReadLine();
            Boolean isEven = GetIsEven(str);
            int sum = isEven ? CalculateEvensSum(bum) : CalculateOddsSum(bum);
            Console.WriteLine("\nСумма: " + sum);

            Console.ReadKey();
        }
    }
 }
   

