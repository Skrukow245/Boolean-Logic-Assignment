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
            int age1 = Int32.Parse(age);        //turning string into int
            Console.WriteLine("Never had a DUI before? True or False");
            string DUI = Console.ReadLine();
            bool noDUI = bool.Parse(DUI);   //turning string into bool
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int tickets1 = Int32.Parse(tickets);
            bool Qualified = (age1 > 15 && noDUI && tickets1 <= 3);  //using && to see if bool is correct
            Console.WriteLine("Are you qualified?");
            Console.WriteLine(Qualified);
            Console.ReadLine();

        }
    }
}
