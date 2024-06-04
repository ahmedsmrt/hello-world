// using System;

// namespace Program
// {
//     class Program 
//     {
//         static void Main(string[] args)
//         {
//             //  Declare 2d array
//             string[,] matrix;

//             // Declare 3d array
//             int[,,] threeD;

//             int[,] array2d = new int[,]
//             {
//                 {1,2,3}, // row 0
//                 {4,5,6}, // row 1
//                 {7,8,9}  // row 2
//             };


//             string[,] array2dString = new string[3,2]
//             {
//                 {"one", "two"}, // row 0
//                 {"three", "four"}, // row 1
//                 {"five", "six"}  // row 2
//             };            

//             array2dString[2,1] = "turkey";

//             int dimensions = array2dString.Rank;

//             System.Console.WriteLine("Central value is {0}", array2d[2,0]);

//             System.Console.WriteLine("Central value is {0} and the rank is {1}", array2dString[2,1], dimensions);




//         }
//     }
// }
