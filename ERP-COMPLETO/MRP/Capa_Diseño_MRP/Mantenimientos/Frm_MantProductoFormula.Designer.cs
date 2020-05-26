namespace Capa_Diseño_MRP.Mantenimientos
{
    partial class Frm_MantProductoFormula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MantProductoFormula));
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.gpb_formula = new System.Windows.Forms.GroupBox();
            this.btn_agregaringredientes = new System.Windows.Forms.Button();
            this.Btn_buscarformula = new System.Windows.Forms.Button();
            this.Lbl_codigoformula = new System.Windows.Forms.Label();
            this.Txt_codigoformula = new System.Windows.Forms.TextBox();
            this.gpb_componentes = new System.Windows.Forms.GroupBox();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_seleccionar = new System.Windows.Forms.Button();
            this.Txt_codigodetalle = new System.Windows.Forms.TextBox();
            this.Lbl_codigocomponente = new System.Windows.Forms.Label();
            this.Dgv_consultaFormulaDetalle = new System.Windows.Forms.DataGridView();
            this.Formula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Cbo_medida = new System.Windows.Forms.ComboBox();
            this.Lbl_medida = new System.Windows.Forms.Label();
            this.Btn_buscarMateriaPrima = new System.Windows.Forms.Button();
            this.Lbl_materiaprima = new System.Windows.Forms.Label();
            this.Lbl_cantidad = new System.Windows.Forms.Label();
            this.Txt_materiaprima = new System.Windows.Forms.TextBox();
            this.Txt_cantidad = new System.Windows.Forms.TextBox();
            this.Pnl_nombreForm.SuspendLayout();
            this.gpb_formula.SuspendLayout();
            this.gpb_componentes.SuspendLayout();
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
            this.Pnl_nombreForm.Size = new System.Drawing.Size(736, 51);
            this.Pnl_nombreForm.TabIndex = 111;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(644, 8);
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
            this.btn_minimizar.Location = new System.Drawing.Point(609, 8);
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
            this.label1.Size = new System.Drawing.Size(413, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANTENIMIENTO COMPONENTES DE FORMULA";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(681, 8);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(33, 31);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // gpb_formula
            // 
            this.gpb_formula.Controls.Add(this.btn_agregaringredientes);
            this.gpb_formula.Controls.Add(this.Btn_buscarformula);
            this.gpb_formula.Controls.Add(this.Lbl_codigoformula);
            this.gpb_formula.Controls.Add(this.Txt_codigoformula);
            this.gpb_formula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_formula.Location = new System.Drawing.Point(21, 65);
            this.gpb_formula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpb_formula.Name = "gpb_formula";
            this.gpb_formula.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpb_formula.Size = new System.Drawing.Size(688, 90);
            this.gpb_formula.TabIndex = 112;
            this.gpb_formula.TabStop = false;
            this.gpb_formula.Text = "Formula";
            // 
            // btn_agregaringredientes
            // 
            this.btn_agregaringredientes.Location = new System.Drawing.Point(479, 30);
            this.btn_agregaringredientes.Name = "btn_agregaringredientes";
            this.btn_agregaringredientes.Size = new System.Drawing.Size(141, 33);
            this.btn_agregaringredientes.TabIndex = 141;
            this.btn_agregaringredientes.Text = "Agregar Ingredientes";
            this.btn_agregaringredientes.UseVisualStyleBackColor = true;
            this.btn_agregaringredientes.Click += new System.EventHandler(this.btn_agregaringredientes_Click);
            // 
            // Btn_buscarformula
            // 
            this.Btn_buscarformula.Image = ((System.Drawing.Image)(resources.GetObject("Btn_buscarformula.Image")));
            this.Btn_buscarformula.Location = new System.Drawing.Point(330, 25);
            this.Btn_buscarformula.Name = "Btn_buscarformula";
            this.Btn_buscarformula.Size = new System.Drawing.Size(54, 42);
            this.Btn_buscarformula.TabIndex = 140;
            this.Btn_buscarformula.UseVisualStyleBackColor = true;
            this.Btn_buscarformula.Click += new System.EventHandler(this.button3_Click);
            // 
            // Lbl_codigoformula
            // 
            this.Lbl_codigoformula.AutoSize = true;
            this.Lbl_codigoformula.Location = new System.Drawing.Point(89, 40);
            this.Lbl_codigoformula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_codigoformula.Name = "Lbl_codigoformula";
            this.Lbl_codigoformula.Size = new System.Drawing.Size(40, 13);
            this.Lbl_codigoformula.TabIndex = 138;
            this.Lbl_codigoformula.Text = "Codigo";
            // 
            // Txt_codigoformula
            // 
            this.Txt_codigoformula.Location = new System.Drawing.Point(168, 38);
            this.Txt_codigoformula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_codigoformula.Name = "Txt_codigoformula";
            this.Txt_codigoformula.Size = new System.Drawing.Size(146, 20);
            this.Txt_codigoformula.TabIndex = 139;
            // 
            // gpb_componentes
            // 
            this.gpb_componentes.Controls.Add(this.Btn_guardar);
            this.gpb_componentes.Controls.Add(this.Btn_eliminar);
            this.gpb_componentes.Controls.Add(this.Btn_modificar);
            this.gpb_componentes.Controls.Add(this.Btn_cancelar);
            this.gpb_componentes.Controls.Add(this.Btn_seleccionar);
            this.gpb_componentes.Controls.Add(this.Txt_codigodetalle);
            this.gpb_componentes.Controls.Add(this.Lbl_codigocomponente);
            this.gpb_componentes.Controls.Add(this.Dgv_consultaFormulaDetalle);
            this.gpb_componentes.Controls.Add(this.Btn_borrar);
            this.gpb_componentes.Controls.Add(this.Btn_agregar);
            this.gpb_componentes.Controls.Add(this.Cbo_medida);
            this.gpb_componentes.Controls.Add(this.Lbl_medida);
            this.gpb_componentes.Controls.Add(this.Btn_buscarMateriaPrima);
            this.gpb_componentes.Controls.Add(this.Lbl_materiaprima);
            this.gpb_componentes.Controls.Add(this.Lbl_cantidad);
            this.gpb_componentes.Controls.Add(this.Txt_materiaprima);
            this.gpb_componentes.Controls.Add(this.Txt_cantidad);
            this.gpb_componentes.Location = new System.Drawing.Point(21, 160);
            this.gpb_componentes.Name = "gpb_componentes";
            this.gpb_componentes.Size = new System.Drawing.Size(688, 378);
            this.gpb_componentes.TabIndex = 118;
            this.gpb_componentes.TabStop = false;
            this.gpb_componentes.Text = "Componentes";
            this.gpb_componentes.Enter += new System.EventHandler(this.gpb_componentes_Enter);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(545, 48);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_guardar.TabIndex = 152;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Location = new System.Drawing.Point(545, 107);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.Btn_eliminar.TabIndex = 151;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.Location = new System.Drawing.Point(545, 77);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.Btn_modificar.TabIndex = 150;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.UseVisualStyleBackColor = true;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Location = new System.Drawing.Point(582, 304);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancelar.TabIndex = 149;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_seleccionar
            // 
            this.Btn_seleccionar.Location = new System.Drawing.Point(582, 263);
            this.Btn_seleccionar.Name = "Btn_seleccionar";
            this.Btn_seleccionar.Size = new System.Drawing.Size(75, 23);
            this.Btn_seleccionar.TabIndex = 148;
            this.Btn_seleccionar.Text = "Seleccionar";
            this.Btn_seleccionar.UseVisualStyleBackColor = true;
            this.Btn_seleccionar.Click += new System.EventHandler(this.Btn_seleccionar_Click);
            // 
            // Txt_codigodetalle
            // 
            this.Txt_codigodetalle.Location = new System.Drawing.Point(113, 41);
            this.Txt_codigodetalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_codigodetalle.Name = "Txt_codigodetalle";
            this.Txt_codigodetalle.Size = new System.Drawing.Size(75, 20);
            this.Txt_codigodetalle.TabIndex = 147;
            // 
            // Lbl_codigocomponente
            // 
            this.Lbl_codigocomponente.AutoSize = true;
            this.Lbl_codigocomponente.Location = new System.Drawing.Point(59, 41);
            this.Lbl_codigocomponente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_codigocomponente.Name = "Lbl_codigocomponente";
            this.Lbl_codigocomponente.Size = new System.Drawing.Size(40, 13);
            this.Lbl_codigocomponente.TabIndex = 146;
            this.Lbl_codigocomponente.Text = "Codigo";
            // 
            // Dgv_consultaFormulaDetalle
            // 
            this.Dgv_consultaFormulaDetalle.AllowUserToAddRows = false;
            this.Dgv_consultaFormulaDetalle.AllowUserToDeleteRows = false;
            this.Dgv_consultaFormulaDetalle.AllowUserToResizeColumns = false;
            this.Dgv_consultaFormulaDetalle.AllowUserToResizeRows = false;
            this.Dgv_consultaFormulaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaFormulaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Formula,
            this.Producto,
            this.Descripcion,
            this.estado,
            this.Column1,
            this.Column2});
            this.Dgv_consultaFormulaDetalle.Location = new System.Drawing.Point(28, 182);
            this.Dgv_consultaFormulaDetalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dgv_consultaFormulaDetalle.Name = "Dgv_consultaFormulaDetalle";
            this.Dgv_consultaFormulaDetalle.RowHeadersVisible = false;
            this.Dgv_consultaFormulaDetalle.RowHeadersWidth = 51;
            this.Dgv_consultaFormulaDetalle.RowTemplate.Height = 24;
            this.Dgv_consultaFormulaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_consultaFormulaDetalle.Size = new System.Drawing.Size(530, 175);
            this.Dgv_consultaFormulaDetalle.TabIndex = 145;
            this.Dgv_consultaFormulaDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_consultaFormulaDetalle_CellContentClick);
            // 
            // Formula
            // 
            this.Formula.HeaderText = "Formula";
            this.Formula.MinimumWidth = 6;
            this.Formula.Name = "Formula";
            this.Formula.Width = 125;
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
            this.Descripcion.HeaderText = "Materia Prima";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // estado
            // 
            this.estado.HeaderText = "Cantidad";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Medida";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "estado";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.Location = new System.Drawing.Point(545, 136);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_borrar.TabIndex = 144;
            this.Btn_borrar.Text = "Borrar";
            this.Btn_borrar.UseVisualStyleBackColor = true;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.Location = new System.Drawing.Point(545, 19);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.Btn_agregar.TabIndex = 143;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.UseVisualStyleBackColor = true;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Cbo_medida
            // 
            this.Cbo_medida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_medida.FormattingEnabled = true;
            this.Cbo_medida.Items.AddRange(new object[] {
            "Gramo",
            "Litro",
            "Onza",
            "Libra",
            "Metro"});
            this.Cbo_medida.Location = new System.Drawing.Point(307, 92);
            this.Cbo_medida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cbo_medida.Name = "Cbo_medida";
            this.Cbo_medida.Size = new System.Drawing.Size(129, 21);
            this.Cbo_medida.TabIndex = 142;
            // 
            // Lbl_medida
            // 
            this.Lbl_medida.AutoSize = true;
            this.Lbl_medida.Location = new System.Drawing.Point(216, 94);
            this.Lbl_medida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_medida.Name = "Lbl_medida";
            this.Lbl_medida.Size = new System.Drawing.Size(42, 13);
            this.Lbl_medida.TabIndex = 141;
            this.Lbl_medida.Text = "Medida";
            // 
            // Btn_buscarMateriaPrima
            // 
            this.Btn_buscarMateriaPrima.Image = ((System.Drawing.Image)(resources.GetObject("Btn_buscarMateriaPrima.Image")));
            this.Btn_buscarMateriaPrima.Location = new System.Drawing.Point(440, 24);
            this.Btn_buscarMateriaPrima.Name = "Btn_buscarMateriaPrima";
            this.Btn_buscarMateriaPrima.Size = new System.Drawing.Size(54, 42);
            this.Btn_buscarMateriaPrima.TabIndex = 140;
            this.Btn_buscarMateriaPrima.UseVisualStyleBackColor = true;
            this.Btn_buscarMateriaPrima.Click += new System.EventHandler(this.Btn_buscarMateriaPrima_Click);
            // 
            // Lbl_materiaprima
            // 
            this.Lbl_materiaprima.AutoSize = true;
            this.Lbl_materiaprima.Location = new System.Drawing.Point(216, 42);
            this.Lbl_materiaprima.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_materiaprima.Name = "Lbl_materiaprima";
            this.Lbl_materiaprima.Size = new System.Drawing.Size(71, 13);
            this.Lbl_materiaprima.TabIndex = 136;
            this.Lbl_materiaprima.Text = "Materia Prima";
            // 
            // Lbl_cantidad
            // 
            this.Lbl_cantidad.AutoSize = true;
            this.Lbl_cantidad.Location = new System.Drawing.Point(59, 96);
            this.Lbl_cantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_cantidad.Name = "Lbl_cantidad";
            this.Lbl_cantidad.Size = new System.Drawing.Size(49, 13);
            this.Lbl_cantidad.TabIndex = 137;
            this.Lbl_cantidad.Text = "Cantidad";
            // 
            // Txt_materiaprima
            // 
            this.Txt_materiaprima.Location = new System.Drawing.Point(307, 38);
            this.Txt_materiaprima.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_materiaprima.Name = "Txt_materiaprima";
            this.Txt_materiaprima.Size = new System.Drawing.Size(129, 20);
            this.Txt_materiaprima.TabIndex = 138;
            // 
            // Txt_cantidad
            // 
            this.Txt_cantidad.Location = new System.Drawing.Point(113, 92);
            this.Txt_cantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_cantidad.Name = "Txt_cantidad";
            this.Txt_cantidad.Size = new System.Drawing.Size(75, 20);
            this.Txt_cantidad.TabIndex = 139;
            this.Txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_cantidad_KeyPress);
            // 
            // Frm_MantProductoFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 550);
            this.Controls.Add(this.gpb_componentes);
            this.Controls.Add(this.gpb_formula);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_MantProductoFormula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MantProductoFormula";
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.gpb_formula.ResumeLayout(false);
            this.gpb_formula.PerformLayout();
            this.gpb_componentes.ResumeLayout(false);
            this.gpb_componentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaFormulaDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.GroupBox gpb_formula;
        private System.Windows.Forms.Button Btn_buscarformula;
        private System.Windows.Forms.Label Lbl_codigoformula;
        private System.Windows.Forms.TextBox Txt_codigoformula;
        private System.Windows.Forms.GroupBox gpb_componentes;
        private System.Windows.Forms.ComboBox Cbo_medida;
        private System.Windows.Forms.Label Lbl_medida;
        private System.Windows.Forms.Button Btn_buscarMateriaPrima;
        private System.Windows.Forms.Label Lbl_materiaprima;
        private System.Windows.Forms.Label Lbl_cantidad;
        private System.Windows.Forms.TextBox Txt_materiaprima;
        private System.Windows.Forms.TextBox Txt_cantidad;
        private System.Windows.Forms.Button btn_agregaringredientes;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_agregar;
        public System.Windows.Forms.DataGridView Dgv_consultaFormulaDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.TextBox Txt_codigodetalle;
        private System.Windows.Forms.Label Lbl_codigocomponente;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_seleccionar;
    }
}