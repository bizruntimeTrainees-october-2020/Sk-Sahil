using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace LINQ
{
    class LinqSortingOperator
    {
        public IEnumerable<object> studentsnameDecending { get; private set; }

        public void SortingOperatrors()
        {
            List<Students> studentsobject = new List<Students>(){
        new Students() { Name = "Suresh Dasari", Gender = "Male", Subjects = new List<string> { "Mathematics", "Physics" } },
        new Students() { Name = "Rohini Alavala", Gender = "Female", Subjects = new List<string> { "Entomology", "Botany" } },
        new Students() { Name = "Praveen Kumar", Gender = "Male", Subjects = new List<string> { "Computers", "Operating System", "Java" } },
        new Students() { Name = "Sateesh Chandra", Gender = "Male", Subjects = new List<string> { "English", "Social Studies", "Chemistry" } },
        new Students() { Name = "Madhav Sai", Gender = "Male", Subjects = new List<string> { "Accounting", "Charted" } }
        };

            //orderBy
            var studentsNameAscending = studentsobject.OrderBy(x => x.Name);
            foreach (var i in studentsNameAscending) 
            {
                Console.Write(i.Name+ " ");

                
            }

            Console.WriteLine();
            //orderBydecending

            var studentsnameDecending = studentsobject.OrderByDescending(x => x.Name);
            foreach (var i in studentsnameDecending) 
            {
                Console.Write(i.Name+ " ");
            }
            Console.WriteLine();

            //ThenBy

            var studentsbjectsThenBy = studentsobject.OrderBy(x => x.Name).ThenBy(x => x.Gender);
            foreach (var i in studentsbjectsThenBy) 
            {
                Console.Write(i.Name + " ");
                Console.Write(i.Gender + " ");
                Console.WriteLine();
            }

        }
     
     
    }
    class Students
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<string> Subjects { get; set; }
    }
}
