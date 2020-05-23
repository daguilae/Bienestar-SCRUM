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
using CapaLogica;
using CapaDiseño.Consulta;

namespace CapaDiseño.Mantenimientos
{
    public partial class Frm_MantMeta : Form
    {
        string scampo;
        string slocalIP;
        string smacAddresses;
        string suser;
        Logica logic = new Logica();
        string tipopermiso;

        public Frm_MantMeta(string usuario, String permiso)
        {
            InitializeComponent();
            bloqueartxt();
            scampo = logic.siguiente("meta", "pkcodigo_meta");
            Txt_Codigo.Text = scampo;
            Cbo_Estado.Items.Add("Activo");
            Cbo_Estado.Items.Add("Inactivo");
            suser = usuario;
            tipopermiso = permiso;
	     /*------------------------*/
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_borrar.Enabled = false;
	    Btn_consultar.Enabled = true;
            /*------------------------*/
            bloqueartxt();

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

        private void Label_MantEmpleados_Click(object sender, EventArgs e)
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

        public void bloqueartxt()
        {
           

            Txt_Codigo.Enabled = false;
            Txt_Nombre.Enabled = false;
            Txt_Descripcion.Enabled = false;
            Txt_Plazo.Enabled = false;
            Txt_Puntaje.Enabled = false;
            Cbo_Estado.Enabled=false;

        }
        public void desbloqueartxt()
        {
            Txt_Nombre.Enabled = true;
            Txt_Descripcion.Enabled = true;
            Txt_Plazo.Enabled = true;
            Txt_Puntaje.Enabled = true;
            Cbo_Estado.Enabled = true;
        }

        public void limpiar()
        {
            Txt_Codigo.Text = "";
            Txt_Nombre.Text = "";
            Txt_Descripcion.Text = "";
            Txt_Plazo.Text = "";
            Txt_Puntaje.Text = "";
            Cbo_Estado.Text = "";
        }
	
	public void permisos()
        {
            if (tipopermiso == "1111")
            {
                //todos
                Btn_guardar.Enabled = true;
                Btn_editar.Enabled = true;
                Btn_borrar.Enabled = true;
                Btn_consultar.Enabled = true;
                desbloqueartxt();
            }
            if (tipopermiso == "1001")
            {
                //Guardar
                Btn_guardar.Enabled = true;
                Btn_editar.Enabled = false;
                Btn_borrar.Enabled = false;
                Btn_consultar.Enabled = true;
                desbloqueartxt();
            }
            if (tipopermiso == "0101")
            {
                //modificar
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = true;
                Btn_borrar.Enabled = false;
                Btn_consultar.Enabled = true;
                desbloqueartxt();
            }
            if (tipopermiso == "0011")
            {
                //eliminar
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = false;
                Btn_borrar.Enabled = true;
                Btn_consultar.Enabled = true;
                desbloqueartxt();
            }
            if (tipopermiso == "0001")
            {
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = false;
                Btn_borrar.Enabled = false;
                Btn_ingresar.Enabled = false;
                Btn_consultar.Enabled = true;
            }
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaMeta concep = new Frm_consultaMeta();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {

                Txt_Codigo.Text = concep.Dgv_consultaMeta.Rows[concep.Dgv_consultaMeta.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_Nombre.Text = concep.Dgv_consultaMeta.Rows[concep.Dgv_consultaMeta.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_Descripcion.Text = concep.Dgv_consultaMeta.Rows[concep.Dgv_consultaMeta.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Txt_Plazo.Text = concep.Dgv_consultaMeta.Rows[concep.Dgv_consultaMeta.CurrentRow.Index].
                      Cells[3].Value.ToString();
                Txt_Puntaje.Text = concep.Dgv_consultaMeta.Rows[concep.Dgv_consultaMeta.CurrentRow.Index].
                     Cells[4].Value.ToString();
                Cbo_Estado.Text = concep.Dgv_consultaMeta.Rows[concep.Dgv_consultaMeta.CurrentRow.Index].
                    Cells[5].Value.ToString();


            }
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            if (Cbo_Estado.Text == "Activo")
            {
                Cbo_Estado.Text = "1";
            }
            else
            {
                Cbo_Estado.Text = "0";
            }

            OdbcDataReader cita = logic.Eliminarmeta(Txt_Codigo.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "HRM", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);
            MessageBox.Show("Eliminado Correctamente.");
            limpiar();
            bloqueartxt();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (Cbo_Estado.Text == "Activo")
            {
                Cbo_Estado.Text = "1";
            }
            else
            {
                Cbo_Estado.Text = "0";
            }
            OdbcDataReader cita = logic.InsertarMeta(Txt_Codigo.Text, Txt_Nombre.Text, Txt_Descripcion.Text, Txt_Plazo.Text, Txt_Puntaje.Text, Cbo_Estado.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "HRM", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);
            MessageBox.Show("Datos guardados correctamente.");
            limpiar();
            bloqueartxt();

        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (Cbo_Estado.Text == "Activo")
            {
                Cbo_Estado.Text = "1";
            }
            else
            {
                Cbo_Estado.Text = "0";
            }

            OdbcDataReader cita = logic.ModificarMeta(Txt_Codigo.Text, Txt_Nombre.Text, Txt_Descripcion.Text, Txt_Plazo.Text, Txt_Puntaje.Text, Cbo_Estado.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "HRM", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);
            MessageBox.Show("Datos modificados correctamente.");
            limpiar();
            bloqueartxt();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            permisos();
        }
    }
}
