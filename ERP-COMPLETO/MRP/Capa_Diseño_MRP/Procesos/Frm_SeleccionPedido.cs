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
using Capa_Logica_MRP;

namespace Capa_Diseño_MRP.Procesos
{
    public partial class Frm_SeleccionPedido : Form
    {
        LIIMRP logic = new LIIMRP();
        string sNom, sCantidad, sCodigo;

        public Frm_SeleccionPedido()
        {
            InitializeComponent();
            Dgv_consulta.Rows.Clear();
            MostrarConsulta();
        }

        //-----------------------------------------------------------------------------------para mostrar en DGV------------------------------------------------------------------------------
        public void MostrarConsulta()
        {
            Dgv_consulta.Rows.Clear();
            OdbcDataReader mostrar = logic.consultaPedidosNombre();
            try
            {
                while (mostrar.Read())
                {
                    Dgv_consulta.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void Frm_SeleccionPedido_Load(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dgv_consulta_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Dgv_consulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_Cod.Text = Convert.ToString(Dgv_consulta.CurrentRow.Cells[0].Value);
            sCodigo = Convert.ToString(Dgv_consulta.CurrentRow.Cells[1].Value);
            sNom = Convert.ToString(Dgv_consulta.CurrentRow.Cells[2].Value);
            sCantidad = Convert.ToString(Dgv_consulta.CurrentRow.Cells[3].Value);
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarayuda = logic.consultaayuda("83");
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

        private void BTn_guardar_Click(object sender, EventArgs e)
        {       
            if (Txt_Cod.Text == "")
                MessageBox.Show("Debe de seleccionar un pedido.");
            else
            {
                string[] valores = { Txt_Cod.Text, sCodigo ,sNom, sCantidad };
                Frm_DescripcionProduccion orden = new Frm_DescripcionProduccion(valores);
                orden.ShowDialog();
            }
            MostrarConsulta();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            MostrarConsulta();
        }
    }
}
