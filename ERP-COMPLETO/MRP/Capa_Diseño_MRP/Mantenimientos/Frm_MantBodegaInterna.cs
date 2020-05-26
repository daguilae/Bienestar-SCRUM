using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica_MRP;
using Capa_Diseño_MRP.Consultas;
using System.Data.Odbc;

namespace Capa_Diseño_MRP.Mantenimientos
{
    public partial class Frm_MantBodegaInterna : Form
    {
        LIIMRP logic = new LIIMRP();
        Validaciones val = new Validaciones();
        string scampo;

        public Frm_MantBodegaInterna()
        {
            InitializeComponent();
            scampo = logic.siguiente("maestroactivos", "pkidmaestroactivos");
            Txt_Activo.Text = scampo;
            comboBox1.Items.Add("Activo");
            comboBox1.Items.Add("Inactivo");
            bloquearTXT();
            Btn_Buscar.Enabled = false;
        }

        private void Frm_MantBodegaInterna_Load(object sender, EventArgs e)
        {

        }
        
        void bloquearTXT()
        {
            TextBox[] txtBox = { Txt_Activo, Txt_CodProd, Txt_ExistenciaActual, Txt_StockMax, Txt_StockMin }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            for (int i = 0; i < txtBox.Length; i++)
            {
                txtBox[i].Enabled = false;
            }
            //COMBO QUE USARAN 
            ComboBox[] comboBox = { comboBox1 }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            //ComboBox[] comboBox = {comboBox1, comboBox2, etc}   Aqui podemos declarar los combo 
            for (int i = 0; i < comboBox.Length; i++)
            {
                comboBox[i].Enabled = false;
            }
        }

        //Metodo para validar los txt que no esten vacios
        private int validarTXT(TextBox[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (string.IsNullOrEmpty(list[i].Text))
                {
                    MessageBox.Show("Debe completar la informacion en el campo " + list[i].Name);
                    return 0;
                }
            }
            return 1;
        }

        void limpiarTXT(TextBox[] txtBox, ComboBox[] comboBo)
        {
            //Aqui se limpian los txt
            for (int i = 0; i < txtBox.Length; i++)
            {
                txtBox[i].Text = "";
            }
            //Aqui colocamos el siguiente codigo de la tabla y su llave primaria 
            scampo = logic.siguiente("maestroactivos", "COD");
            Txt_Activo.Text = scampo;
            if (comboBox1.Text != "")
            {
                comboBox1.Text = "Activo";
            }
            else
            {
                comboBox1.Text = "Inactivo";
            }
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            TextBox[] txtBox = { Txt_Activo,Txt_CodProd,Txt_ExistenciaActual,Txt_StockMax,Txt_StockMin }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            for (int i = 0; i < txtBox.Length; i++)
            {
                txtBox[i].Enabled = true;
            }
            ComboBox[] comboBox = { comboBox1 }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            for (int i = 0; i < comboBox.Length; i++)
            {
                comboBox[i].Enabled = true;
            }
            Btn_Buscar.Enabled = true;
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            //COMBO QUE USARAN 
            ComboBox[] comboBox = { comboBox1 }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            //ComboBox[] comboBox = {comboBox1, comboBox2, etc}   Aqui podemos declarar los combo 
            //Primero debemos de validar si los txt vienen vacios
            TextBox[] txtBox = { Txt_Activo, Txt_CodProd, Txt_ExistenciaActual, Txt_StockMax, Txt_StockMin }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            //ComboBox[] comboBox = {comboBox1, comboBox2, etc}   Aqui podemos declarar los combo 
            if (validarTXT(txtBox) == 0)
                return;
            else
            {
                if (comboBox1.Text == "Activo")
                {
                    comboBox1.Text = "1";
                }
                else
                {
                    comboBox1.Text = "0";
                }
                //Aqui se declara la tabla donde se ira a modificar y en el segundoa arreglo, se debe de colocar los nombre de los campos.
                string[] valores = { "maestroactivos", Txt_Activo.Text, Txt_CodProd.Text, Txt_ExistenciaActual.Text, Txt_StockMin.Text, Txt_StockMax.Text, comboBox1.Text };
                string[] campos = { "pkidmaestroactivos", "pkidproducto", "existencia_actual", "stock_maximo", "stock_minimo", "estado" };
                if (logic.Modificar(valores, campos) == null)
                    MessageBox.Show("Ocurrio un error al modificar los datos.");
                else
                {
                    MessageBox.Show("Datos modificados exitosamente.");
                    limpiarTXT(txtBox, comboBox); //Si usamos combo, debemos de enviarselo aqui a la funcion y declarar a la funcion que recibe
                    bloquearTXT();
                }
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            //Primero debemos de validar si los txt vienen vacios
            TextBox[] txtBox = { Txt_Activo, Txt_CodProd, Txt_ExistenciaActual, Txt_StockMin, Txt_StockMax }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            //COMBO QUE USARAN 
            ComboBox[] comboBox = { comboBox1 }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            //ComboBox[] comboBox = {comboBox1, comboBox2, etc}   Aqui podemos declarar los combo 
            if (validarTXT(txtBox) == 0)
                return;
            else
            {
                if (comboBox1.Text == "Activo")
                {
                    comboBox1.Text = "1";
                }
                else
                {
                    comboBox1.Text = "0";
                }
                //Aqui se declara la tabla donde se ira a insertar y los txt que se guardaran en el orden de la tabla
                string[] valores = { "maestroactivos", Txt_Activo.Text, Txt_CodProd.Text, Txt_ExistenciaActual.Text, Txt_StockMin.Text, Txt_StockMax.Text, comboBox1.Text };
                if (logic.Insertar(valores) == null)
                    MessageBox.Show("Ocurrio un error al guardar los datos.");
                else
                {
                    MessageBox.Show("Datos guardados exitosamente.");
                    limpiarTXT(txtBox, comboBox); //Si usamos combo, debemos de enviarselo aqui a la funcion y declarar a la funcion que recibe
                    bloquearTXT();
                }
            }
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            //COMBO QUE USARAN 
            ComboBox[] comboBox = { comboBox1 }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            //ComboBox[] comboBox = {comboBox1, comboBox2, etc}   Aqui podemos declarar los combo 
            TextBox[] txtBox = { Txt_Activo, Txt_CodProd, Txt_ExistenciaActual, Txt_StockMax, Txt_StockMin }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            //Aqui se declara la tabla que se ira a eliminar, el codigo por medio del txt y el nombre de la llave primaria.
            string[] valores = { "maestroactivos", Txt_Activo.Text, "pkidmaestroactivos" };
            if (logic.Eliminar(valores) == null)
                MessageBox.Show("Ocurrio un error al borrar los datos.");
            else
            {
                MessageBox.Show("Datos eliminados exitosamente.");
                limpiarTXT(txtBox, comboBox); //Si usamos combo, debemos de enviarselo aqui a la funcion y declarar a la funcion que recibe
                bloquearTXT();
            }
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Consulta_BodegaInterna concep = new Consulta_BodegaInterna();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {

                Txt_Activo.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_CodProd.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_ExistenciaActual.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[2].Value.ToString();  
                Txt_StockMin.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[3].Value.ToString();
                Txt_StockMax.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                     Cells[4].Value.ToString();
                comboBox1.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                    Cells[5].Value.ToString();
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Consulta_Producto concep = new Consulta_Producto();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_CodProd.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }

            Txt_CodProd.Enabled = false;
        }

        private void Txt_CodProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_idProd_Click(object sender, EventArgs e)
        {

        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Txt_ExistenciaActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.CamposNumericos(e);
        }

        private void Txt_StockMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.CamposNumericos(e);
        }

        private void Txt_StockMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.CamposNumericos(e);
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarayuda = logic.consultaayuda("79");
            try
            {
                while (mostrarayuda.Read())
                {
                    ruta = mostrarayuda.GetString(1);
                    indice = mostrarayuda.GetString(2);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            Help.ShowHelp(this, ruta, indice);
        }
    }
}
