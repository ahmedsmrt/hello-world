using System;

namespace Program
{
    class Program 
    {

        static int[,] matrix = 
        {
            {1,2,3}, // row 0
            {4,5,6}, // row 1
            {7,8,9}  // row 2
        };


        static void Main(string[] args)
        {
            foreach (int item in matrix)
            {
                System.Console.Write(item + " ");
            }

            System.Console.WriteLine("\nThis is our 2d array being printed using a nested for loop.");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    System.Console.Write(matrix[i,j] + " ");
                }
            }
        }
    }
}
