namespace Capa_Diseño_MRP.Procesos
{
    partial class Frm_AsignacionEstacionPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AsignacionEstacionPedido));
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_producción = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_asignar = new System.Windows.Forms.Button();
            this.Btn_estacion = new System.Windows.Forms.Button();
            this.Txt_estacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_produccion = new System.Windows.Forms.TextBox();
            this.Lbl_codigoacreedor = new System.Windows.Forms.Label();
            this.Dgv_consultaFormulaDetalle = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnl_nombreForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaFormulaDetalle)).BeginInit();
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
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(698, 51);
            this.Pnl_nombreForm.TabIndex = 113;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(613, 12);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btn_minimizar.Location = new System.Drawing.Point(578, 12);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASIGNACION DE ESTACIÓN A PRODUCCIÓN";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(651, 12);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(33, 31);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_producción);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.btn_asignar);
            this.groupBox1.Controls.Add(this.Btn_estacion);
            this.groupBox1.Controls.Add(this.Txt_estacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txt_produccion);
            this.groupBox1.Controls.Add(this.Lbl_codigoacreedor);
            this.groupBox1.Location = new System.Drawing.Point(35, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 137);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estación";
            // 
            // Btn_producción
            // 
            this.Btn_producción.Image = ((System.Drawing.Image)(resources.GetObject("Btn_producción.Image")));
            this.Btn_producción.Location = new System.Drawing.Point(256, 26);
            this.Btn_producción.Name = "Btn_producción";
            this.Btn_producción.Size = new System.Drawing.Size(54, 42);
            this.Btn_producción.TabIndex = 152;
            this.Btn_producción.UseVisualStyleBackColor = true;
            this.Btn_producción.Click += new System.EventHandler(this.Btn_producción_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(351, 98);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 150;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_asignar
            // 
            this.btn_asignar.Location = new System.Drawing.Point(255, 98);
            this.btn_asignar.Name = "btn_asignar";
            this.btn_asignar.Size = new System.Drawing.Size(75, 23);
            this.btn_asignar.TabIndex = 145;
            this.btn_asignar.Text = "Asignar";
            this.btn_asignar.UseVisualStyleBackColor = true;
            this.btn_asignar.Click += new System.EventHandler(this.btn_asignar_Click);
            // 
            // Btn_estacion
            // 
            this.Btn_estacion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_estacion.Image")));
            this.Btn_estacion.Location = new System.Drawing.Point(561, 26);
            this.Btn_estacion.Name = "Btn_estacion";
            this.Btn_estacion.Size = new System.Drawing.Size(54, 42);
            this.Btn_estacion.TabIndex = 151;
            this.Btn_estacion.UseVisualStyleBackColor = true;
            this.Btn_estacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_estacion
            // 
            this.Txt_estacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_estacion.Location = new System.Drawing.Point(399, 41);
            this.Txt_estacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_estacion.Name = "Txt_estacion";
            this.Txt_estacion.Size = new System.Drawing.Size(146, 20);
            this.Txt_estacion.TabIndex = 145;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 144;
            this.label4.Text = "Estación";
            // 
            // Txt_produccion
            // 
            this.Txt_produccion.Location = new System.Drawing.Point(98, 40);
            this.Txt_produccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_produccion.Name = "Txt_produccion";
            this.Txt_produccion.Size = new System.Drawing.Size(146, 20);
            this.Txt_produccion.TabIndex = 143;
            // 
            // Lbl_codigoacreedor
            // 
            this.Lbl_codigoacreedor.AutoSize = true;
            this.Lbl_codigoacreedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigoacreedor.Location = new System.Drawing.Point(17, 43);
            this.Lbl_codigoacreedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_codigoacreedor.Name = "Lbl_codigoacreedor";
            this.Lbl_codigoacreedor.Size = new System.Drawing.Size(61, 13);
            this.Lbl_codigoacreedor.TabIndex = 140;
            this.Lbl_codigoacreedor.Text = "Producción";
            // 
            // Dgv_consultaFormulaDetalle
            // 
            this.Dgv_consultaFormulaDetalle.AllowUserToAddRows = false;
            this.Dgv_consultaFormulaDetalle.AllowUserToDeleteRows = false;
            this.Dgv_consultaFormulaDetalle.AllowUserToResizeColumns = false;
            this.Dgv_consultaFormulaDetalle.AllowUserToResizeRows = false;
            this.Dgv_consultaFormulaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaFormulaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Descripcion,
            this.estado,
            this.Column1});
            this.Dgv_consultaFormulaDetalle.Location = new System.Drawing.Point(93, 216);
            this.Dgv_consultaFormulaDetalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dgv_consultaFormulaDetalle.Name = "Dgv_consultaFormulaDetalle";
            this.Dgv_consultaFormulaDetalle.RowHeadersVisible = false;
            this.Dgv_consultaFormulaDetalle.RowHeadersWidth = 51;
            this.Dgv_consultaFormulaDetalle.RowTemplate.Height = 24;
            this.Dgv_consultaFormulaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_consultaFormulaDetalle.Size = new System.Drawing.Size(504, 175);
            this.Dgv_consultaFormulaDetalle.TabIndex = 146;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Codigo";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Proceso";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // estado
            // 
            this.estado.HeaderText = "Producción";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Estación";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Frm_AsignacionEstacionPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 411);
            this.Controls.Add(this.Dgv_consultaFormulaDetalle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_AsignacionEstacionPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AsignacionEstacionPedido";
            this.Load += new System.EventHandler(this.Frm_AsignacionEstacionPedido_Load);
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaFormulaDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_estacion;
        private System.Windows.Forms.TextBox Txt_estacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_produccion;
        private System.Windows.Forms.Label Lbl_codigoacreedor;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_asignar;
        public System.Windows.Forms.DataGridView Dgv_consultaFormulaDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button Btn_producción;
    }
}