using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDataBase;
using StudentsJoinedToSpecialties;

class StudentsToSpecialties
{
    public static void Main()
    {
        StudentDirectory studentDB = new StudentDirectory();
        SpecialtyDirectory specialtyDB = new SpecialtyDirectory();
        var specialtyQ = from student in studentDB.Students
                        orderby student.FirstName ascending, student.LastName ascending
                        join specialty in specialtyDB.specialies on student.FacultyNumber equals specialty.FacultyNumber
                        select new { student.FirstName, student.LastName, student.FacultyNumber, specialty.SpecialtyName };
        foreach (var student in specialtyQ)
        {
            Console.WriteLine("{0} {1} {2} {3}", student.FirstName, student.LastName, student.FacultyNumber, student.SpecialtyName);
        }               
                       
    }
}

