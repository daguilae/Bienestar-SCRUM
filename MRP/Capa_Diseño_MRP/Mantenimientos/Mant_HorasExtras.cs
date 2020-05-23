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
    public partial class Mant_HorasExtras : Form
    {
        LFCMRP logic = new LFCMRP();
        Validaciones val = new Validaciones();
        string scampo;

        public Mant_HorasExtras()
        {
            InitializeComponent();
            scampo = logic.siguiente("horasextras", "pkcodigohorasextras");
            txt_codigo.Text = scampo;
            DateTime fechaHoy = DateTime.Now;
            string fechaHE = fechaHoy.ToString("yyyy/MM/dd");
            Txt_fechaHE.Text = fechaHE;
            bloquearTXT();
        }

        void bloquearTXT()
        {
            TextBox[] txtBox = { txt_codigo, txt_empleado, txt_cantidad, Txt_fechaHE };
            for (int i = 0; i < txtBox.Length; i++)
            {
                txtBox[i].Enabled = false;
            }
            
            ComboBox[] comboBox = { cbo_estado };            
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
            
            scampo = logic.siguiente("horasextras", "pkcodigohorasextras");
            txt_codigo.Text = scampo;
            if (cbo_estado.Text != "")
            {
                cbo_estado.Text = "Activo";
            }
            else
            {
                cbo_estado.Text = "Inactico";
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

            OdbcDataReader mostrarayuda = logic.consultaayuda("71");
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
            TextBox[] txtBox = { txt_codigo, txt_empleado, txt_cantidad, Txt_fechaHE };
            for (int i = 0; i < txtBox.Length; i++)
            {
                txtBox[i].Enabled = true;
            }
            ComboBox[] comboBox = { cbo_estado };
            for (int i = 0; i < comboBox.Length; i++)
            {
                comboBox[i].Enabled = true;
            }
            txt_codigo.Enabled = false;
            Txt_fechaHE.Enabled = false;
            txt_empleado.Enabled = false;
            
            DateTime fechaHoy = DateTime.Now;
            string fechaHE = fechaHoy.ToString("yyyy/MM/dd");
            Txt_fechaHE.Text = fechaHE;
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            ComboBox[] comboBox = { cbo_estado };
            TextBox[] txtBox = { txt_codigo, txt_empleado, txt_cantidad, Txt_fechaHE };
            
            if (validarTXT(txtBox) == 0)
                return;
            else
            {
                if (cbo_estado.Text == "Activo")
                {
                    cbo_estado.Text = "1";
                }
                else
                {
                    cbo_estado.Text = "0";
                }
                
                string[] valores = { "horasextras", txt_codigo.Text, txt_empleado.Text, txt_cantidad.Text, Txt_fechaHE.Text, cbo_estado.Text };
                string[] campos = { "pkcodigohorasextras", "fkcodigoempleado", "cantidad", "fecha", "estado" };
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
            TextBox[] txtBox = { txt_codigo, txt_empleado, txt_cantidad, Txt_fechaHE };
            ComboBox[] comboBox = { cbo_estado };
            
            if (validarTXT(txtBox) == 0)
                return;
            else
            {
                if (cbo_estado.Text == "Activo")
                {
                    cbo_estado.Text = "1";
                }
                else
                {
                    cbo_estado.Text = "0";
                }
                
                string[] valores = { "horasextras", txt_codigo.Text, txt_empleado.Text, txt_cantidad.Text, Txt_fechaHE.Text, cbo_estado.Text };
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
            ComboBox[] comboBox = { cbo_estado };
            TextBox[] txtBox = { txt_codigo, txt_empleado, txt_cantidad, Txt_fechaHE };
            
            string[] valores = { "horasextras", txt_codigo.Text, "pkcodigohorasextras" };
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
            Consulta_HorasExtras ruta = new Consulta_HorasExtras();
            ruta.ShowDialog();

            if (ruta.DialogResult == DialogResult.OK)
            {
                txt_codigo.Text = ruta.Dgv_consultaHorasExtras.Rows[ruta.Dgv_consultaHorasExtras.CurrentRow.Index].
                      Cells[0].Value.ToString();
                txt_empleado.Text = ruta.Dgv_consultaHorasExtras.Rows[ruta.Dgv_consultaHorasExtras.CurrentRow.Index].
                      Cells[1].Value.ToString();                
                txt_cantidad.Text = ruta.Dgv_consultaHorasExtras.Rows[ruta.Dgv_consultaHorasExtras.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Txt_fechaHE.Text = ruta.Dgv_consultaHorasExtras.Rows[ruta.Dgv_consultaHorasExtras.CurrentRow.Index].
                      Cells[3].Value.ToString();
                cbo_estado.Text = ruta.Dgv_consultaHorasExtras.Rows[ruta.Dgv_consultaHorasExtras.CurrentRow.Index].
                      Cells[4].Value.ToString();
            }
        }

        private void btn_buscarE_Click(object sender, EventArgs e)
        {
            Consulta_Empleado ruta = new Consulta_Empleado();
            ruta.ShowDialog(); 
            txt_empleado.Text=ruta.Dgv_consultaEmpleado.Rows[ruta.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[0].Value.ToString();
            txt_empleado.Enabled = false;
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.CamposNumericos(e);
        }
    }
}
