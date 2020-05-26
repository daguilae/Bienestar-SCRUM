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
    public partial class Frm_DescripcionProduccion : Form
    {
        string sCodProducto;
        LIIMRP logic = new LIIMRP();
        string scampo;

        public Frm_DescripcionProduccion(string[] datos)
        {
            InitializeComponent();
            //El orden de recepcion es: Codigo de pedido, codigo de producto, nombre del producto, cantidad solicitada.
            scampo = logic.siguiente("encabezado_produccion", "pkidencabezadop");
            txt_codPedido.Text = datos[0];
            sCodProducto = datos[1];
            txt_codProduccion.Text = scampo;
            txt_aProducir.Text = datos[2];
            txt_total.Text = datos[3];
            cargarFormula();
        }

        void cargarFormula()
        {
            OdbcDataReader mostrar = logic.consultaFormulaID(sCodProducto);
            try
            {
                while (mostrar.Read())
                {
                    txt_codFormula.Text = mostrar.GetString(0);
                    txt_detalleFormula.Text = mostrar.GetString(1);
                    break;
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            OdbcDataReader detalle = logic.consultaFormulaDetalleID(txt_codFormula.Text);
            try
            {
                while (detalle.Read())
                {
                    Dgv_consulta.Rows.Add(detalle.GetString(0), detalle.GetString(1), detalle.GetString(2));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
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
            string[] campos = { "encabezado_produccion", txt_codProduccion.Text, txt_codPedido.Text, txt_descripcion.Text, txt_total.Text, "1" };
            string[] detalle = { "detalle_produccion", txt_codProduccion.Text, txt_codFormula.Text, "1" };
            if (txt_descripcion.Text == "")
                MessageBox.Show("Debe de ingresar una descripcion.");
            else
                if (logic.insertar(campos) == null || logic.insertar(detalle) == null)
                    MessageBox.Show("Ocurrio un error al guardar.");
                else
                {
                    MessageBox.Show("Guardado exitosamente.");
                //Actualizar el pedido a 0
                    logic.actualizarPedido(txt_codPedido.Text);
                    this.Dispose();
                }
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarayuda = logic.consultaayuda("80");
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
