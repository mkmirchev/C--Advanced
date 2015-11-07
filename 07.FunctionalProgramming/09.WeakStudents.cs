using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDataBase;

static class WeakStudents
{
    static void Main()
    {
        StudentDirectory database = new StudentDirectory();
        var sortWeakStudents = database.Students.SortWeakStudents();
        foreach (var student in sortWeakStudents)
        {
            Console.WriteLine(student.FirstName + " "+ string.Join(" ", student.Marks));
        }

    }
    public static List<Student> SortWeakStudents(this List<Student> database)
    {
        var sortWeakStudents = from student in database
                           where (student.Marks.Count( x => x == 2 ) == 2)
                           select student;

        return sortWeakStudents.ToList();
    }
}

