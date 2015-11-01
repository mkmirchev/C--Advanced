using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class FullDirectoryTraversal
{
    static void Main()
    {
        string[] filePaths = Directory.GetFiles(@"../../", "*.*", SearchOption.AllDirectories);
        List<FileInfo> files = filePaths.Select(Path => new FileInfo(Path)).ToList();
        var sorter = files.OrderBy(file => file.Length).GroupBy(file => file.Extension).OrderByDescending(group => group.Count()).ThenBy(group => group.Key);
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        StreamWriter writer = new StreamWriter(desktop + "/report.txt");
        foreach (var group in sorter)
        {
            writer.WriteLine(group.Key);
            foreach (var y in group)
            {
                writer.WriteLine("--{0} - {1:F3}.kb", y.Name, y.Length / 1024.0);
            }
        }
        writer.Close();
        System.Diagnostics.Process.Start(desktop + "/report.txt");
    }
}

