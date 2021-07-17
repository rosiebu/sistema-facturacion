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
    public partial class FrmVendedor : Form
    {
        SqlConnection con = null;
        public FrmVendedor()
        {
            InitializeComponent();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }
        private void ejecutarConsulta()
        {
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-NTBUCGO\\INSTANCIA1;Initial Catalog=SISTEMAFACTURACION;Integrated Security=True");
                con.Open();
                string sql = "select * from Vendedor ";
                sql += "where " + CbxCriterio.Text + " like '%" + TxtABuscar.Text + "%'";
                sql += " order by " + CbxCriterio.Text;
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DgvVendedores.DataSource = dt;
                DgvVendedores.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta " + ex.Message);
            }
        }



        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmEdVendedor frm = new FrmEdVendedor();
            frm.Modo = "C";
            frm.con = con;

            frm.ShowDialog();
        }

        private void FrmVendedores_Activated(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }

        private void DgvVendedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DgvVendedores.SelectedRows[0];
                FrmEdVendedor frm = new FrmEdVendedor();
                frm.ID = row.Cells[0].Value.ToString();
                frm.Nombre = row.Cells[1].Value.ToString();
                frm.Comision = row.Cells[2].Value.ToString();
                frm.Estado = row.Cells[3].Value.ToString();
                frm.Modo = "U";
                frm.con = con;
                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el registro. " + ex.Message);
            }
        }
        private void FrmVendedores_Load(object sender, EventArgs e)
        {
            CbxCriterio.SelectedIndex = 0;
            ejecutarConsulta();
        }
    }
}
