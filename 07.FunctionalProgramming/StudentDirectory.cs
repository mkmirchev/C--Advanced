using System;
using System.Collections.Generic;

namespace StudentDataBase
{
    public class StudentDirectory
    {
        public List<Student> Students = CreateStudentDirectory();
        public static List<Student> CreateStudentDirectory()
        {
            var students = new List<Student>()
            {               
                new Student(),
                new Student(),   
                new Student(),
                new Student(),
                new Student()
            };
            return students;
        }
    }
}
