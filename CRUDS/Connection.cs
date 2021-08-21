using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDS
{
    class Connection : Form
    {
        public static string myCnStr = Properties.Settings.Default.SISTEMAFACTURACIONConnectionString;

        public SqlConnection con = new SqlConnection(myCnStr);
        
        public DataTable ejecutarConsulta( string table , string criterio, string aBuscar)
        {
            
            try
            {
                con.Open();
                string sql = "select * from "+ table;
                sql += " where " + criterio + " like '%" + aBuscar + "%'";
                sql += " order by " + criterio;
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                return dt;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta " + ex.Message);
                return new DataTable();
            }
        }

        public string[] getMany2one(string table, string column = "id") 
        {
            try
            {
                string query = "SELECT " + column + " From " + table;
                SqlCommand cursor = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cursor.ExecuteReader();
                List<string> temp = new List<string>();
                while (reader.Read())
                {
                    temp.Add(reader[0].ToString());
                }
                string[] res = temp.ToArray();
                reader.Close();
                con.Close();
                return res;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta " + ex.Message);
                return new string[] {};
            }
                
        }

        public int getMany2oneId(string table, string whereColumn, string match = "null", string clause="=")
        {
            try
            {
                string query = "SELECT id FROM " + table + " where " + whereColumn + " " + clause + " '" + match +"'";
                Console.WriteLine(query);
                con.Open();
                SqlCommand cursor = new SqlCommand(query, con);
                SqlDataReader reader = cursor.ExecuteReader();
                int res = 0;
                while (reader.Read())
                {
                    res = (int)reader[0];
                }
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta " + ex.Message);
                return 0;
            }
        }
    }
}
