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
    public partial class Frm_ReporteOrdenCompras : Form
    {
        public Frm_ReporteOrdenCompras(string codigo)
        {
            Logica logic = new Logica();
            string report = "";
            InitializeComponent();
            ReportDocument ordencomprarpt = new ReportDocument();

            OdbcDataReader mostrarreporte = logic.consultareporte("102");
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

            ordencomprarpt.Load(report);
            ordencomprarpt.SetParameterValue("codigo", codigo);
            crystalReportViewer1.ReportSource = ordencomprarpt;
        }
    }
}
