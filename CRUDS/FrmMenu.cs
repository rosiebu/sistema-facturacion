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
    public partial class FrmMenu : Form
    {
        //string userPermissionLevel;
        public int Rol { get; set; }

        public FrmMenu()
        {
            //userPermissionLevel = userPermission;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Rol!=1)
            {
                tiposInventariosToolStripMenuItem.Visible = false;
                tiposInventariosToolStripMenuItem.Enabled = false;

                almacenesToolStripMenuItem.Visible = false;
                almacenesToolStripMenuItem.Enabled = false;
            }
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmArticulo frm = new FrmArticulo();
            frm.Rol = Rol;
            frm.ShowDialog();
        }

        private void almacenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCondicionesDePago frm = new FrmCondicionesDePago();
            frm.Rol = Rol;
            frm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frm = new FrmLogin();
            frm.Show();
            //Application.Exit();
        }

        private void tiposInventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.Rol = Rol;
            frm.ShowDialog();
        }

        private void existeciaXAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendedor frm = new FrmVendedor();
            frm.Rol = Rol;
            frm.ShowDialog();
        }
    }
}
