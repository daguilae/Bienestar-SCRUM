namespace Capa_Diseño_MRP.Procesos
{
    partial class Frm_SolicitudCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SolicitudCompra));
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.Lbl_idapp = new System.Windows.Forms.Label();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.Txt_CodProd = new System.Windows.Forms.TextBox();
            this.Txt_Activo = new System.Windows.Forms.TextBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_StockMinimo = new System.Windows.Forms.Label();
            this.Lbl_StockMax = new System.Windows.Forms.Label();
            this.Lbl_ExistenciaActual = new System.Windows.Forms.Label();
            this.Lbl_idProd = new System.Windows.Forms.Label();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Btn_Solicitar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Pnl_nombreForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(250)))));
            this.Pnl_nombreForm.Controls.Add(this.Lbl_idapp);
            this.Pnl_nombreForm.Controls.Add(this.btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.label1);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(0, 0);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(847, 53);
            this.Pnl_nombreForm.TabIndex = 76;
            // 
            // Lbl_idapp
            // 
            this.Lbl_idapp.AutoSize = true;
            this.Lbl_idapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idapp.ForeColor = System.Drawing.Color.White;
            this.Lbl_idapp.Location = new System.Drawing.Point(16, 12);
            this.Lbl_idapp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_idapp.Name = "Lbl_idapp";
            this.Lbl_idapp.Size = new System.Drawing.Size(50, 20);
            this.Lbl_idapp.TabIndex = 10;
            this.Lbl_idapp.Text = "000 -";
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(760, 10);
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
            this.btn_minimizar.Location = new System.Drawing.Point(723, 10);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(33, 31);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SOLICITUD  COMPRA";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(797, 10);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(33, 31);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.Image")));
            this.Btn_Buscar.Location = new System.Drawing.Point(376, 135);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(43, 44);
            this.Btn_Buscar.TabIndex = 107;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(544, 267);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(286, 21);
            this.comboBox1.TabIndex = 106;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(544, 74);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(286, 168);
            this.Txt_Descripcion.TabIndex = 105;
            this.Txt_Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Descripcion_KeyPress);
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Location = new System.Drawing.Point(146, 210);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(212, 20);
            this.Txt_Cantidad.TabIndex = 103;
            this.Txt_Cantidad.TextChanged += new System.EventHandler(this.Txt_Cantidad_TextChanged);
            this.Txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cantidad_KeyPress);
            // 
            // Txt_CodProd
            // 
            this.Txt_CodProd.Location = new System.Drawing.Point(146, 144);
            this.Txt_CodProd.Name = "Txt_CodProd";
            this.Txt_CodProd.Size = new System.Drawing.Size(212, 20);
            this.Txt_CodProd.TabIndex = 102;
            // 
            // Txt_Activo
            // 
            this.Txt_Activo.Location = new System.Drawing.Point(146, 74);
            this.Txt_Activo.Name = "Txt_Activo";
            this.Txt_Activo.Size = new System.Drawing.Size(212, 20);
            this.Txt_Activo.TabIndex = 101;
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Location = new System.Drawing.Point(454, 270);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(40, 13);
            this.Lbl_Estado.TabIndex = 100;
            this.Lbl_Estado.Text = "Estado";
            // 
            // Lbl_StockMinimo
            // 
            this.Lbl_StockMinimo.AutoSize = true;
            this.Lbl_StockMinimo.Location = new System.Drawing.Point(454, 77);
            this.Lbl_StockMinimo.Name = "Lbl_StockMinimo";
            this.Lbl_StockMinimo.Size = new System.Drawing.Size(63, 13);
            this.Lbl_StockMinimo.TabIndex = 99;
            this.Lbl_StockMinimo.Text = "Descripcion";
            // 
            // Lbl_StockMax
            // 
            this.Lbl_StockMax.AutoSize = true;
            this.Lbl_StockMax.Location = new System.Drawing.Point(29, 275);
            this.Lbl_StockMax.Name = "Lbl_StockMax";
            this.Lbl_StockMax.Size = new System.Drawing.Size(37, 13);
            this.Lbl_StockMax.TabIndex = 98;
            this.Lbl_StockMax.Text = "Fecha";
            // 
            // Lbl_ExistenciaActual
            // 
            this.Lbl_ExistenciaActual.AutoSize = true;
            this.Lbl_ExistenciaActual.Location = new System.Drawing.Point(29, 212);
            this.Lbl_ExistenciaActual.Name = "Lbl_ExistenciaActual";
            this.Lbl_ExistenciaActual.Size = new System.Drawing.Size(98, 13);
            this.Lbl_ExistenciaActual.TabIndex = 97;
            this.Lbl_ExistenciaActual.Text = "Cantidad a Solicitar";
            // 
            // Lbl_idProd
            // 
            this.Lbl_idProd.AutoSize = true;
            this.Lbl_idProd.Location = new System.Drawing.Point(29, 151);
            this.Lbl_idProd.Name = "Lbl_idProd";
            this.Lbl_idProd.Size = new System.Drawing.Size(86, 13);
            this.Lbl_idProd.TabIndex = 96;
            this.Lbl_idProd.Text = "Codigo Producto";
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.Location = new System.Drawing.Point(29, 77);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(86, 13);
            this.Lbl_Id.TabIndex = 95;
            this.Lbl_Id.Text = "Codigo Solicitud ";
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.Location = new System.Drawing.Point(146, 269);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(212, 20);
            this.Dtp_Fecha.TabIndex = 108;
            // 
            // Btn_Solicitar
            // 
            this.Btn_Solicitar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Solicitar.Image")));
            this.Btn_Solicitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Solicitar.Location = new System.Drawing.Point(494, 318);
            this.Btn_Solicitar.Name = "Btn_Solicitar";
            this.Btn_Solicitar.Size = new System.Drawing.Size(82, 55);
            this.Btn_Solicitar.TabIndex = 109;
            this.Btn_Solicitar.Text = "SOLICITAR";
            this.Btn_Solicitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Solicitar.UseVisualStyleBackColor = true;
            this.Btn_Solicitar.Click += new System.EventHandler(this.Btn_Solicitar_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(406, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 55);
            this.button1.TabIndex = 110;
            this.button1.Text = "HABILITAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(318, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 55);
            this.button2.TabIndex = 111;
            this.button2.Text = "CONSULTAR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Frm_SolicitudCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 389);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Solicitar);
            this.Controls.Add(this.Dtp_Fecha);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.Txt_Cantidad);
            this.Controls.Add(this.Txt_CodProd);
            this.Controls.Add(this.Txt_Activo);
            this.Controls.Add(this.Lbl_Estado);
            this.Controls.Add(this.Lbl_StockMinimo);
            this.Controls.Add(this.Lbl_StockMax);
            this.Controls.Add(this.Lbl_ExistenciaActual);
            this.Controls.Add(this.Lbl_idProd);
            this.Controls.Add(this.Lbl_Id);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_SolicitudCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_SolicitudCompra";
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Label Lbl_idapp;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.TextBox Txt_CodProd;
        private System.Windows.Forms.TextBox Txt_Activo;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_StockMinimo;
        private System.Windows.Forms.Label Lbl_StockMax;
        private System.Windows.Forms.Label Lbl_ExistenciaActual;
        private System.Windows.Forms.Label Lbl_idProd;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha;
        private System.Windows.Forms.Button Btn_Solicitar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}