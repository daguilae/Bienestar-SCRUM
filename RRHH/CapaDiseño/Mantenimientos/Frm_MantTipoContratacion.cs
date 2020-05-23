using CapaDiseño.Consulta;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;

namespace CapaDiseño.Mantenimientos
{
    public partial class Frm_MantTipoContratacion : Form
    {
        Logica logic = new Logica();

        string slocalIP;
        string smacAddresses;
        string suser;
        string scampo;
	    string tipopermiso;
        string scontrato, smes, sproyecto, sestado;

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
        public Frm_MantTipoContratacion(String susuario, String permiso)
        {
            InitializeComponent();
            obtenerip();
            suser = susuario;
            codigosiguiente();
            Txt_Codigo.Enabled = false;
            bloqueartxt();
	    
	    /*------------------------*/
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_borrar.Enabled = false;
            /*------------------------*/
            tipopermiso = permiso;
        }

        public void codigosiguiente()
        {
            scampo = logic.siguiente("tipocontratacion", "pkcodigocontratacion");
            Txt_Codigo.Text = scampo;
        }

	public void bloqueartxt()
        {
            
            Cbo_Estado.Enabled = false;
            chc_contrato.Enabled = false;
            chc_mes.Enabled = false;
            chc_proyecto.Enabled = false;
        }
        public void desbloqueartxt()
        {           
            Cbo_Estado.Enabled = true;
            chc_mes.Enabled = true;
            chc_proyecto.Enabled = true;
            chc_contrato.Enabled = true;
        }
        public void limpiar()
        {
            Txt_Codigo.Clear();
            Cbo_Estado.Text = "";
            chc_contrato.Checked = false;
            chc_mes.Checked = false;
            chc_proyecto.Checked = false;
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
        private void Frm_MantTipoContratacion_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarEmpleado = logic.consultaayuda("15");
            try
            {
                while (mostrarEmpleado.Read())
                {
                    ruta = mostrarEmpleado.GetString(1);
                    indice = mostrarEmpleado.GetString(2);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            Help.ShowHelp(this, ruta, indice);
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Pic_Consultar_Click(object sender, EventArgs e)
        {
            Frm_TipoContratacion concep = new Frm_TipoContratacion();
            concep.ShowDialog();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            permisos();
            codigosiguiente();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            string sestado1;
            //estado
            if (Cbo_Estado.Text == "Activo")
            {
                sestado1 = "1";
            }
            else
            {
                sestado1 = "0";
            }

            //tipos de contratos
            string smes1, scontrato1, sproyecto1;
            //contrato
            if (chc_contrato.Checked == true)
            {
                scontrato1 = "1";
            }
            else
            {
                scontrato1 = "0";
            }
            //mes
            if (chc_mes.Checked == true)
            {
                smes1 = "1";
            }
            else
            {
                smes1 = "0";
            }
            //proyecto
            if (chc_proyecto.Checked == true)
            {
                sproyecto1 = "1";
            }
            else
            {
                sproyecto1 = "0";
            }
            MessageBox.Show(Txt_Codigo.Text);
            MessageBox.Show(scontrato1);
            MessageBox.Show(smes1);
            MessageBox.Show(sproyecto1);
            MessageBox.Show(sestado1);
            OdbcDataReader cita = logic.ModificarTC(Txt_Codigo.Text, scontrato1, smes1, sproyecto1, sestado1);
            MessageBox.Show("Datos modificados correctamente.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);
	        limpiar();
            codigosiguiente();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            
                //estado
                if (Cbo_Estado.Text == "Activo")
                {
                    Cbo_Estado.Text = "1";
                }
                else
                {
                    Cbo_Estado.Text = "0";
                }

                //tipos de contratos
                string mes1, contrato1, proyecto1;
                //contrato
                if (chc_contrato.Checked == true)
                {
                    contrato1 = "1";
                }
                else
                {
                    contrato1 = "0";
                }
                //mes
                if (chc_mes.Checked == true)
                {
                    mes1 = "1";
                }
                else
                {
                    mes1 = "0";
                }
                //proyecto
                if (chc_proyecto.Checked == true)
                {
                    proyecto1 = "1";
                }
                else
                {
                    proyecto1 = "0";
                }


                OdbcDataReader cita = logic.InsertarTC(Txt_Codigo.Text, contrato1, mes1, proyecto1, Cbo_Estado.Text);
                MessageBox.Show("Datos insertar correctamente.");
                logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
                limpiar();
                codigosiguiente();
            
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarTC(Txt_Codigo.Text);
            MessageBox.Show("Eliminado Correctamente.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);
	        limpiar();
            codigosiguiente();
        }

        private void chc_contrato_Click(object sender, EventArgs e)
        {
            if(chc_contrato.Checked == true)
            {
                chc_mes.Checked = false;
                chc_proyecto.Checked = false;
            }
        }

        private void chc_proyecto_Click(object sender, EventArgs e)
        {
            if(chc_proyecto.Checked == true)
            {
                chc_mes.Checked = false;
                chc_contrato.Checked = false;
            }
        }

        private void chc_mes_Click(object sender, EventArgs e)
        {
            if(chc_mes.Checked == true)
            {
                chc_proyecto.Checked = false;
                chc_contrato.Checked = false;
            }
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            
            Frm_TipoContratacion concep = new Frm_TipoContratacion();
            concep.ShowDialog();
            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_Codigo.Text = concep.Dgv_consultaContratacion.Rows[concep.Dgv_consultaContratacion.CurrentRow.Index].
                      Cells[0].Value.ToString();
                scontrato = concep.Dgv_consultaContratacion.Rows[concep.Dgv_consultaContratacion.CurrentRow.Index].
                      Cells[1].Value.ToString();
                smes = concep.Dgv_consultaContratacion.Rows[concep.Dgv_consultaContratacion.CurrentRow.Index].
                      Cells[2].Value.ToString();
                sproyecto = concep.Dgv_consultaContratacion.Rows[concep.Dgv_consultaContratacion.CurrentRow.Index].
                      Cells[3].Value.ToString();
                sestado = concep.Dgv_consultaContratacion.Rows[concep.Dgv_consultaContratacion.CurrentRow.Index].
                      Cells[4].Value.ToString();

                //contrato
                if (scontrato == "1")
                {
                    chc_contrato.Checked = true;
                }
                else
                {
                    chc_contrato.Checked = false;
                }
                //mes
                if (smes == "1")
                {
                    chc_mes.Checked = true;
                }
                else
                {
                    chc_mes.Checked = false;
                }
                //proyecto   
                if (sproyecto == "1")
                {

                    chc_proyecto.Checked = true;
                }
                else
                {

                    chc_proyecto.Checked = false;
                }
                if (sestado == "1")
                {
                    Cbo_Estado.Text = "Activo";
                }
                else
                {
                    Cbo_Estado.Text = "Inactivo";
                }

            }
            else
            {
                limpiar();
                codigosiguiente();
            }
            
        }

        private void Cbo_Proyecto_Click(object sender, EventArgs e)
        {

        }
    }
}
