using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ////<variables>
            //Console.WriteLine("This is test programm. PLease input 'stest' variable value");
            //String stest = Console.ReadLine();
            //int itest = 5;
            //Console.WriteLine("variables stest + itest = " + stest + itest);
            ////</variables>

            ////<literals>
            //Console.WriteLine("literals" + 0b11); //двоичная форма
            //Console.WriteLine("literals 16x \t" + 0x0A);
            //Console.WriteLine("literals \t literals \n literals"); //\t табуляция
            ////</literals>

            ////<types>
            //Console.WriteLine($"stest: {stest}");
            ////</types>

            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите возраст");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите желаемую зарплату разработчика .Net в тенге");
            decimal salaryTng = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите курс тенге к доллару");
            decimal exchangeRatesDT = Convert.ToDecimal(Console.ReadLine());

            decimal salaryDollar;
            salaryDollar = salaryTng / exchangeRatesDT;
            Console.WriteLine("{0} {1} лет. {0} хочет быть .Net разработчиком и получать не менее {2}$", name, age, salaryDollar);

            Console.ReadKey();
        }
    }
}
