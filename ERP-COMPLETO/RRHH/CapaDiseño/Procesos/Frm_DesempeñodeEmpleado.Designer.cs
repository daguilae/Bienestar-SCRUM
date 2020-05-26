namespace CapaDiseño.Procesos
{
    partial class Frm_DesempeñodeEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DesempeñodeEmpleado));
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Desempeño = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_CodEmpleado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Promedio = new System.Windows.Forms.Button();
            this.Txt_Prome = new System.Windows.Forms.TextBox();
            this.Lbl_Promedio = new System.Windows.Forms.Label();
            this.Btn_BuscarEmp = new System.Windows.Forms.Button();
            this.Txt_Empleado = new System.Windows.Forms.TextBox();
            this.Dgv_Desempeno = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Pnl_nombreForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Desempeno)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pnl_nombreForm.Controls.Add(this.label1);
            this.Pnl_nombreForm.Controls.Add(this.lbl_Desempeño);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(-1, 1);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(1136, 63);
            this.Pnl_nombreForm.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "238 -";
            // 
            // lbl_Desempeño
            // 
            this.lbl_Desempeño.AutoSize = true;
            this.lbl_Desempeño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Desempeño.ForeColor = System.Drawing.Color.White;
            this.lbl_Desempeño.Location = new System.Drawing.Point(92, 19);
            this.lbl_Desempeño.Name = "lbl_Desempeño";
            this.lbl_Desempeño.Size = new System.Drawing.Size(259, 25);
            this.lbl_Desempeño.TabIndex = 0;
            this.lbl_Desempeño.Text = "Desempeño de Empleado";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1049, 10);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_CodEmpleado
            // 
            this.Lbl_CodEmpleado.AutoSize = true;
            this.Lbl_CodEmpleado.Location = new System.Drawing.Point(27, 42);
            this.Lbl_CodEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_CodEmpleado.Name = "Lbl_CodEmpleado";
            this.Lbl_CodEmpleado.Size = new System.Drawing.Size(119, 17);
            this.Lbl_CodEmpleado.TabIndex = 45;
            this.Lbl_CodEmpleado.Text = "Codigo Empleado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Promedio);
            this.groupBox1.Controls.Add(this.Txt_Prome);
            this.groupBox1.Controls.Add(this.Lbl_Promedio);
            this.groupBox1.Controls.Add(this.Btn_BuscarEmp);
            this.groupBox1.Controls.Add(this.Txt_Empleado);
            this.groupBox1.Controls.Add(this.Lbl_CodEmpleado);
            this.groupBox1.Location = new System.Drawing.Point(39, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1053, 90);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Btn_Promedio
            // 
            this.Btn_Promedio.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Promedio.Image")));
            this.Btn_Promedio.Location = new System.Drawing.Point(899, 22);
            this.Btn_Promedio.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Promedio.Name = "Btn_Promedio";
            this.Btn_Promedio.Size = new System.Drawing.Size(57, 55);
            this.Btn_Promedio.TabIndex = 50;
            this.Btn_Promedio.UseVisualStyleBackColor = true;
            this.Btn_Promedio.Click += new System.EventHandler(this.Btn_Promedio_Click);
            // 
            // Txt_Prome
            // 
            this.Txt_Prome.Location = new System.Drawing.Point(629, 38);
            this.Txt_Prome.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Prome.Name = "Txt_Prome";
            this.Txt_Prome.Size = new System.Drawing.Size(253, 22);
            this.Txt_Prome.TabIndex = 49;
            // 
            // Lbl_Promedio
            // 
            this.Lbl_Promedio.AutoSize = true;
            this.Lbl_Promedio.Location = new System.Drawing.Point(553, 42);
            this.Lbl_Promedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Promedio.Name = "Lbl_Promedio";
            this.Lbl_Promedio.Size = new System.Drawing.Size(68, 17);
            this.Lbl_Promedio.TabIndex = 48;
            this.Lbl_Promedio.Text = "Promedio";
            // 
            // Btn_BuscarEmp
            // 
            this.Btn_BuscarEmp.Image = ((System.Drawing.Image)(resources.GetObject("Btn_BuscarEmp.Image")));
            this.Btn_BuscarEmp.Location = new System.Drawing.Point(431, 22);
            this.Btn_BuscarEmp.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_BuscarEmp.Name = "Btn_BuscarEmp";
            this.Btn_BuscarEmp.Size = new System.Drawing.Size(57, 55);
            this.Btn_BuscarEmp.TabIndex = 47;
            this.Btn_BuscarEmp.UseVisualStyleBackColor = true;
            this.Btn_BuscarEmp.Click += new System.EventHandler(this.Btn_BuscarEmp_Click);
            // 
            // Txt_Empleado
            // 
            this.Txt_Empleado.Location = new System.Drawing.Point(168, 38);
            this.Txt_Empleado.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Empleado.Name = "Txt_Empleado";
            this.Txt_Empleado.Size = new System.Drawing.Size(253, 22);
            this.Txt_Empleado.TabIndex = 46;
            // 
            // Dgv_Desempeno
            // 
            this.Dgv_Desempeno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Desempeno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.Dgv_Desempeno.Location = new System.Drawing.Point(69, 214);
            this.Dgv_Desempeno.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Desempeno.Name = "Dgv_Desempeno";
            this.Dgv_Desempeno.RowHeadersWidth = 51;
            this.Dgv_Desempeno.Size = new System.Drawing.Size(983, 294);
            this.Dgv_Desempeno.TabIndex = 47;
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
            this.Column2.HeaderText = "Fecha Asignacion";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Puntuacion";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Codigo Empleado";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Codigo Meta";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Estado Completado";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Fecha Realizacion";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_actualizar.FlatAppearance.BorderSize = 3;
            this.Btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.Location = new System.Drawing.Point(888, 537);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(164, 41);
            this.Btn_actualizar.TabIndex = 97;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Frm_DesempeñodeEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 591);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Dgv_Desempeno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_DesempeñodeEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_DesempeñodeEmpleado";
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Desempeno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Label lbl_Desempeño;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label Lbl_CodEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Promedio;
        private System.Windows.Forms.TextBox Txt_Prome;
        private System.Windows.Forms.Label Lbl_Promedio;
        private System.Windows.Forms.Button Btn_BuscarEmp;
        private System.Windows.Forms.TextBox Txt_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        public System.Windows.Forms.DataGridView Dgv_Desempeno;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Label label1;
    }
}