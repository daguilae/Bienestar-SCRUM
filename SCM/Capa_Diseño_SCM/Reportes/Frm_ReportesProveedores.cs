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
    public partial class Frm_ReportesProveedores : Form
    {
        Logica logic = new Logica();
        string report = "";
        public Frm_ReportesProveedores()
        {
            InitializeComponent();
            ReportDocument proveedor = new ReportDocument();

            OdbcDataReader mostrarreporte = logic.consultareporte("106");
           

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

            proveedor.Load(report);

            crystalReportViewer1.ReportSource = proveedor;
        }

        }
    }
