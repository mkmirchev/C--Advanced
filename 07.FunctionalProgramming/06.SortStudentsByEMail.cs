using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDataBase;

namespace SortStudentsByEMail
{    
    static class Program
    {
        static void Main(string[] args)
        {
            StudentDirectory dB = new StudentDirectory();
            string pattern = @"(?<=\w\@)abv\.bg?()";
            Regex rgx = new Regex(pattern);
            var abv = dB.Students.Where(email => rgx.IsMatch(email.Email));
            var abvEmails = from student in dB.Students
                            where rgx.IsMatch(student.Email)
                            select student;

            Console.WriteLine("Lambda");
            foreach (var student in abv)
            {                
                Console.WriteLine("{0} {1} {2}",student.FirstName, student.LastName, student.Email);
            }

            Console.WriteLine();
            Console.WriteLine("LINQ"");
            foreach (var student in abvEmails)
            {                               
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Email);
            }
        }
    }
}
