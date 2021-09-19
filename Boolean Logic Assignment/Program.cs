using System;


namespace Boolean_Logic_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Car Insurance Application");
            Console.WriteLine("What is your age");
            string age = Console.ReadLine();
            int age1 = Int32.Parse(age);
            Console.WriteLine("Never had a DUI before? True or False");
            string DUI = Console.ReadLine();
            bool noDUI = bool.Parse(DUI);
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int tickets1 = Int32.Parse(tickets);
            bool Qualified = (age1 > 15 && noDUI && tickets1 <= 3);
            Console.WriteLine("Are you qualified?");
            Console.WriteLine(Qualified);
            Console.ReadLine();

        }
    }
}
