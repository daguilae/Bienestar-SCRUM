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
using CapaLogica;
using CapaDiseño.Consulta;

namespace CapaDiseño.Procesos
{
    public partial class Frm_EvaluacionMeta : Form
    {
        public Frm_EvaluacionMeta()
        {
            InitializeComponent();
            bloqueartxt();
            scampo = logic.siguiente("kpi", "pkcodigokpi");
            Txt_Cod.Text = scampo;
            Cbo_Estado.Items.Add("Activo");
            Cbo_Estado.Items.Add("Inactivo");
            Dtp_Asignacion.Format = DateTimePickerFormat.Custom;
            Dtp_Asignacion.CustomFormat = "yyyy-MM-dd";
            Dtp_Realizacion.Format = DateTimePickerFormat.Custom;
            Dtp_Realizacion.CustomFormat = "yyyy-MM-dd";
        }

       Logica logic = new Logica();

        string scampo;
        string slocalIP;
        string smacAddresses;
        string suser;

        public void bloqueartxt()
        {
            /*------------------------*/
            Btn_Ingresar.Enabled = true;
            Btn_Insertar.Enabled = false;
            Btn_Modificar.Enabled = false;
            /*------------------------*/

            Txt_Cod.Enabled = false;
            Txt_CodEmpleado.Enabled = false;
            Txt_CodMeta.Enabled = false;
            Dtp_Asignacion.Enabled = false;
            Txt_Puntuacion.Enabled = false;
            Dtp_Realizacion.Enabled = false;
            Cbo_Estado.Enabled = false;

        }
        public void desbloqueartxt()
        {
           

            /*------------------------*/
            Btn_Ingresar.Enabled = false;
            Btn_Insertar.Enabled = true;
            Btn_Modificar.Enabled = true;
            /*------------------------*/

            Txt_Cod.Enabled = false;
            Txt_CodEmpleado.Enabled = true;
            Txt_CodMeta.Enabled = true;
            Dtp_Asignacion.Enabled = true;
            Txt_Puntuacion.Enabled = true;
            Dtp_Realizacion.Enabled = true;
            Cbo_Estado.Enabled = true;

        }

        public void limpiar()
        {
            Txt_Cod.Text = "";
            Txt_CodEmpleado.Text = "";
            Txt_CodMeta.Text = "";
            Txt_Puntuacion.Text = "";
            Dtp_Realizacion.Text = "";
            Dtp_Asignacion.Text = "";
            Cbo_Estado.Text = "";

        }

        private void Lbl_procesonominal_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Insertar_Click(object sender, EventArgs e)
        {
            if (Cbo_Estado.Text == "Activo")
            {
                Cbo_Estado.Text = "1";
            }
            else
            {
                Cbo_Estado.Text = "0";
            }

            OdbcDataReader cita = logic.InsertarEvaluacion(Txt_Cod.Text, Dtp_Asignacion.Text, Txt_Puntuacion.Text, Txt_CodEmpleado.Text, Txt_CodMeta.Text, Cbo_Estado.Text, Dtp_Realizacion.Text);
            MessageBox.Show("Datos registrados.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "HRM", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
            limpiar();
            bloqueartxt();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Cbo_Estado.Text == "Activo")
            {
                Cbo_Estado.Text = "1";
            }
            else
            {
                Cbo_Estado.Text = "0";
            }

            OdbcDataReader cita = logic.ModificarEvaluacion(Txt_Cod.Text, Dtp_Asignacion.Text, Txt_Puntuacion.Text, Txt_CodEmpleado.Text, Txt_CodMeta.Text, Cbo_Estado.Text, Dtp_Realizacion.Text);
            MessageBox.Show("Datos registrados.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "HRM", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
            limpiar();
            bloqueartxt();
        }

       

        private void Btn_CodEmp_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleado concep = new Frm_consultaEmpleado();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_CodEmpleado.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }

            Txt_CodEmpleado.Enabled = false;
        }

        private void Btn_CodMeta_Click(object sender, EventArgs e)
        {
            Frm_consultaMeta concep = new Frm_consultaMeta();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_CodMeta.Text = concep.Dgv_consultaMeta.Rows[concep.Dgv_consultaMeta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }

            Txt_CodMeta.Enabled = false;
        }

        private void Btn_Desempeño_Click(object sender, EventArgs e)
        {
            Frm_DesempeñodeEmpleado concep = new Frm_DesempeñodeEmpleado();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {

                Txt_Cod.Text = concep.Dgv_Desempeno.Rows[concep.Dgv_Desempeno.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Dtp_Asignacion.Text = concep.Dgv_Desempeno.Rows[concep.Dgv_Desempeno.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_Puntuacion.Text = concep.Dgv_Desempeno.Rows[concep.Dgv_Desempeno.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Txt_CodEmpleado.Text = concep.Dgv_Desempeno.Rows[concep.Dgv_Desempeno.CurrentRow.Index].
                      Cells[3].Value.ToString();
                Txt_CodMeta.Text = concep.Dgv_Desempeno.Rows[concep.Dgv_Desempeno.CurrentRow.Index].
                     Cells[4].Value.ToString();
                Cbo_Estado.Text = concep.Dgv_Desempeno.Rows[concep.Dgv_Desempeno.CurrentRow.Index].
                    Cells[5].Value.ToString();
               Dtp_Realizacion.Text = concep.Dgv_Desempeno.Rows[concep.Dgv_Desempeno.CurrentRow.Index].
                    Cells[6].Value.ToString();
                

            }
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
           
        }
    }
}
