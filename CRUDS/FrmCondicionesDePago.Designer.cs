﻿
namespace CRUDS
{
    partial class FrmCondicionesDePago
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
            this.condicionesDePagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMAFACTURACIONDataSet = new CRUDS.SISTEMAFACTURACIONDataSet();
            this.condicionesDePagoTableAdapter = new CRUDS.SISTEMAFACTURACIONDataSetTableAdapters.CondicionesDePagoTableAdapter();
            this.tableAdapterManager = new CRUDS.SISTEMAFACTURACIONDataSetTableAdapters.TableAdapterManager();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvCondicionesDePago = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtABuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxCriterio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.condicionesDePagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFACTURACIONDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCondicionesDePago)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // condicionesDePagoBindingSource
            // 
            this.condicionesDePagoBindingSource.DataMember = "CondicionesDePago";
            this.condicionesDePagoBindingSource.DataSource = this.sISTEMAFACTURACIONDataSet;
            // 
            // sISTEMAFACTURACIONDataSet
            // 
            this.sISTEMAFACTURACIONDataSet.DataSetName = "SISTEMAFACTURACIONDataSet";
            this.sISTEMAFACTURACIONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // condicionesDePagoTableAdapter
            // 
            this.condicionesDePagoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArticuloTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CondicionesDePagoTableAdapter = this.condicionesDePagoTableAdapter;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.LineasFacturaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CRUDS.SISTEMAFACTURACIONDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendedorTableAdapter = null;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DgvCondicionesDePago);
            this.panel2.Location = new System.Drawing.Point(28, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 382);
            this.panel2.TabIndex = 3;
            // 
            // DgvCondicionesDePago
            // 
            this.DgvCondicionesDePago.AllowUserToAddRows = false;
            this.DgvCondicionesDePago.AllowUserToDeleteRows = false;
            this.DgvCondicionesDePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCondicionesDePago.Location = new System.Drawing.Point(3, 3);
            this.DgvCondicionesDePago.Name = "DgvCondicionesDePago";
            this.DgvCondicionesDePago.ReadOnly = true;
            this.DgvCondicionesDePago.RowHeadersWidth = 51;
            this.DgvCondicionesDePago.Size = new System.Drawing.Size(768, 374);
            this.DgvCondicionesDePago.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.TxtABuscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CbxCriterio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 38);
            this.panel1.TabIndex = 2;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackgroundImage = global::CRUDS.Properties.Resources.plus;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregar.Location = new System.Drawing.Point(714, 3);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(32, 31);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = global::CRUDS.Properties.Resources.search;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.Location = new System.Drawing.Point(642, 3);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(32, 31);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtABuscar
            // 
            this.TxtABuscar.Location = new System.Drawing.Point(348, 8);
            this.TxtABuscar.Name = "TxtABuscar";
            this.TxtABuscar.Size = new System.Drawing.Size(262, 20);
            this.TxtABuscar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Palabras a buscar";
            // 
            // CbxCriterio
            // 
            this.CbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCriterio.FormattingEnabled = true;
            this.CbxCriterio.Items.AddRange(new object[] {
            "ID",
            "Descripcion",
            "Dias",
            "Estado"});
            this.CbxCriterio.Location = new System.Drawing.Point(76, 8);
            this.CbxCriterio.Name = "CbxCriterio";
            this.CbxCriterio.Size = new System.Drawing.Size(145, 21);
            this.CbxCriterio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criterio";
            // 
            // FrmCondicionesDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 432);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCondicionesDePago";
            this.Text = "Condiciones de Pago";
            ((System.ComponentModel.ISupportInitialize)(this.condicionesDePagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFACTURACIONDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCondicionesDePago)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private SISTEMAFACTURACIONDataSet sISTEMAFACTURACIONDataSet;
        private System.Windows.Forms.BindingSource condicionesDePagoBindingSource;
        private SISTEMAFACTURACIONDataSetTableAdapters.CondicionesDePagoTableAdapter condicionesDePagoTableAdapter;
        private SISTEMAFACTURACIONDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvCondicionesDePago;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtABuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxCriterio;
        private System.Windows.Forms.Label label1;
    }
}