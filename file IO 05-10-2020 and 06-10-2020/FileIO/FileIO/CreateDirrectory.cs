using System;
using System.IO;
using System.Text;

namespace FileIO
{
    class CreateDirrectory
    {
        public void CreateDirMethod() 
        {
            string newpath = @"E:\Temp\Demos\FileSystem\subFolderD";
            bool directoryexist = Directory.Exists(newpath);
            if (directoryexist)
            {
                Console.WriteLine("directory exist");

            }
            else
            {
                Directory.CreateDirectory(newpath);

                Console.WriteLine("dirwectory created...!");
            }
        }
    }
}
