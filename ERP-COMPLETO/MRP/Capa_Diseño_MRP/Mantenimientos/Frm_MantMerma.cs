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
    public partial class Frm_MantMerma : Form
    {
        LAPMRP logic = new LAPMRP();
        Validaciones v = new Validaciones();
        string scampo;
        string slocalIP;
        string smacAddresses;
        string suser;

        public Frm_MantMerma(String susuario)
        {
            InitializeComponent();
            Txt_tipomerma.Enabled = false;
            Txt_producto.Enabled = false;
            //Bitacora
            obtenerip();
            suser = susuario;
            //bloqueo de campos
            bloquear();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Merma";
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
            scampo = logic.siguiente("merma", "pkidmerma");
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
            Txt_producto.Clear();
            Txt_tipomerma.Clear();
            Txt_valor.Clear();
            Txt_cantidad.Clear();
            Cbo_estado.ResetText();
            
        }

        private void Btn_consultaRuta_Click(object sender, EventArgs e)
        {

        }

        private void Btn_consultaTipoMerma_Click(object sender, EventArgs e)
        {
            Frm_consultaTipoMerma concep = new Frm_consultaTipoMerma();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_tipomerma.Text = concep.Dgv_consultaTipoMerma.Rows[concep.Dgv_consultaTipoMerma.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
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
            OdbcDataReader cita = logic.modificarmerma(Txt_codigo.Text, Txt_tipomerma.Text, Txt_producto.Text, Double.Parse(Txt_cantidad.Text), Double.Parse(Txt_valor.Text), estado);
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
            OdbcDataReader cita = logic.insertarmerma(Txt_codigo.Text, Txt_tipomerma.Text, Txt_producto.Text, Double.Parse(Txt_cantidad.Text), Double.Parse(Txt_valor.Text), estado);
            MessageBox.Show("Datos registrados.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "MRP", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarmerma(Txt_codigo.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "MRP", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);
            MessageBox.Show("Eliminado Correctamentee.");
            limpiar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            desbloquear();

            Frm_consultaMerma merma = new Frm_consultaMerma();
            merma.ShowDialog();

            if (merma.DialogResult == DialogResult.OK)
            {
                Txt_codigo.Text = merma.Dgv_consultaMerma.Rows[merma.Dgv_consultaMerma.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_tipomerma.Text = merma.Dgv_consultaMerma.Rows[merma.Dgv_consultaMerma.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_producto.Text = merma.Dgv_consultaMerma.Rows[merma.Dgv_consultaMerma.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Txt_cantidad.Text = merma.Dgv_consultaMerma.Rows[merma.Dgv_consultaMerma.CurrentRow.Index].
                      Cells[3].Value.ToString();
                Txt_valor.Text = merma.Dgv_consultaMerma.Rows[merma.Dgv_consultaMerma.CurrentRow.Index].
                      Cells[4].Value.ToString();
                Cbo_estado.Text = merma.Dgv_consultaMerma.Rows[merma.Dgv_consultaMerma.CurrentRow.Index].
                      Cells[5].Value.ToString();
            }
        }

        private void Txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Camposdecimales(e);
        }

        private void Txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Camposdecimales(e);
        }

        private void Btn_consultarProducto_Click(object sender, EventArgs e)
        {
            Frm_consultaProductoTerminado concep = new Frm_consultaProductoTerminado();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_producto.Text = concep.Dgv_consultaProductoTerminado.Rows[concep.Dgv_consultaProductoTerminado.CurrentRow.Index].
                      Cells[0].Value.ToString();
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

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarayuda = logic.consultaayuda("82");
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
