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

namespace Capa_Diseño_MRP.Procesos
{
    public partial class Frm_AsignacionEstacionPedido : Form
    {
        LAPMRP logic = new LAPMRP();
        string scampo;
        string slocalIP;
        string smacAddresses;
        string suser;

        public Frm_AsignacionEstacionPedido(String susuario)
        {
            InitializeComponent();
            
            //Bitacora
            obtenerip();
            suser = susuario;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Asignacion de Estacion a Producción";
            Txt_produccion.Enabled = false;
            Txt_estacion.Enabled = false;
        }

        public void MostrarTabla()
        {
            OdbcDataReader mostrar = logic.consultarasignacion();
            try
            {
                while (mostrar.Read())
                {
                    Dgv_consultaFormulaDetalle.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Consulta_Estacion concep = new Frm_Consulta_Estacion();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_estacion.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void btn_asignar_Click(object sender, EventArgs e)
        {
            if (Txt_estacion.Text == "" | Txt_produccion.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                OdbcDataReader cita = logic.insertarprocesoproduccion(Txt_produccion.Text, Txt_estacion.Text);
                MessageBox.Show("Datos registrados.");
                logic.bitacora("0", slocalIP, smacAddresses, suser, "MRP", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
                Txt_estacion.Clear();
                Txt_produccion.Clear();
                Dgv_consultaFormulaDetalle.Rows.Clear();
                MostrarTabla();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Txt_estacion.Clear();
            Txt_produccion.Clear();
        }

        private void Frm_AsignacionEstacionPedido_Load(object sender, EventArgs e)
        {
            Dgv_consultaFormulaDetalle.Rows.Clear();
            MostrarTabla();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_producción_Click(object sender, EventArgs e)
        {
            Frm_ConsultaEncabezadoProduccion concep = new Frm_ConsultaEncabezadoProduccion();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_produccion.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarayuda = logic.consultaayuda("74");
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
