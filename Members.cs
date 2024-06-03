using System;
using System.Diagnostics;

namespace MembersC
{
    class Members 
    {
        // member private fields
        private string memberName;
        private string jobTitle;
        private int salary;

        // member public fields
        public int age;
        // member property exposes jobTitle variable safely - Props naming starts with capital letter
        public string JobTitle { get; set; }

        // public member Method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if(isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                System.Console.WriteLine("My name is {0}, my job title is {1}. I'm {2} years old", memberName, jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            System.Console.WriteLine("My salary is {0}", salary);
        }

        // member constructor
        public Members()
        {
            age = 31;
            memberName = "Xavier";
            salary = 195000;
            jobTitle = "Developer";
            System.Console.WriteLine("Object created");
        }

        // member - finalizer - destructor
        ~Members()
        {
            // Cleans up statements
            System.Console.WriteLine("Deconstruction of Members object.");
            Debug.Write("Deconstruction of Members object.");
        }

    }
}
