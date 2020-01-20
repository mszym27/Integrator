using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Integrator
{
    public class Class_Data
    {
        private SqlConnection conn_MsSQL = null;
        private SqlCommand comd_MsSQL = null;
        public SqlDataReader read_MsSQL = null;
        private SqlDataAdapter adap_MsSQL = null;
        public DataSet ds_MsSQL = new DataSet();
        public string error_db = null;

        public void Connect_MsSQL(string host, string port, string dbname, string login, string pass)
        {
            error_db = null;

            try
            {
                conn_MsSQL = new SqlConnection("Data Source=" + host + "," + port + "; Database=" + dbname + "; User ID=" + login + "; Password=" + pass);
                conn_MsSQL.Open();
            }
            catch (SqlException ex)
            {
                error_db = ex.Message;
            }
        }

        public bool isOpen_MsSQL()
        {
            bool test = false;
            error_db = null;

            try
            {
                if (conn_MsSQL != null)
                {
                    if (conn_MsSQL.State == ConnectionState.Open)
                    {
                        test = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                error_db = ex.Message;
            }

            return test;
        }

        public void Close_MsSQL()
        {
            error_db = null;
            try
            {
                if (conn_MsSQL != null)
                {
                    if (conn_MsSQL.State == ConnectionState.Open)
                    {
                        conn_MsSQL.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                error_db = ex.Message;
            }
        }

        //zapełniam Data Set

        public void DS_MsSQL(string query, string tabname)
        {
            error_db = null;

            try
            {
                //usuwam jeśli już była pobrana
                if (ds_MsSQL.Tables.IndexOf(tabname) != -1)
                {
                    ds_MsSQL.Tables.Remove(tabname);
                }

                comd_MsSQL = new SqlCommand(query, conn_MsSQL);
                adap_MsSQL = new SqlDataAdapter(comd_MsSQL.CommandText, conn_MsSQL);
                adap_MsSQL.Fill(ds_MsSQL, tabname);
                adap_MsSQL.Dispose();
            }
            catch (SqlException ex)
            {
                error_db = ex.Message;
            }
        }

        //zapełniam Reader

        public void Read_MsSQL(string query)
        {
            error_db = null;

            try
            {
                comd_MsSQL = new SqlCommand(query, conn_MsSQL);
                read_MsSQL = comd_MsSQL.ExecuteReader();
            }
            catch (SqlException ex)
            {
                error_db = ex.Message;

                if (!read_MsSQL.IsClosed)
                {
                    read_MsSQL.Close();
                }
            }
        }

        //update, insert

        public int Noread_MsSQL(string query)
        {
            error_db = null;
            int id = 0;

            try
            {
                comd_MsSQL = new SqlCommand(query, conn_MsSQL);
                id = comd_MsSQL.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                error_db = ex.Message;

                if (!read_MsSQL.IsClosed)
                {
                    read_MsSQL.Close();
                }
            }

            return id;
        }

        //tutaj mogę wydostać inta (,,id") informującego o obecności rekordu w tabeli

        public int Scalarread_MsSQL(string query)
        {
            error_db = null;
            int id = 0;

            try
            {
                comd_MsSQL = new SqlCommand(query, conn_MsSQL);
                id = Convert.ToInt32(comd_MsSQL.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                error_db = ex.Message;

                if (!read_MsSQL.IsClosed)
                {
                    read_MsSQL.Close();
                }
            }

            return id;
        }
    }
}
