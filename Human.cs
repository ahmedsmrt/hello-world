using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBasics
{
    class Human
    {
        public string firstName;
        
        // Member Method
        public void IntroduceMyself()
        {
            Console.WriteLine($"Hi i'm {firstName}, what's good with you!");
        }
    }
}