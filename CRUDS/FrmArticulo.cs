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
    public partial class FrmArticulo : Form
    {
        SqlConnection con = null;
        public FrmArticulo()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }

        private void ejecutarConsulta()
        {
            string myCnStr = Properties.Settings.Default.SISTEMAFACTURACIONConnectionString;
            try
            {
                con = new SqlConnection(myCnStr);
                con.Open();
                string sql = "select * from Articulo ";
                sql += "where " + CbxCriterio.Text + " like '%" + TxtABuscar.Text + "%'";
                sql += " order by " + CbxCriterio.Text;
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DgvArticulos.DataSource = dt;
                DgvArticulos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta " + ex.Message);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmArticulos frm = new FrmArticulos();
            frm.Modo = "C";
            frm.con = con;
            frm.ShowDialog();
        }

        private void DgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DgvArticulos.SelectedRows[0];
                FrmArticulos frm = new FrmArticulos();
                frm.ID = row.Cells[0].Value.ToString();
                frm.descripcion = row.Cells[1].Value.ToString();
                frm.costoUnitario = float.Parse(row.Cells[2].Value.ToString());
                frm.precioUnitario = float.Parse(row.Cells[3].Value.ToString());
                frm.Estado = row.Cells[4].Value.ToString();
                frm.Modo = "U";
                frm.con = con;
                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el registro. " + ex.Message);
            }
        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            CbxCriterio.SelectedIndex = 0;
            ejecutarConsulta();
        }
    }
}
