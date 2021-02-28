using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDepartment1
{
    class Department
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private Student[] students;

        public Department()
        {
            students = new Student[60];
        }

        public Department(string name, string id)
        {
            this.name = name;
            this.id = id;
            students = new Student[60];
        }

        public void AddStudent(params Student[] arrStudent)
        {
            foreach (var s in arrStudent)
            {
                students[studentCount++] = s;
                s.Department = this;
            }
        }

        public void AllStudent()
        {
            /*foreach(Student s in students) {
                s.ShowInfo();
            }*/
        }
    }
}
