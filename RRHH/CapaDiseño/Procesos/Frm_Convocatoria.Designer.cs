﻿namespace CapaDiseño.Procesos
{
    partial class Frm_Convocatoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Convocatoria));
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_NombrePdF = new System.Windows.Forms.Label();
            this.Txt_NombrePDF = new System.Windows.Forms.TextBox();
            this.DTP_fEHCA = new System.Windows.Forms.DateTimePicker();
            this.Cbo_MC = new System.Windows.Forms.ComboBox();
            this.Cbo_TipoC = new System.Windows.Forms.ComboBox();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Label_Fecha = new System.Windows.Forms.Label();
            this.Label_Medio = new System.Windows.Forms.Label();
            this.Label_TipoContratacion = new System.Windows.Forms.Label();
            this.Label_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_PERFIL = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnl_Desempeño = new System.Windows.Forms.Panel();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_desempeñoTitulo = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PERFIL)).BeginInit();
            this.Pnl_Desempeño.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.Location = new System.Drawing.Point(1037, 165);
            this.Btn_Imprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(139, 37);
            this.Btn_Imprimir.TabIndex = 26;
            this.Btn_Imprimir.Text = "ACEPTAR";
            this.Btn_Imprimir.UseVisualStyleBackColor = true;
            this.Btn_Imprimir.Click += new System.EventHandler(this.Btn_Imprimir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label_NombrePdF);
            this.panel1.Controls.Add(this.Txt_NombrePDF);
            this.panel1.Controls.Add(this.DTP_fEHCA);
            this.panel1.Controls.Add(this.Btn_Imprimir);
            this.panel1.Controls.Add(this.Cbo_MC);
            this.panel1.Controls.Add(this.Cbo_TipoC);
            this.panel1.Controls.Add(this.Txt_Id);
            this.panel1.Controls.Add(this.Label_Fecha);
            this.panel1.Controls.Add(this.Label_Medio);
            this.panel1.Controls.Add(this.Label_TipoContratacion);
            this.panel1.Controls.Add(this.Label_ID);
            this.panel1.Location = new System.Drawing.Point(23, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 251);
            this.panel1.TabIndex = 25;
            // 
            // Label_NombrePdF
            // 
            this.Label_NombrePdF.AutoSize = true;
            this.Label_NombrePdF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NombrePdF.Location = new System.Drawing.Point(416, 198);
            this.Label_NombrePdF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_NombrePdF.Name = "Label_NombrePdF";
            this.Label_NombrePdF.Size = new System.Drawing.Size(129, 20);
            this.Label_NombrePdF.TabIndex = 28;
            this.Label_NombrePdF.Text = "Nombre Archivo";
            // 
            // Txt_NombrePDF
            // 
            this.Txt_NombrePDF.Location = new System.Drawing.Point(595, 197);
            this.Txt_NombrePDF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_NombrePDF.Name = "Txt_NombrePDF";
            this.Txt_NombrePDF.Size = new System.Drawing.Size(229, 22);
            this.Txt_NombrePDF.TabIndex = 27;
            // 
            // DTP_fEHCA
            // 
            this.DTP_fEHCA.Location = new System.Drawing.Point(803, 32);
            this.DTP_fEHCA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTP_fEHCA.Name = "DTP_fEHCA";
            this.DTP_fEHCA.Size = new System.Drawing.Size(283, 22);
            this.DTP_fEHCA.TabIndex = 18;
            // 
            // Cbo_MC
            // 
            this.Cbo_MC.FormattingEnabled = true;
            this.Cbo_MC.Location = new System.Drawing.Point(803, 111);
            this.Cbo_MC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbo_MC.Name = "Cbo_MC";
            this.Cbo_MC.Size = new System.Drawing.Size(283, 24);
            this.Cbo_MC.TabIndex = 17;
            this.Cbo_MC.SelectedIndexChanged += new System.EventHandler(this.Cbo_MC_SelectedIndexChanged);
            // 
            // Cbo_TipoC
            // 
            this.Cbo_TipoC.FormattingEnabled = true;
            this.Cbo_TipoC.Location = new System.Drawing.Point(295, 107);
            this.Cbo_TipoC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbo_TipoC.Name = "Cbo_TipoC";
            this.Cbo_TipoC.Size = new System.Drawing.Size(229, 24);
            this.Cbo_TipoC.TabIndex = 16;
            this.Cbo_TipoC.SelectedIndexChanged += new System.EventHandler(this.Cbo_TipoC_SelectedIndexChanged);
            // 
            // Txt_Id
            // 
            this.Txt_Id.Location = new System.Drawing.Point(295, 30);
            this.Txt_Id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(229, 22);
            this.Txt_Id.TabIndex = 8;
            // 
            // Label_Fecha
            // 
            this.Label_Fecha.AutoSize = true;
            this.Label_Fecha.Location = new System.Drawing.Point(637, 31);
            this.Label_Fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Fecha.Name = "Label_Fecha";
            this.Label_Fecha.Size = new System.Drawing.Size(53, 17);
            this.Label_Fecha.TabIndex = 6;
            this.Label_Fecha.Text = "FECHA";
            // 
            // Label_Medio
            // 
            this.Label_Medio.AutoSize = true;
            this.Label_Medio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Medio.Location = new System.Drawing.Point(619, 108);
            this.Label_Medio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Medio.Name = "Label_Medio";
            this.Label_Medio.Size = new System.Drawing.Size(140, 40);
            this.Label_Medio.TabIndex = 5;
            this.Label_Medio.Text = "MEDIO DE \r\nCOMUNICACION";
            // 
            // Label_TipoContratacion
            // 
            this.Label_TipoContratacion.AutoSize = true;
            this.Label_TipoContratacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TipoContratacion.Location = new System.Drawing.Point(41, 111);
            this.Label_TipoContratacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_TipoContratacion.Name = "Label_TipoContratacion";
            this.Label_TipoContratacion.Size = new System.Drawing.Size(184, 20);
            this.Label_TipoContratacion.TabIndex = 4;
            this.Label_TipoContratacion.Text = "TIPO CONTRATACION";
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ID.Location = new System.Drawing.Point(41, 31);
            this.Label_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(125, 20);
            this.Label_ID.TabIndex = 3;
            this.Label_ID.Text = "ID EMPLEADO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 348);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "INFORMACION DE PERFIL";
            // 
            // DGV_PERFIL
            // 
            this.DGV_PERFIL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PERFIL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.DGV_PERFIL.Location = new System.Drawing.Point(23, 400);
            this.DGV_PERFIL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_PERFIL.Name = "DGV_PERFIL";
            this.DGV_PERFIL.RowHeadersVisible = false;
            this.DGV_PERFIL.RowHeadersWidth = 51;
            this.DGV_PERFIL.Size = new System.Drawing.Size(1197, 204);
            this.DGV_PERFIL.TabIndex = 22;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Primaria";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Secundaria";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Bachillerato";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Estudiante_U";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Grado_U";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Curso_Extra";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Descripcion_curso";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Estado";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Pnl_Desempeño
            // 
            this.Pnl_Desempeño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pnl_Desempeño.Controls.Add(this.Btn_ayuda);
            this.Pnl_Desempeño.Controls.Add(this.Btn_minimizar);
            this.Pnl_Desempeño.Controls.Add(this.Btn_cerrar);
            this.Pnl_Desempeño.Controls.Add(this.Lbl_desempeñoTitulo);
            this.Pnl_Desempeño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_Desempeño.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Desempeño.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_Desempeño.Name = "Pnl_Desempeño";
            this.Pnl_Desempeño.Size = new System.Drawing.Size(1265, 63);
            this.Pnl_Desempeño.TabIndex = 28;
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(1155, 15);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(44, 38);
            this.Btn_ayuda.TabIndex = 9;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.Image")));
            this.Btn_minimizar.Location = new System.Drawing.Point(1105, 15);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(44, 38);
            this.Btn_minimizar.TabIndex = 8;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(1204, 15);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.Btn_cerrar.TabIndex = 7;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_desempeñoTitulo
            // 
            this.Lbl_desempeñoTitulo.AutoSize = true;
            this.Lbl_desempeñoTitulo.ForeColor = System.Drawing.Color.White;
            this.Lbl_desempeñoTitulo.Location = new System.Drawing.Point(15, 21);
            this.Lbl_desempeñoTitulo.Name = "Lbl_desempeñoTitulo";
            this.Lbl_desempeñoTitulo.Size = new System.Drawing.Size(189, 25);
            this.Lbl_desempeñoTitulo.TabIndex = 0;
            this.Lbl_desempeñoTitulo.Text = "CONVOCATORIA";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(1060, 337);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(139, 37);
            this.Btn_Buscar.TabIndex = 29;
            this.Btn_Buscar.Text = "BUSCAR";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Frm_Convocatoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 619);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Pnl_Desempeño);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_PERFIL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Convocatoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Convocatoria";
            this.Load += new System.EventHandler(this.Frm_Convocatoria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PERFIL)).EndInit();
            this.Pnl_Desempeño.ResumeLayout(false);
            this.Pnl_Desempeño.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Imprimir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DTP_fEHCA;
        private System.Windows.Forms.ComboBox Cbo_MC;
        private System.Windows.Forms.ComboBox Cbo_TipoC;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Label Label_Fecha;
        private System.Windows.Forms.Label Label_Medio;
        private System.Windows.Forms.Label Label_TipoContratacion;
        private System.Windows.Forms.Label Label_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_PERFIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Panel Pnl_Desempeño;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_desempeñoTitulo;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label Label_NombrePdF;
        private System.Windows.Forms.TextBox Txt_NombrePDF;
    }
}