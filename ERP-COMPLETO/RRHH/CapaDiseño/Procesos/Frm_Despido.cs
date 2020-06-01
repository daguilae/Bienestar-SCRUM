using CapaDiseño.Consulta;
using CapaLogica;
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

namespace CapaDiseño.Procesos
{
    public partial class Frm_Despido : Form
    {
        Logica Logic = new Logica();
        //bitacora
        string slocalIP;
        string smacAddresses;
        string suser;

        public Frm_Despido(String susuario)
        {
            InitializeComponent();
            //bloqueo 
            Gpb_DatosEmpleado.Enabled = false;
            Gpb_DatosContratoEmpleado.Enabled = false;
            Gpb_Despido.Enabled = false;
            Gpb_Indemnizacion.Enabled = false;
            //bitacora
            obtenerip();
            suser = susuario;
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

        public void LimpiarTodos()
        {
            Txt_CodigoEmpleado.Clear();
            Txt_PrimerNombre.Clear();
            Txt_SegundoNombre.Clear();
            Txt_PrimerApellido.Clear();
            Txt_SegundoApellido.Clear();
            Txt_Telefono.Clear();
            Dtp_FechaInicioContrato.ResetText();
            Dtp_FechaFinalContrato.ResetText();
            Dtp_FechaFinalContrato2.ResetText();
            Txt_Jornada.Clear();
            Txt_DiasLaborados.Clear();
            Txt_Indemnizacion.Clear();
            Txt_Jornada.Clear();
            Txt_RazonDespido.Clear();
            Txt_SueldoFinal.Clear();
            Txt_Descripcion.Clear();
        }

        private void Btn_ConsultarEmpleados_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleado consultaempleado = new Frm_consultaEmpleado();
            consultaempleado.ShowDialog();
            if (consultaempleado.DialogResult == DialogResult.OK)
            {
                Txt_CodigoEmpleado.Text = consultaempleado.Dgv_consultaEmpleado.Rows[consultaempleado.Dgv_consultaEmpleado.CurrentRow.Index].Cells[0].Value.ToString();
                Txt_PrimerNombre.Text = consultaempleado.Dgv_consultaEmpleado.Rows[consultaempleado.Dgv_consultaEmpleado.CurrentRow.Index].Cells[2].Value.ToString();
                Txt_SegundoNombre.Text = consultaempleado.Dgv_consultaEmpleado.Rows[consultaempleado.Dgv_consultaEmpleado.CurrentRow.Index].Cells[3].Value.ToString();
                Txt_PrimerApellido.Text = consultaempleado.Dgv_consultaEmpleado.Rows[consultaempleado.Dgv_consultaEmpleado.CurrentRow.Index].Cells[4].Value.ToString();
                Txt_SegundoApellido.Text = consultaempleado.Dgv_consultaEmpleado.Rows[consultaempleado.Dgv_consultaEmpleado.CurrentRow.Index].Cells[5].Value.ToString();
                Txt_Telefono.Text = consultaempleado.Dgv_consultaEmpleado.Rows[consultaempleado.Dgv_consultaEmpleado.CurrentRow.Index].Cells[7].Value.ToString();

            }
            //bloqueo y desbloqueo 
            Gpb_DatosEmpleado.Enabled = true;
            Txt_CodigoEmpleado.Enabled = false;
            Txt_PrimerNombre.Enabled = false;
            Txt_SegundoNombre.Enabled = false;
            Txt_PrimerApellido.Enabled = false;
            Txt_SegundoApellido.Enabled = false;
            Txt_Telefono.Enabled = false;
            Btn_ConsultarEmpleados.Enabled = false;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_CancelarEmpleado_Click(object sender, EventArgs e)
        {
            //bloqueo y desbloqueo 
            Gpb_DatosEmpleado.Enabled = false;
            Txt_CodigoEmpleado.Clear();
            Txt_PrimerNombre.Clear();
            Txt_SegundoNombre.Clear();
            Txt_PrimerApellido.Clear();
            Txt_SegundoApellido.Clear();
            Txt_Telefono.Clear();
            Btn_ConsultarEmpleados.Enabled = true;
            Dtp_FechaInicioContrato.ResetText();
        }

        private void Btn_AceptarEmpleado_Click(object sender, EventArgs e)
        {
            if (Txt_CodigoEmpleado.Text == "" | Txt_PrimerApellido.Text == "" | Txt_PrimerNombre.Text == "")
            {
                MessageBox.Show("Debe INGRESAR un EMPLEADO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //bloqueo para nuevo ingreso
                Gpb_Empleados.Enabled = true;
                Gpb_DatosEmpleado.Enabled = false;
                Gpb_DatosContratoEmpleado.Enabled = false;
                Gpb_Despido.Enabled = false;
                Gpb_Indemnizacion.Enabled = false;
                Btn_ConsultarEmpleados.Enabled = true;
            }
            else
            {
            //buscar fecha inicio de contrato
            if (Txt_CodigoEmpleado.Text == "")
            {
                MessageBox.Show("Debe INGRESAR un EMPLEADO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OdbcDataReader FechaInicio = Logic.BuscarFechaInicioContratacion(Txt_CodigoEmpleado.Text);

                try
                {
                    while (FechaInicio.Read())
                    {

                        Dtp_FechaInicioContrato.Text = FechaInicio.GetString(0);


                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
            //buscar jornada
            if (Txt_CodigoEmpleado.Text == "")
            {
                MessageBox.Show("Debe INGRESAR un EMPLEADO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OdbcDataReader Jornada = Logic.BuscaJornadaEmpleado(Txt_CodigoEmpleado.Text);

                try
                {
                    while (Jornada.Read())
                    {

                        Txt_Jornada.Text = Jornada.GetString(0);


                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }

            //bloqueo y desbloqueo 
            Gpb_DatosEmpleado.Enabled = false;
            Gpb_DatosContratoEmpleado.Enabled = true;
            Dtp_FechaInicioContrato.Enabled = false;
            Txt_Jornada.Enabled = false;
          }


        }

        private void Btn_CancelarDatosContrato_Click(object sender, EventArgs e)
        {
            Dtp_FechaInicioContrato.ResetText();
            Dtp_FechaFinalContrato.ResetText();
            Txt_RazonDespido.Clear();
            Txt_SueldoFinal.Clear();
            Txt_Descripcion.Clear();
            Txt_Jornada.Clear();
            Gpb_DatosEmpleado.Enabled = true;
            Gpb_DatosContratoEmpleado.Enabled = false;
        }

        private void Txt_SueldoPromedio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_SueldoFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dtp_FechaFinalContrato_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void Btn_CalcularIndemnizacion_Click(object sender, EventArgs e)
        {
            


            if (Txt_SueldoFinal.Text == "" | Txt_RazonDespido.Text == "" | Txt_Descripcion.Text == "")
            {
                MessageBox.Show("Debe COMPLETAR los CAMPOS solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //EVITAR INGRESO DE FECHA DE DESPIDO QUE SEA ANTES DE FECHA DE CONTRATACION
                int iS = DateTime.Compare(Dtp_FechaFinalContrato.Value, Dtp_FechaInicioContrato.Value);
                if (iS < 0)
                {
                    MessageBox.Show("La FECHA FINAL DE CONTRATO no puede ser MAYOR que FECHA INICIO DE CONTRATO","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //DESBLOQUEO DE GPB
                    Gpb_Indemnizacion.Enabled = true;
                    //FECHA FINAL DE CONTRATO
                    Dtp_FechaFinalContrato2.Text = Dtp_FechaFinalContrato.Text;
                    //DIAS LABORADOS
                    DateTime dfechainicio = Dtp_FechaInicioContrato.Value.Date;
                    DateTime dfechafinal = Dtp_FechaFinalContrato.Value.Date;
                    TimeSpan tSpan = dfechafinal - dfechainicio;
                    int idias = tSpan.Days;
                    Txt_DiasLaborados.Text = idias.ToString();

                    //----------------------------------------------------------------------------
                    //CALCULO DE INDEMNIZACION
                    //----------------------------------------------------------------------------
                    //SUELDOACTUAL
                    Double dSueldoActual = Double.Parse(Txt_SueldoFinal.Text);

                    //SUELDO DE UN AÑO
                    Double dSalarios = 14;
                    Double dSueldoAlAño = (dSueldoActual * dSalarios);

                    //SUELDO DIVIDIDO 12 MESES
                    Double dMeses = 12;
                    Double dSalarioEnDoceMeses = (dSueldoAlAño / dMeses);

                    //SUELDO POR DIAS LABORADOS
                    Double dDiasLaborados = Double.Parse(Txt_DiasLaborados.Text);
                    Double dSalarioEnDiasLaborados = (dSalarioEnDoceMeses * dDiasLaborados);

                    //TOTAL DE INDEMNIZACION
                    Double dDiasAlAño = 365;
                    Double dIndemnizacion = (dSalarioEnDiasLaborados / dDiasAlAño);
                    string sIndemnizacion = (Math.Round(dIndemnizacion, 2)).ToString();
                    Txt_Indemnizacion.Text = sIndemnizacion;

                    //------------------------------------------------------------------------------

                    //BLOQUEO DE CAMPOS
                    Txt_Indemnizacion.Enabled = false;
                    Txt_DiasLaborados.Enabled = false;
                    Dtp_FechaFinalContrato2.Enabled = false;
                    Gpb_DatosContratoEmpleado.Enabled = false;
                    Gpb_Despido.Enabled = true;
                }
            }
        }

        private void Txt_SueldoFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Dtp_FechaFinalContrato2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Btn_CancelarDespido_Click(object sender, EventArgs e)
        {
            Gpb_Despido.Enabled = false;
            Gpb_Indemnizacion.Enabled = false;
            Gpb_DatosContratoEmpleado.Enabled = true;
            Dtp_FechaFinalContrato2.ResetText();
            Txt_Indemnizacion.Clear();
            Txt_DiasLaborados.Clear();
        }

        private void Btn_RealizarDespido_Click(object sender, EventArgs e)
        {
           
            //FORMATO DE FECHAS Y HORAS
            string sFechaFinal;
            sFechaFinal = Dtp_FechaFinalContrato.Value.ToString("yyyy-MM-dd");
            OdbcDataReader Despido = Logic.InsertaDespido(Txt_CodigoEmpleado.Text, Txt_RazonDespido.Text, Txt_Descripcion.Text,sFechaFinal,Double.Parse(Txt_Indemnizacion.Text));
            MessageBox.Show("Despido realizado con EXITO ","Ingreso de Despido");
            Logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
            LimpiarTodos();
            //bloqueo para nuevo ingreso
            Gpb_Empleados.Enabled = true;
            Gpb_DatosEmpleado.Enabled = false;
            Gpb_DatosContratoEmpleado.Enabled = false;
            Gpb_Despido.Enabled = false;
            Gpb_Indemnizacion.Enabled = false;
            Btn_ConsultarEmpleados.Enabled = true;

        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
