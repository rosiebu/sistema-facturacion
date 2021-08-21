using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDS
{
    public partial class FrmClientes : Form
    {
        SqlConnection con = null;
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sISTEMAFACTURACIONDataSet);

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CbxCriterio.SelectedIndex = 0;
            ejecutarConsulta();
        }

        private void ejecutarConsulta()
        {
            string myCnStr = Properties.Settings.Default.SISTEMAFACTURACIONConnectionString;
            try
            {
                con = new SqlConnection(myCnStr);
                con.Open();
                string sql = "select * from Cliente ";
                sql += "where " + CbxCriterio.Text + " like '%" + TxtABuscar.Text + "%'";
                sql += " order by " + CbxCriterio.Text;
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DgvClientes.DataSource = dt;
                DgvClientes.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta " + ex.Message);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmEdCliente frm = new FrmEdCliente();
            frm.Modo = "C";
            frm.con = con;
            frm.ShowDialog();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }
        private void FrmClientes_Activated(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }

        private void DgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DgvClientes.SelectedRows[0];
                FrmEdCliente frm = new FrmEdCliente();
                frm.ID = row.Cells[0].Value.ToString();
                frm.Nombre = row.Cells[1].Value.ToString();
                frm.Apellido = row.Cells[2].Value.ToString();
                frm.No_Documento = row.Cells[3].Value.ToString();
                frm.Id_Condiciones_de_Pago = row.Cells[4].Value.ToString();
                frm.Modo = "U";
                frm.con = con;
                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el registro. " + ex.Message);
            }
        }

    }
}

