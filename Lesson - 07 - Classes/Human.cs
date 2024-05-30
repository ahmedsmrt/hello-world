// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace ClassesBasics
// {
//     class Human
//     {
//         // Since these variables are not being referenced or changed outside of the scope of this class there is no need for them to be public.
//         private string firstName;
//         private string lastName;
//         private string eyeColor;
//         private int age;



//         //  parameterized constructor

//         public Human(string firstName, string lastName, string eyeColor, int age)
//         {
//             this.firstName = firstName;
//             this.lastName = lastName;
//             this.eyeColor = eyeColor;
//             this.age = age;            
//         }
        
//         // Member Method
//         public void IntroduceMyself()
//         {
//             Console.WriteLine($"Hi i'm {firstName} {lastName}, I am {age} years old with {eyeColor} eyes! What's good with you!");
//         }
//     }
// }