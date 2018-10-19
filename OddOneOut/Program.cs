using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOneOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraysize = GetNumbers("What size do you want your array? Must be larger than zero.");
            int[] arrayOfInt = new int[arraysize];

            for (int i = 1; i < (arrayOfInt.Length+1); i++)
            {
                arrayOfInt[i-1] = i;
            }

            for (int i = 0; i < (arrayOfInt.Length ); i++)
            {
                Console.WriteLine(arrayOfInt[i]);
            }
            Console.WriteLine($"The sum of the odd numbers in this array are {getSum(arrayOfInt)}.");
            Console.WriteLine($"The average of the odd numbers in this array are {getAverage(arrayOfInt)}.");


        }


        static int GetNumbers(string message)
        {
            int number;
            Console.WriteLine(message);
            while (!int.TryParse(Console.ReadLine(), out number) || number < 1)
            {
                Console.WriteLine($"Invalid! Try again! {message}");
            }
            return number;
        }
        static string getUsernumbers(string message)
        {
            int number;
            Console.Write(message);

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("That is not a number! " + message);
            }
            return number.ToString();
        }
        static int getSum(Array array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length+1; i++)
            {
                if (i == 1 )
                {
                    sum = sum + 1;
                }
                else if (i %2 == 1)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
        static int getAverage(Array array)
        {
            int count = 0;
            int sum = 0;
            for (int i = 1; i < array.Length + 1; i++)
            {
                if (i == 1)
                {
                    sum = sum + 1;
                    count++;
                }
                else if (i % 2 == 1)
                {
                    sum = sum + i;
                    count++;
                }
            }
            return sum/count;
        }


    }
}
