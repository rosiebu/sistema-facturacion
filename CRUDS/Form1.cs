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
    public partial class Form1 : Form
    {
        string table = "Factura";
        Connection conection = new Connection();
        System.Windows.Forms.ComboBox[] Many2oneFields = null;
        System.Windows.Forms.DataGridViewComboBoxColumn[] DgvMany2oneFields = null;

        public Form1()
        {
            InitializeComponent();
            //para agregar many2one se agrega un combobox con tag correspondiente a su tabla
            //y se agrega el mismo en esta lista.
            Many2oneFields = new System.Windows.Forms.ComboBox[] {
                this.clienteCbx,
                this.vendedorCbx
            };

            this.producto.Tag = "articulo";
            DgvMany2oneFields = new System.Windows.Forms.DataGridViewComboBoxColumn[] {
                this.producto
            };

            InitializeMany2oneFields();
            InitializeDgvMany2oneFields();
        }

        private void InitializeMany2oneFields()
        {
            if (this.Many2oneFields == null) return;
            for (int i = 0; i < this.Many2oneFields.Length; i++) {
                string table = this.Many2oneFields[i].Tag.ToString();
                System.Windows.Forms.ComboBox Cbx = this.Many2oneFields[i];
                this.Add_ComboBox_Items(Get_Many2oneFields(table), Cbx);
            }
        }
        private void InitializeDgvMany2oneFields()
        {
            if (this.DgvMany2oneFields == null) return;
            for (int i = 0; i < this.DgvMany2oneFields.Length; i++)
            {
                string table = this.DgvMany2oneFields[i].Tag.ToString();
                Console.WriteLine(table);
                System.Windows.Forms.DataGridViewComboBoxColumn DgvCbx = this.DgvMany2oneFields[i];
                this.Add_DgvComboBox_Items(Get_Many2oneFields(table, "descripcion"), DgvCbx);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Add_ComboBox_Items(object[] items, System.Windows.Forms.ComboBox ComboBox)
        {
            ComboBox.Items.AddRange(items);
        }
        private void Add_DgvComboBox_Items(object[] items, System.Windows.Forms.DataGridViewComboBoxColumn ComboBox)
        {
            ComboBox.Items.AddRange(items);
        }

        private object[] Get_Many2oneFields(string table, string column="nombre") {
            if (table == null) return new object[] {};
            object[] items = conection.getMany2one(table, column);
            return items;
        }

        private void borrar_lineaBtn_Click(object sender, EventArgs e)
        {
            int lstRowNum = this.linesDgv.Rows.Count - 1;
            DataGridViewRow row = this.linesDgv.Rows[lstRowNum];
            Console.WriteLine(row.Cells[2].Value);
            if (row.Cells[2].Value == null) return;
            this.linesDgv.Rows.Remove(row);
            if (this.linesDgv.Rows.Count == 0)
            {
                this.linesDgv.Rows.Add();
            }
            return;
        }

        private void linesDgv_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.ColumnIndex.Equals(0));
            int rowNum = e.RowIndex;
            int qty;
            float precio;
            string match;
            DataGridViewRow row = this.linesDgv.Rows[rowNum];
            try {
                qty = int.Parse(row.Cells[2].Value.ToString());
                precio = float.Parse(row.Cells[3].Value.ToString());
                
            }
            catch {
                qty = 1;
                precio = 0;
                row.Cells[2].Value = qty;
                row.Cells[4].Value = precio;
                row.Cells[4].Value = precio * qty;
            }
            
            if (e.ColumnIndex.Equals(0)) {
                string slctColumn = "precio_unitario";
                try { match = row.Cells[0].Value.ToString();} catch { return; }
                precio = getProductColumnByDescription(slctColumn, match);
                row.Cells[3].Value = precio;
                row.Cells[4].Value = precio * qty;
            }
            row.Cells[4].Value = precio * qty;

        }

        private dynamic getProductColumnByDescription(string column, string description) {
            string table = "articulo";
            string whereColumn = "descripcion";
            return conection.getMany2oneId(table, whereColumn, description, "=", column);
        }

        private string getLinesQueryCreate() {
            /*
            ###insertar lineas factura###
            id factura, id articulo, cantidad, precio unitario, total
            insert into lineasfactura values(1, 1, 1, 200, 200);
            */

            string res = "";
            string id_articulo;
            string id_factura;
            string cantidad;
            string precio;
            string total;
            DataGridViewRow row;
            for (int i = 0; i < this.linesDgv.Rows.Count; i++) {
                row = this.linesDgv.Rows[i];
                
                id_articulo  = row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : null;
                id_factura = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : null;
                cantidad = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : null;
                precio = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : null;
                total = row.Cells[4].Value != null ? row.Cells[4].Value.ToString() : null;
                if (id_articulo != null && id_factura != null && cantidad != null && precio != null) {
                    res += "insert into lineasfactura values(";
                    res += id_articulo + ",";
                    res += id_factura + ",";
                    res += cantidad + ",";
                    res += precio + ",";
                    res += total + ",";
                    res += ")";
                }
                
            }
            

            return res;
        }
        private string getLinesQueryUpdate() {
            return "";
        }

        private string getInvoiceQueryCreate() {
            return "";
        }

        private string getInvoiceQueryUpdate() {
            return "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("last:" + conection.getLastIdOnTable("articulo"));
            Console.WriteLine(getLinesQueryCreate());
        }
    }
}
