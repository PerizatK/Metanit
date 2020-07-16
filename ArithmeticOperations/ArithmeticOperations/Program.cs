using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 4;
            //int num2 = 5;
            //int num3 = 15;
            //int num4 = 10;
            //int num5 = 5;
            //int result = 12;

            //result += num1 * num2 + num3 % num4 / num5; // 12 + result;
            //Console.WriteLine(result);

            //short a = -32769;
            //Console.WriteLine(a);

            /////////Условные конструкции. Упражнение 1.
            //Console.WriteLine("Please input first number to compare");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please input second number to compare");
            //int b = Convert.ToInt32(Console.ReadLine());

            //string mes;

            //if (a>b)
            //{
            //    mes = $"{a} is more then {b}"; 
            //}
            //else if (a<b)
            //{
            //    mes = $"{b} is more then {a}";
            //}
            //else mes = "This two numbers are equal";

            //Console.WriteLine(mes);
            //Console.ReadKey();


            //Условные конструкции. Упражнение 2.
            //string mes;

            //Console.WriteLine("please enter the number to compare");
            //int a = Convert.ToInt32(Console.ReadLine());

            //mes = (a > 5 && a < 10) ? $"{a} more than 5 and less than 10" : $"{a} is unknown number";
            //Console.WriteLine(mes);
            //Console.ReadKey();

            ////Условные конструкции. Упражнение 3.
            //Console.WriteLine("please enter the number to compare");
            //int a = Convert.ToInt32(Console.ReadLine());

            //string mes = ((a == 5) || (a == 10)) ? $"{a} equals to 5 or 10" : $"{a} is unknown number";
            //Console.WriteLine(mes);
            //Console.ReadKey();

            ////Условные конструкции. Упражнение 4-5.
            //Console.WriteLine("please enter the number to compare");
            //double a = Convert.ToDouble(Console.ReadLine());
            ////int b;

            //if (a < 100)
            //{
            //    a = a + a * 0.05;
            //}
            //else if (a >= 100 && a <= 200)
            //{
            //    a = a + a * 0.07;
            //}
            //else a = a + a * 0.1;

            //Console.WriteLine(a + 15);
            //Console.ReadKey();

            //Условные конструкции. Упражнение 6.
            //Console.WriteLine("please enter umber of operation you would like to use: \n 1 = + \n 2 = - \n 3 = * ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //string mes;
            //switch (number)
            //{
            //    case 1:
            //        mes = "Addition (+)";
            //        break;
            //    case 2:
            //        mes = "Subtraction (-)";
            //        break;
            //    case 3:
            //        mes = "Multiplication (*)";
            //        break;
            //    default:
            //        mes = "unknown number entered";
            //        break;
            //}
            //Console.WriteLine(mes);
            //Console.ReadKey();


            //Условные конструкции. Упражнение 7.

            Console.WriteLine("please enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter umber of operation you would like to use: \n 1 = + \n 2 = - \n 3 = * ");
            int number = Convert.ToInt32(Console.ReadLine());

            string mes;
            switch (number)
            {
                case 1:
                    mes = "Addition (+) -- " + Convert.ToString(num1 + num2);
                    break;
                case 2:
                    mes = "Subtraction (-) -- " + Convert.ToString(num1 - num2);
                    break;
                case 3:
                    mes = "Multiplication (*) -- " + Convert.ToString(num1 * num2);
                    break;
                default:
                    mes = "unknown number entered";
                    break;
            }
            Console.WriteLine(mes);
            Console.ReadKey();
        }
    }
}
