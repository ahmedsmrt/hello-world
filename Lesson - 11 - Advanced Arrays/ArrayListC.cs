// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace ArrayListC
// {
//     class Program 
//     {
//         static void Main(string[] args)
//         {
//             // Declaring an array list
//             ArrayList myArrayList = new ArrayList();
//             ArrayList myArrayList2 = new ArrayList(100);

//             myArrayList.Add(25);
//             myArrayList.Add("hello");
//             myArrayList.Add(13.37);
//             myArrayList.Add(13);
//             myArrayList.Add(253);
//             myArrayList.Add(25.3);

//             // Deletes specific entry
//             myArrayList.Remove(13);

//             // Deletes entry at specified index
//             myArrayList.RemoveAt(0); 

//             System.Console.WriteLine(myArrayList.Count);

//             double sum = 0;

//             foreach (object obj in myArrayList)
//             {
//                 if(obj is int)
//                 {
//                     sum += Convert.ToDouble(obj);
//                 }else if(obj is double)
//                 {
//                     sum += (double)obj;
//                 }else if (obj is string)
//                 {
//                     System.Console.WriteLine(obj);
//                 }
//             };

//             System.Console.WriteLine(sum);
//         }
//     }
// }
