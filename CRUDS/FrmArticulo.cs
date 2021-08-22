using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDS
{
    public partial class FrmArticulo : Form
    {
        public int Rol { get; set; }

        DataTable oDt = new DataTable();
        Connection conection = new Connection();
        //SqlConnection oCon = null;

        string table = "Articulo";

        public FrmArticulo()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            buscar("");
            //ejecutarConsulta();
        }
        private void buscar(string pFiltro)
        {
            string sSQL = "select * from articulo ";
            if (pFiltro.Trim().Length > 0)
                sSQL += pFiltro;
            oDt = new DataTable();

            DataTable dt = conection.ejecutarConsulta(table, CbxCriterio.Text, TxtABuscar.Text);
            DgvArticulo.DataSource = dt;
            //DgvArticulo.DataSource = oDT;
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
            //oCon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=SISTEMAFACTURACION;Integrated Security=True");
            //oCon.Open();

            if (Rol != 1)
            {
                BtnAgregar.Visible = false;
                BtnAgregar.Enabled = false;
            }
            CbxCriterio.SelectedIndex = 0;
            buscar("");
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
        private void ExportarDatos(DataGridView datalistado)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);
                int IndiceColumna = 0;
                foreach (DataGridViewColumn columna in datalistado.Columns) //leer las columnas 
                {
                    IndiceColumna++;
                    excel.Cells[1, IndiceColumna] = columna.Name;
                }
                int IndiceFila = 0;
                foreach (DataGridViewRow fila in datalistado.Rows) // leer las filas de las columnas 
                {
                    IndiceFila++;
                    IndiceColumna = 0;
                    foreach (DataGridViewColumn columna in datalistado.Columns)
                    {
                        IndiceColumna++;
                        excel.Cells[IndiceFila + 1, IndiceColumna] = fila.Cells[columna.Name].Value;
                    }
                }
                excel.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("No hay Registros a Exportar.");
            }
        }



        //Exporta a un documento Excel pero está vacío, probablemente por un problema de conexión con la base
        //de datos
        private void BtnExportar_Click(object sender, EventArgs e)
        {
            ExportarDatos(DgvArticulo);
        }

    }
}
