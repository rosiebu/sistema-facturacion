using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDS
{
    public partial class FrmCliente : Form
    {
        public int Rol { get; set; }


        Connection conection = new Connection();

        string table = "cliente";

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CbxCriterio.SelectedIndex = 0;
            buscar();
        }

        

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmEdCliente frm = new FrmEdCliente();
            frm.Modo = "C";
            frm.con = conection.con;
            frm.ShowDialog();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            buscar();
        }
        private void FrmClientes_Activated(object sender, EventArgs e)
        {
            buscar();
        }
        private void buscar()
        {
            DataTable dt = conection.ejecutarConsulta(table, CbxCriterio.Text, TxtABuscar.Text);
            DgvClientes.DataSource = dt;
            DgvClientes.Refresh();
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
                frm.con = conection.con;
                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el registro. " + ex.Message);
            }
        }
    }
}


