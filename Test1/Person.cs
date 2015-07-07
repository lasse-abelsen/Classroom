using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public abstract class Person
    {
        public Person(string fname, string lname, string cmail)
        {
            FirstName = fname;
            LastName = lname;
            ContactMail = cmail;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactMail { get; set; }
    }
}
