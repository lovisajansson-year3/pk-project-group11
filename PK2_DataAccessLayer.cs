using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g11assignment1
{
    class PK2_DataAccessLayer
    {
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        string conString = @"Data Source =uwdb18.srv.lu.se\ICSSQL001;Initial Catalog =SYSA14_PK_ProgAssignment2;User ID =sysa14reader; Password=INFreader1";
        //returnerar table med tablesofinterest
        public DataTable DisplayTable()
        {
            string sqlstr = "select * from TablesOfInterest";
            SqlDataReader dR = null;
            DataTable dt = new DataTable();
            using (sqlCon = new SqlConnection(conString))
            {
                try
                {
                    sqlCon.Open();
                    sqlCmd = new SqlCommand(sqlstr, sqlCon);
                    using (dR = sqlCmd.ExecuteReader())

                        dt.Load(dR);

                }
                catch (SqlException e) { Console.WriteLine(e.ToString()); }
            }
            return dt;
        }
        public DataTable DisplayMetadata(string table)
        {
            string sqlstr = "select column_name as 'Column names' from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME=";
            sqlstr += $"'{table}'";
            SqlDataReader dR = null;
            DataTable dt = new DataTable();
            using (sqlCon = new SqlConnection(conString))
            {
                try
                {
                    sqlCon.Open();
                    sqlCmd = new SqlCommand(sqlstr, sqlCon);
                    using (dR = sqlCmd.ExecuteReader())

                        dt.Load(dR);

                }
                catch (SqlException e) { Console.WriteLine(e.ToString()); }
            }
            return dt;
        }
        public DataTable DisplayRows(string table)
        {
            string sqlstr = "select count(*) as 'Number of Rows' from ";
            sqlstr += $"{table}";
            SqlDataReader dR = null;
            DataTable dt = new DataTable();
            using (sqlCon = new SqlConnection(conString))
            {
                try
                {
                    sqlCon.Open();
                    sqlCmd = new SqlCommand(sqlstr, sqlCon);
                    using (dR = sqlCmd.ExecuteReader())

                        dt.Load(dR);

                }
                catch (SqlException e) { Console.WriteLine(e.ToString()); }
            }
            return dt;
        }
    }
}


//select column_name from information_schema.columns where table_name = $