using Capa_Diseño_SCM.Consultas;
using Capa_Logica_SCM;
using CapaDiseño.Consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Diseño_SCM.Mantenimientos
{
    public partial class Frm_MantProducto : Form
    {
        LIPSCM logic = new LIPSCM();
        Validaciones v = new Validaciones();
        string scampo;
        string slocalIP;
        string smacAddresses;
        string suser;
        string tipopermiso;

        public Frm_MantProducto(string usuario, string permiso)
        {
            InitializeComponent();
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_borrar.Enabled = false;
            Btn_consultar.Enabled = false;
            bloqueartxt();
            scampo = logic.siguiente("producto", "pkidProducto");
            Txt_IdP.Text = scampo;
            Cbo_estado.Items.Add("Activo");
            Cbo_estado.Items.Add("Inactivo");
            suser = usuario;
            tipopermiso = permiso;
        }

        public void permisos()
        {
            if (tipopermiso == "1111")
            {
                //todos
                Btn_guardar.Enabled = true;
                Btn_editar.Enabled = true;
                Btn_borrar.Enabled = true;
                Btn_consultar.Enabled = true;
                desbloqueartxt();
            }
            if (tipopermiso == "1001")
            {
                //Guardar
                Btn_guardar.Enabled = true;
                Btn_editar.Enabled = false;
                Btn_borrar.Enabled = false;
                Btn_consultar.Enabled = true;
                desbloqueartxt();
            }
            if (tipopermiso == "0101")
            {
                //modificar
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = true;
                Btn_borrar.Enabled = false;
                Btn_consultar.Enabled = true;
                desbloqueartxt();
            }
            if (tipopermiso == "0011")
            {
                //eliminar
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = false;
                Btn_borrar.Enabled = true;
                Btn_consultar.Enabled = true;
                desbloqueartxt();
            }
            if (tipopermiso == "0001")
            {
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = false;
                Btn_borrar.Enabled = false;
                Btn_ingresar.Enabled = false;
                Btn_consultar.Enabled = true;
            }
        }
        public void obtenerip()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    slocalIP = ip.ToString();
                }
            }
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    smacAddresses += nic.GetPhysicalAddress().ToString();
                    break;

                }
            }
        }

        public void bloqueartxt()
        {
  
            Txt_Proveedor.Enabled = false;
            Txt_IdP.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_Precio.Enabled = false;
            Txt_Descripcion.Enabled = false;
            Txt_Presentacion.Enabled = false;
            Txt_Costo.Enabled = false;
            Txt_Bodega.Enabled = false;
            Txt_Existencias.Enabled = false;
            Txt_TipoProd.Enabled = false;
            Cbo_estado.Enabled = false;

        }
        public void desbloqueartxt()
        {

            Txt_Proveedor.Enabled = true;
            Txt_IdP.Enabled = true;
            Txt_nombre.Enabled = true;
            Txt_Precio.Enabled = true;
            Txt_Descripcion.Enabled = true;
            Txt_Presentacion.Enabled = true;
            Txt_Costo.Enabled = true;
            Txt_Bodega.Enabled = true;
            Txt_Existencias.Enabled = true;
            Txt_TipoProd.Enabled = true;
            Cbo_estado.Enabled = true;
        }

        public void limpiar()
        {
            Txt_Proveedor.Text = "";
            Txt_IdP.Text = "";
            Txt_nombre.Text = "";
            Txt_Precio.Text = "";
            Txt_Descripcion.Text = "";
            Txt_Presentacion.Text = "";
            Txt_Costo.Text = "";
            Txt_Bodega.Text = "";
            Txt_Existencias.Text = "";
            Txt_TipoProd.Text = "";
            Cbo_estado.Text = "";

        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            permisos();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.Modificarproducto(Txt_Proveedor.Text, Txt_IdP.Text, Txt_nombre.Text, Txt_Precio.Text, Txt_Descripcion.Text, Txt_Presentacion.Text, Txt_Costo.Text, Txt_TipoProd.Text, Cbo_estado.Text);
            OdbcDataReader cita1 = logic.Modificarproductoenbodega(Txt_Bodega.Text, Txt_IdP.Text, Txt_Existencias.Text, Cbo_estado.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "SCM", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);
            MessageBox.Show("Datos modificados correctamente.");
            limpiar();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (Cbo_estado.Text == "Activo")
            {
                Cbo_estado.Text = "1";
            }
            else
            {
                Cbo_estado.Text = "0";
            }
            OdbcDataReader cita = logic.Insertarproducto(Txt_Proveedor.Text, Txt_IdP.Text, Txt_nombre.Text, Txt_Precio.Text, Txt_Descripcion.Text, Txt_Presentacion.Text, Txt_Costo.Text, Txt_TipoProd.Text, Cbo_estado.Text);
            OdbcDataReader cita1 = logic.Insertarproductoenbodega(Txt_Bodega.Text, Txt_IdP.Text, Txt_Existencias.Text, Cbo_estado.Text);
            MessageBox.Show("Datos registrados.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "SCM", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.Eliminarproducto(Txt_IdP.Text);
            OdbcDataReader cita1 = logic.Eliminarproductoenbodega(Txt_IdP.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "SCM", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);
            MessageBox.Show("Eliminado Correctamentee.");
            limpiar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaProducto concep = new Frm_consultaProducto();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {

                Txt_Proveedor.Text = concep.Dgv_consultaProd.Rows[concep.Dgv_consultaProd.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_IdP.Text = concep.Dgv_consultaProd.Rows[concep.Dgv_consultaProd.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_nombre.Text = concep.Dgv_consultaProd.Rows[concep.Dgv_consultaProd.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Txt_Precio.Text = concep.Dgv_consultaProd.Rows[concep.Dgv_consultaProd.CurrentRow.Index].
                      Cells[3].Value.ToString();
                Txt_Descripcion.Text = concep.Dgv_consultaProd.Rows[concep.Dgv_consultaProd.CurrentRow.Index].
                     Cells[4].Value.ToString();
                Txt_Presentacion.Text = concep.Dgv_consultaProd.Rows[concep.Dgv_consultaProd.CurrentRow.Index].
                    Cells[5].Value.ToString();
                Txt_Costo.Text = concep.Dgv_consultaProd.Rows[concep.Dgv_consultaProd.CurrentRow.Index].
                    Cells[6].Value.ToString();
                Cbo_estado.Text = concep.Dgv_consultaProd.Rows[concep.Dgv_consultaProd.CurrentRow.Index].
                    Cells[7].Value.ToString();
                Txt_TipoProd.Text = concep.Dgv_consultaProd.Rows[concep.Dgv_consultaProd.CurrentRow.Index].
                    Cells[8].Value.ToString();
                Txt_Bodega.Text = concep.Dgv_consultaProd.Rows[concep.Dgv_consultaProd.CurrentRow.Index].
                    Cells[9].Value.ToString();
                Txt_Existencias.Text = concep.Dgv_consultaProd.Rows[concep.Dgv_consultaProd.CurrentRow.Index].
                    Cells[10].Value.ToString();

            }
        }

        private void Btn_BuscarBodega_Click(object sender, EventArgs e)
        {
            Frm_consultaBodega concep = new Frm_consultaBodega();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_Bodega.Text = concep.Dgv_consultaBodega.Rows[concep.Dgv_consultaBodega.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }

            Txt_Bodega.Enabled = false;
        }

        private void Btn_BuscarTipoProd_Click(object sender, EventArgs e)
        {
            Frm_consultaTipoProducto concep = new Frm_consultaTipoProducto();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_TipoProd.Text = concep.Dgv_consultaProd.Rows[concep.Dgv_consultaProd.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }

            Txt_TipoProd.Enabled = false;
        }

        private void Btn_BuscarProveedor_Click(object sender, EventArgs e)
        {
            Frm_consultaProveedor concep = new Frm_consultaProveedor();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_Proveedor.Text = concep.Dgv_consultaProveedores.Rows[concep.Dgv_consultaProveedores.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }

            Txt_Proveedor.Enabled = false;
        }

        private void Txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CamposLetras(e);
        }

        private void Txt_Presentacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CamposLetras(e);
        }

        private void Txt_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CamposNumerosYLetras(e);
        }

        private void Txt_Costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CampoNumerico(e);
        }

        private void Txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CampoNumerico(e);
        }

        private void Txt_Existencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CampoNumerico(e);
        }

        private void Txt_TipoProd_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarayuda = logic.consultaayuda("67");
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
