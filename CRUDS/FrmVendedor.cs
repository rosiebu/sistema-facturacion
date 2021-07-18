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

        Connection conection = new Connection();

        string table = "Vendedor";

        public FrmVendedor()
        {
            InitializeComponent();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
            
        }
        private void buscar()
        {
            DataTable dt = conection.ejecutarConsulta(table, CbxCriterio.Text, TxtABuscar.Text);
            DgvVendedores.DataSource = dt;
            DgvVendedores.Refresh();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmEdVendedor frm = new FrmEdVendedor();
            frm.Modo = "C";
            frm.con = conection.con;

            frm.ShowDialog();
        }

        private void FrmVendedores_Activated(object sender, EventArgs e)
        {
            buscar();
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
                frm.con = conection.con;
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
            buscar();
        }
    }
}
