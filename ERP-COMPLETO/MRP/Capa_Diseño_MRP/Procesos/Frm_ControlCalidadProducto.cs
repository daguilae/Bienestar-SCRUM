using Capa_Diseño_MRP.Consultas;
using Capa_Diseño_MRP.Mantenimientos;
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
    public partial class Frm_ControlCalidadProducto : Form
    {
        LAPMRP logic = new LAPMRP();
        string scampo;
        string slocalIP;
        string smacAddresses;
        string suser;

        public Frm_ControlCalidadProducto(String susuario)
        {
            InitializeComponent();

            //Bitacora
            obtenerip();
            suser = susuario;
            //bloqueo de campos
            Txt_produccion.Enabled = false;
            Txt_estandar.Enabled = false;
            Txt_estacion.Enabled = false;
            Btn_merma.Enabled = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Control Calidad de Producto";
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

        private void btn_estandar_Click(object sender, EventArgs e)
        {
            Frm_Consulta_EstandarCalidad concep = new Frm_Consulta_EstandarCalidad();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_estandar.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void btn_producción_Click(object sender, EventArgs e)
        {
            Frm_consultaProcesoProduccion concep = new Frm_consultaProcesoProduccion();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_produccion.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Txt_produccion.Text == "" | Txt_cantidad.Text == "" | Txt_estacion.Text == "" | Txt_estandar.Text == "" | Txt_descripcion.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {                
                if (cb_no.Checked == true || cb_si.Checked == true)
                {
                    if (cb_no.Checked == true)
                    {
                        string estado = "0";
                        OdbcDataReader cita = logic.insertarproductocontrolcalidad(Txt_produccion.Text, Txt_estandar.Text, Txt_descripcion.Text, estado);
                        MessageBox.Show("Datos registrados.");
                        logic.bitacora("0", slocalIP, smacAddresses, suser, "MRP", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
                    }
                    else
                    {
                        string estado = "1";
                        OdbcDataReader cita = logic.insertarproductocontrolcalidad(Txt_produccion.Text, Txt_estandar.Text, Txt_descripcion.Text, estado);
                        MessageBox.Show("Datos registrados.");
                        logic.bitacora("0", slocalIP, smacAddresses, suser, "MRP", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar si el producto tiene defectos o no");
                }
            }
        }

        private void cb_si_Click(object sender, EventArgs e)
        {
            if (cb_si.Checked == true)
            {
                Btn_merma.Enabled = true;
            }
            else
            {
                Btn_merma.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Txt_cantidad.Clear();
            Txt_descripcion.Clear();
            Txt_estacion.Clear();
            Txt_estandar.Clear();
            Txt_produccion.Clear();
            cb_no.ResetText();
            cb_si.ResetText();
        }

        private void Btn_merma_Click(object sender, EventArgs e)
        {
            Frm_MantMerma concep = new Frm_MantMerma("");
            concep.ShowDialog();
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

            OdbcDataReader mostrarayuda = logic.consultaayuda("76");
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
