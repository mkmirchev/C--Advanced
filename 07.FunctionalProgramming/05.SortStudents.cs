using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class SortStudents
{
    static void Main(string[] args)
    {
        StudentDirectory database = new StudentDirectory();
        var sortedStudents = database.Students.OrderByDescending(firstName => firstName.FirstName).ThenBy(lastname => lastname.LastName);
        Console.WriteLine("Sorted by using of Lambda expression");
        Console.WriteLine();
        foreach (var student in sortedStudents)
        {
            Console.WriteLine("{0} {1} {2}",student.FirstName, student.LastName, student.FacultyNumber);
        }
        var sortStudentsQuery = database.Students.SortStudentsQuery();
        Console.WriteLine();
        Console.WriteLine("Sorted by using of LINQ Query");
        Console.WriteLine();
        foreach (var student in sortStudentsQuery)
        {
            Console.WriteLine("{0} {1} {2}",student.FirstName, student.LastName, student.FacultyNumber);
        }
    }

    public static List<Student> SortStudentsQuery(this List<Student> database)
    {
        var sortStudentsQuery = 
            from student in database
            orderby student.FirstName descending, 
                    student.LastName descending
            select student;
        return sortStudentsQuery.ToList();                        
    }
}

