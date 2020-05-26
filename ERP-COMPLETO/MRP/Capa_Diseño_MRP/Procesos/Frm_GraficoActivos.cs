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
using Capa_Diseño_MRP.Consultas;
using Capa_Logica_MRP;

namespace Capa_Diseño_MRP.Procesos
{
    public partial class Frm_GraficoActivos : Form
    {
        LIIMRP logic = new LIIMRP();
        public Frm_GraficoActivos()
        {
            InitializeComponent();
            chart1.Series["Series1"].LegendText = "Stock Minimo";
            chart1.Series["Series2"].LegendText = "Stock Actual";
            //chart1.Series["Series2"].Points[0].Color = Color.Red;
            chart1.Series["Series3"].LegendText = "Stock Maximo";
           //chart1.Series["Series3"].Points[0].Color = Color.Green;
        }

        void ActualizarTodo()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            OdbcDataReader mostrar = logic.consultaActivos();
            try
            {
               if (mostrar == null)
                {
                    MessageBox.Show("Actualmente no existen Activos disponibles para graficar.");
                }
                else
                {
                    while (mostrar.Read())
                    {
                        chart1.Series["Series1"].Points.AddXY("", mostrar.GetDouble(2));
                        chart1.Series["Series2"].Points.AddXY(mostrar.GetString(0), mostrar.GetDouble(1));
                        chart1.Series["Series3"].Points.AddXY("", mostrar.GetDouble(3));
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Se encontro un error: " + err.Message);
            }

        }
        private void Frm_GraficoActivos_Load(object sender, EventArgs e)
        {
            ActualizarTodo();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BTn_guardar_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            OdbcDataReader mostrar = logic.consultaActivosEspecifica(Txt_Nom.Text);
            
            try
            {        
                    while (mostrar.Read())
                    {
                        chart1.Series["Series1"].Points.AddXY("", mostrar.GetDouble(2));
                        chart1.Series["Series2"].Points.AddXY(mostrar.GetString(0), mostrar.GetDouble(1));
                        chart1.Series["Series3"].Points.AddXY("", mostrar.GetDouble(3));
                    }
            }
            catch (Exception err)
            {
                MessageBox.Show("Se encontro un error: " + err.Message + " Ya que el producto no existe. Consulte el catalogo.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Txt_Nom.Text = "";
            ActualizarTodo();
        }

        private void btn_catalogo_Click(object sender, EventArgs e)
        {
            Frm_consultaActivosNombres cons = new Frm_consultaActivosNombres();
            cons.ShowDialog();

            if (cons.DialogResult == DialogResult.OK)
            {
                Txt_Nom.Text = cons.Dgv_consulta.Rows[cons.Dgv_consulta.CurrentRow.Index].
                      Cells[1].Value.ToString();
            }
        }
    }
}
