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
    public partial class Frm_MantCuentasContables : Form
    {
        LFCMRP logic = new LFCMRP();
        Validaciones val = new Validaciones();
        string scampo;

        public Frm_MantCuentasContables()
        {
            InitializeComponent();
            scampo = logic.siguiente("cuentas_contable", "pkcodigocuenta");
            txt_codigo.Text = scampo;
            bloquearTXT();
        }

        void bloquearTXT()
        {
            TextBox[] txtBox = { txt_codigo, txt_nombre, txt_monto };
            for (int i = 0; i < txtBox.Length; i++)
            {
                txtBox[i].Enabled = false;
            }

            ComboBox[] comboBox = { cbo_DebeHaber };
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
            for (int i = 0; i < txtBox.Length; i++)
            {
                txtBox[i].Text = "";
            }

            scampo = logic.siguiente("cuentas_contable", "pkcodigocuenta");
            txt_codigo.Text = scampo;
            
            if (cbo_DebeHaber.Text != "")
            {
                cbo_DebeHaber.Text = "Debe";
            }
            else
            {
                cbo_DebeHaber.Text = "Haber";
            }           
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarayuda = logic.consultaayuda("70");
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

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            TextBox[] txtBox = { txt_codigo, txt_nombre, txt_monto };
            for (int i = 0; i < txtBox.Length; i++)
            {
                txtBox[i].Enabled = true;
            }
            ComboBox[] comboBox = { cbo_DebeHaber };
            for (int i = 0; i < comboBox.Length; i++)
            {
                comboBox[i].Enabled = true;
            }
            txt_codigo.Enabled = false;
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            ComboBox[] comboBox = { cbo_DebeHaber };
            TextBox[] txtBox = { txt_codigo, txt_nombre, txt_monto };

            if (validarTXT(txtBox) == 0)
                return;
            else
            {
                if (cbo_DebeHaber.Text == "Debe")
                {
                    cbo_DebeHaber.Text = "1";
                }
                else
                {
                    cbo_DebeHaber.Text = "0";
                }
                
                string[] valores = { "cuentas_contable", txt_codigo.Text, txt_nombre.Text, txt_monto.Text, cbo_DebeHaber.Text };
                string[] campos = { "pkcodigocuenta", "nombre_cuenta", "monto", "debe_haber" };
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
            TextBox[] txtBox = { txt_codigo, txt_nombre, txt_monto };
            ComboBox[] comboBox = { cbo_DebeHaber };

            if (validarTXT(txtBox) == 0)
                return;
            else
            {                
                if (cbo_DebeHaber.Text == "Debe")
                {
                    cbo_DebeHaber.Text = "1";
                }
                else
                {
                    cbo_DebeHaber.Text = "0";
                }
                
                string[] valores = { "cuentas_contable", txt_codigo.Text, txt_nombre.Text, txt_monto.Text, cbo_DebeHaber.Text };
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
            ComboBox[] comboBox = { cbo_DebeHaber };
            TextBox[] txtBox = { txt_codigo, txt_nombre, txt_monto };

            string[] valores = { "cuentas_contable", txt_codigo.Text, "pkcodigocuenta" };
            if (logic.Eliminar(valores) == null)
                MessageBox.Show("Ocurrio un error al borrar los datos.");
            else
            {
                MessageBox.Show("Datos eliminados exitosamente.");
                limpiarTXT(txtBox, comboBox);
                bloquearTXT();
            }
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Consulta_CuentasContables ruta = new Consulta_CuentasContables();
            ruta.ShowDialog();

            if (ruta.DialogResult == DialogResult.OK)
            {
                txt_codigo.Text = ruta.Dgv_consultaCuentasContables.Rows[ruta.Dgv_consultaCuentasContables.CurrentRow.Index].
                      Cells[0].Value.ToString();
                txt_nombre.Text = ruta.Dgv_consultaCuentasContables.Rows[ruta.Dgv_consultaCuentasContables.CurrentRow.Index].
                      Cells[1].Value.ToString();
                txt_monto.Text = ruta.Dgv_consultaCuentasContables.Rows[ruta.Dgv_consultaCuentasContables.CurrentRow.Index].
                      Cells[2].Value.ToString();
                cbo_DebeHaber.Text = ruta.Dgv_consultaCuentasContables.Rows[ruta.Dgv_consultaCuentasContables.CurrentRow.Index].
                      Cells[3].Value.ToString();                
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.CamposLetras(e);
        }

        private void txt_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.CamposNumericos(e);
        }
    }
}
