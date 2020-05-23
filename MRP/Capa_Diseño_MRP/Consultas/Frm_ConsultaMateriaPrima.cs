using Capa_Logica_MRP;
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

namespace Capa_Diseño_MRP.Consultas
{
    public partial class Frm_ConsultaMateriaPrima : Form
    {
        LAPMRP logic = new LAPMRP();
        public Frm_ConsultaMateriaPrima()
        {
            InitializeComponent();
            Dgv_consultaMateriaPrima.Rows.Clear();
            MostrarTabla();
        }

        public void MostrarTabla()
        {
            OdbcDataReader mostrar = logic.consultarmateriaprima();
            try
            {
                while (mostrar.Read())
                {
                    Dgv_consultaMateriaPrima.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5), mostrar.GetString(6), mostrar.GetString(7), mostrar.GetString(8));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
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

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consultaMateriaPrima.Rows.Clear();
            MostrarTabla();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaMateriaPrima.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayuda no disponible");
        }

        private void Frm_ConsultaMateriaPrima_Load(object sender, EventArgs e)
        {

            Dgv_consultaMateriaPrima.Rows.Clear();
            MostrarTabla();
        }
    }
}
