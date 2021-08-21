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
    public partial class FrmEdVendedor : Form
    {
        public SqlConnection con { get; set; }
        public String ID { get; set; }
        public String Nombre { get; set; }
        public String Comision { get; set; }
        public String Estado { get; set; }
        public String Modo { get; set; }
        public FrmEdVendedor()
        {
            InitializeComponent();
        }

        private void FrmEdVendedor_Load(object sender, EventArgs e)
        {
            if (Modo.Equals("U"))
            {
                TxtID.Text = ID;
                TxtNombre.Text = Nombre;
                TxtComision.Text = Comision;
                currentEstado = Estado;
            }
            TxtID.ReadOnly = true;
        }

        public string currentEstado = "False";

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string sql = "";
            try
            {
                if (cbxEstado.CheckState == CheckState.Checked)
                    currentEstado = "True";
                else 
                    currentEstado = "False";

                if (Modo.Equals("C"))
                {
                    sql += "insert into vendedor (nombre, comision, estado) values ('";
                    sql += TxtNombre.Text.ToString() + "','";
                    sql += TxtComision.Text + "','" + currentEstado + "')";
                }
                else
                {
                    sql += "Update vendedor set ";
                    sql += "nombre = '" + TxtNombre.Text.ToString() + "',";
                    sql += "comision = '" + TxtComision.Text + "',";
                    sql += "estado = '" + currentEstado + "' ";
                    sql += "where id = " + TxtID.Text;
                }
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registro guardado exitosamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar. " + ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete Vendedor ";
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
