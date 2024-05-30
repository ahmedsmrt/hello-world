using System;

namespace ClassesBasics
{
    class Program 
    {
        static void Main(string[] args)
        {               
           //How to create a new class
           Human ahmed = new Human();
           //Access public variable from external class
           ahmed.firstName = "Ahmed";
           ahmed.IntroduceMyself();

           Console.ReadKey(true);
        }
    }
}
