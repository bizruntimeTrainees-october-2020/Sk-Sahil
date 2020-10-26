using System;
using System.IO;
namespace LogPrograms
{
  interface LogBase
    {
        public  void Log(string Messege);
    }
   public class Logger: LogBase
    {
        private string CurrentDirectory { get; set; }
        private string FileName { get; set; }
        private string FilePath { get; set; }
        public Logger()
        {
            this.CurrentDirectory = Directory.GetCurrentDirectory();
            this.FileName = "log.txt";
            this.FilePath = this.CurrentDirectory + "/" + this.FileName;

        }

        public  void Log(string Messege)
        {
            using (System.IO.StreamWriter sw = System.IO.File.AppendText(this.FilePath)) 
            {
                sw.Write("\r\n Log Entry:");
                sw.WriteLine("{0}{1}",DateTime.Now.ToLongTimeString(),DateTime.Now.ToLongDateString());
                sw.WriteLine("{0}", Messege);

            }
           

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            logger.Log("This is an");
            logger.Log("logfille");
        }
    }
}
