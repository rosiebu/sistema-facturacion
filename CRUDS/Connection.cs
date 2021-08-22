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

        public dynamic getMany2oneId(string table, string whereColumn, string match = "null", string clause="=", string selectColumn="id")
        {
            try
            {
                string query = "SELECT "+ selectColumn +" FROM " + table + " where " + whereColumn + " " + clause + " '" + match +"'";
                Console.WriteLine(query);
                con.Open();
                SqlCommand cursor = new SqlCommand(query, con);
                SqlDataReader reader = cursor.ExecuteReader();
                dynamic res = false;
                while (reader.Read())
                {
                    res = (dynamic)reader[0];
                }
                reader.Close();
                con.Close();
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta " + ex.Message);
                return 0;
            }
        }
        public string getLastIdOnTable(string table) {
            try
            {
                string query = "SELECT TOP 1 " + "id" + " From " + table + " Order by id desc;";
                SqlCommand cursor = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cursor.ExecuteReader();
                string id = "";
                
                reader.Read();
                id = reader[0].ToString();
                
                reader.Close();
                con.Close();
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta " + ex.Message);
                return "";
            }
        }
        public void executeNonQuery(string query) {
            try { 
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registro guardado exitosamente");
            } catch (Exception ex) {
                MessageBox.Show("Error al guardar. " + ex.Message);
            }
        }
    }
}
