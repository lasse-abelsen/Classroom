using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public abstract class Person
    {
        public Person(string fName, string lName, string cMail)
        {
            FirstName = fName;
            LastName = lName;
            ContactMail = cMail;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactMail { get; set; }
    }
}
