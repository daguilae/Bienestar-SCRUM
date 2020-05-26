namespace Capa_Diseño_MRP.Procesos
{
    partial class Frm_Poliza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Poliza));
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.txt_haber = new System.Windows.Forms.TextBox();
            this.txt_debe = new System.Windows.Forms.TextBox();
            this.LBLTOTAL = new System.Windows.Forms.Label();
            this.btn_ingresarCuenta = new System.Windows.Forms.Button();
            this.Gpb_Detallenominal = new System.Windows.Forms.GroupBox();
            this.Dgv_poliza = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentasContables = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp_finalpoliza = new System.Windows.Forms.DateTimePicker();
            this.dtp_iniciopoliza = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.Txt_tipo = new System.Windows.Forms.TextBox();
            this.Txt_numeropoliza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.Pnl_nombreForm.SuspendLayout();
            this.Gpb_Detallenominal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_poliza)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(250)))));
            this.Pnl_nombreForm.Controls.Add(this.btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.label1);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(0, 0);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(573, 53);
            this.Pnl_nombreForm.TabIndex = 77;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(472, 8);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(33, 31);
            this.btn_Ayuda.TabIndex = 6;
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(436, 8);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(33, 31);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PÓLIZA";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(510, 8);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(33, 31);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(450, 285);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizar.TabIndex = 85;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click_1);
            // 
            // txt_haber
            // 
            this.txt_haber.Enabled = false;
            this.txt_haber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_haber.Location = new System.Drawing.Point(319, 451);
            this.txt_haber.Name = "txt_haber";
            this.txt_haber.Size = new System.Drawing.Size(100, 20);
            this.txt_haber.TabIndex = 84;
            this.txt_haber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_debe_KeyPress);
            // 
            // txt_debe
            // 
            this.txt_debe.Enabled = false;
            this.txt_debe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_debe.Location = new System.Drawing.Point(189, 451);
            this.txt_debe.Name = "txt_debe";
            this.txt_debe.Size = new System.Drawing.Size(100, 20);
            this.txt_debe.TabIndex = 83;
            this.txt_debe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_debe_KeyPress);
            // 
            // LBLTOTAL
            // 
            this.LBLTOTAL.AutoSize = true;
            this.LBLTOTAL.Location = new System.Drawing.Point(88, 454);
            this.LBLTOTAL.Name = "LBLTOTAL";
            this.LBLTOTAL.Size = new System.Drawing.Size(76, 13);
            this.LBLTOTAL.TabIndex = 82;
            this.LBLTOTAL.Text = "Sumas Iguales";
            // 
            // btn_ingresarCuenta
            // 
            this.btn_ingresarCuenta.Location = new System.Drawing.Point(444, 332);
            this.btn_ingresarCuenta.Name = "btn_ingresarCuenta";
            this.btn_ingresarCuenta.Size = new System.Drawing.Size(98, 47);
            this.btn_ingresarCuenta.TabIndex = 81;
            this.btn_ingresarCuenta.Text = "Ingresar Cuenta Contable";
            this.btn_ingresarCuenta.UseVisualStyleBackColor = true;
            this.btn_ingresarCuenta.Click += new System.EventHandler(this.btn_ingresarCuenta_Click_1);
            // 
            // Gpb_Detallenominal
            // 
            this.Gpb_Detallenominal.Controls.Add(this.Dgv_poliza);
            this.Gpb_Detallenominal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Detallenominal.Location = new System.Drawing.Point(12, 238);
            this.Gpb_Detallenominal.Margin = new System.Windows.Forms.Padding(2);
            this.Gpb_Detallenominal.Name = "Gpb_Detallenominal";
            this.Gpb_Detallenominal.Padding = new System.Windows.Forms.Padding(2);
            this.Gpb_Detallenominal.Size = new System.Drawing.Size(421, 196);
            this.Gpb_Detallenominal.TabIndex = 80;
            this.Gpb_Detallenominal.TabStop = false;
            this.Gpb_Detallenominal.Text = "Detalle";
            // 
            // Dgv_poliza
            // 
            this.Dgv_poliza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_poliza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.CuentasContables,
            this.Debe,
            this.Haber});
            this.Dgv_poliza.Location = new System.Drawing.Point(10, 30);
            this.Dgv_poliza.Name = "Dgv_poliza";
            this.Dgv_poliza.RowHeadersVisible = false;
            this.Dgv_poliza.Size = new System.Drawing.Size(406, 150);
            this.Dgv_poliza.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // CuentasContables
            // 
            this.CuentasContables.HeaderText = "Cuentas Contables";
            this.CuentasContables.Name = "CuentasContables";
            // 
            // Debe
            // 
            this.Debe.HeaderText = "Debe";
            this.Debe.Name = "Debe";
            // 
            // Haber
            // 
            this.Haber.HeaderText = "Haber";
            this.Haber.Name = "Haber";
            // 
            // dtp_finalpoliza
            // 
            this.dtp_finalpoliza.Enabled = false;
            this.dtp_finalpoliza.Location = new System.Drawing.Point(106, 91);
            this.dtp_finalpoliza.Name = "dtp_finalpoliza";
            this.dtp_finalpoliza.Size = new System.Drawing.Size(200, 20);
            this.dtp_finalpoliza.TabIndex = 3;
            this.dtp_finalpoliza.UseWaitCursor = true;
            this.dtp_finalpoliza.Value = new System.DateTime(2020, 3, 31, 0, 0, 0, 0);
            // 
            // dtp_iniciopoliza
            // 
            this.dtp_iniciopoliza.Enabled = false;
            this.dtp_iniciopoliza.Location = new System.Drawing.Point(106, 57);
            this.dtp_iniciopoliza.Name = "dtp_iniciopoliza";
            this.dtp_iniciopoliza.Size = new System.Drawing.Size(200, 20);
            this.dtp_iniciopoliza.TabIndex = 2;
            this.dtp_iniciopoliza.UseWaitCursor = true;
            this.dtp_iniciopoliza.Value = new System.DateTime(2020, 3, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Final";
            this.label6.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Inicio";
            this.label5.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_descripcion);
            this.groupBox1.Controls.Add(this.lbl_descripcion);
            this.groupBox1.Controls.Add(this.dtp_finalpoliza);
            this.groupBox1.Controls.Add(this.dtp_iniciopoliza);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Txt_tipo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_numeropoliza);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 158);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE POLIZA";
            this.groupBox1.UseWaitCursor = true;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(338, 58);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(187, 82);
            this.txt_descripcion.TabIndex = 41;
            this.txt_descripcion.UseWaitCursor = true;
            this.txt_descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descripcion_KeyPress);
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(344, 26);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(63, 13);
            this.lbl_descripcion.TabIndex = 40;
            this.lbl_descripcion.Text = "Descripción";
            this.lbl_descripcion.UseWaitCursor = true;
            // 
            // Txt_tipo
            // 
            this.Txt_tipo.Enabled = false;
            this.Txt_tipo.Location = new System.Drawing.Point(105, 120);
            this.Txt_tipo.Name = "Txt_tipo";
            this.Txt_tipo.Size = new System.Drawing.Size(202, 20);
            this.Txt_tipo.TabIndex = 39;
            this.Txt_tipo.Text = "COSTOS";
            this.Txt_tipo.UseWaitCursor = true;
            // 
            // Txt_numeropoliza
            // 
            this.Txt_numeropoliza.Enabled = false;
            this.Txt_numeropoliza.Location = new System.Drawing.Point(105, 23);
            this.Txt_numeropoliza.Name = "Txt_numeropoliza";
            this.Txt_numeropoliza.Size = new System.Drawing.Size(100, 20);
            this.Txt_numeropoliza.TabIndex = 4;
            this.Txt_numeropoliza.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Póliza";
            this.label3.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "No. Póliza";
            this.label7.UseWaitCursor = true;
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(450, 395);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(75, 39);
            this.btn_generar.TabIndex = 86;
            this.btn_generar.Text = "Generar Póliza";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click_1);
            // 
            // Frm_Poliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 493);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.txt_haber);
            this.Controls.Add(this.txt_debe);
            this.Controls.Add(this.LBLTOTAL);
            this.Controls.Add(this.btn_ingresarCuenta);
            this.Controls.Add(this.Gpb_Detallenominal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Poliza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Poliza";
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.Gpb_Detallenominal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_poliza)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.TextBox txt_haber;
        private System.Windows.Forms.TextBox txt_debe;
        private System.Windows.Forms.Label LBLTOTAL;
        private System.Windows.Forms.Button btn_ingresarCuenta;
        private System.Windows.Forms.GroupBox Gpb_Detallenominal;
        private System.Windows.Forms.DateTimePicker dtp_finalpoliza;
        private System.Windows.Forms.DateTimePicker dtp_iniciopoliza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_tipo;
        private System.Windows.Forms.TextBox Txt_numeropoliza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.DataGridView Dgv_poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentasContables;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Haber;
    }
}