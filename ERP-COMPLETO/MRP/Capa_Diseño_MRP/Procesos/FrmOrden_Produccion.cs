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
    public partial class FrmOrden_Produccion : Form
    {
        Logica logic = new Logica();

        string scampo1;
        string scampo2;

        public FrmOrden_Produccion()
        {
            InitializeComponent();
            scampo1 = logic.siguiente("orden_produccion", "pkidordenproduccion");
            scampo2 = logic.siguiente("pedido", "pkidpedido");
            Txt_codped.Enabled = false;
            Txt_prod.Enabled = false;
            Txt_cantidad.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            btn_guardar.Enabled = false;
            button4.Enabled = false;
            Txt_codorden.Text = scampo1;
            Txt_codped.Text = scampo2;
            Txt_codorden.Enabled = false;
            Txt_codped.Enabled = false;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
            logic.insertarp(Txt_codped.Text, Txt_prod.Text, "1", Txt_codemp.Text, Txt_cantidad.Text, Txt_codorden.Text);
            // dataGridView1Data.Rows.Add(Txt_codped.Text);
            dataGridView1.Rows.Clear();
               OdbcDataReader mostrar = logic.consultarpedidos("pedido",Txt_codorden.Text);
            try
            {
                while (mostrar.Read())
                {
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(4));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            scampo2 = logic.siguiente("pedido", "pkidpedido");
            Txt_codped.Text = scampo2;
            Txt_prod.Text = "";
            Txt_cantidad.Text = "";
        }

        private void limpiar()
        {
            Txt_cantidad.Text="";
            Txt_codemp.Text = "";
            Txt_prod.Text = "";
            Txt_codorden.Text = "";
            Txt_codped.Text = "";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            limpiar();
            dataGridView1.Rows.Clear();
            scampo1 = logic.siguiente("orden_produccion", "pkidordenproduccion");
            scampo2 = logic.siguiente("pedido", "pkidpedido");
            Txt_codped.Enabled = false;
            Txt_prod.Enabled = false;
            Txt_cantidad.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            btn_guardar.Enabled = false;
            button4.Enabled = false;
            Txt_codorden.Text = scampo1;
            Txt_codped.Text = scampo2;
            Txt_codorden.Enabled = false;
            Txt_codped.Enabled = false;
            txt_Detalle.Enabled = true;
            dtp_fechaentrega.Enabled = true;
            dtp_fecharealizacon.Enabled = true;
            btn_buscaremp.Enabled = true;

        }

        private void Btn_buscaremp_Click(object sender, EventArgs e)
        {

            if (txt_Detalle.Text != "" && Txt_codorden.Text != "")
            {
                logic.insertarop(Txt_codorden.Text, dtp_fecharealizacon.Value.ToString("yyyy-MM-dd"), dtp_fechaentrega.Value.ToString("yyyy-MM-dd"), txt_Detalle.Text, "1");

                txt_Detalle.Enabled = false;
                Txt_codorden.Enabled = false;
                dtp_fechaentrega.Enabled = false;
                dtp_fecharealizacon.Enabled = false;
                btn_buscaremp.Enabled = false;
                //------------------------------------------//
                Txt_codped.Enabled = true;
                Txt_prod.Enabled = true;
                Txt_cantidad.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                btn_guardar.Enabled = true;
                button4.Enabled = true;
                Txt_codped.Enabled = false;
            }
            else
            {
              MessageBox.Show("Porfavor llene todos los campos");
            }
            
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarayuda = logic.consultaayuda("87");
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
