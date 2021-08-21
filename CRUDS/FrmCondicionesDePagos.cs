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
    public partial class FrmCondicionesDePagos : Form
    {
        public SqlConnection con { get; set; }
        public FrmCondicionesDePagos()
        {
            InitializeComponent();
        }
        

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            string sql = "";
            try
            {
                sql += "insert into CondicionesDePago (id, descripcion, cantidad_dias, Estado) values (";
                sql += TxtID.Text + ",'" + TxtNombre.Text + "','";
                sql += TxtComision.Text + "','" + TxtEstado.Text + "')";
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

        }
    }
}
