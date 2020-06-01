using Capa_Diseño_MRP.Consultas;
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

namespace Capa_Diseño_MRP.Procesos
{
    public partial class Frm_Costos_Produccion : Form
    {
        LAPMRP logic = new LAPMRP();
        string scampo;

        public Frm_Costos_Produccion()
        {
            InitializeComponent();
            scampo = logic.siguiente("costodefabricacion", "pkidcostodefabricacion");
            txtCodigo.Text = scampo;
        }

        public void MostrarConsultaProduccion()
        {
            OdbcDataReader mostrar = logic.consultaProduccion(txtProduccion.Text);

            try
            {
                while (mostrar.Read())
                {
                    Dgv_Produccion.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        public void MostrarManoO()
        {
            OdbcDataReader mostrar = logic.consultaManoO(txtProduccion.Text);

            try
            {
                while (mostrar.Read())
                {
                    Dgv_ManoObra.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Dgv_Produccion.Rows.Clear();
            MostrarConsultaProduccion();

            Dgv_ManoObra.Rows.Clear();
            MostrarManoO();
        }

        public int sumaPrecio = 0;
        private void BtnCalculoProduccion_Click(object sender, EventArgs e)
        {            
            const int columnaPrecio = 4;
            foreach (DataGridViewRow row in Dgv_Produccion.Rows)
            {
                sumaPrecio += Convert.ToInt32(row.Cells[columnaPrecio].Value);

            }
            txtCostoMP.Text = sumaPrecio.ToString();
            txtMPFinal.Text = txtCostoMP.Text;
        }

        private void BtnBuscarGasto_Click(object sender, EventArgs e)
        {
            Frm_Consulta_Gastos gastos = new Frm_Consulta_Gastos();
            gastos.ShowDialog();

            if (gastos.DialogResult == DialogResult.OK)
            {
                txtCodGasto.Text = gastos.Dgv_consulta.Rows[gastos.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();

                Dgv_Gastos.Rows.Add(gastos.Dgv_consulta.Rows[gastos.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString(), gastos.Dgv_consulta.Rows[gastos.Dgv_consulta.CurrentRow.Index].
                      Cells[1].Value.ToString(), gastos.Dgv_consulta.Rows[gastos.Dgv_consulta.CurrentRow.Index].
                      Cells[2].Value.ToString());
            }
        }

        public void MostrarConsultaGasto()
        {
            OdbcDataReader mostrar = logic.consultaGastosP(txtCodGasto.Text);

            try
            {
                while (mostrar.Read())
                {
                    Dgv_Gastos.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void BtnAgregarGasto_Click(object sender, EventArgs e)
        {
            Dgv_Gastos.Rows.Clear();
            MostrarConsultaGasto();
            txtCodGasto.Text = "";
        }

        public int sumaPrecioG = 0;
        private void BtnCalcularGasto_Click(object sender, EventArgs e)
        {
            const int columnaPrecio = 2;
            foreach (DataGridViewRow row in Dgv_Gastos.Rows)
            {
                sumaPrecioG += Convert.ToInt32(row.Cells[columnaPrecio].Value);

            }
            txtCostoGasto.Text = sumaPrecioG.ToString();
            txtGIFinal.Text = txtCostoGasto.Text;
        }

        public int sumaPrecioM = 0;
        private void Button2_Click(object sender, EventArgs e)
        {
            double mano = 0;
            double horas = 0;
            const int columnaSueldo = 3;
            foreach (DataGridViewRow row in Dgv_ManoObra.Rows)
            {
                sumaPrecioM += Convert.ToInt32(row.Cells[columnaSueldo].Value);

            }
            horas = Convert.ToDouble(txtHoras.Text);
            mano = ((Convert.ToDouble(sumaPrecioM.ToString())/30)/8)*horas;
            txtCostoMano.Text = mano.ToString();
            txtMOFinal.Text = txtCostoMano.Text;
        }

        private void BtnCalcularTotal_Click(object sender, EventArgs e)
        {
            double a, b, c, total;
            a = Convert.ToDouble(txtMPFinal.Text);
            b = Convert.ToDouble(txtMOFinal.Text);
            c = Convert.ToDouble(txtGIFinal.Text);
            total = a + b + c;
            txtTotal.Text = Convert.ToString(total);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            OdbcDataReader costo = logic.InsertarCostosF(txtCodigo.Text,txtProduccion.Text,txtMerma.Text,txtTotal.Text);
            MessageBox.Show("Datos registrados.");
            this.Dispose();
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarayuda = logic.consultaayuda("78");
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
