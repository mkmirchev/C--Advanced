using System;
using System.IO;

class CopyBinaryFile
{
    static void Main()
    {
        FileStream input = new FileStream(@"D:\Mirchev\SoftUni\Advanced-C#\06.StreamsAndFiles\04.CopyBinaryFile\picture.jpg",FileMode.Open);
        FileStream copy = new FileStream(@"D:\Mirchev\SoftUni\Advanced-C#\06.StreamsAndFiles\04.CopyBinaryFile\picture(copy).jpg", FileMode.Create);
        using (input)
        {
            using (copy)
            {
                byte[] buffer = new byte[4096];
                while (true)
                {
                    int reader = input.Read(buffer, 0, buffer.Length);
                    if (reader == 0) 
                    {
                        break;
                    }
                    copy.Write(buffer, 0, buffer.Length);
                }
            }
        }
        input.Close();
        copy.Close();
    }
}
