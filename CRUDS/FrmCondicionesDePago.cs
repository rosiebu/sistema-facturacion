using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUDS
{
    public partial class FrmCondicionesDePago : Form
    {
        public SqlConnection con = null;
        public FrmCondicionesDePago()
        {
            InitializeComponent();
            CbxCriterio.SelectedIndex = 0;
            ejecutarConsulta();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            
            FrmCondicionesDePagos frm = new FrmCondicionesDePagos();
            frm.con = con;
            frm.ShowDialog();
            
        }
        private void ejecutarConsulta()
        {
                string myCnStr = Properties.Settings.Default.SISTEMAFACTURACIONConnectionString;
                try
                {
                    con = new SqlConnection(myCnStr);
                    con.Open();
                    string sql = "select * from CondicionesDePago ";
                    sql += "where " + CbxCriterio.Text + " like '%" + TxtABuscar.Text + "%'";
                    sql += " order by " + CbxCriterio.Text;
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DgvCondicionesDePago.DataSource = dt;
                    DgvCondicionesDePago.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la consulta " + ex.Message);
                }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }
    }
}
