using System;

namespace HelloWorld
{
    class Program 
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific(args[0]);
            Console.Read(); // Waits for Enter key press before closing
        }

        // Access modifier (static) return type method name (param 1, param2)
        // Methods should only do one thing!
        public static void WriteSomething()
        {
            Console.WriteLine("I am called a method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
    }
}
