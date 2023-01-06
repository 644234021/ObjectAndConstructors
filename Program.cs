using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAndConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1= new Student();
            stu1.setStudentName("Perapat");
            //stu1.studentId = "644234021";
            //stu1.studentName = "Perapat";
            //stu1.studentAge = 20;
            //stu1.studentCourse = "Computer Science";

            Student stu2 = new Student("0000001","Somsom","Com",21);
            //stu2.studentId = "0000001";
            //stu2.studentName = "Cat";
            //stu2.studentAge = 2;
            //stu2.studentCourse = "Computer Science";

            stu1.SaySomething();
            stu2.SaySomething();
            Console.ReadLine();
        }
    }
}
