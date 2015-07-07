using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Student : Person
    {
        public Student(string fname, string lname, int clevel, string cmail = "No mail") : base(fname, lname, cmail)
        {
            ID = Guid.NewGuid();
            FirstName = fname;
            LastName = lname;
            ContactMail = cmail;
            ClassLevel = clevel;
            students.Add(this);
        }

        public int ClassLevel { get; set; }
        public static List<Student> students = new List<Student>();
        //se teacher.cs for guid
        public Guid ID;

    }
}
