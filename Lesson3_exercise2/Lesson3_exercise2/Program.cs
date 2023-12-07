using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John Walton", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin Herick", Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill Anderson", Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram Morgan" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron Alexander" , Age = 15 }
};
                // Check the age of each student
            var teenAgerStudent = studentList.Where(s => s.Age > 12 && s.Age < 20);
          
            Console.WriteLine("Teen age Students:");
            foreach (Student std in teenAgerStudent)
            {
                Console.WriteLine(std.StudentName);
            }
            //Check name length of each student
            var TeenStudentName = studentList.Where(a => a.StudentName.Length > 11);
            Console.WriteLine(" Student name lenght :");
            foreach (Student student in TeenStudentName)
            {
                Console.WriteLine(student.StudentName);
            }
            //Check Student ID which is odd number or even number 
            var StudentEvenOddID = studentList.Where(id  => id.StudentID %  2 == 0);
            Console.WriteLine(" Student even ID:");
            foreach (Student studentid in StudentEvenOddID)
            {
                Console.WriteLine(studentid.StudentName);
            }
        }
    }
}
