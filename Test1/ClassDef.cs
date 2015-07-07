using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class ClassDef
    {
        public event EventHandler GoalReached;

        public ClassDef(string cName, int mAttendants)
        {
            ID = Guid.NewGuid();
            ClassName = cName;
            MinAttendants = mAttendants;
            Hosts = new List<Teacher>();
            Students = new List<Student>();
        }

        public Guid ID;
        public string ClassName { get; set; }
        public int MinAttendants { get; set; }
        public List<Teacher> Hosts { get; set; }
        public List<Student> Students { get; set; }

        public void AddTeacherToClass(Teacher teacher)
        {
            if(!Hosts.Contains(teacher))
            {
                Hosts.Add(teacher);
            }
        }

        public void RemoveTeacher(Teacher teacher)
        {
            if (Hosts.Contains(teacher))
            {
                Hosts.Remove(teacher);
            }
        }

        public void AddStudentToClass(Student stud)
        {
            if(!Students.Contains(stud))
            {
                Students.Add(stud);
            }
            if(Students.Count == MinAttendants)
            {
                OnGoalReached();
            }
        }

        public void RemoveStudent(Student stud)
        {
            if(Students.Contains(stud))
            {
                Students.Remove(stud);
            }
        }

        public void OnGoalReached()
        {
            if (GoalReached != null)
            {
                GoalReached(this, EventArgs.Empty);
            }
        }
    }
}
