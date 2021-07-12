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
    public partial class FrmArticulos : Form
    {
        public SqlConnection con { get; set; }
        public String ID { get; set; }
        public String descripcion { get; set; }
        public float costoUnitario { get; set; }
        public float precioUnitario { get; set; }
        public String Estado { get; set; }
        public String Modo { get; set; }
        public FrmArticulos()
        {
            InitializeComponent();

        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            if (Modo.Equals("U"))
            {
                TxtID.Text = ID;
                TxtDescripcion.Text = descripcion;
                TxtCostoUnitario.Text = costoUnitario.ToString();
                TxtPrecioUnitario.Text = precioUnitario.ToString();
                TxtEstado.Text = Estado;
            }
            TxtID.ReadOnly = Modo.Equals("U");

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string myCnStr = Properties.Settings.Default.SISTEMAFACTURACIONConnectionString;
            string sql = "";
            try
            {
                if (Modo.Equals("C"))
                {
                    sql += "insert into Articulo (id, descripcion, consto_unitario, precio_unitario, estado) values (";
                    sql += TxtID.Text + ",'" + TxtDescripcion.Text + "',";
                    sql += TxtCostoUnitario.Text + "," + TxtPrecioUnitario.Text + ",'" + TxtEstado.Text + "')";
                }
                else
                {
                    sql += "Update Articulo set ";
                    sql += "id = '" + TxtID.Text + "',";
                    sql += "descripcion = '" + TxtDescripcion.Text + "',";
                    sql += "consto_unitario = '" + TxtCostoUnitario.Text + "',";
                    sql += "precio_unitario = '" + TxtPrecioUnitario.Text + "',";
                    sql += "estado = '" + TxtEstado.Text + "' ";
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
