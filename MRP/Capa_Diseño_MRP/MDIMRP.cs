using Capa_Diseño_MRP.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Diseño_MRP.Mantenimientos;
using Capa_Diseño_MRP.Procesos;
using Capa_Diseño_MRP.Reportes;

namespace Capa_Diseño_MRP
{
    public partial class MDIMRP : Form
    {
        private int childFormNumber = 0;
        string susuario="";

        public MDIMRP(string usr_principal)
        {
            InitializeComponent();
            this.Size = new Size(1450, 780);
            //Console.BackgroundColor = ConsoleColor.Green;
            this.BackColor = System.Drawing.Color.White;

            susuario = usr_principal;
            this.BackColor = System.Drawing.Color.White;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void CerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool ventanalistaproductos = false;
        Consulta_pedidos listaproductos = new Consulta_pedidos();
        private void ListaDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Consulta_pedidos);
            if (ventanalistaproductos == false || frmC == null)
            {
                if (frmC == null)
                {
                    listaproductos = new Consulta_pedidos();
                }

                listaproductos.MdiParent = this;
                listaproductos.Show();
                Application.DoEvents();
                ventanalistaproductos = true;
            }
            else
            {
                listaproductos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaBodegaInterna = false;
        Frm_MantBodegaInterna bodega = new Frm_MantBodegaInterna();
        private void BodegaInternaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantBodegaInterna);
            if (ventanaBodegaInterna == false || frmC == null)
            {
                if (frmC == null)
                {
                    bodega = new Frm_MantBodegaInterna();
                }

                bodega.MdiParent = this;
                bodega.Show();
                Application.DoEvents();
                ventanaBodegaInterna = true;
            }
            else
            {
                bodega.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        
        bool ventanaSolicitud = false;
        Frm_SolicitudCompra solicitud = new Frm_SolicitudCompra();
        private void SolicitudDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_SolicitudCompra);
            if (ventanaSolicitud == false || frmC == null)
            {
                if (frmC == null)
                {
                    solicitud = new Frm_SolicitudCompra();
                }

                solicitud.MdiParent = this;
                solicitud.Show();
                Application.DoEvents();
                ventanaSolicitud = true;
            }
            else
            {
                solicitud.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaGraficas = false;
        Frm_GraficoActivos graficas = new Frm_GraficoActivos();
        private void graficaDeActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_GraficoActivos);
            if (ventanaGraficas == false || frmC == null)
            {
                if (frmC == null)
                {
                    graficas = new Frm_GraficoActivos();
                }

                graficas.MdiParent = this;
                graficas.Show();
                Application.DoEvents();
                ventanaGraficas = true;
            }
            else
            {
                graficas.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaProduccion = false;
        Frm_SeleccionPedido produccion = new Frm_SeleccionPedido();
        private void detalleProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_SeleccionPedido);
            if (ventanaProduccion == false || frmC == null)
            {
                if (frmC == null)
                {
                    produccion = new Frm_SeleccionPedido();
                }

                produccion.MdiParent = this;
                produccion.Show();
                Application.DoEvents();
                ventanaProduccion = true;
            }
            else
            {
                produccion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaCostosP = false;
        Frm_Costos_Produccion costosP = new Frm_Costos_Produccion();
        private void CostoDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Costos_Produccion);
            if (ventanaCostosP == false || frmC == null)
            {
                if (frmC == null)
                {
                    costosP = new Frm_Costos_Produccion();
                }

                costosP.MdiParent = this;
                costosP.Show();
                Application.DoEvents();
                ventanaCostosP = true;
            }
            else
            {
                costosP.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool procesoCalidadProducto = false;
        Frm_ControlCalidadProducto procesocalidadproducto = new Frm_ControlCalidadProducto("");
        private void ControlDeCalidadEnProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_ControlCalidadProducto);
            if (procesoCalidadProducto == false || frmC == null)
            {
                if (frmC == null)
                {
                    procesocalidadproducto = new Frm_ControlCalidadProducto(susuario);
                }

                procesocalidadproducto.MdiParent = this;
                procesocalidadproducto.Show();
                Application.DoEvents();
                procesoCalidadProducto = true;
            }
            else
            {
                procesocalidadproducto.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        
        bool procesoAsignacionEstacion = false;
        Frm_AsignacionEstacionPedido procesoasignacionestacion = new Frm_AsignacionEstacionPedido("");
        private void AsignacionDeEstacionAProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_AsignacionEstacionPedido);
            if (procesoAsignacionEstacion == false || frmC == null)
            {
                if (frmC == null)
                {
                    procesoasignacionestacion = new Frm_AsignacionEstacionPedido(susuario);
                }

                procesoasignacionestacion.MdiParent = this;
                procesoasignacionestacion.Show();
                Application.DoEvents();
                procesoAsignacionEstacion = true;
            }
            else
            {
                procesoasignacionestacion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaEstandar = false;
        Frm_Mant_EstandarCalidad estandar = new Frm_Mant_EstandarCalidad();
        private void EstandarDeCalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Mant_EstandarCalidad);
            if (ventanaEstandar == false || frmC == null)
            {
                if (frmC == null)
                {
                    estandar = new Frm_Mant_EstandarCalidad();
                }

                estandar.MdiParent = this;
                estandar.Show();
                Application.DoEvents();
                ventanaEstandar = true;
            }
            else
            {
                estandar.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaEstacion = false;
        Frm_Mant_Estacion estacion = new Frm_Mant_Estacion();
        private void EstacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Mant_Estacion);
            if (ventanaEstacion == false || frmC == null)
            {
                if (frmC == null)
                {
                    estacion = new Frm_Mant_Estacion();
                }

                estacion.MdiParent = this;
                estacion.Show();
                Application.DoEvents();
                ventanaEstacion = true;
            }
            else
            {
                estacion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaGastos = false;
        Frm_Mant_Gastos gastos = new Frm_Mant_Gastos();
        private void GastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Mant_Gastos);
            if (ventanaGastos == false || frmC == null)
            {
                if (frmC == null)
                {
                    gastos = new Frm_Mant_Gastos();
                }

                gastos.MdiParent = this;
                gastos.Show();
                Application.DoEvents();
                ventanaGastos = true;
            }
            else
            {
                gastos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool mantFormula = false;
        Frm_MantFormula mantformula = new Frm_MantFormula("");
        private void FormulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantFormula);
            if (mantFormula == false || frmC == null)
            {
                if (frmC == null)
                {
                    mantformula = new Frm_MantFormula(susuario);
                }

                mantformula.MdiParent = this;
                mantformula.Show();
                Application.DoEvents();
                mantFormula = true;
            }
            else
            {
                mantformula.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool mantComponentes = false;
        Frm_MantProductoFormula mantcomponentes = new Frm_MantProductoFormula("");
        private void ComponentesDeFormulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantProductoFormula);
            if (mantComponentes == false || frmC == null)
            {
                if (frmC == null)
                {
                    mantcomponentes = new Frm_MantProductoFormula(susuario);
                }

                mantcomponentes.MdiParent = this;
                mantcomponentes.Show();
                Application.DoEvents();
                mantComponentes = true;
            }
            else
            {
                mantcomponentes.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool mantTipoMerma = false;
        Frm_MantTipoMerma manttipomerma = new Frm_MantTipoMerma("");
        private void TipoMermaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantTipoMerma);
            if (mantTipoMerma == false || frmC == null)
            {
                if (frmC == null)
                {
                    manttipomerma = new Frm_MantTipoMerma(susuario);
                }

                manttipomerma.MdiParent = this;
                manttipomerma.Show();
                Application.DoEvents();
                mantTipoMerma = true;
            }
            else
            {
                manttipomerma.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }

        }

        bool mantMerma = false;
        Frm_MantMerma mantmerma = new Frm_MantMerma("");
        private void MermaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantMerma);
            if (mantMerma == false || frmC == null)
            {
                if (frmC == null)
                {
                    mantmerma = new Frm_MantMerma(susuario);
                }

                mantmerma.MdiParent = this;
                mantmerma.Show();
                Application.DoEvents();
                mantMerma = true;
            }
            else
            {
                mantmerma.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaHorasExtra = false;
        Mant_HorasExtras horasextra = new Mant_HorasExtras();
        private void HorasExtrasProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Mant_HorasExtras);
            if (ventanaHorasExtra == false || frmC == null)
            {
                if (frmC == null)
                {
                    horasextra = new Mant_HorasExtras();
                }

                horasextra.MdiParent = this;
                horasextra.Show();
                Application.DoEvents();
                ventanaHorasExtra = true;
            }
            else
            {
                horasextra.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaCuentasContables = false;
        Frm_MantCuentasContables cuentascontables = new Frm_MantCuentasContables();
        private void CuentasContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantCuentasContables);
            if (ventanaCuentasContables == false || frmC == null)
            {
                if (frmC == null)
                {
                    cuentascontables = new Frm_MantCuentasContables();
                }

                cuentascontables.MdiParent = this;
                cuentascontables.Show();
                Application.DoEvents();
                ventanaCuentasContables = true;
            }
            else
            {
                cuentascontables.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaPoliza = false;
        Frm_Poliza poliza = new Frm_Poliza();
        private void PolizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Poliza);
            if (ventanaPoliza == false || frmC == null)
            {
                if (frmC == null)
                {
                    poliza = new Frm_Poliza();
                }

                poliza.MdiParent = this;
                poliza.Show();
                Application.DoEvents();
                ventanaPoliza = true;
            }
            else
            {
                poliza.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaop = false;
        FrmOrden_Produccion op = new FrmOrden_Produccion();
        private void OrdenDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmOrden_Produccion);
            if (ventanaop == false || frmC == null)
            {
                if (frmC == null)
                {
                    op = new FrmOrden_Produccion();
                }

                op.MdiParent = this;
                op.Show();
                Application.DoEvents();
                ventanalistaproductos = true;
            }
            else
            {
                op.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool reporteCostoProduccion = false;
        Frm_ReporteCostoProduccion costos = new Frm_ReporteCostoProduccion();
        private void reporteCostoProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_ReporteCostoProduccion);
            if (reporteCostoProduccion == false || frmC == null)
            {
                if (frmC == null)
                {
                    costos = new Frm_ReporteCostoProduccion();
                }

                costos.MdiParent = this;
                costos.Show();
                Application.DoEvents();
                reporteCostoProduccion = true;
            }
            else
            {
                costos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }

        }
        bool listapedidos = false;
        Frm_ListaPedidos lista = new Frm_ListaPedidos();
        private void reporteListaDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_ListaPedidos);
            if (listapedidos == false || frmC == null)
            {
                if (frmC == null)
                {
                    lista = new Frm_ListaPedidos();
                }

                lista.MdiParent = this;
                lista.Show();
                Application.DoEvents();
                listapedidos = true;
            }
            else
            {
                lista.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }

        }
        bool ReporteOrden = false;
        Frm_ReporteOrdenProduccioncs orden = new Frm_ReporteOrdenProduccioncs();
        private void reporteOrdenesProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_ReporteOrdenProduccioncs);
            if (ReporteOrden == false || frmC == null)
            {
                if (frmC == null)
                {
                    orden = new Frm_ReporteOrdenProduccioncs();
                }

                orden.MdiParent = this;
                orden.Show();
                Application.DoEvents();
                ReporteOrden = true;
            }
            else
            {
                orden.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        private void MDIMRP_Load(object sender, EventArgs e)
        {
            lbl_user.Text = susuario;
        }

        private void Btn_minimzar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

