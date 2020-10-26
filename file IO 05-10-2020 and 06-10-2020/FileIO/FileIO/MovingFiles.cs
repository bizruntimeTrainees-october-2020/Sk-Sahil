using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIO
{
    class MovingFiles
    {
        public void MovingFilesMethod() 
        {
            string rootpath = @"E:\Temp\Demos\FileSystem";
            string[] files = Directory.GetFiles(rootpath);
            string destinationpath = @"E:\Temp\Demos\FileSystem\SubFolderA\";
            foreach (string file in files)
            {
                try
                {
                    File.Move(file, $"{destinationpath}{Path.GetFileName(file)}", true);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
