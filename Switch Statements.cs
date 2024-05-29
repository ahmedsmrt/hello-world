using System;

namespace LoginSystemProg
{
    class Program 
    {
        static void Main(string[] args)
        {               
            int age = 25;
            switch(age)
            {
                case 15:
                    Console.WriteLine("Too young to go clerbin!");
                    break;
                case 25:
                    Console.WriteLine("Have fun at the clerb!");
                    break;
                default
                    Console.WriteLine("Damn you must be hella old");
                    break;
            }
        }
    }
}
