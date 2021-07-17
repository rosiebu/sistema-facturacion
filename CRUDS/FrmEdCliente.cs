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
                comboIDpago.SelectedItem = Id_Condiciones_de_Pago;
            }
            TxtID.ReadOnly = true;
            comboIDpago.Text = comboIDpago.Items[0].ToString();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {


                string sql = "";
                if (Modo.Equals("C"))
                {
                    sql += "insert into cliente (nombre, apellido, no_documento, id_conciciones_de_pago) values ('";
                    sql += TxtNombre.Text + "','";
                    sql += TxtApellido.Text + "','" + TxtDocumento.Text + "','" + comboIDpago.SelectedItem.ToString() + "')";

                }
                else
                {
                    sql += "Update cliente set ";
                    sql += "nombre = '" + TxtNombre.Text + "',";
                    sql += "apellido = '" + TxtApellido.Text + "',";
                    sql += "no_documento = '" + TxtDocumento.Text + "',";
                    sql += "id_conciciones_de_pago = '" + comboIDpago.SelectedItem.ToString() + "' ";
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

        public static bool validaCedula(string pCedula)
        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
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
