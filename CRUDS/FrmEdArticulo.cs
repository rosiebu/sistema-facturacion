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
    public partial class FrmEdArticulo : Form
    {
        public SqlConnection con { get; set; }
        public String ID { get; set; }
        public String descripcion { get; set; }
        public float costoUnitario { get; set; }
        public float precioUnitario { get; set; }
        public String Estado { get; set; }
        public String Modo { get; set; }
        public FrmEdArticulo()
        {
            InitializeComponent();

        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            if (Modo.Equals("U"))
            {
                TxtDescripcion.Text = descripcion;
                numCosto.Text = costoUnitario.ToString();
                numPrecio.Text = precioUnitario.ToString();
                currentEstado = Estado;
            }
            TxtID.ReadOnly = true;
        }
        public string currentEstado = "False";

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string myCnStr = Properties.Settings.Default.SISTEMAFACTURACIONConnectionString;
            string sql = "";
            try
            {
                if (cbxEstado.CheckState == CheckState.Checked)
                    currentEstado = "True";
                else
                    currentEstado = "False";

                if (Modo.Equals("C"))
                {
                    sql += "insert into Articulo (descripcion, consto_unitario, precio_unitario, estado) values ('";
                    sql += TxtDescripcion.Text + "','";
                    sql += numCosto.Text.ToString() + "','" + numPrecio.Text.ToString() + "','" + currentEstado + "')";
                }
                else
                {
                    sql += "Update Articulo set ";
                    sql += "descripcion = '" + TxtDescripcion.Text.ToString() + "',";
                    sql += "consto_unitario = '" + numCosto.Text.ToString() + "',";
                    sql += "precio_unitario = '" + numPrecio.Text.ToString() + "',";
                    sql += "estado = '" + currentEstado + "' ";
                    sql += "where id = " + TxtID.Text;
                }
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro guardado exitosamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar. " + ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e) {

            try
            {
                string sql = "delete Articulo ";
                sql += "where id = " + TxtID.Text;
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado exitosamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar. " + ex.Message);
            }
    }
    }
}
