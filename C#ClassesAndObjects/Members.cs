using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ClassesAndObjects
{
    internal class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary = 50000;

        // member - public field
        public int age;

        public string JobTitle {
            get
            {
                return jobTitle;
            } set
            {
                jobTitle = value;
            }
        }

        // public member method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine($"Hi, my name is {memberName}, and my job title is {jobTitle}. I'm {age} years old.");
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}");
        }

        // member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucas";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        // member - finalizer/destructor
        ~Members()
        {
            // cleanup statements...
            Console.WriteLine("Deconstruction of Members object");
            Debug.Write("Destruction of Members object");
        }
    }
}
