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
    public partial class Frm_consultaFormulaDetalle : Form
    {
        LAPMRP logic = new LAPMRP();
        public Frm_consultaFormulaDetalle()
        {
            InitializeComponent();
            Dgv_consultaFormulaDetalle.Rows.Clear();
            MostrarTabla();
        }

        public void MostrarTabla()
        {
            OdbcDataReader mostrar = logic.consultarformuladet();
            try
            {
                while (mostrar.Read())
                {
                    Dgv_consultaFormulaDetalle.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
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

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayuda no disponible");
        }

        private void Frm_consultaFormulaDetalle_Load(object sender, EventArgs e)
        {

            Dgv_consultaFormulaDetalle.Rows.Clear();
            MostrarTabla();
        }
    }
}
