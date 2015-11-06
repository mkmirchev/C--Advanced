using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataBase
{
    public static class StudentsByFirstAndLastName
    {
        public static void Main()
        {
            StudentDirectory database = new StudentDirectory();
            var studentsByNames = database.Students.StudentsByNames();
            PrintStudentsByNames(studentsByNames);                                          
        }

        
        public static List<Student> StudentsByNames(this List<Student> database)
        {
            var studentsByNames =
                from student in database
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;
            return studentsByNames.ToList();
        }

        private static void PrintStudentsByNames(IEnumerable<Student> studentsQuery)
        {
            foreach (var student in studentsQuery)
            {
                Console.WriteLine("{0} {1}",student.FirstName, student.LastName);
            }
        }
    }
}
