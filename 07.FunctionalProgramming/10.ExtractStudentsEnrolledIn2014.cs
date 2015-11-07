using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDataBase;

class ExtractStudentsEnrolledIn2014
{
    static void Main()
    {
        StudentDirectory database = new StudentDirectory();
        var studentsEnrolled = from student in database.Students
                               where ((student.FacultyNumber / 1000) % 100) == 14
                               select student;
        Print.PrintStudentsInfo(studentsEnrolled);

    }
}

