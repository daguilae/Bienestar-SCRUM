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
using CapaDiseño.Consulta;
using CapaLogica;
using System.Net;
using System.Net.NetworkInformation;


namespace CapaDiseño.Mantenimientos
{
    public partial class Frm_ManteDepartamento : Form
    {
        Logica logic = new Logica();
        string scampo;
        string suser;
	string tipopermiso;
	

        string slocalIP;
        string smacAddresses;
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


        public Frm_ManteDepartamento(String susuario, String permiso)
        {
            InitializeComponent();
            scampo = logic.siguiente("departamentos", "pkcodigodepto");
            
            obtenerip();
            suser = susuario;
	    Txt_Cod.Text = scampo;
            bloqueartxt();
  		/*------------------------*/
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_borrar.Enabled = false;
	    Btn_consultar.Enabled = false;
            /*------------------------*/
            tipopermiso = permiso;
        }

	 public void bloqueartxt()
        {
          
            txt_descripcion.Enabled = false;
            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = false;
        }
        public void desbloqueartxt()
        {           
      		
            txt_descripcion.Enabled = true;
            Txt_Cod.Enabled = true;
            Txt_nombre.Enabled = true;
        }

        public void limpiar()
        {
            txt_descripcion.Text = "";
            Txt_Cod.Text = "";
            Txt_nombre.Text = "";
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


        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
          permisos();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader departamentos = logic.modificarDepartamento(Txt_Cod.Text, Txt_nombre.Text, txt_descripcion.Text);
            MessageBox.Show("Datos modificados correctamente.");
            scampo = logic.siguiente("departamentos", "pkcodigodepto");
            Txt_Cod.Text = scampo;
            Txt_nombre.Text = "";
            txt_descripcion.Text = "";
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);
	    limpiar();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader departamentos = logic.InsertarDepartamento(Txt_Cod.Text, Txt_nombre.Text, txt_descripcion.Text);
            MessageBox.Show("Departamento Insertado correctamente.");
            scampo = logic.siguiente("departamentos", "pkcodigodepto");
            Txt_Cod.Text = scampo;
            Txt_nombre.Text = "";
            txt_descripcion.Text = "";
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
	    limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader perfil = logic.eliminarDepartamento(Txt_Cod.Text);
            MessageBox.Show("Eliminado Correctamentee.");
            scampo = logic.siguiente("departamentos", "pkcodigodepto");
            Txt_Cod.Text = scampo;
            Txt_nombre.Text = "";
            txt_descripcion.Text = "";
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);
	    limpiar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaDepartamento perfil = new Frm_consultaDepartamento();
            perfil.ShowDialog();

            if (perfil.DialogResult == DialogResult.OK)
            {
                Txt_Cod.Text = perfil.Dgv_consultaDepartamento.Rows[perfil.Dgv_consultaDepartamento.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombre.Text = perfil.Dgv_consultaDepartamento.Rows[perfil.Dgv_consultaDepartamento.CurrentRow.Index].
                   Cells[1].Value.ToString();
                txt_descripcion.Text = perfil.Dgv_consultaDepartamento.Rows[perfil.Dgv_consultaDepartamento.CurrentRow.Index].
                   Cells[2].Value.ToString();
            }
        }

        private void Frm_ManteDepartamento_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarEmpleado = logic.consultaayuda("4");
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
    }
}
