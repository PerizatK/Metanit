using System;

namespace Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i<9;i++)
            //{
            //Console.WriteLine("Hello World!" + i);
            //}

            //int i = 0;
            //for (; i < 10;)
            //{
            //    Console.WriteLine($"2 в степени {++i} = {Math.Pow(2, i)}");
            //}

            //int i = -1;
            //do
            //{
            //    Console.WriteLine(i);
            //    --i;
            //}
            //while (i > 0);

            //int i = 6;
            //while (i>0 && i<15)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //decimal sumBegin, sumEnd ;
            //int totalMonth;

            //Console.WriteLine("Please enter save amount");
            //sumBegin = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine("Please enter month amount");
            //totalMonth = Convert.ToInt32(Console.ReadLine());

            //sumEnd = sumBegin;
            //for (int i = 1; i <= totalMonth; i++)
            //{
            //    sumEnd += sumEnd * 0.07m;
            //    Console.WriteLine($"deposit amount {sumBegin}, total month amount {totalMonth}, " +
            //        $"current month {i}, current deposit amount {sumEnd}");
            //}

            //Console.WriteLine("\n\n");

            //sumEnd = sumBegin;
            //int j = 1;
            //while (j <= totalMonth)
            //{
            //    sumEnd += sumEnd * 0.07m;
            //    Console.WriteLine($"deposit amount {sumBegin}, total month amount {totalMonth}, " +
            //        $"current month {j}, current deposit amount {sumEnd}");
            //    j++;
            //}
            //Console.WriteLine("\n\n");

            //for (int i = 1; i<=10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} * {j} = {i*j}");
            //    }
            //    Console.WriteLine("\n");
            //}

            while (true)
            {
                Console.WriteLine("Please input first number");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please input second number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10)
                {
                    Console.WriteLine("Inputed numbers are invalid. Please try again.");
                }
                else
                {
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                }
            }


            Console.ReadKey();
        }
    }
}
