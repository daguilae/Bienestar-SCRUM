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
using CapaDiseño.Consulta;
using CapaLogica;

namespace CapaDiseño.Procesos
{


    public partial class Frm_DesempeñodeEmpleado : Form
    {
        public Frm_DesempeñodeEmpleado()
        {
            InitializeComponent();
            MostrarConsulta();
        }

        public void limpiar()
        {
            Txt_Empleado.Text = "";
            Txt_Prome.Text = "";
            

        }

        string scampo;
        string slocalIP;
        string smacAddresses;
        string suser;

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

        Logica logic = new Logica();

        

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_BuscarEmp_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleado concep = new Frm_consultaEmpleado();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_Empleado.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }

            Txt_Empleado.Enabled = false;
        }

        private void Btn_Promedio_Click(object sender, EventArgs e)
        {
            /* OdbcDataReader cita = logic.ConsultaPromedio(Txt_Empleado.Text);
             Txt_Prome.Text = 
             MessageBox.Show("El promedio es: (Verifique la casilla de Promedio).");
             logic.bitacora("0", slocalIP, smacAddresses, suser, "HRM", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);*/

            OdbcDataReader mostrarDatos = logic.ConsultaPromedio(Txt_Empleado.Text);
            try
            {
                while (mostrarDatos.Read())
                {

                    Txt_Prome.Text = mostrarDatos.GetString(0);  

                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            MessageBox.Show("El promedio es: (Verifique la casilla de Promedio).");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "HRM", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
        }

        

        public void MostrarConsulta()
        {


            OdbcDataReader mostrarDatos = logic.ConsultaEvaluacion(Txt_Empleado.Text);
            try
            {
                while (mostrarDatos.Read())
                {

                    Dgv_Desempeno.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetString(3), mostrarDatos.GetString(4), mostrarDatos.GetString(5));

                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_Desempeno.Rows.Clear();
            MostrarConsulta();
            
        }
    }
}
