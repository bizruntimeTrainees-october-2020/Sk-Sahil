using System;
using System.Data;

namespace AdoNetDataSetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DatasetClass dsc = new DatasetClass();
            DataTable dataTable1= dsc.GetEmployeTable();
           DataTable dataTable2= dsc.GetDepartmentTable();
           DataSet dataSet= dsc.GenerateDataSet();


            //printing dataset
            
                foreach (DataTable table in dataSet.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        foreach (DataColumn column in table.Columns)
                        {
                            Console.WriteLine(row[column]);
                        }
                    }
                }




        }
    }
}
