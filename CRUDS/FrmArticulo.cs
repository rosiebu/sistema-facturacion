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
    public partial class FrmArticulo : Form
    {
        public int Rol { get; set; }

        Connection conection = new Connection();

        string table = "Articulo";

        public FrmArticulo()
        {
            InitializeComponent();
            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            buscar();

            
            //ejecutarConsulta();
        }
        private void buscar()
        {
            DataTable dt = conection.ejecutarConsulta(table, CbxCriterio.Text, TxtABuscar.Text);
            DgvArticulo.DataSource = dt;
            DgvArticulo.Refresh();
        }
        

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmEdArticulo frm = new FrmEdArticulo();
            frm.Modo = "C";
            frm.con = conection.con;
            frm.ShowDialog();
        }



        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            if (Rol != 1)
            {
                BtnAgregar.Visible = false;
                BtnAgregar.Enabled = false;
            }
            CbxCriterio.SelectedIndex = 0;
            buscar();
        }

        private void DgvArticulo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DgvArticulo.SelectedRows[0];
                FrmEdArticulo frm = new FrmEdArticulo();
                frm.ID = row.Cells[0].Value.ToString();
                frm.descripcion = row.Cells[1].Value.ToString();
                frm.costoUnitario = float.Parse(row.Cells[2].Value.ToString());
                frm.precioUnitario = float.Parse(row.Cells[3].Value.ToString());
                frm.Estado = row.Cells[4].Value.ToString();
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
