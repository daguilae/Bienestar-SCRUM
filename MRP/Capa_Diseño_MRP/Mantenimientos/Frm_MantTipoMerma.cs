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
    public partial class Frm_MantTipoMerma : Form
    {
        LAPMRP logic = new LAPMRP();
        string scampo;
        string slocalIP;
        string smacAddresses;
        string suser;

        public Frm_MantTipoMerma(String susuario)
        {
            InitializeComponent();
            //Bitacora
            obtenerip();
            suser = susuario;
            //bloqueo de campos
            bloquear();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Tipo Merma";            
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
            scampo = logic.siguiente("tipomerma", "pkidtipomerma");
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
            Txt_nombre.Clear();
            Cbo_estado.ResetText();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            OdbcDataReader cita = logic.modificartipomerma(Txt_codigo.Text, Txt_nombre.Text, Txt_descripcion.Text, estado);
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
            OdbcDataReader cita = logic.insertartipomerma(Txt_codigo.Text, Txt_nombre.Text, Txt_descripcion.Text, estado);
            MessageBox.Show("Datos registrados.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "MRP", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
            limpiar();            
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminartipomerma(Txt_codigo.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "MRP", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);
            MessageBox.Show("Eliminado Correctamentee.");
            limpiar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            desbloquear();

            Frm_consultaTipoMerma tipomerma = new Frm_consultaTipoMerma();
            tipomerma.ShowDialog();

            if (tipomerma.DialogResult == DialogResult.OK)
            {
                Txt_codigo.Text = tipomerma.Dgv_consultaTipoMerma.Rows[tipomerma.Dgv_consultaTipoMerma.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombre.Text = tipomerma.Dgv_consultaTipoMerma.Rows[tipomerma.Dgv_consultaTipoMerma.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_descripcion.Text = tipomerma.Dgv_consultaTipoMerma.Rows[tipomerma.Dgv_consultaTipoMerma.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Cbo_estado.Text = tipomerma.Dgv_consultaTipoMerma.Rows[tipomerma.Dgv_consultaTipoMerma.CurrentRow.Index].
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

        private void Frm_MantTipoMerma_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarayuda = logic.consultaayuda("86");
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
