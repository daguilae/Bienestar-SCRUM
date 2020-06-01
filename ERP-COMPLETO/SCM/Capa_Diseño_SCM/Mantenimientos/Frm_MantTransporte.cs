using Capa_Datos_SCM;
using Capa_Diseño_SCM.Consultas;
using Capa_Logica_SCM;
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


namespace Capa_Diseño_SCM.Mantenimientos
{
    public partial class Frm_MantTransporte : Form
    {
        LIPSCM logic = new LIPSCM();
        Validaciones v = new Validaciones();
        string scampo;
        string slocalIP;
        string smacAddresses;
        string suser;
        string tipopermiso;
        public Frm_MantTransporte(String susuario, string permiso)
        {
            InitializeComponent();
            
            //--------
            //codigo siguiente 
            scampo = logic.siguiente("transporte", "pkidtransporte");
            //Bitacora
            obtenerip();
            suser = susuario;
            //bloqueo de campos
            bloquear();
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_borrar.Enabled = false;
            Btn_consultar.Enabled = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Transporte";
            Txt_codigotransporte.Text = scampo;
            tipopermiso = permiso;
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

        public void desbloquear()
        {
            Txt_chasis.Enabled = true;
            Txt_codigotransporte.Enabled = true;
            Txt_motor.Enabled = true;
            Txt_placa.Enabled = true;
            Cbo_estado.Enabled = true;
            Txt_Ruta.Enabled = true;
            Txt_TipoTransporte.Enabled = true;
            }
        public void bloquear()
        {
            Txt_chasis.Enabled = false;
            Txt_codigotransporte.Enabled = false;
            Txt_motor.Enabled = false;
            Txt_placa.Enabled = false;
            Cbo_estado.Enabled = false;
            Txt_Ruta.Enabled = false;
            Txt_TipoTransporte.Enabled = false;
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
                desbloquear();
            }
            if (tipopermiso == "1001")
            {
                //Guardar
                Btn_guardar.Enabled = true;
                Btn_editar.Enabled = false;
                Btn_borrar.Enabled = false;
                Btn_consultar.Enabled = true;
                desbloquear();
            }
            if (tipopermiso == "0101")
            {
                //modificar
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = true;
                Btn_borrar.Enabled = false;
                Btn_consultar.Enabled = true;
                desbloquear();
            }
            if (tipopermiso == "0011")
            {
                //eliminar
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = false;
                Btn_borrar.Enabled = true;
                Btn_consultar.Enabled = true;
                desbloquear();
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

        public void limpiar()
        {
            Txt_codigotransporte.Clear();
            Txt_codigotransporte.Focus();
            Txt_motor.Clear();
            Txt_placa.Clear();
            Txt_chasis.Clear();
            Cbo_estado.Text = "";
            Txt_Ruta.Clear();
            Txt_TipoTransporte.Clear();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            permisos();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (Cbo_estado.Text == "Activo")
            {
                Cbo_estado.Text = "1";
            }
            else
            {
                Cbo_estado.Text = "0";
            }
            OdbcDataReader cita = logic.modificartransporte(Txt_codigotransporte.Text, Txt_Ruta.Text, Txt_TipoTransporte.Text, Txt_placa.Text, Txt_chasis.Text, Txt_motor.Text, Cbo_estado.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "SCM", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);
            MessageBox.Show("Datos modificados correctamente.");
            limpiar();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (Cbo_estado.Text == "Activo")
            {
                Cbo_estado.Text = "1";
            }
            else
            {
                Cbo_estado.Text = "0";
            }
            OdbcDataReader cita = logic.insertartransporte(Txt_codigotransporte.Text, Txt_Ruta.Text, Txt_TipoTransporte.Text, Txt_placa.Text, Txt_chasis.Text, Txt_motor.Text, Cbo_estado.Text);
            MessageBox.Show("Datos registrados.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "SCM", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
            limpiar();
            
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            if (Cbo_estado.Text == "Activo")
            {
                Cbo_estado.Text = "1";
            }
            else
            {
                Cbo_estado.Text = "0";
            }
            OdbcDataReader cita = logic.eliminartransporte(Txt_codigotransporte.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "SCM", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);
            MessageBox.Show("Eliminado Correctamentee.");
            limpiar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaTransporte transporte = new Frm_consultaTransporte();
            transporte.ShowDialog();

            if (transporte.DialogResult == DialogResult.OK)
            {
                Txt_codigotransporte.Text = transporte.Dgv_consultaTransporte.Rows[transporte.Dgv_consultaTransporte.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_Ruta.Text = transporte.Dgv_consultaTransporte.Rows[transporte.Dgv_consultaTransporte.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_TipoTransporte.Text = transporte.Dgv_consultaTransporte.Rows[transporte.Dgv_consultaTransporte.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Txt_placa.Text = transporte.Dgv_consultaTransporte.Rows[transporte.Dgv_consultaTransporte.CurrentRow.Index].
                      Cells[3].Value.ToString();
                Txt_chasis.Text = transporte.Dgv_consultaTransporte.Rows[transporte.Dgv_consultaTransporte.CurrentRow.Index].
                      Cells[4].Value.ToString();
                Txt_motor.Text = transporte.Dgv_consultaTransporte.Rows[transporte.Dgv_consultaTransporte.CurrentRow.Index].
                      Cells[5].Value.ToString();
                Cbo_estado.Text = transporte.Dgv_consultaTransporte.Rows[transporte.Dgv_consultaTransporte.CurrentRow.Index].
                      Cells[6].Value.ToString();
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

            OdbcDataReader mostrarayuda = logic.consultaayuda("58");
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

        private void Cbo_tipotransporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Cbo_ruta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_consultaRuta_Click(object sender, EventArgs e)
        {
            Frm_consultaRuta concep = new Frm_consultaRuta();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_Ruta.Text = concep.Dgv_consultaRuta.Rows[concep.Dgv_consultaRuta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }

            Txt_Ruta.Enabled = false;
        }

        private void Btn_BuscarTipoTransporte_Click(object sender, EventArgs e)
        {
            Frm_consultaTipoTransporte concep = new Frm_consultaTipoTransporte();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_TipoTransporte.Text = concep.Dgv_consultaTipoTransporte.Rows[concep.Dgv_consultaTipoTransporte.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }

            Txt_TipoTransporte.Enabled = false;
        }
    }
}
