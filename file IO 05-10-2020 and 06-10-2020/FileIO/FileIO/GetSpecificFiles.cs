using Aspose.Cells;
using System;
using System.IO;
using System.Text;

namespace FileIO
{
    class GetSpecificFiles
    {
        public void GetSpecificFilesMethod() 
        {
            string rootpath = @"E:\Temp\Demos\FileSystem";
            var files = Directory.GetFiles(rootpath, "*.*", SearchOption.AllDirectories);
            foreach (string file in files) 
            {
                Console.WriteLine(file);
            }
        
        }
    }
}
