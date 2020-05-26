using Capa_Logica_SCM;
using CrystalDecisions.CrystalReports.Engine;
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

namespace Capa_Diseño_SCM.Reportes
{
    public partial class Frm_ReportesProductos : Form
    {
        Logica logic = new Logica();
        string report = "";
        public Frm_ReportesProductos()
        {
            InitializeComponent();
            ReportDocument producto = new ReportDocument();
            OdbcDataReader mostrarreporte = logic.consultareporte("105");
            try
            {
                while (mostrarreporte.Read())
                {
                    report = mostrarreporte.GetString(1);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            producto.Load(report);
            crystalReportViewer2.ReportSource = producto;
        }

        private void productos1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
