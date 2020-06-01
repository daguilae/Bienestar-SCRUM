﻿using Capa_Diseño_SCM.Consultas;
using Capa_Diseño_SCM.Mantenimientos;
using Capa_Diseño_SCM.Reportes;
using Capa_Logica_SCM;
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

namespace Capa_Diseño_SCM.Procesos
{
    public partial class Frm_Ordencompra : Form
    {
        
        LIFSCM logic = new LIFSCM();
        Logica logics = new Logica();
        string codigoproduct;
        string producto;
        string costo;
        string totales;
        string totalimpuesto;
        

        public Frm_Ordencompra()
        {
            InitializeComponent();
           Txt_orden.Text  = logic.siguiente("ordencomrpaencabezado", "pkIdOrdenCompraEncabezado");
            

        }

        public Frm_Ordencompra(String scodusuario)
        {
            InitializeComponent();
           Txt_orden.Text  = logic.siguiente("ordencomrpaencabezado", "pkIdOrdenCompraEncabezado");

            Txt_codigoempleado.Text = scodusuario.ToString();

        }
        public void numeroorden()

        {
            if (Txt_orden.Text=="") 
            {
                Txt_orden.Text = "1";
            }
            else
                {
                    OdbcDataReader mostrar = logic.codorden();
                try
                {
                    while (mostrar.Read())
                    {
                        Txt_orden.Text = mostrar.GetString(0);


                    }

                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }



            }
        }


    
            

        



    

        public void Mostrarimpuestos()
        {

            OdbcDataReader mostrar = logic.impuestos ();
            try
            {
                while (mostrar.Read())
                {

                   Txt_impuesto.Text = mostrar.GetString(0);

                }



            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }


        }
        public void Mostrarproductos()
        {


            OdbcDataReader mostrarEmpleado = logic.productosmostrar(Txt_codProveedor.Text );
            try
            {
                while (mostrarEmpleado.Read())
                {

                    Dgv_productos.Rows.Add(mostrarEmpleado.GetString(0), mostrarEmpleado.GetString(1), mostrarEmpleado.GetString(2));

                }



            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }


        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
           if(Txt_impuesto.Text =="")
            {
                MessageBox.Show("Complete Datos de foma de pago");
            }
            else
            {
                Txt_codProveedor.Enabled = false;
                Mostrarproductos(); }
           
          

        }

        private void Dgv_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public void total()
        {
           totales= (Convert.ToInt32(Txt_cantidad.Text) * Convert.ToInt32(costo)).ToString();
        }

        public void totalorden()
        {
            if (textBox2.Text == "")
            {
                Txt_descuento.Text = "0";
                double subtotal, descuento,  total;
                double impuesto, resultimpuesto;
                subtotal = Convert.ToDouble(Txt_subtotal.Text);
                descuento = Convert.ToDouble(Txt_descuento.Text);
                impuesto = Convert.ToDouble(Txt_impuesto.Text);
                resultimpuesto = subtotal * impuesto;
                total = subtotal - descuento + resultimpuesto;
                Txt_Totalorden.Text = total.ToString();
                totalimpuesto = resultimpuesto.ToString();

            }
            else
            {
               double subtotal, descuento, impuesto, resultimpuesto, descunto, total;
                subtotal = Convert.ToDouble(Txt_subtotal.Text);
                
                double tbox2 = Convert.ToDouble(textBox2.Text);
                descunto = tbox2 / 100;
                descuento =subtotal* descunto;
                Txt_descuento.Text = descuento.ToString();
                impuesto = Convert.ToDouble(Txt_impuesto.Text);
                resultimpuesto = subtotal * impuesto;
                total = subtotal - descuento + resultimpuesto;
                Txt_Totalorden.Text = total.ToString();
                totalimpuesto = resultimpuesto.ToString();
            }
        }

        public void subtotal()
        {
            //Variable donde almacenaremos el resultado de la sumatoria.
            double sumatoria = 0;
            //Método con el que recorreremos todas las filas de nuestro Datagridview
            foreach (DataGridViewRow row in Dgv_detalle.Rows)
            {
                //Aquí seleccionaremos la columna que contiene los datos numericos.
                sumatoria += Convert.ToDouble(row.Cells["Column4"].Value);
            }
            //Por ultimo asignamos el resultado a el texto de nuestro Label
            Txt_subtotal.Text = Convert.ToString(sumatoria);

        }
        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            label2.Visible = false;
            Lbl_cantidad.Visible = false;
            Txt_cantidad.Visible = false;
            Btn_agregar.Visible = false;
            if (Txt_cantidad.Text == "")
            {
                MessageBox.Show("ingrese cantidad");
            }
            else
            {
                total();
                Dgv_detalle.Rows.Add(codigoproduct,producto , costo, Txt_cantidad.Text, totales);
                total();
                
                MessageBox.Show("agregado a la orden");
             
                Txt_cantidad.Clear();
             
                subtotal();
                totalorden();
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void Guardar()

        {
            string codorden = Convert.ToString(Txt_orden.Text);
            string codproveedor= Convert.ToString(Txt_codigoempleado.Text);
            string formapago= Convert.ToString(Txt_formapago.Text);


            string fechapedido = Txt_fecha.Value.ToString("yyyy-MM-dd");
            string fecharequerida = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            string codempleado = Convert.ToString(Txt_codigoempleado.Text);
            string obsevaciones = Convert.ToString(textBox1.Text);
            string impuesto = totalimpuesto.ToString();
            string total = Convert.ToString(Txt_Totalorden.Text);
            string descuento = Convert.ToString(Txt_descuento.Text);


            OdbcDataReader cita = logic.insertarencabezado(codorden,codproveedor, formapago, fechapedido, fecharequerida,codempleado,obsevaciones,impuesto , total , descuento );



        }

        public void Guardar2()

        {
            foreach (DataGridViewRow row in Dgv_detalle.Rows)
            {
                string codorden = Convert.ToString(Txt_orden.Text);
                string producto = Convert.ToString(row.Cells["Codigo"].Value);
                string cantidad = Convert.ToString(row.Cells["Column3"].Value);
                string total = Convert.ToString(row.Cells["Column4"].Value);

                OdbcDataReader cita = logic.insertardetalle(codorden, producto, cantidad, total);



            }
          


           



        }

        private void Btn_generar_Click(object sender, EventArgs e)
        {
            {
                button4.Visible = true;
                REPORTES.Visible = true;
                if (Txt_formapago.Text == "")
                {
                    MessageBox.Show("Complete Datos de foma de pago");
                }
                else
                {
                    Guardar();
                    Guardar2();
                    MessageBox.Show("GENERADA");
                }



            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_consultaImpuesto concep = new Frm_consultaImpuesto();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {

                Txt_impuesto.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[3].Value.ToString();
            }
        }

        private void btn_buscarI_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleados concep = new Frm_consultaEmpleados();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
               Txt_codigoempleado.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
        Frm_consultaFormaPago concep = new Frm_consultaFormaPago();
        concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {

                Txt_formapago.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }

}

        private void Gpb_Detallenominal_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Visible = true;
            Txt_cantidad.Visible = true;
            Btn_agregar.Visible = true;

            if (Dgv_productos.Rows.Count == 0)
            {
                return;
            }
            else
            {
                codigoproduct = Dgv_productos.Rows[Dgv_productos.CurrentRow.Index].
                  Cells[0].Value.ToString();
                producto  = Dgv_productos.Rows[Dgv_productos.CurrentRow.Index].
                    Cells[1].Value.ToString();
                costo  = Dgv_productos.Rows[Dgv_productos.CurrentRow.Index].
                       Cells[2].Value.ToString();
            }

        }

        private void Dgv_detalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txt_codigoempleado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {

            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarayuda = logic.consultaayuda("63");
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

        private void button4_Click(object sender, EventArgs e)
        {
            string codigo = Convert.ToString(Txt_orden.Text);
            Frm_ReporteOrdenCompras ordencomprarpt = new Frm_ReporteOrdenCompras(codigo);
            ordencomprarpt.ShowDialog();
        }

        private void REPORTES_Click(object sender, EventArgs e)
        {

        }
    }
}

