using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devdas_Chatterjee_EX03
{
    class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }

        // constructor
        public Student(string id, string name)
        {
            Name = name;
            ID = id;
        }

        public override string ToString()
        {
            return String.Format("\nID: {0}, Name:{1}", ID, Name);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Student))
                return false;
            return Equals((Student)obj);
        }

        public bool Equals(Student student)
        {
            if (ID == student.ID && Name == student.Name)
                return true;
            else
            {
                return false;
            }
        }
    }
}
