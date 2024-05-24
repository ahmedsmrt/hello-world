// using System;

// public class NumberSwapper 
// {
//     public static void Main(string[] args)
//     {
//         if (args.Length > 1) 
//         {
//             // Parse the first two arguments to integers
//             if (int.TryParse(args[0], out int a) && int.TryParse(args[1], out int b))
//             {
//                 // Swap a and b
//                 int tempInt = a;
//                 a = b;
//                 b = tempInt;
                
//                 Console.WriteLine("a is: " + a + " and b is: " + b);
//             }
//             else
//             {
//                 Console.WriteLine("The first two arguments must be valid integers.");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Please provide at least two arguments.");
//         }
//     }
// }
