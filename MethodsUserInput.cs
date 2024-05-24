using System;

namespace HelloWorld
{
    class Program 
    {
        static void Main(string[] args)
        {
            Calculate();
        }  

        public static void Calculate()
        {

            Console.WriteLine("Please your arithmetic operation:");
            string operation = Console.ReadLine();

            Console.WriteLine("Please input your first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input your second number:");   
            int num2 = int.Parse(Console.ReadLine());
        
            if (operation == "Add") 
            {
                Console.WriteLine($"Your result is {Add(num1, num2)}, thank you for using this app.");
            } else if (operation == "Multiply")
            {
                Console.WriteLine($"Your result is {Multiply(num1, num2)}, thank you for using this app.");
            }
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }    

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }       
    }
}
