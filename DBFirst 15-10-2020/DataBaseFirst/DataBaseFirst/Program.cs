using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DBFirstEntityEntities();
            var post = new Post()
            {

                //PostId = 1,
               DatePublish = DateTime.Now,
               Title="This is title",
                Body = "This is body",
              
            };
            try
            {
                context.Posts.Add(post);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            Console.WriteLine("successful...!");
            Console.ReadLine();
        }
    }
}
