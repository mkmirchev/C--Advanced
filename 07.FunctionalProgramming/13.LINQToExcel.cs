using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using OfficeOpenXml;

namespace LINQToExcel
{
    class LINQToExcelExample
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            List<Student> students = new List<Student>();
            string[] txtRow = new string[12];
            using (StreamReader txtRowReader = new StreamReader(@"../../Students-data.txt"))
            {
                txtRow = Regex.Split(txtRowReader.ReadLine().Trim(), @"\t"); //get the names of the columns
                while (txtRowReader.Peek() > -1) //add all rows with information about students in List<Students>
                {
                    string[] line = Regex.Split(txtRowReader.ReadLine().Trim(), @"\s");
                    students.Add(new Student(int.Parse(line[0]), line[1], line[2], line[3], line[4], line[5], int.Parse(line[6]), int.Parse(line[7]), int.Parse(line[8]), double.Parse(line[9]), int.Parse(line[10]), double.Parse(line[11])));
                    students.Last().CalculateResult();
                }
                txtRowReader.Close();
            }
            var getOnlineStudents = from student in students
                                    where student.StudentType.ToLower() == "online"
                                    orderby student.result descending
                                    select student;
            var getStudentResults = from std in getOnlineStudents
                                    orderby std.result descending
                                    select std.result;
            var pack = new ExcelPackage(new FileInfo("excelTest.xlsm"));
            var ws = pack.Workbook.Worksheets.Add("data");
            ws.SetValue("A1", "SoftUni OOP course results");
            ws.Cells["A1"].Style.Font.Size = 15;
            ws.Cells["A1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
            ws.Cells["A1"].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
            ws.Cells["A1:M2"].Merge = true;

            for (int i = 0; i < txtRow.Length; i++)
            {
                ws.Cells[3, 1 + i].Value = txtRow[i];

                ws.Cells[3, 13].Value = "Result";              
            }

            ws.Column(13).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            ws.Column(13).Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGreen);
            ws.Cells["A3:M3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            ws.Cells["A3:M3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Green);
            ws.Cells["A3:M3"].Style.Font.Color.SetColor(System.Drawing.Color.White);
            ws.Cells[4, 1].LoadFromCollection(getOnlineStudents);
            ws.Cells[4, 13].LoadFromCollection(getStudentResults);
            pack.SaveAs(new FileInfo(@"../../excelTest.xls"));
        }
    }
}

