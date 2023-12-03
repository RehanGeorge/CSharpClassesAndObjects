using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ClassesAndObjects
{
    internal class Student
    {
        private int Id;
        private string Name;
        private int GPA;

        public Student(int id, string name, int gpa)
        {
            Id = id;
            Name = name;
            GPA = gpa;
        }

        //Properties
        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }

        public string NAME
        {
            get { return Name; }
            set { Name = value; }
        }

        public int GRADE
        {
            get { return GPA; }
            set { GPA = value; }
        }
    }
}
