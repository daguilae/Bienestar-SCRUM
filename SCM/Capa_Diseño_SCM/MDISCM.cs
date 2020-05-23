using Capa_Diseño_SCM.Mantenimientos;
using Capa_Diseño_SCM.Procesos;
using Capa_Diseño_SCM.Reportes;
using CapaDiseño.Mantenimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Diseño_SCM
{
    public partial class MDISCM : Form
    {
        private int childFormNumber = 0;
        string susuario = "";
        string tipopermiso = "";
        public MDISCM(string suser, string spermiso)
        {
            InitializeComponent();
            susuario = suser;
            tipopermiso = spermiso;
            this.Size = new Size(1450,780);
            //Console.BackgroundColor = ConsoleColor.Green;
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
          
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
        bool ventanaConceptos = false;
        Frm_MantPercepciones conceptos = new Frm_MantPercepciones("","");
        private void PercepcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantPercepciones);
            if (ventanaConceptos == false || frmC == null)
            {
                if (frmC == null)
                {
                    conceptos = new Frm_MantPercepciones(susuario,tipopermiso);
                }

                conceptos.MdiParent = this;
                conceptos.Show();
                Application.DoEvents();
                ventanaConceptos = true;
            }
            else
            {
                conceptos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        private void CerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool ventanaFactura = false;
        Frm_BusquedaOrdenCompra facturaP = new Frm_BusquedaOrdenCompra("");
        private void ingresoFacturaProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_BusquedaOrdenCompra);
            if (ventanaFactura == false || frmC == null)
            {
                if (frmC == null)
                {
                    facturaP = new Frm_BusquedaOrdenCompra(susuario);
                }

                facturaP.MdiParent = this;
                facturaP.Show();
                Application.DoEvents();
                ventanaFactura = true;
            }
            else
            {
                facturaP.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaImpuestos = false;
        Frm_MantImpuestos impuestos = new Frm_MantImpuestos("","");
        private void impuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantImpuestos);
            if (ventanaImpuestos == false || frmC == null)
            {
                if (frmC == null)
                {
                    impuestos = new Frm_MantImpuestos(susuario, tipopermiso);
                }

                impuestos.MdiParent = this;
                impuestos.Show();
                Application.DoEvents();
                ventanaImpuestos = true;
            }
            else
            {
                impuestos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaordenDeCompra = false;
        Frm_Ordencompra orden = new Frm_Ordencompra("");
        private void OrdenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Ordencompra);
            if (ventanaordenDeCompra == false || frmC == null)
            {
                if (frmC == null)
                {
                    orden = new Frm_Ordencompra(susuario);
                }

                orden.MdiParent = this;
                orden.Show();
                Application.DoEvents();
                ventanaordenDeCompra = true;
            }
            else
            {
                orden.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }

        }
        bool ventanAcreedor = false;
        Frm_MantAcreedor mantAcreedor = new Frm_MantAcreedor("", "");
        private void AcreedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantAcreedor);
            if (ventanAcreedor == false || frmC == null)
            {
                if (frmC == null)
                {
                    mantAcreedor = new Frm_MantAcreedor(susuario, tipopermiso);
                }

                mantAcreedor.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                mantAcreedor.Show();
                Application.DoEvents();
                ventanAcreedor = true;
            }
            else
            {
                mantAcreedor.WindowState = System.Windows.Forms.FormWindowState.Normal;

            }
        }
        bool ventanaBodega = false;
        Frm_MantBodega Bodega = new Frm_MantBodega("", "");
        private void BodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantBodega);
            if (ventanaBodega == false || frmC == null)
            {
                if (frmC == null)
                {
                    Bodega = new Frm_MantBodega(susuario, tipopermiso);
                }

                Bodega.MdiParent = this;
                Bodega.Show();
                Application.DoEvents();
                ventanaBodega = true;
            }
            else
            {
                Bodega.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaProducto = false;
        Frm_MantProducto Producto = new Frm_MantProducto("","");
        private void ProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantProducto);
            if (ventanaProducto == false || frmC == null)
            {
                if (frmC == null)
                {
                    Producto = new Frm_MantProducto(susuario, tipopermiso);
                }

                Producto.MdiParent = this;
                Producto.Show();
                Application.DoEvents();
                ventanaProducto = true;
            }
            else
            {
                Producto.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaProveedor = false;
        Frm_MantProveedores Proveedor = new Frm_MantProveedores("","");


        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantProveedores);
            if (ventanaProveedor == false || frmC == null)
            {
                if (frmC == null)
                {
                    Proveedor = new Frm_MantProveedores(susuario, tipopermiso);
                }

                Proveedor.MdiParent = this;
                Proveedor.Show();
                Application.DoEvents();
                ventanaProveedor = true;
            }
            else
            {
                Bodega.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool mantRuta = false;
        Frm_MantRuta mantruta = new Frm_MantRuta("","");
        private void RutaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantRuta);
            if (mantRuta == false || frmC == null)
            {
                if (frmC == null)
                {
                    mantruta = new Frm_MantRuta(susuario, tipopermiso);
                }
                mantruta.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                mantruta.MdiParent = this;
                mantruta.Show();
                Application.DoEvents();
                mantRuta = true;
            }
            else
            {
                mantruta.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool mantTipoTransporte = false;
        Frm_MantTipoTransporte manttipotransporte = new Frm_MantTipoTransporte("","");

        private void TipoDeTransporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantTipoTransporte);
            if (mantTipoTransporte == false || frmC == null)
            {
                if (frmC == null)
                {
                    manttipotransporte = new Frm_MantTipoTransporte(susuario, tipopermiso);
                }
                mantAcreedor.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                manttipotransporte.MdiParent = this;
                manttipotransporte.Show();
                Application.DoEvents();
                mantTipoTransporte = true;
            }
            else
            {
                manttipotransporte.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool mantTransporte = false;
        Frm_MantTransporte manttransporte = new Frm_MantTransporte("","");

        private void TransporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantTransporte);
            if (mantTransporte == false || frmC == null)
            {
                if (frmC == null)
                {
                    manttransporte = new Frm_MantTransporte(susuario, tipopermiso);
                }

                manttransporte.MdiParent = this;
                manttransporte.Show();
                Application.DoEvents();
                mantTransporte = true;
            }
            else
            {
                manttransporte.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool prodevolucion = false;
        Frm_DevolucionProveedores devol = new Frm_DevolucionProveedores();

        private void DevolucionSobreCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantTransporte);
            if (prodevolucion == false || frmC == null)
            {
                if (frmC == null)
                {
                    devol = new Frm_DevolucionProveedores();
                }

                devol.MdiParent = this;
                devol.Show();
                Application.DoEvents();
                prodevolucion = true;
            }
            else
            {
                devol.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool ventanaListaMov = false;
        Frm_ListaMovInv ListMov = new Frm_ListaMovInv("");
        private void MovimientoInventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_ListaMovInv);
            if (ventanaListaMov == false || frmC == null)
            {
                if (frmC == null)
                {
                    ListMov = new Frm_ListaMovInv(susuario);
                }

                ListMov.MdiParent = this;
                ListMov.Show();
                Application.DoEvents();
                ventanaListaMov = true;
            }
            else
            {
                ListMov.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        bool productos = false;
        Frm_ReportesProductos producto = new Frm_ReportesProductos();
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_ReportesProductos);
            if (productos == false || frmC == null)
            {
                if (frmC == null)
                {
                    producto = new Frm_ReportesProductos();
                }

                producto.MdiParent = this;
                producto.Show();
                Application.DoEvents();
                productos = true;
            }
            else
            {
                producto.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool proveedores = false;
        Frm_ReportesProveedores proveedor = new Frm_ReportesProveedores();
        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_ReportesProveedores);
            if (proveedores == false || frmC == null)
            {
                if (frmC == null)
                {
                    proveedor = new Frm_ReportesProveedores();
                }

                proveedor.MdiParent = this;
                proveedor.Show();
                Application.DoEvents();
                proveedores = true;
            }
            else
            {
                proveedor.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }

        }

        bool impuesto = false;
        Frm_Reportesimpuestos impuest = new Frm_Reportesimpuestos();
        private void impuestosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Reportesimpuestos);
            if (impuesto == false || frmC == null)
            {
                if (frmC == null)
                {
                    impuest= new Frm_Reportesimpuestos();
                }

                impuest.MdiParent = this;
                impuest.Show();
                Application.DoEvents();
                impuesto = true;
            }
            else
            {
                impuest.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }

        }

        private void MDISCM_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
            lbl_user.Text = susuario;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_minimzar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
    }

