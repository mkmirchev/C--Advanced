using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDataBase;

    static class FilterStudentsByPhone
    {
        static void Main()
        {
            
            StudentDirectory database = new StudentDirectory();
            var sortByPhone = database.Students.SortByPhone();
            Print.PrintStudentsInfo(sortByPhone);

        }
        public static List<Student> SortByPhone(this List<Student> database)
        { 
            var sortByPhone = from student in database
                              where student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") || student.Phone.StartsWith("+359 2")
                              select student;
            return sortByPhone.ToList();
        }
    }

