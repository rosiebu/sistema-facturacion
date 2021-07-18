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
    public partial class FrmCondicionesDePago : Form
    {

        Connection conection = new Connection();

        string table = "CondicionesDePago";

        public FrmCondicionesDePago()
        {
            InitializeComponent();
            CbxCriterio.SelectedIndex = 0;
            buscar();
            
        }
        private void FrmCondicionesDePago_Load(object sender, EventArgs e)
        {
            CbxCriterio.SelectedIndex = 0;
            buscar();
            
        }

        
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmEdPago frm = new FrmEdPago();
            frm.Modo = "C";
            frm.con = conection.con;

            frm.ShowDialog();
        }
        private void FrmCondicionesDePago_Activated(object sender, EventArgs e)
        {
            buscar();
            
        }


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
            
        }
        private void buscar()
        {
            DataTable dt = conection.ejecutarConsulta(table, CbxCriterio.Text, TxtABuscar.Text);
            DgvCondicionesDePago.DataSource = dt;
            DgvCondicionesDePago.Refresh();
        }

        private void DgvCondicionesDePago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DgvCondicionesDePago.SelectedRows[0];
                FrmEdPago frm = new FrmEdPago();
                frm.ID = row.Cells[0].Value.ToString();
                frm.Descripcion = row.Cells[1].Value.ToString();
                frm.Dias = row.Cells[2].Value.ToString();
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
    }
}
