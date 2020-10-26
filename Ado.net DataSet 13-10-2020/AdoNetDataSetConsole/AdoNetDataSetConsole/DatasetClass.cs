using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace AdoNetDataSetConsole
{
    class DatasetClass
    {
        DataTable dt;
        DataColumn dc;
        DataRow dr;
        DataSet ds;

        
        public DataTable GetEmployeTable()
        {
            dt = new DataTable("Employee");
            //employee tab region

            dc = new DataColumn("eId", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };
            dc = new DataColumn("eName", typeof(string));
            dt.Columns.Add(dc);
            dc = new DataColumn("dId", typeof(int));
            dt.Columns.Add(dc);


            //add rows

            dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = "Thiago Messi";
            dr[2] = 10;
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr[0] = 2;
            dr[1] = "Chritiano jr";
            dr[2] = 15;
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr[0] = 3;
            dr[1] = "Chettri jr";
            dr[2] = 20;
            dt.Rows.Add(dr);



            return dt;
        }
        public DataTable GetDepartmentTable()
        {
            dt = new DataTable("Department");
            //dept tab region

            dc = new DataColumn("dId", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };
            dc = new DataColumn("eName", typeof(string));
            dt.Columns.Add(dc);
            //add rows

            dr = dt.NewRow();
            dr[0] = 10;
            dr[1] = "Hr Dept";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 20;
            dr[1] = "Technical Dept";
            dt.Rows.Add(dr);


            return dt;
        }
        public DataSet GenerateDataSet()
        {
            DataTable emp = GetEmployeTable();
            DataTable dept = GetDepartmentTable();
            ds = new DataSet("MYDS");
            ds.Tables.Add(emp);
            ds.Tables.Add(dept);

            //creating relationships
           
                DataColumn col_pk = ds.Tables["Department"].Columns["dId"];
                DataColumn col_fk = ds.Tables["Employee"].Columns["dId"];
                DataRelation drel = new DataRelation("Emp_Dept_relation", col_pk, col_fk);
            try
            {
                ds.Relations.Add(drel);

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return ds;
        }

       
       
        
   
    }
}
