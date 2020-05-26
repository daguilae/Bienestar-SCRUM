using Capa_Diseño_MRP.Consultas;
using Capa_Logica_MRP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Capa_Diseño_MRP.Mantenimientos
{
    public partial class Frm_Mant_Estacion : Form
    {
        LAPMRP logic = new LAPMRP();
        string scampo;

        public Frm_Mant_Estacion()
        {
            InitializeComponent();
            scampo = logic.siguiente("estacion", "pkidestacion");
            txtCodigo.Text = scampo;
            bloquearTXT();
        }

        void bloquearTXT()
        {
            TextBox[] txtBox = { txtCodigo, txtNombre, txtEmpleado }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILZIARAN
            for (int i = 0; i < txtBox.Length; i++)
            {
                txtBox[i].Enabled = false;
            }
            //COMBO QUE USARAN 
            ComboBox[] comboBox = { cmbEstado };

            for (int i = 0; i < comboBox.Length; i++)
            {
                comboBox[i].Enabled = false;
            }
        }

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
            scampo = logic.siguiente("estacion", "pkidestacion");
            txtCodigo.Text = scampo;
            if (cmbEstado.Text != "")
            {
                cmbEstado.Text = "Activo";
            }
            else
            {
                cmbEstado.Text = "Inactico";
            }
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            TextBox[] txtBox = { txtCodigo, txtNombre, txtEmpleado }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILIZAN
            for (int i = 0; i < txtBox.Length; i++)
            {
                txtBox[i].Enabled = true;
            }
            ComboBox[] comboBox = { cmbEstado }; //COLOCAR TODOS LOS TEXTBOX QUE SE UTILIZAN
            for (int i = 0; i < comboBox.Length; i++)
            {
                comboBox[i].Enabled = true;
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            ComboBox[] comboBox = { cmbEstado };
            TextBox[] txtBox = { txtCodigo, txtNombre, txtEmpleado };

            if (validarTXT(txtBox) == 0)
                return;
            else
            {
                if (cmbEstado.Text == "Activo")
                {
                    cmbEstado.Text = "1";
                }
                else
                {
                    cmbEstado.Text = "0";
                }
                //Aqui se declara la tabla donde se ira a modificar y en el segundoa arreglo, se debe de colocar los nombre de los campos.
                string[] valores = { "estacion", txtCodigo.Text, txtNombre.Text, txtEmpleado.Text, cmbEstado.Text };
                string[] campos = { "pkidestacion", "nombre", "pkidempleado", "estado" };
                if (logic.Modificar(valores, campos) == null)
                    MessageBox.Show("Ocurrio un error al modificar los datos.");
                else
                {
                    MessageBox.Show("Datos modificados exitosamente.");
                    limpiarTXT(txtBox, comboBox);
                    bloquearTXT();
                }
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            ComboBox[] comboBox = { cmbEstado };
            TextBox[] txtBox = { txtCodigo, txtNombre,txtEmpleado };

            if (validarTXT(txtBox) == 0)
                return;
            else
            {
                if (cmbEstado.Text == "Activo")
                {
                    cmbEstado.Text = "1";
                }
                else
                {
                    cmbEstado.Text = "0";
                }

                string[] valores = { "estacion", txtCodigo.Text, txtNombre.Text, txtEmpleado.Text, cmbEstado.Text };
                if (logic.Insertar(valores) == null)
                    MessageBox.Show("Ocurrio un error al guardar los datos.");
                else
                {
                    MessageBox.Show("Datos guardados exitosamente.");
                    limpiarTXT(txtBox, comboBox);
                    bloquearTXT();
                }
            }
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            ComboBox[] comboBox = { cmbEstado };
            TextBox[] txtBox = { txtCodigo, txtNombre, txtEmpleado };

            string[] valores = { "estacion", txtCodigo.Text, "pkidestacion" };
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
            Frm_Consulta_Estacion estacion = new Frm_Consulta_Estacion();
            estacion.ShowDialog();

            if (estacion.DialogResult == DialogResult.OK)
            {
                txtCodigo.Text = estacion.Dgv_consulta.Rows[estacion.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
                txtNombre.Text = estacion.Dgv_consulta.Rows[estacion.Dgv_consulta.CurrentRow.Index].
                      Cells[1].Value.ToString();
                txtEmpleado.Text = estacion.Dgv_consulta.Rows[estacion.Dgv_consulta.CurrentRow.Index].
                      Cells[2].Value.ToString();
            }
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarayuda = logic.consultaayuda("73");
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
