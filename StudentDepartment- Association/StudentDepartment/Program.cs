using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDepartment
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("Computer Science", "CS");
            Department d2 = new Department("Electrical Engg.", "EEE");
            Student s1 = new Student("Rahim Kabir", "18-78969-2", 3.6f);
            Student s2 = new Student("Abdul Haque", "18-78768-2", 3.2f);
            Student s3 = new Student("Abul Kalam", "18-76754-2", 2.9f);

            d1.AddStudent(s1, s2, s3);
            s1.Department = d1;
            s2.Department = d1;
            s3.Department = d1;
            s1.Department.ShowInfo();
            d2.AddStudent(s3);

            d1.AllStudent();
            Console.WriteLine("***********************");
            d2.AllStudent();

        }
    }
}
