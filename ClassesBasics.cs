using System;

namespace ClassesBasics
{
    class Program 
    {
        static void Main(string[] args)
        {               
           //How to create a new class
           Human ahmed = new Human("Ahmed", "Gasim", "Green", 32);
           Human zacharia = new Human("Zacharia", "Withers", "Black", 42);
           //Access public variable from external class
           ahmed.IntroduceMyself();
           zacharia.IntroduceMyself();

           Console.ReadKey(true);
        }
    }
}
