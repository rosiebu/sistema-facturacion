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
    public partial class FrmEdPago : Form
    {
        public SqlConnection con { get; set; }
        public String ID { get; set; }
        public String Descripcion { get; set; }
        public String Dias { get; set; }
        public String Estado { get; set; }
        public String Modo { get; set; }
        public FrmEdPago()
        {
            InitializeComponent();
        }

        private void FrmEdPago_Load(object sender, EventArgs e)
        {
            if (Modo.Equals("U"))
            {
                TxtID.Text = ID;
                TxtDesc.Text = Descripcion;
                numDias.Text = Dias;
                currentEstado = Estado;
            }
            TxtID.ReadOnly = true;
        }

        public string currentEstado = "False";

        private void BtnAgregar_Click_1(object sender, EventArgs e)
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
                    sql += "insert into condicionesdepago (descripcion, cantidad_dias, Estado) values ('";
                    sql += TxtDesc.Text + "','";
                    sql += numDias.Text.ToString() + "','" + currentEstado + "')";
                }
                else
                {
                    sql += "Update condicionesdepago set ";
                    sql += "descripcion = '" + TxtDesc.Text.ToString() + "',";
                    sql += "cantidad_dias = '" + numDias.Text.ToString() + "',";
                    sql += "estado = '" + currentEstado + "' ";
                    sql += "where id = '" + TxtID.Text;
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
                string sql = "delete condicionesdepago ";
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
