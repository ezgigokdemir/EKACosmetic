using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKAKozmetik
{
    static class SqlRunner
    {
        public static string manager = ConfigurationManager.ConnectionStrings["ekaConnection"].ConnectionString;
        
        public static DataTable SQLSorguCalistir(string sql)
        {
            SqlConnection connection = null;
            DataTable data = new DataTable();

            try
            {
                connection = new SqlConnection(manager);
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                data.Load(command.ExecuteReader());
            }
            catch (Exception e)
            {
                throw new Exception("Sorgu çalıştırılamadı : " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return data;
        }

        public static int NonSorguCalistir(string sql)
        {
            SqlConnection connection = null;
            int result = -1;

            try
            {
                connection = new SqlConnection(manager);
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public static ArrayList SqlDataReader(string sql,string column)
        {
            SqlConnection connection = null;
            SqlDataReader dr = null;
            ArrayList drArrayList = new ArrayList();
            
            try
            {
                connection = new SqlConnection(manager);
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    drArrayList.Add(dr[column]);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Sorgu çalıştırılamadı : " + e.Message);
            }
            finally
            {
                dr.Close();
                connection.Close();
            }
            return drArrayList;
        }
    }
}
