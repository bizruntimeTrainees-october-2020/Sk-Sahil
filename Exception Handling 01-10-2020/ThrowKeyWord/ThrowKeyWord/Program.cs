using System;

namespace ThrowKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = null;

            try
            {
                PrintStudentName(std);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           

           
        }

        private static void PrintStudentName(Student std)
        {
            if (std == null)
                throw new NullReferenceException("Student object is null.");

            Console.WriteLine("I am not reachable");
        }
    }
    class Student
    {
       public String StudentName { get; set; }

    }
}
