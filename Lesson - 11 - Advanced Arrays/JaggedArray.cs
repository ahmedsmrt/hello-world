// using System;

// namespace JaggedArray
// {
//     // An array within an array
//     class JaggedArray 
//     {
//         static void Main(string[] args)
//         {
//             // Declare jagged array
//             int[][] jaggedArray = new int[3][];

//             jaggedArray[0] = new int[5];
//             jaggedArray[1] = new int[3];
//             jaggedArray[2] = new int[2];   

//             jaggedArray[0] = new int[] {2,3,4,5,6};
//             jaggedArray[1] = new int[] {12,15,33};      
//             jaggedArray[2] = new int[] {47,98};     
            
//             // alt way
//             int[][] jaggedArrayTwo = new int[][]
//             {
//                 new int[] {2,3,5,12,5},
//                 new int[] {99 , 33, 14}
//             };

//             System.Console.WriteLine("The value in the middle of the first entry is {0}", jaggedArrayTwo[0][2]);
//         }
//     }
// }
