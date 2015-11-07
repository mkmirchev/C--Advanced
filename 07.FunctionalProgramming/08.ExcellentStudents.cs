using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDataBase;

    static class ExcellentStudents
    {
        static void Main()
        {
            StudentDirectory database = new StudentDirectory();
            var exellentStudents = from student in database.Students
                                   where student.Marks.Contains(6)
                                   select new { fullName = string.Join(" ", student.FirstName, student.LastName), marks = string.Join(" ", student.Marks) };
            foreach (var student in exellentStudents)
            {
                Console.WriteLine("Name: {0} , Grades: {{{1}}}", student.fullName, student.marks);
            }
          
        }     
    }

