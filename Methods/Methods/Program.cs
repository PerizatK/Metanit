using System;
namespace SortApp
{
    class Program
    {
        //        static void Main(string[] args)
        //        {
        //            //SayHello();
        //            //SayGoodbye();

        //            int x = 5;
        //            x++;
        //            ReturnXbyValue(x);
        //            ReturnXbyLink(ref x);
        //            ReturnXByOut(out x);
        //            Console.WriteLine($"{x} from Main");

        //            Console.ReadLine();
        //        }

        //        static void ReturnXbyValue(int x)
        //        {
        //            x++;
        //            Console.WriteLine($"{x} from method ReturnXbyValue");
        //        }

        //        static void ReturnXbyLink(ref int x)
        //        {
        //            x++;
        //            Console.WriteLine($"{x} from method ReturnXbyLink");
        //        }

        //        static void ReturnXByOut(out int x)
        //        {
        //            x = 0;
        //  
        //Console.WriteLine($"{x} from method ReturnXByOut");
        //static void Main(string[] args)
        //{
        //    int i = 0;
        //    Console.Write(i++ + Calculate(i));
        //    Console.WriteLine(i);

        //    Console.ReadKey();
        //}

        //public static int Calculate(int i)
        //{
        //    Console.Write(i++);
        //    return i;
        //}

        //// передача параметра с params
        //static void Addition(params int[] integers)
        //{
        //    int result = 0;
        //    for (int i = 0; i < integers.Length; i++)
        //    {
        //        result += integers[i] * 2;
        //    }
        //    Console.WriteLine(result);
        //}
        //// передача массива
        //static void AdditionMas(int[] integers, int k)
        //{
        //    int result = 0;
        //    for (int i = 0; i < integers.Length; i++)
        //    {
        //        result += (integers[i] * k);
        //    }
        //    Console.WriteLine(result);
        //}

        //static void Main(string[] args)
        //{
        //    Addition(1, 2, 3, 4, 5);

        //    int[] array = new int[] { 1, 2, 3, 4, 5 };
        //    AdditionMas(array, 2);

        //    Console.ReadLine();
        //}


        int x = 8;
        static void Main(string[] args)
        {
            int x = 9;

            {
                x++;
            }

            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}

