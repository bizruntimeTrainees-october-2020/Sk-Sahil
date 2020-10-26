using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIO
{
    class CopyFiles
    {
        public void CopyFilesMehod() 
        {
            string rootpath = @"E:\Temp\Demos\FileSystem";
            string[] files = Directory.GetFiles(rootpath);
            string destinationpath = @"E:\Temp\Demos\FileSystem\SubFolderA\";
            foreach (string file in files)
            {
                try
                {
                    File.Copy(file, $"{destinationpath}{Path.GetFileName(file)}", true);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }

            //it generates files by number names

            //for (int i = 0; i < files.Length; i++) 
            //{
            //    File.Copy(files[i], $"{destinationpath}{i}.txt",true);
            //}
        }
    }
}
