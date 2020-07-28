using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;

namespace CountDays__OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Count person = new Count { name = "Perizat", year = 1990, month = 7, day = 30 };
            //person.runMethod();

            new Count();
            Console.ReadKey();
        }
    }

    class Count
    {
        public String name;
        public int year;
        public int month;
        public int day;

        public Count()
        {
            name = "Perizat";
            year = 1990;
            month = 7;
            day = 30;

            runMethod();
        }

        public void runMethod()
        {
            getAmountOfDays();
            while (1 == 1)
            {
                Console.WriteLine("Please enter your name");
                this.name = Console.ReadLine();

                Console.WriteLine("Please enter your year of birth");
                this.year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter your month of birth");
                this.month = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter your day of birth");
                this.day = Convert.ToInt32(Console.ReadLine());

                getAmountOfDays();

                Console.WriteLine("\n\n Try one more time: Yes: Y, NO: N?");
                if (Console.ReadLine() == "N")
                {
                    break;
                }
            }
        }

        private void getAmountOfDays()
        {
            System.DateTime birthdate = new System.DateTime(year, month, day, 0, 0, 0);
            System.TimeSpan diff = DateTime.Now - birthdate;

            Console.WriteLine($"Dear {name} you were born {birthdate}. \n" +
            $"For now ({DateTime.Now}) you lived on the Earth {diff.Days} days");
        }
    }
}
