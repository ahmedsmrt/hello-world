using System;

namespace Program
{
    class Program 
    {
        static void Main(string[] args)
        {
            // Define the size of the array
            int size = 5;
            
            // Initialize the array
            string[] friendList = new string[size];

            // Prompt the user to input names and greet each friend
            for (int i = 0; i < size; i++)
            {
                Console.Write("Please put in your friend's name: ");
                string friend = Console.ReadLine();
                friendList[i] = friend;
                Console.WriteLine($"Hey {friend}, how've you been fam!");
            }
        }
    }
}
