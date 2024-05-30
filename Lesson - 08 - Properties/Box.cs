// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Properties
// {
//     class Box
//     {
//         // Member Variables
//         private int length = 4;
//         // public int width;
//         private int height = 5;
//         public int volume;

//         // Short hand to create default getter and setter
//         public int Width { get; set; }


//         public int Height
//         {
//             get
//             {
//                 return height;
//             }
//             set
//             {
//                 height = value;
//             }
//         }

//         public void SetLength(int length)
//         {
//             this.length = length;
//         }

//         public int GetLength()
//         {
//             return this.length;
//         }

//         public void DisplayInfo()
//         {
//             Console.WriteLine($"Length {length}, Width {Width}, Height {height}, Volume {volume = length * Width * height}");
//         }


//     }
// }