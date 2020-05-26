using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Diseño_MRP.Consultas;
using Capa_Logica_MRP;
using System.Data.Odbc;

namespace Capa_Diseño_MRP.Procesos
{
    public partial class Frm_SolicitudCompra : Form
    {
        public Frm_SolicitudCompra()
        {
            InitializeComponent();
            bloquearTXT();
            Dtp_Fecha.Enabled = false;
            Btn_Buscar.Enabled=false;
            scampo = logic.siguiente("solicitudactivos", "pkidsolicitudactivos");
            Txt_Activo.Text = scampo;
            comboBox1.Items.Add("Activo");
            comboBox1.Items.Add("Inactivo");

           Dtp_Fecha.Value.ToString("yyyy-MM-dd"); 
        }

        LIIMRP logic = new LIIMRP();
        string scampo;
        Validaciones val = new Validaciones();

        void bloquearTXT()
        {
            TextBox[] txtBox = { Txt_Activo, Txt_CodProd, Txt_Cantidad, Txt_Descripcion }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
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
            Btn_Buscar.Enabled = false;
        }

        private void Btn_Solicitar_Click(object sender, EventArgs e)
        {
            //Primero debemos de validar si los txt vienen vacios
            TextBox[] txtBox = { Txt_Activo, Txt_CodProd, Txt_Cantidad, Txt_Descripcion }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
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
                string[] valores = { "solicitudactivos", Txt_Activo.Text, Txt_Cantidad.Text, Txt_Descripcion.Text, Txt_CodProd.Text, Dtp_Fecha.Value.ToString("yyyy-MM-dd"), comboBox1.Text };
                if (logic.Insertar(valores) == null)
                    MessageBox.Show("Ocurrio un error al guardar los datos.");

                else
                {
                    logic.BotonSolicitar(Txt_CodProd.Text);
                    MessageBox.Show("Solicitud Realizada Exitosamente.");
                    limpiarTXT(txtBox, comboBox); //Si usamos combo, debemos de enviarselo aqui a la funcion y declarar a la funcion que recibe
                    bloquearTXT();
                    MessageBox.Show("Reabastecimiento realizado Exitosamente");
                }
            }                     
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TextBox[] txtBox = { Txt_Activo, Txt_CodProd, Txt_Cantidad, Txt_Descripcion }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            for (int i = 0; i < txtBox.Length; i++)
            {
                txtBox[i].Enabled = true;
            }
            ComboBox[] comboBox = { comboBox1 }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            for (int i = 0; i < comboBox.Length; i++)
            {
                comboBox[i].Enabled = true;
            }

            Dtp_Fecha.Enabled = true;
            Btn_Buscar.Enabled = true;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Txt_Cantidad_TextChanged(object sender, EventArgs e)
        {
        }

        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.CamposNumericos(e);
        }

        private void Txt_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.CamposNumerosYLetras(e);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Consulta_BodegaInterna concep = new Consulta_BodegaInterna();
            concep.ShowDialog();
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarayuda = logic.consultaayuda("85");
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
