using System;
using System.IO;
using System.Text;

namespace FileIO
{
    class ReadingDirectories
    {
        public void ReadingDirectoriesMethod() 
        {
            string rootpath = @"E:\Temp\Demos\FileSystem";
            string[] files1 = Directory.GetDirectories(rootpath, "*", SearchOption.AllDirectories);
            foreach (string file in files1)
            {
                Console.WriteLine(file);
            }

        }

    }
}
