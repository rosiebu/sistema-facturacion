using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDS
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Connection ocon = new Connection();
            ocon.con.Open();
            string claveEncriptadaMD5 = getMD5Hash(txtContrasena.Text);
            Console.WriteLine(claveEncriptadaMD5);
            string sSQL = "select 'S' from Usuarios where contraseña = '" + claveEncriptadaMD5 + "' and id_usuario = '" + txtUsuario.Text + "'";
            SqlCommand ocmd = new SqlCommand(sSQL, ocon.con);
            string sExiste = "";
            Console.WriteLine(ocmd);



            if (ocmd.ExecuteScalar() != null)
            {
                try
                {
                    sExiste = ocmd.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    string sError = ex.Message;
                }
            }
            if (!String.IsNullOrEmpty(sExiste))
            {
                string qu = "select idRol from Usuarios where id_usuario= '" + txtUsuario.Text + "'";
                SqlCommand comando = new SqlCommand(qu, ocon.con);

                int Rol = (int)comando.ExecuteScalar();
                FrmMenu frm = new FrmMenu();
                frm.Rol = Rol;

                //FrmMenu frmMenu = new FrmMenu("admin");

                this.Hide();
                //frmMenu.Closed += (s, args) => this.Close();
                frm.Show();

            }
            else
            {
                MessageBox.Show("Clave incorrecta", "Error");
            }
        }

        public string getMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        internal static string getSha1Hash(string text)
        {
            if (String.IsNullOrEmpty(text))
                return String.Empty;

            using (var sha1 = new System.Security.Cryptography.SHA1Managed())
            {
                byte[] textData = Encoding.UTF8.GetBytes(text);

                byte[] hash = sha1.ComputeHash(textData);

                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
