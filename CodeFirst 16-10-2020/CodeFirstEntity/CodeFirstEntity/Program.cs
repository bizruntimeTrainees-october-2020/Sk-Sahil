using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntity
{


    public class Post
    {
        public int Postid { get; set; }
        public DateTime datePublish { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public class BlogDbContext : DbContext 
    {
        public DbSet<Post> Posts { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
