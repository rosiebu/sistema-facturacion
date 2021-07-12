
namespace CRUDS
{
    partial class FrmEdCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.TxtIDPago = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "No. Documento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Pago:";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(102, 18);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(53, 20);
            this.TxtID.TabIndex = 5;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(102, 56);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(192, 20);
            this.TxtNombre.TabIndex = 6;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(102, 99);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(192, 20);
            this.TxtApellido.TabIndex = 7;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(102, 145);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(174, 20);
            this.TxtDocumento.TabIndex = 8;
            // 
            // TxtIDPago
            // 
            this.TxtIDPago.Location = new System.Drawing.Point(102, 184);
            this.TxtIDPago.Name = "TxtIDPago";
            this.TxtIDPago.Size = new System.Drawing.Size(35, 20);
            this.TxtIDPago.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TxtID);
            this.panel1.Controls.Add(this.TxtIDPago);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtDocumento);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtApellido);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 230);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnEliminar);
            this.panel2.Controls.Add(this.BtnAgregar);
            this.panel2.Location = new System.Drawing.Point(12, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 50);
            this.panel2.TabIndex = 11;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackgroundImage = global::CRUDS.Properties.Resources.delete;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminar.Location = new System.Drawing.Point(203, 6);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(32, 31);
            this.BtnEliminar.TabIndex = 12;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackgroundImage = global::CRUDS.Properties.Resources.diskette;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregar.Location = new System.Drawing.Point(77, 5);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(32, 31);
            this.BtnAgregar.TabIndex = 12;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // FrmEdCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 314);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEdCliente";
            this.Text = "FrmEdCliente";
            this.Load += new System.EventHandler(this.FrmEdCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.TextBox TxtIDPago;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
    }
}