using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i > 0; i--)
                Console.WriteLine("Hello World!");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please enter your age ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are an Adult");
            }
            else
            {
                Console.WriteLine("You are a Child");
            }
            Console.ReadLine();
        }
    }
}