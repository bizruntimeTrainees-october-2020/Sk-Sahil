using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAdapterBulkReading
{
    class DataReading
    {
       
        public void DataReadingByDataAdapter()
        {
            //calling connection
            ConnectionProvider provider = new ConnectionProvider();
           SqlConnection con = provider.GetConnection();
          
                //populating data through adapter
            SqlDataAdapter adapter1 = new SqlDataAdapter("Select * from Employee", con);
            SqlDataAdapter adapter2 = new SqlDataAdapter("Select * from EmplpyeePerfomance", con);
            
            DataSet EmpDataSet = new DataSet();

            try
            {  
                //filling tables inside datasets

                adapter1.Fill(EmpDataSet, "Employee");
                adapter2.Fill(EmpDataSet, "EmplpyeePerfomance");



                DataRelation relation = EmpDataSet.Relations.Add("Child_parent_rel",
           EmpDataSet.Tables["Employee"].Columns["eId"],
           EmpDataSet.Tables["EmplpyeePerfomance"].Columns["eId"]);

            

                foreach (DataRow pRow in EmpDataSet.Tables["Employee"].Rows)
                {
                  Console.Write(pRow["eName"]+" ");
                    foreach (DataRow cRow in pRow.GetChildRows(relation))
                        Console.WriteLine("\t" + cRow["eRating"]);
                }
                


            }

           

            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally 
            {
                con.Close();
            }
           

        }
    }
}
