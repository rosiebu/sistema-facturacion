namespace CRUDS
{
    partial class FrmArticulo
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
            this.label1 = new System.Windows.Forms.Label();
            this.CbxCriterio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtABuscar = new System.Windows.Forms.TextBox();
            this.DgvArticulo = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criterio";
            // 
            // CbxCriterio
            // 
            this.CbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCriterio.FormattingEnabled = true;
            this.CbxCriterio.Items.AddRange(new object[] {
            "Descripcion",
            "Costo Unitario",
            "Precio Unitario",
            "Estado"});
            this.CbxCriterio.Location = new System.Drawing.Point(81, 20);
            this.CbxCriterio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbxCriterio.Name = "CbxCriterio";
            this.CbxCriterio.Size = new System.Drawing.Size(149, 24);
            this.CbxCriterio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar: ";
            // 
            // TxtABuscar
            // 
            this.TxtABuscar.Location = new System.Drawing.Point(348, 22);
            this.TxtABuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtABuscar.Name = "TxtABuscar";
            this.TxtABuscar.Size = new System.Drawing.Size(297, 22);
            this.TxtABuscar.TabIndex = 3;
            // 
            // DgvArticulo
            // 
            this.DgvArticulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticulo.Location = new System.Drawing.Point(27, 90);
            this.DgvArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvArticulo.Name = "DgvArticulo";
            this.DgvArticulo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DgvArticulo.RowTemplate.Height = 24;
            this.DgvArticulo.Size = new System.Drawing.Size(819, 379);
            this.DgvArticulo.TabIndex = 4;
            this.DgvArticulo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvArticulo_CellDoubleClick);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = global::CRUDS.Properties.Resources.search;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.Location = new System.Drawing.Point(683, 16);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(43, 41);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackgroundImage = global::CRUDS.Properties.Resources.plus;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregar.Location = new System.Drawing.Point(776, 18);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(43, 38);
            this.BtnAgregar.TabIndex = 6;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // FrmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 481);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.DgvArticulo);
            this.Controls.Add(this.TxtABuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbxCriterio);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmArticulo";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.FrmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxCriterio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtABuscar;
        private System.Windows.Forms.DataGridView DgvArticulo;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnAgregar;
    }
}