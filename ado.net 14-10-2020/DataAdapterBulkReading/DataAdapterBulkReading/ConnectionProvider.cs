using System;
using System.Data.SqlClient;
using System.Text;

namespace DataAdapterBulkReading
{
    class ConnectionProvider
    {
        public SqlConnection GetConnection() 
        {

            SqlConnection con = null;
            try
            {
                string connectionString = "data source=.; database=BizRun; integrated security=SSPI";
                con = new SqlConnection(connectionString);
                con.Open();
                Console.WriteLine("Connection Established");

            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }

            return con;
        }
    }
}
