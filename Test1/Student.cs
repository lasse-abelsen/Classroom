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
        }

        public int ClassLevel { get; set; }

        //se teacher.cs for guid
        public Guid ID;

    }
}
