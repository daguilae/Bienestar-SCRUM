using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Capa_Logica_MRP;
using Capa_Diseño_MRP.Mantenimientos;

namespace Capa_Diseño_MRP.Procesos
{
    public partial class Frm_Poliza : Form
    {
        LFCMRP logic = new LFCMRP();
        Validaciones val = new Validaciones();
        string sueldobase = "0";
        string horas_extras = "0";
        int sueldo = 0;
        string materiap = "0";
        int materiaptotal = 0;
        int costo1 = 0;
        int costo2 = 0;
        int costo3 = 0;
        int costo4 = 0;
        int costo5 = 0;
        int costo6 = 0;
        int costo7 = 0;
        int costo8 = 0;
        int costo9 = 0;
        int total1 = 0;
        int total2 = 0;
        int total3 = 0;
        

        public Frm_Poliza()
        {
            InitializeComponent();
            Txt_numeropoliza.Text = logic.siguiente("mydb.polizadetalle_mrp", "pkidpolizaencabezado_MRP");

            MateriaPrima1();
            gastos();
            suelds();
            sueldos();
            operaciones();
            operacionmateriaprima();
            MateriaPrima();
            cuentas();
            cuentas2();
            sumasiguales();
           
           
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarayuda = logic.consultaayuda("72");
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

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void operaciones()
        {
            int montohora;
            montohora = int.Parse(horas_extras) * 15;
            sueldo = int.Parse(sueldobase) + montohora;
            Dgv_poliza.Rows.Add("001", "SUELDOS ", sueldo.ToString(), "");
        }

        public void operacionmateriaprima()
        {
            materiaptotal = int.Parse(materiap)-sueldo -total1-total2-total3;
        }
        public void gastos()
        {


            OdbcDataReader cuenta1 = logic.cuentascontables("agua");
            try
            {
                while (cuenta1.Read())
            {
                costo1 = cuenta1.GetInt32(0);

            }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            OdbcDataReader cuenta2 = logic.cuentascontables("energia electrica");

                try
                {
                    while (cuenta2.Read())
            {
                costo2 = cuenta2.GetInt32(0);

            }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            OdbcDataReader cuenta3 = logic.cuentascontables("luz");
                    try
                    {
                        while (cuenta3.Read())
            {
                costo3 = cuenta3.GetInt32(0);

            }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            OdbcDataReader cuenta4 = logic.cuentascontables("energia");
                        try
                        {
                            while (cuenta4.Read())
            {
                costo4 = cuenta3.GetInt32(0);

            }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            OdbcDataReader cuenta5 = logic.cuentascontables("calefaccion");
                            try
                            {
                                while (cuenta5.Read())
            {
                costo5 = cuenta5.GetInt32(0);

            }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            total1 = costo1 + costo2 + costo3 + costo4 + costo5;

            OdbcDataReader insertar1 = logic.newcuenta("141","SUMINISTROS", total1.ToString());
            OdbcDataReader insertar2 = logic.updatecuenta("141", "SUMINISTROS", total1.ToString());
            
            OdbcDataReader cuenta6 = logic.cuentascontables("alquileres");
            try
            {
                while (cuenta6.Read())
                {
                    costo6 = cuenta6.GetInt32(0);

                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            OdbcDataReader cuenta7 = logic.cuentascontables("alquiler");
            try
            {
                while (cuenta7.Read())
                {
                    costo7 = cuenta7.GetInt32(0);

                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            OdbcDataReader cuenta8 = logic.cuentascontables("renta");
            try
            {
                while (cuenta8.Read())
                {
                    costo8 = cuenta8.GetInt32(0);

                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            total2 = costo6 + costo7 + costo8;

            OdbcDataReader insertar3 = logic.newcuenta("121", "ALQUILERES", total2.ToString());
            OdbcDataReader insertar4 = logic.updatecuenta("121", "ALQUILERES", total2.ToString());


            OdbcDataReader cuenta9 = logic.gastosextras();
            try
            {
                while (cuenta9.Read())
                {
                    costo9 = cuenta8.GetInt32(0);

                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            total3 = total1 - total2 - costo9;
            OdbcDataReader insertar5 = logic.newcuenta("191", "MATERIALES INDIRECTOS", total3.ToString());
            OdbcDataReader insertar6 = logic.updatecuenta("191", "MATERIALES INDIRECTOS", total3.ToString());

        }

        public void suelds()
        {
            OdbcDataReader desplegar = logic.horasextras();
            try
            {
                while (desplegar.Read())
                {
                    horas_extras = desplegar.GetString(0);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        public void desactivar()
        {
            if (txt_debe.Text != "")
            {
                btn_actualizar.Visible = false;
                btn_ingresarCuenta.Visible = false;
            }
        }

        public void sumasiguales()
        {
            OdbcDataReader desplegar = logic.iguales(Txt_numeropoliza.Text);
            try
            {
                while (desplegar.Read())
                {
                    txt_debe.Text = desplegar.GetString(0);
                    txt_haber.Text = desplegar.GetString(0);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        public void cuentas2()
        {
            Dgv_poliza.Rows.Add("020", "BANCOS", "", sueldo.ToString());
            Dgv_poliza.Rows.Add("050", "COMPRAS", "", materiaptotal);

            OdbcDataReader mostrar = logic.mostrarcuenta();
            try
            {
                while (mostrar.Read())
                {
                    Dgv_poliza.Rows.Add(mostrar.GetString(0), mostrar.GetString(1) + " POR PAGAR", "", mostrar.GetString(2));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        public void cuentas()
        {
            OdbcDataReader mostrar = logic.mostrarcuenta();
            try
            {
                while (mostrar.Read())
                {
                    Dgv_poliza.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        public void sueldos()
        {
            OdbcDataReader mostrar = logic.sueldobase();
            try
            {
                while (mostrar.Read())
                {
                    sueldobase = mostrar.GetString(0);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        public void MateriaPrima()
        {
            OdbcDataReader mostrar = logic.materiaprima();
            try
            {
                while (mostrar.Read())
                {
                    materiap = mostrar.GetString(0);
                    Dgv_poliza.Rows.Add("010", "Materia Prima", materiaptotal, "");
                   
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        public void MateriaPrima1()
        {
            OdbcDataReader mostrar = logic.materiaprima();
            try
            {
                while (mostrar.Read())
                {
                    materiap = mostrar.GetString(0);
                    

                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        public void Guardar_Encabezado()
        {
            string numeroPoliza = Convert.ToString(Txt_numeropoliza.Text);
            string TipoPoliza = Convert.ToString(Txt_tipo.Text);
            string Descripcion = Convert.ToString(txt_descripcion.Text);
            string fechaInicio = dtp_iniciopoliza.Value.ToString("yyyy-MM-dd");
            string fechaFin = dtp_finalpoliza.Value.ToString("yyyy-MM-dd");
            OdbcDataReader insertar = logic.Insertarencabezado(numeroPoliza, fechaInicio, fechaFin, Descripcion);
        }

        public void Guardar_detalle()
        {
            foreach (DataGridViewRow row in Dgv_poliza.Rows)
            {
                string numeroPoliza = Convert.ToString(Txt_numeropoliza.Text);
                int codigo = Convert.ToInt32(row.Cells["Codigo"].Value);
                string debe = Convert.ToString(row.Cells["Debe"].Value);
                string haber = Convert.ToString(row.Cells["Haber"].Value);

                OdbcDataReader insertar = logic.Insertardetalle(numeroPoliza, codigo, debe, haber);
            }
        }

        private void btn_ingresarCuenta_Click_1(object sender, EventArgs e)
        {
            Frm_MantCuentasContables hola = new Frm_MantCuentasContables();
            hola.Show();
        }

        private void btn_generar_Click_1(object sender, EventArgs e)
        {
            Guardar_Encabezado();
            Guardar_detalle();
            sumasiguales();
            desactivar();
        }

        private void btn_actualizar_Click_1(object sender, EventArgs e)
        {
            Dgv_poliza.Rows.Clear();

            MateriaPrima1();
            gastos();
            suelds();
            sueldos();
            operaciones();
            operacionmateriaprima();
            MateriaPrima();
            cuentas();
            cuentas2();
            sumasiguales();
            txt_debe.Clear();
            txt_haber.Clear();
        }

        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.CamposNumerosYLetras(e);
        }

        private void txt_debe_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.CamposNumericos(e);
        }
    }
}
