using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Teacher : Person
    {
        public Teacher(string fname, string lname, string cmail = "No mail")
            :base(fname, lname, cmail)
        {
            ID = Guid.NewGuid();
            FirstName = fname;
            LastName = lname;
            ContactMail = cmail;
        }

        public List<ClassDef> ClassList { get; set; }

        //Guid = unique identifier, se fx https://msdn.microsoft.com/en-us/library/system.guid.newguid(v=vs.110).aspx
        private Guid ID;
    }
}
