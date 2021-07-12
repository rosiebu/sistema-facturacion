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
    public partial class FrmEdCliente : Form
    {
        public SqlConnection con { get; set; }
        public String ID { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String No_Documento { get; set; }
        public String Id_Condiciones_de_Pago { get; set; }
        public String Modo { get; set; }
        public FrmEdCliente()
        {
            InitializeComponent();
        }

        private void FrmEdCliente_Load(object sender, EventArgs e)
        {
            if (Modo.Equals("U"))
            {
                TxtID.Text = ID;
                TxtNombre.Text = Nombre;
                TxtApellido.Text = Apellido;
                TxtDocumento.Text = No_Documento;
                TxtIDPago.Text = Id_Condiciones_de_Pago;
            }
            TxtID.ReadOnly = Modo.Equals("U");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                if (Modo.Equals("C"))
                {
                    sql += "insert into Cliente (id, nombre, apellido, no_documento, id_conciciones_de_pago) values (";
                    sql += TxtID.Text + ",'" + TxtNombre.Text + "','";
                    sql += TxtApellido.Text + "','" + TxtDocumento.Text + "','" + TxtIDPago + "')";

                }
                else
                {
                    sql += "Update Cliente set ";
                    sql += "id = '" + TxtID.Text + "',";
                    sql += "nombre = '" + TxtNombre.Text + "',";
                    sql += "apellido = '" + TxtApellido.Text + "',";
                    sql += "no_documento = '" + TxtDocumento.Text + "',";
                    sql += "id_conciciones_de_pago = '" + TxtIDPago.Text + "' ";
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete Cliente ";
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
