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

namespace CapaDiseño.Consulta
{
    public partial class Frm_consultaMeta : Form
    {
        public Frm_consultaMeta()
        {
            InitializeComponent();
            MostrarConsulta();
        }

        Logica logic = new Logica();

        public void MostrarConsulta()
        {


            OdbcDataReader mostrarDatos = logic.Consultameta();
            try
            {
                while (mostrarDatos.Read())
                {

                    Dgv_consultaMeta.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetString(3), mostrarDatos.GetString(4), mostrarDatos.GetString(5));

                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }


        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaMeta.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consultaMeta.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Dgv_consultaMeta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
