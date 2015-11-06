using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDataBase;

namespace StudentDataBase
{
    public static class StudentsByAges
    {
        public static void Main()
        { 
            StudentDirectory database = new StudentDirectory();
            var studentsByAge = database.Students.StudentsByAge();
            PrintStudentsByAge(studentsByAge);
        }

        public static void PrintStudentsByAge(List<Student> studentsByAge)
        {
            foreach (var student in studentsByAge)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Age);
            }
        }
        public static List<Student> StudentsByAge(this List<Student> database)
        {
            var studentsByAge =
                from students in database
                where students.Age >= 18 && students.Age <= 24
                select students;
            return studentsByAge.ToList();
        }
        
    }
    
}
