using System;

namespace IDealWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            User user;

            do
            {
                Console.WriteLine("Please enter your age");
                user.age = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Please enter your height");
                user.height = Int32.Parse(Console.ReadLine());

                user.DisplayInfo();

                Console.WriteLine("Try one more time? \n Yes: Y, No: N");
                
                if (Console.ReadLine() == "N")
                { 
                    break;
                }
                    }
            while (1 == 1);


            Console.ReadKey();
        }

        struct User
        {
            public int age;
            public int height;

            public void DisplayInfo()
            {
                int weight;
                if (age < 40)
                {
                    weight = height - 110;
                }
                else
                {
                    weight = height - 100;
                }
                Console.WriteLine($"Your ideal weight equals to {weight}");
            }

        }
    }
}
