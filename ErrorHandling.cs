using System;

namespace TryAndCatchC
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string userInput = Console.ReadLine();
            

            int num1 = 5;
            int num2 = 0;

            int result;

            try
            {
                result = num1 / num2; 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
            }


            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct data type.");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Overflow Exception");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Argument Null Exception Exception");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }            

            Console.ReadKey();
        }     
    }
}
