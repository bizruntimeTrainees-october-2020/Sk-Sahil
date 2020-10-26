using System;

namespace DataAdapterBulkReading
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConnectionProvider cp = new ConnectionProvider();
            //cp.GetConnection();

            DataReading dataReading = new DataReading();
            dataReading.DataReadingByDataAdapter();
        }
    }
}
