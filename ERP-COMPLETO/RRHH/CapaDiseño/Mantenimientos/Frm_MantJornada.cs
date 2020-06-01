using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseño.Consulta;
using CapaLogica;
using System.Data.Odbc;
using System.Net;
using System.Net.NetworkInformation;


namespace CapaDiseño.Mantenimientos
{
    public partial class Frm_MantJornada : Form
    {
        Logica logic = new Logica();

        string slocalIP;
        string smacAddresses;
        string suser;
        string tipopermiso;
       
        

	    
          
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

        public Frm_MantJornada(String susuario,String permiso)
        {
            InitializeComponent();
            obtenerip();
            Txt_codigoJornada.Text= logic.siguiente("jornada", "pkcodigojornada"); 
            suser = susuario;
            tipopermiso = permiso;
            Cbo_estadoJornada.Items.Add("Activo");
            Cbo_estadoJornada.Items.Add("Inactivo");
            /*------------------------*/
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_borrar.Enabled = false;
	    Btn_consultar.Enabled = false;
            /*------------------------*/
	   bloqueartxt();

           
        }
 public void bloqueartxt()
        {
          
            Txt_codigoJornada.Enabled = false;
            Txt_nombreJornada.Enabled = false;
            Txt_horasJornada.Enabled = false;
            Cbo_estadoJornada.Enabled = false;
        }
        public void desbloqueartxt()
        {
            Txt_nombreJornada.Enabled = true;
            Txt_horasJornada.Enabled = true;
            Cbo_estadoJornada.Enabled = true;
        }
        public void limpiar()
        {
            Txt_codigoJornada.Text = "";
            Txt_nombreJornada.Text = "";
            Txt_horasJornada.Text = "";
            Cbo_estadoJornada.Text = "";
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

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarEmpleado = logic.consultaayuda("11");
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

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            permisos();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (Cbo_estadoJornada.Text == "Activo")
            {
                Cbo_estadoJornada.Text = "1";
            }
            else
            {
                Cbo_estadoJornada.Text = "0";
            }
            OdbcDataReader jornada = logic.modificarJornada(Txt_codigoJornada.Text, Txt_nombreJornada.Text, Txt_horasJornada.Text, Cbo_estadoJornada.Text);
            MessageBox.Show("Datos modificados correctamente.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);
	    limpiar();
            bloqueartxt();

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (Cbo_estadoJornada.Text == "Activo")
            {
                Cbo_estadoJornada.Text = "1";
            }
            else
            {
                Cbo_estadoJornada.Text = "0";
            }
            OdbcDataReader jornada = logic.insertarJornada(Txt_codigoJornada.Text, Txt_nombreJornada.Text, Txt_horasJornada.Text, Cbo_estadoJornada.Text);
            MessageBox.Show("Datos registrados.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
	        limpiar();
            Txt_codigoJornada.Text = logic.siguiente("jornada", "pkcodigojornada");
            bloqueartxt();

        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader jornada = logic.eliminarJornada(Txt_codigoJornada.Text);
            MessageBox.Show("Eliminado Correctamentee.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);
	    limpiar();
            bloqueartxt();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaJornada concep = new Frm_consultaJornada();
            concep.ShowDialog();
            
            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_codigoJornada.Text = concep.Dgv_consultaJornada.Rows[concep.Dgv_consultaJornada.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombreJornada.Text = concep.Dgv_consultaJornada.Rows[concep.Dgv_consultaJornada.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_horasJornada.Text = concep.Dgv_consultaJornada.Rows[concep.Dgv_consultaJornada.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Cbo_estadoJornada.Text = concep.Dgv_consultaJornada.Rows[concep.Dgv_consultaJornada.CurrentRow.Index].
                     Cells[3].Value.ToString();
            }
        }

        private void Cbo_estadoJornada_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Frm_MantJornada_Load(object sender, EventArgs e)
        {

        }
    }
}
