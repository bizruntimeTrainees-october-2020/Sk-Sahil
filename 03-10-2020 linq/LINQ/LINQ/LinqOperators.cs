using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace LINQ
{
    class LinqOperators
    {
        public void LinqOperatorMethods()
        {
            string[] countries = { "US", "UK", "India", "Russia", "China", "Australia", "Argentina" };
            List<string> result = countries.ToList();
            foreach (var i in result)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            string[] countriesArray = countries.ToArray();
            foreach (var i in countriesArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            List<Employee> objEmployee = new List<Employee>()
            {
                new Employee(){ Name="Akshay Tyagi", Department="IT", Country="India"},
                new Employee(){ Name="Vaishali Tyagi", Department="Marketing", Country="Australia"},
                new Employee(){ Name="Arpita Rai", Department="HR", Country="China"},
                new Employee(){ Name="Shubham Ratogi", Department="Sales", Country="USA"},
                new Employee(){ Name="Himanshu Tyagi", Department="Operations", Country="Canada"}
            };
            var emp = (from employee in objEmployee select employee).ToLookup(x => x.Department);
            Console.WriteLine("Grouping Employees by Department");
            foreach (var KeyValurPair in emp)
            {
                Console.WriteLine(KeyValurPair.Key);
                
                
                foreach (var item in emp[KeyValurPair.Key])
                {
                    Console.WriteLine("\t" + item.Name + "\t" + item.Department + "\t" + item.Country);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            ArrayList obj = new ArrayList();
            obj.Add("USA"); obj.Add("Australia"); obj.Add("UK"); obj.Add("India");
            IEnumerable<string> res = obj.Cast<string>();
            foreach (var i in res)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            ArrayList bl = new ArrayList();
            bl.Add("USA"); bl.Add("Australia"); bl.Add("UK"); bl.Add("India");bl.Add(1);bl.Add(2);
            IEnumerable<int> oftype = bl.OfType<int>();
            foreach (var item in oftype)
            {
                Console.Write(item+" ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            int[] NumArray = new int[] { 1, 2, 3, 4, 5 };
            var asenum = NumArray.AsEnumerable();
            foreach (var item in asenum)
            {
                Console.Write(item + " ");
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            List<Student> objStudent = new List<Student>()
            {
                new Student() { Id=1,Name = "Vinay Tyagi", Gender = "Male",Location="Chennai" },
                new Student() { Id=2,Name = "Vaishali Tyagi", Gender = "Female", Location="Chennai" },
                new Student() { Id=3,Name = "Montu Tyagi", Gender = "Male",Location="Bangalore" },
                new Student() { Id=4,Name = "Akshay Tyagi", Gender = "Male", Location ="Vizag"},
                new Student() { Id=5,Name = "Arpita Rai", Gender = "Male", Location="Nagpur"}
             };
            var student = objStudent.ToDictionary(x => x.Id, x => x.Name);
            foreach (var stud in student)
            {
                Console.WriteLine(stud.Key + "\t" + stud.Value);
            }





        }

    }
    class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Country { get; set; }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
    }
}
