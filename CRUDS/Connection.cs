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
                con = new SqlConnection(myCnStr);
                con.Open();
                string sql = "select * from "+ table;
                sql += " where " + criterio + " like '%" + aBuscar + "%'";
                sql += " order by " + criterio;
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta " + ex.Message);
                return new DataTable();
            }
        }


    }
}
