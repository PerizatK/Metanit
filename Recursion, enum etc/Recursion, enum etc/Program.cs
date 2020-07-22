using System;

namespace Recursion__enum_etc
{

    //class Program
    //{
    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Here is Fibonacci number");
    //    for (int i = 0; i < 30; i++)
    //    {
    //        Console.Write($"{FibonacciNumber(i)}  ");
    //    }

    //    Console.ReadKey();
    //}

    //static int FibonacciNumber(int n)
    //{
    //    if (n == 0 || n==1)
    //    {

    //        return n;
    //    }
    //    else
    //    {
    //        return FibonacciNumber(n - 1) + FibonacciNumber(n - 2);
    //    }
    //}
    //}

    //class Program
    //{
    //    enum Operation
    //    {
    //        Add = 1,
    //        Substract,
    //        Multiply,
    //        Divide
    //    }
    //    static void Main(string[] args)
    //    {
    //        Operation op;
    //        double num1, num2;
    //        Console.WriteLine("Please enter first number");
    //        num1 = Convert.ToDouble(Console.ReadLine());

    //        Console.WriteLine("Please enter second number");
    //        num2 = Convert.ToDouble(Console.ReadLine());

    //        MathOperations(num1, num2, Operation.Add);
    //        MathOperations(num1, num2, Operation.Divide);
    //        MathOperations(num1, num2, Operation.Multiply);
    //        MathOperations(num1, num2, Operation.Substract);

    //        Console.ReadKey();
    //    }

    //    static void MathOperations(double x, double y, Operation op)
    //    {
    //        double result = 0.0;

    //        switch (op)
    //        {
    //            case Operation.Add:
    //                result = x + y;
    //                break;
    //            case Operation.Divide:
    //                result = x - y;
    //                break;
    //            case Operation.Multiply:
    //                result = x * y;
    //                break;
    //            case Operation.Substract:
    //                result = x / y;
    //                break;
    //        }

    //        Console.WriteLine("{0} operation result equals to {1}", op, result);

    //    }
    //}
    //class Programm
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine(Convert.ToByte(254));
    //        Console.ReadKey();
    //    }
    //}

    //кортежи
    class Programm
    {
        static void Main(string[] args)
        {
            var (name, age) = GetTuple(("Perizat", 29), 10);
            Console.WriteLine(name);
            Console.WriteLine(age);
            
            Console.Read();
        }

        private static (string name, int age) GetTuple((string n, int a) tuple, int x)
        {
            var result = (name: tuple.n, age: tuple.a + x);
            return result;
        }
    }
}
