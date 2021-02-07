using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Course1
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;

        public Course1()
        {
        }

        public Course1(string courseName, string courseCode, int courseCredit)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
        }

        internal void ShowCourseInfo()
        {
            Console.WriteLine("courseName:" + courseName);
            Console.WriteLine("courseCode:" + courseCode);
            Console.WriteLine("courseCredit:" + courseCredit);
        }

        public string CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                courseName = value;
            }
        }

        public string CourseCode
        {
            get
            {
                return courseCode;
            }
            set
            {
                courseCode = value;
            }
        }

        public int CourseCredit
        {
            get
            {
                return courseCredit;
            }
            set
            {
                courseCredit = value;
            }
        }

        class Main1
        {
            static void Main(string[] args)
            {
                Course1 c = new Course1();
                Course1 c1 = new Course1("Object Oriented Programming 2 (C#)", "CSC3115",3);
                c1.ShowCourseInfo();
            }
        }
    }
}
