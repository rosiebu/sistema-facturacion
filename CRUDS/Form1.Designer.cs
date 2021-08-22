namespace CRUDS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.sISTEMAFACTURACIONDataSet = new CRUDS.SISTEMAFACTURACIONDataSet();
            this.lineasFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lineasFacturaTableAdapter = new CRUDS.SISTEMAFACTURACIONDataSetTableAdapters.LineasFacturaTableAdapter();
            this.linesDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.clienteCbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vendedorCbx = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.producto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.id_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFACTURACIONDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineasFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // sISTEMAFACTURACIONDataSet
            // 
            this.sISTEMAFACTURACIONDataSet.DataSetName = "SISTEMAFACTURACIONDataSet";
            this.sISTEMAFACTURACIONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lineasFacturaBindingSource
            // 
            this.lineasFacturaBindingSource.DataMember = "LineasFactura";
            this.lineasFacturaBindingSource.DataSource = this.sISTEMAFACTURACIONDataSet;
            // 
            // lineasFacturaTableAdapter
            // 
            this.lineasFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // linesDgv
            // 
            this.linesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.linesDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.id_factura,
            this.cantidad,
            this.precio_unitario,
            this.total});
            this.linesDgv.Location = new System.Drawing.Point(21, 127);
            this.linesDgv.Name = "linesDgv";
            this.linesDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.linesDgv.RowTemplate.Height = 24;
            this.linesDgv.Size = new System.Drawing.Size(776, 233);
            this.linesDgv.TabIndex = 1;
            this.linesDgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.linesDgv_CellEndEdit_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha";
            // 
            // clienteCbx
            // 
            this.clienteCbx.FormattingEnabled = true;
            this.clienteCbx.Location = new System.Drawing.Point(89, 31);
            this.clienteCbx.Name = "clienteCbx";
            this.clienteCbx.Size = new System.Drawing.Size(200, 24);
            this.clienteCbx.TabIndex = 3;
            this.clienteCbx.Tag = "cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vendedor";
            // 
            // vendedorCbx
            // 
            this.vendedorCbx.FormattingEnabled = true;
            this.vendedorCbx.Location = new System.Drawing.Point(541, 31);
            this.vendedorCbx.Name = "vendedorCbx";
            this.vendedorCbx.Size = new System.Drawing.Size(200, 24);
            this.vendedorCbx.TabIndex = 6;
            this.vendedorCbx.Tag = "vendedor";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 412);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 96);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(643, 534);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.ToolTipText = "producto";
            this.producto.Width = 125;
            // 
            // id_factura
            // 
            this.id_factura.HeaderText = "Id Factura";
            this.id_factura.MinimumWidth = 6;
            this.id_factura.Name = "id_factura";
            this.id_factura.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 125;
            // 
            // precio_unitario
            // 
            this.precio_unitario.HeaderText = "Precio Unitario";
            this.precio_unitario.MinimumWidth = 6;
            this.precio_unitario.Name = "precio_unitario";
            this.precio_unitario.Width = 125;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Comentarios";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 591);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vendedorCbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clienteCbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linesDgv);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFACTURACIONDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineasFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private SISTEMAFACTURACIONDataSet sISTEMAFACTURACIONDataSet;
        private System.Windows.Forms.BindingSource lineasFacturaBindingSource;
        private SISTEMAFACTURACIONDataSetTableAdapters.LineasFacturaTableAdapter lineasFacturaTableAdapter;
        private System.Windows.Forms.DataGridView linesDgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox clienteCbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox vendedorCbx;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewComboBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label label4;
    }
}