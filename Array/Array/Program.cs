using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] num1 = new int[] { 0, 1, 2, 3, 4, 5 };

            //foreach (int i in num1)
            //{
            //    Console.WriteLine(i);
            //}


            //int[,] num2 = new int[3, 4] { { 0, 1, 2, 5 }, { 0, 5, 2, 3 }, { 2, 11, 4, 5 } }; //трехмерный массив //int [ось y, ось x]
            //foreach (int j in num2)
            //{
            //    Console.WriteLine(j);
            //}

            //int[] num = { -4, -3, -2, -1, 0, 1, 2, 3, 4, };
            //int result = 0;
            //foreach (int number in num)
            //{
            //    if (number > 0)
            //    {
            //        result++;
            //       }

            //}
            //Console.WriteLine($"Amount of numbers higher than 0: {result}");

            //инверсия массива, переворот в обратном порядке.
            //int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

            //int n = numbers.Length;
            //int k = n / 2; //middle of array
            //int temp;

            //for (int i = 0; i<k; i++)
            //{
            //    temp = numbers[i];
            //    numbers[i] = numbers[n - i - 1];
            //    numbers[n - i - 1] = temp;
            //}

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            ///has to be like: 
            ///{{{1 , 2} , {3 , 4}}, 
            ///{{4 , 5} , {6 , 7}} ,
            ///{{7 , 8}, {9 , 10}} , 
            ///{{10 , 11} , {12 , 13}}}
            //int[,,] mas = { { { 1, 2 },{ 3, 4 } },
            //                { { 4, 5 }, { 6, 7 } },
            //                { { 7, 8 }, { 9, 10 } },
            //                { { 10, 11 }, { 12, 13 } } }; //двумерный массив

            //int x = mas.GetUpperBound(0) + 1;
            //int y = mas.GetUpperBound(1) + 1;
            //int z = mas.GetUpperBound(2) + 1;

            //Console.Write("{");
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        if (j == 0)
            //        {
            //            Console.Write("{");
            //        }

            //        for (int k = 0; k < z; k++)
            //        {
            //            if (k == 0)
            //            {
            //                Console.Write("{");
            //            }

            //            if (k < z && k != 0)
            //            {
            //                Console.Write(",");
            //            }

            //            Console.Write(mas[i, j, k]);

            //            if (k == z - 1)
            //            {
            //                Console.Write("}");
            //                if (k != j)
            //                {
            //                    Console.Write(",");
            //                }
            //            }
            //        }
            //        if (j == y - 1)
            //        {
            //            if (i == x - 1)
            //            {
            //                Console.Write("}");
            //            }
            //            else
            //                Console.Write("},");
            //            //if (j < y - 1)
            //            //{
            //            //    Console.Write(",");

            //            //}
            //        }
            //        //Console.Write($"i = {i}, j = {j}, x = {x}, y = {y}, z = {z}");
            //    }

            //}
            //Console.Write("}");

            //пузырьковая сортировка
            int[] nums = new int[7];
            Console.WriteLine("Please input 7 numbers to sorter");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{i + 1} number = ");
                nums[i] = Int32.Parse(Console.ReadLine());
            }

            int temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sort result:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            Console.ReadKey();
        }
    }
}

