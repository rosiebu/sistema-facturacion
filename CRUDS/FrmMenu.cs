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
        string userPermissionLevel;


        public FrmMenu(string userPermission)
        {
            userPermissionLevel = userPermission;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmArticulo frm = new FrmArticulo();
            frm.ShowDialog();
        }

        private void almacenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCondicionesDePago frm = new FrmCondicionesDePago();
            frm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tiposInventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.ShowDialog();
        }

        private void existeciaXAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendedor frm = new FrmVendedor();
            frm.ShowDialog();
        }

        private void Form1_Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
