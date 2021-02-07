using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student1
    {
        private string name;
        private string id;
        private string department;
        private float cgpa;

        public Student1() 
        {
        }
            public Student1(string name, string id, string department, float cgpa)
            {
                this.name = name;
                this.id = id;
                this.department = department;
                this.cgpa = cgpa;
            }
        internal void ShowInfo()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Id:" + id);
            Console.WriteLine("Department:" + department);
            Console.WriteLine("Cgpa:" + cgpa);
        }
        
    
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        } 
        public float Cgpa
        {
            get
            {
                return cgpa;
            }
            set
            {
                cgpa = value;
            }
        }
    }
    class Main1
    {
        static void Main(string[]args)
        {
            Student1 s = new Student1();
            Student1 s1 = new Student1("Ahmed Rahim", "27-36920-1", "Physics", 3.27f);
            s1.ShowInfo();
        }
    }
}
