using System.IO;
using System.Linq;

namespace StudentDataBase
{
    public class ClassStudent
    {
        public static void Main()
        {
            StudentDirectory database = new StudentDirectory();
            database.Students.PrintStudentsInfo();
        }
    }
}
