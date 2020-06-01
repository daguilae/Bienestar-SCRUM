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



    public partial class Frm_MantPerfiles : Form
    {
        Logica logic = new Logica();
        string scampo;

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
        public Frm_MantPerfiles(String susuario, String permiso)
        {
            InitializeComponent();
            codigosiguiente();
            Txt_Cod.Enabled = false;
            txt_extras.Enabled = false;
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_borrar.Enabled = false;
            Btn_consultar.Enabled = false;
            bloquear();
            obtenerip();
            suser = susuario;
            tipopermiso = permiso;
        }
        public void codigosiguiente()
        {
            scampo = logic.siguiente("perfil_encabezado", "pkcodperfil");
            Txt_Cod.Text = scampo;
        }

        public void desbloquear()
        {
            //habilita campos para ingreso de datos
            chc_primaria.Enabled = true;
            chc_secundaria.Enabled = true;
            chc_bachillerato.Enabled = true;
            chc_Estudiante.Enabled = true;
            chc_Graduado.Enabled = true;
            chc_Cursos.Enabled = true;
            Txt_puesto.Enabled = true;
        }

        public void bloquear()
        {
            chc_primaria.Enabled = false;
            chc_secundaria.Enabled = false;
            chc_bachillerato.Enabled = false;
            chc_Estudiante.Enabled = false;
            chc_Graduado.Enabled = false;
            chc_Cursos.Enabled = false;
            Txt_puesto.Enabled = false;
        }

        public void limpiar()
        {
            //chc_primaria.Text = "";
            chc_primaria.Checked = false;
            //chc_secundaria.Text = "";
            chc_secundaria.Checked = false;
            //chc_bachillerato.Text = "";
            chc_bachillerato.Checked = false;
            //chc_Estudiante.Text = "";
            chc_Estudiante.Checked = false;
            //chc_Graduado.Text = "";
            chc_Graduado.Checked = false;
            //chc_Cursos.Text = "";
            chc_Cursos.Checked = false;
            txt_extras.Clear();
            Txt_Cod.Clear();
            Txt_puesto.Clear();
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

        private void btn_buscarCreador_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            permisos();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consltaPerfiles perfil = new Frm_consltaPerfiles();
            perfil.ShowDialog();

            if (perfil.DialogResult == DialogResult.OK)
            {
                Txt_Cod.Text = perfil.Dgv_consultaPerfil.Rows[perfil.Dgv_consultaPerfil.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_puesto.Text = perfil.Dgv_consultaPerfil.Rows[perfil.Dgv_consultaPerfil.CurrentRow.Index].
                      Cells[1].Value.ToString();
                chc_primaria.Text = perfil.Dgv_consultaPerfil.Rows[perfil.Dgv_consultaPerfil.CurrentRow.Index].
                      Cells[2].Value.ToString();
                chc_secundaria.Text = perfil.Dgv_consultaPerfil.Rows[perfil.Dgv_consultaPerfil.CurrentRow.Index].
                      Cells[3].Value.ToString();
                chc_bachillerato.Text = perfil.Dgv_consultaPerfil.Rows[perfil.Dgv_consultaPerfil.CurrentRow.Index].
                      Cells[4].Value.ToString();
                chc_Estudiante.Text = perfil.Dgv_consultaPerfil.Rows[perfil.Dgv_consultaPerfil.CurrentRow.Index].
                      Cells[5].Value.ToString();
                chc_Graduado.Text = perfil.Dgv_consultaPerfil.Rows[perfil.Dgv_consultaPerfil.CurrentRow.Index].
                      Cells[6].Value.ToString();
                chc_Cursos.Text = perfil.Dgv_consultaPerfil.Rows[perfil.Dgv_consultaPerfil.CurrentRow.Index].
                      Cells[7].Value.ToString();
                txt_extras.Text = perfil.Dgv_consultaPerfil.Rows[perfil.Dgv_consultaPerfil.CurrentRow.Index].
                      Cells[8].Value.ToString();
                //primaria
                if(chc_primaria.Text == "1")
                {
                    chc_primaria.Text = "";
                    chc_primaria.Checked = true;
                }
                else
                {
                    chc_primaria.Text = "";
                    chc_primaria.Checked = false;
                }
                //secundaria
                if (chc_secundaria.Text == "1")
                {
                    chc_secundaria.Text = "";
                    chc_secundaria.Checked = true;
                }
                else
                {
                    chc_secundaria.Text = "";
                    chc_secundaria.Checked = false;
                }
                //bachillerato
                if (chc_bachillerato.Text == "1")
                {
                    chc_bachillerato.Text = "";
                    chc_bachillerato.Checked = true;
                }
                else
                {
                    chc_bachillerato.Text = "";
                    chc_bachillerato.Checked = false;
                }
                //estudiante
                if (chc_Estudiante.Text == "1")
                {
                    chc_Estudiante.Text = "";
                    chc_Estudiante.Checked = true;
                }
                else
                {
                    chc_Estudiante.Text = "";
                    chc_Estudiante.Checked = false;
                }
                //Graduado
                if (chc_Graduado.Text == "1")
                {
                    chc_Graduado.Text = "";
                    chc_Graduado.Checked = true;
                }
                else
                {
                    chc_Graduado.Checked = false;
                    chc_Graduado.Text = "";
                }
                //Cursos
                if (chc_Cursos.Text == "1")
                {
                    chc_Cursos.Text = "";
                    chc_Cursos.Checked = true;
                    txt_extras.Enabled = true;
                }
                else
                {
                    chc_Cursos.Text = "";
                    chc_Cursos.Checked = false;
                }
                
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (Txt_puesto.Text == "")
            {
                MessageBox.Show("Debe ingresar el codigo de un puesto ");
            }
            else
            {

                //Conversion a numeros
                bool p, s, b, es, g, c;
                p = chc_primaria.Checked;
                s = chc_secundaria.Checked;
                b = chc_bachillerato.Checked;
                es = chc_Estudiante.Checked;
                g = chc_Graduado.Checked;
                c = chc_Cursos.Checked;

                string p2, s2, b2, es2, g2, c2;
                int p1, s1, b1, es1, g1, c1;

                p1 = Convert.ToInt32(p);
                s1 = Convert.ToInt32(s);
                b1 = Convert.ToInt32(b);
                es1 = Convert.ToInt32(es);
                g1 = Convert.ToInt32(g);
                c1 = Convert.ToInt32(c);

                p2 = p1.ToString();
                s2 = s1.ToString();
                b2 = b1.ToString();
                es2 = es1.ToString();
                g2 = g1.ToString();
                c2 = c1.ToString();

                //MessageBox.Show(p2);
                OdbcDataReader perfil = logic.InsertarPerfil(Txt_Cod.Text, Txt_puesto.Text, p2, s2, b2, es2, g2, c2, txt_extras.Text);
                MessageBox.Show("Perfil Creado.");
                logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
                limpiar();
                codigosiguiente();
            }
        }

        private void Frm_MantPerfiles_Load(object sender, EventArgs e)
        {

        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            //Conversion a numeros
            bool p, s, b, es, g, c;
            p = chc_primaria.Checked;
            s = chc_secundaria.Checked;
            b = chc_bachillerato.Checked;
            es = chc_Estudiante.Checked;
            g = chc_Graduado.Checked;
            c = chc_Cursos.Checked;

            string p2, s2, b2, es2, g2, c2;
            int p1, s1, b1, es1, g1, c1;

            p1 = Convert.ToInt32(p);
            s1 = Convert.ToInt32(s);
            b1 = Convert.ToInt32(b);
            es1 = Convert.ToInt32(es);
            g1 = Convert.ToInt32(g);
            c1 = Convert.ToInt32(c);

            p2 = p1.ToString();
            s2 = s1.ToString();
            b2 = b1.ToString();
            es2 = es1.ToString();
            g2 = g1.ToString();
            c2 = c1.ToString();

            MessageBox.Show(Txt_Cod.Text);
            MessageBox.Show(Txt_puesto.Text);
            MessageBox.Show(p2);
            MessageBox.Show(s2);
            MessageBox.Show(b2);
            MessageBox.Show(es2);
            MessageBox.Show(g2);
            MessageBox.Show(c2);
            MessageBox.Show(txt_extras.Text);

            OdbcDataReader perfil = logic.modificarPerfil(Txt_Cod.Text, Txt_puesto.Text, p2, s2, b2, es2, g2, c2, txt_extras.Text);
            MessageBox.Show("Datos modificados correctamente.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);
            limpiar();
            codigosiguiente();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader perfil = logic.eliminarPerfil(Txt_Cod.Text);
            MessageBox.Show("Eliminado Correctamentee.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);
            limpiar();
            codigosiguiente();
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarEmpleado = logic.consultaayuda("14");
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

        private void chc_Cursos_Click(object sender, EventArgs e)
        {
            if (chc_Cursos.Checked == true)
            {
                txt_extras.Enabled = true;
            }
            else
            {
                txt_extras.Enabled = false;
            }


        }
       
        
    }
}
