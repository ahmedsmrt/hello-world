// using System;

// namespace TryParseC
// {
//     class Program 
//     {
//         static void Main(string[] args)
//         {
//            Console.WriteLine("What's the temperature today?");
//            string temperature = Console.ReadLine();
//            int numTemp;
//            int number; 
//             if(int.TryParse(temperature, out number))
//             {
//                 numTemp = number;
//             }
//             else
//             {
//                 numTemp = 0;
//                 Console.WriteLine("Value entered was not a number.");      
//             }

//             if(numTemp < 20) 
//             {
//                 Console.WriteLine("Take a coat it's freezing!");
//             }
//             else if(numTemp == 20) 
//             {
//                 Console.WriteLine("Just put on a nice casual fit my boi.");
//             }
//             else if(numTemp > 30) 
//             {
//                 Console.WriteLine("It's hot as ballz!");
//             }
//             else
//             {
//                 Console.WriteLine("Put on them shorts that make you look like a zaddy!");
//             }      

//             Console.Read();                              

//         }
//     }
// }
