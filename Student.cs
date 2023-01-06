using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAndConstructors
{
    internal class Student
    {
        String studentId;
        String studentName;
        int studentAge;
        String studentCourse;
        
        //Constructor คือ Method ที่ชื่่อเหมือน Class ทำงานเมื่อมีการสร้าง Object ใหม่ของ Class ขึ้นมา
        public Student()
        {
            studentId = "0000000";
            studentName = "Unknown";
            studentCourse = "Unknown";
            studentAge = 0;
        }

        //Constructor
        public Student(String id,String name,String course,int age)
        {
            studentId = id;
            studentName = name;
            studentCourse = course;
            studentAge = age;
        }
        public void setStudentName(String name)
        {
            studentName = name;
        }

        public void SaySomething()
        {
            Console.WriteLine("Good Morning, My name is {0}.", studentName);
            Console.WriteLine("I'm {0} years old. My student ID is {1}.", studentAge, studentId);
            Console.WriteLine("I'm a {0} student at Songkhla Rajabhat University.", studentCourse);
            Console.WriteLine("-----------------------------------");
        }
    }
}
