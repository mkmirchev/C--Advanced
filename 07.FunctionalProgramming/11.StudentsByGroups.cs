using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDataBase;

class StudentsByGroups
{
    static void Main()
    {
        StudentDirectory database = new StudentDirectory();
        var studentByGroupsQuery = from student in database.Students
                                   group student by student.GroupName
                                       into specialties
                                       select specialties;
        foreach (var group in studentByGroupsQuery)
        {
            Console.WriteLine("{0}",group.Key);
            foreach (var student in group)
            {
                Console.WriteLine("{0} {1} {2}",student.FirstName, student.LastName, student.FacultyNumber);
            }
        }
                                       
    }
}

