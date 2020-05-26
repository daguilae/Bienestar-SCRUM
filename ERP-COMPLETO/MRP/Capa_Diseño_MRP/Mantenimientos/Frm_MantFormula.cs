using Capa_Diseño_MRP.Consultas;
using Capa_Logica_MRP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Diseño_MRP.Mantenimientos
{
    public partial class Frm_MantFormula : Form
    {
        LAPMRP logic = new LAPMRP();
        string scampo;
        string slocalIP;
        string smacAddresses;
        string suser;

        public Frm_MantFormula(String susuario)
        {
            InitializeComponent();
            //Bitacora
            obtenerip();
            suser = susuario;
            Txt_producto.Enabled = false;
            //bloqueo de campos
            bloquear();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Formula";
        }

        public void obtenerip()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    slocalIP = ip.ToString();
                }
            }
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    smacAddresses += nic.GetPhysicalAddress().ToString();
                    break;

                }
            }
        }

        public void codigosiguiente()
        {
            //codigo siguiente 
            scampo = logic.siguiente("formula_encabezado", "pkidformulaencabezado");
            Txt_codigo.Text = scampo;
        }

        public void bloquear()
        {
            gpb_datos.Enabled = false;
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_borrar.Enabled = false;
        }

        public void desbloquear()
        {
            gpb_datos.Enabled = true;
            Btn_guardar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_borrar.Enabled = true;
        }

        public void limpiar()
        {
            Txt_codigo.Clear();
            Txt_descripcion.Clear();
            Txt_producto.Clear();
            Cbo_estado.ResetText();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloquear();
            codigosiguiente();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            string estado = "0";
            if (Cbo_estado.Text == "Activo")
            {
                estado = "1";
            }
            if (Cbo_estado.Text == "Inactivo")
            {
                estado = "0";
            }
            OdbcDataReader cita = logic.modificarformulaencabezado(Txt_codigo.Text, Txt_producto.Text, Txt_descripcion.Text, estado);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "MRP", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);
            MessageBox.Show("Datos modificados correctamente.");
            limpiar();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            string estado = "0";
            if (Cbo_estado.Text == "Activo")
            {
                estado = "1";
            }
            if (Cbo_estado.Text == "Inactivo")
            {
                estado = "0";
            }
            OdbcDataReader cita = logic.insertarformulaencabezado(Txt_codigo.Text, Txt_producto.Text, Txt_descripcion.Text, estado);
            MessageBox.Show("Datos registrados.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "MRP", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarformulaencabezado(Txt_codigo.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "MRP", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);
            MessageBox.Show("Eliminado Correctamentee.");
            limpiar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            desbloquear();

            Frm_consultaFormula formula_encabezado = new Frm_consultaFormula();
            formula_encabezado.ShowDialog();

            if (formula_encabezado.DialogResult == DialogResult.OK)
            {
                Txt_codigo.Text = formula_encabezado.Dgv_consultaFormula.Rows[formula_encabezado.Dgv_consultaFormula.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_producto.Text = formula_encabezado.Dgv_consultaFormula.Rows[formula_encabezado.Dgv_consultaFormula.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_descripcion.Text = formula_encabezado.Dgv_consultaFormula.Rows[formula_encabezado.Dgv_consultaFormula.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Cbo_estado.Text = formula_encabezado.Dgv_consultaFormula.Rows[formula_encabezado.Dgv_consultaFormula.CurrentRow.Index].
                      Cells[3].Value.ToString();
            }
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_consultaProducto_Click(object sender, EventArgs e)
        {
            Frm_consultaProductoTerminado concep = new Frm_consultaProductoTerminado();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_producto.Text = concep.Dgv_consultaProductoTerminado.Rows[concep.Dgv_consultaProductoTerminado.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarayuda = logic.consultaayuda("81");
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
