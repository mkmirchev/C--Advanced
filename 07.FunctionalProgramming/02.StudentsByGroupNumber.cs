using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDataBase;

namespace StudentDataBase
{
    class StudentsByGroupNumber
    {
        static void Main()
        {
            StudentDirectory database = new StudentDirectory();
            var studentByGroupQuery =
                    from student in database.Students
                    orderby student.FirstName
                    group student by student.GroupNumber
                        into studentGroup
                        where studentGroup.Key == 11
                        select studentGroup;
            PrintStudentByGroup(studentByGroupQuery);
        }

        public static void PrintStudentByGroup<T>(IEnumerable<IGrouping<T, Student>> studentByGroupQuery)
        {
            foreach (var group in studentByGroupQuery)
            {
                Console.WriteLine("Group: {0}", @group.Key);
                foreach (var student in @group)
                {
                    Console.WriteLine("Name: {0} {1}, Age: {2}, Faculty Number: {3} " +
                                  "\n\tPhone: {4}, Email: {5} \n\tGrades: {{{6}}}",
                    student.FirstName, student.LastName, student.Age, student.FacultyNumber,
                    student.Phone, student.Email, string.Join(", ", student.Marks));
                }
            }
        }
    }
}
