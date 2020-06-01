namespace Capa_Diseño_MRP.Procesos
{
    partial class Frm_SeleccionPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SeleccionPedido));
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Dgv_consulta = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTn_guardar = new System.Windows.Forms.Button();
            this.Lbl_codPercepcion = new System.Windows.Forms.Label();
            this.Txt_Cod = new System.Windows.Forms.TextBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.Pnl_nombreForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consulta)).BeginInit();
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
            this.Pnl_nombreForm.Size = new System.Drawing.Size(852, 51);
            this.Pnl_nombreForm.TabIndex = 3;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(762, 8);
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
            this.btn_minimizar.Location = new System.Drawing.Point(727, 8);
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
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECCION PEDIDO";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(800, 8);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(33, 31);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Dgv_consulta
            // 
            this.Dgv_consulta.AllowUserToAddRows = false;
            this.Dgv_consulta.AllowUserToDeleteRows = false;
            this.Dgv_consulta.AllowUserToResizeColumns = false;
            this.Dgv_consulta.AllowUserToResizeRows = false;
            this.Dgv_consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.codP,
            this.nombre,
            this.cantidad,
            this.orden});
            this.Dgv_consulta.Location = new System.Drawing.Point(11, 108);
            this.Dgv_consulta.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_consulta.MultiSelect = false;
            this.Dgv_consulta.Name = "Dgv_consulta";
            this.Dgv_consulta.ReadOnly = true;
            this.Dgv_consulta.RowHeadersVisible = false;
            this.Dgv_consulta.RowHeadersWidth = 51;
            this.Dgv_consulta.RowTemplate.Height = 24;
            this.Dgv_consulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_consulta.Size = new System.Drawing.Size(822, 258);
            this.Dgv_consulta.TabIndex = 80;
            this.Dgv_consulta.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_consulta_CellContentDoubleClick);
            this.Dgv_consulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_consulta_CellDoubleClick);
            // 
            // cod
            // 
            this.cod.HeaderText = "COD";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            // 
            // codP
            // 
            this.codP.HeaderText = "COD Producto";
            this.codP.Name = "codP";
            this.codP.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre Producto";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // orden
            // 
            this.orden.HeaderText = "COD Orden Produccion";
            this.orden.Name = "orden";
            this.orden.ReadOnly = true;
            // 
            // BTn_guardar
            // 
            this.BTn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTn_guardar.FlatAppearance.BorderSize = 3;
            this.BTn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BTn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.BTn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTn_guardar.Location = new System.Drawing.Point(573, 65);
            this.BTn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.BTn_guardar.Name = "BTn_guardar";
            this.BTn_guardar.Size = new System.Drawing.Size(126, 28);
            this.BTn_guardar.TabIndex = 107;
            this.BTn_guardar.Text = "Generar orden";
            this.BTn_guardar.UseVisualStyleBackColor = true;
            this.BTn_guardar.Click += new System.EventHandler(this.BTn_guardar_Click);
            // 
            // Lbl_codPercepcion
            // 
            this.Lbl_codPercepcion.AutoSize = true;
            this.Lbl_codPercepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codPercepcion.Location = new System.Drawing.Point(180, 70);
            this.Lbl_codPercepcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_codPercepcion.Name = "Lbl_codPercepcion";
            this.Lbl_codPercepcion.Size = new System.Drawing.Size(96, 18);
            this.Lbl_codPercepcion.TabIndex = 106;
            this.Lbl_codPercepcion.Text = "COD Pedido:";
            // 
            // Txt_Cod
            // 
            this.Txt_Cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cod.Location = new System.Drawing.Point(287, 67);
            this.Txt_Cod.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Cod.Name = "Txt_Cod";
            this.Txt_Cod.Size = new System.Drawing.Size(282, 24);
            this.Txt_Cod.TabIndex = 105;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_actualizar.FlatAppearance.BorderSize = 3;
            this.btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Location = new System.Drawing.Point(707, 380);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(126, 28);
            this.btn_actualizar.TabIndex = 108;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // Frm_SeleccionPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 421);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.BTn_guardar);
            this.Controls.Add(this.Lbl_codPercepcion);
            this.Controls.Add(this.Txt_Cod);
            this.Controls.Add(this.Dgv_consulta);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_SeleccionPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_SeleccionPedido";
            this.Load += new System.EventHandler(this.Frm_SeleccionPedido_Load);
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cerrar;
        public System.Windows.Forms.DataGridView Dgv_consulta;
        private System.Windows.Forms.Button BTn_guardar;
        private System.Windows.Forms.Label Lbl_codPercepcion;
        private System.Windows.Forms.TextBox Txt_Cod;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn codP;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden;
    }
}