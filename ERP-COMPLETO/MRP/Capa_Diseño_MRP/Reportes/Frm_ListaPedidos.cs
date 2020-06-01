using Capa_Logica_MRP;
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

namespace Capa_Diseño_MRP.Reportes
{
    public partial class Frm_ListaPedidos : Form
    {
      
        public Frm_ListaPedidos()
        {
            Logica logic = new Logica();
            string report = "";
            InitializeComponent();
            ReportDocument producto = new ReportDocument();
            OdbcDataReader mostrarreporte = logic.consultareporte("202");
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
            crystalReportViewer1.ReportSource = producto;
            crystalReportViewer1.RefreshReport();
        }
    }
}
