using Capa_Diseño_MRP.Consultas;
using Capa_Logica_MRP;
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

namespace Capa_Diseño_MRP.Mantenimientos
{
    public partial class Frm_MantProductoFormula : Form
    {
        LAPMRP logic = new LAPMRP();
        Validaciones v = new Validaciones();
        string scampo;
        string slocalIP;
        string smacAddresses;
        string suser;
        public Frm_MantProductoFormula(String susuario)
        {
            InitializeComponent();
            gpb_componentes.Enabled = false;
            Dgv_consultaFormulaDetalle.Enabled = false;
            //Bitacora
            obtenerip();
            suser = susuario;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Mantenimiento Componentes de Formula";
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

        public void MostrarTabla()
        {
            string codigoencabezado = Txt_codigoformula.Text;
            OdbcDataReader mostrar = logic.consultarformuladetalle(codigoencabezado);
            try
            {
                while (mostrar.Read())
                {
                    Dgv_consultaFormulaDetalle.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        public void codigosiguiente()
        {
            //codigo siguiente 
            scampo = logic.siguiente("formula_detalle", "linea");
            Txt_codigodetalle.Text = scampo;
        }

        public void limpiar()
        {
            Txt_codigodetalle.Clear();
            Txt_cantidad.Clear();
            Txt_materiaprima.Clear();
            Cbo_medida.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_consultaFormula concep = new Frm_consultaFormula();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_codigoformula.Text = concep.Dgv_consultaFormula.Rows[concep.Dgv_consultaFormula.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {          
            Txt_codigodetalle.Text = Dgv_consultaFormulaDetalle.CurrentRow.Cells[1].Value.ToString();
            Txt_materiaprima.Text = Dgv_consultaFormulaDetalle.CurrentRow.Cells[2].Value.ToString();
            Txt_cantidad.Text = Dgv_consultaFormulaDetalle.CurrentRow.Cells[3].Value.ToString();
            Cbo_medida.Text = Dgv_consultaFormulaDetalle.CurrentRow.Cells[4].Value.ToString();
            Btn_agregar.Enabled = false;
            Btn_guardar.Enabled = false;
            Btn_modificar.Enabled = true;
            Btn_eliminar.Enabled = true;
            Txt_cantidad.Enabled = true;
            Cbo_medida.Enabled = true;
            Btn_buscarMateriaPrima.Enabled = true;
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            Txt_codigodetalle.Clear();
            Txt_cantidad.Clear();
            Txt_materiaprima.Clear();
            Cbo_medida.ResetText();
            Btn_agregar.Enabled = true;
            Btn_guardar.Enabled = false;
            Btn_modificar.Enabled = false;
            Btn_eliminar.Enabled = false;
            Btn_seleccionar.Enabled = false;
            Txt_cantidad.Enabled = false;
            Cbo_medida.Enabled = false;

            if (Dgv_consultaFormulaDetalle.RowCount == 0)
            {

            }
            else
            {
                Btn_seleccionar.Enabled = true;
            }
        }

        private void btn_agregaringredientes_Click(object sender, EventArgs e)
        {
            if(Txt_codigoformula.Text == "")
            {
                MessageBox.Show("Debe ingresar una formula");
            }
            else
            {
                Btn_buscarMateriaPrima.Enabled = false;
                gpb_componentes.Enabled = true;
                Dgv_consultaFormulaDetalle.Enabled = true;
                Txt_codigodetalle.Enabled = false;
                Txt_cantidad.Enabled = false;
                Txt_materiaprima.Enabled = false;
                Cbo_medida.Enabled = false;
                Btn_guardar.Enabled = false;
                Btn_modificar.Enabled = false;
                Btn_eliminar.Enabled = false;
                Btn_seleccionar.Enabled = false;
                gpb_formula.Enabled = false;
                
                MostrarTabla();
            }

            if(Dgv_consultaFormulaDetalle.RowCount == 0)
            {
                Btn_agregar.Enabled = true;
            }
            else
            {
                Btn_seleccionar.Enabled = true;
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Dgv_consultaFormulaDetalle.Rows.Clear();
            gpb_componentes.Enabled = false;
            Dgv_consultaFormulaDetalle.Enabled = false;
            Txt_codigodetalle.Clear();
            Txt_cantidad.Clear();
            Txt_materiaprima.Clear();
            Cbo_medida.ResetText();
            gpb_formula.Enabled = true;
            Txt_codigoformula.Clear();
        }

        private void gpb_componentes_Enter(object sender, EventArgs e)
        {

        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Dgv_consultaFormulaDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            Btn_buscarMateriaPrima.Enabled = true;
            Txt_codigodetalle.Enabled = false;
            codigosiguiente();
            Txt_materiaprima.Enabled = false;
            Txt_cantidad.Enabled = true;
            Cbo_medida.Enabled = true;
            Btn_guardar.Enabled = true;
            Btn_agregar.Enabled = false;
            Btn_seleccionar.Enabled = false;
        }

        private void Btn_buscarMateriaPrima_Click(object sender, EventArgs e)
        {
            Frm_ConsultaMateriaPrima concep = new Frm_ConsultaMateriaPrima();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_materiaprima.Text = concep.Dgv_consultaMateriaPrima.Rows[concep.Dgv_consultaMateriaPrima.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            string estado = "1";
            
            OdbcDataReader cita = logic.insertarformuladetalle(Txt_codigoformula.Text, Txt_codigodetalle.Text, Txt_materiaprima.Text, Double.Parse(Txt_cantidad.Text), Cbo_medida.Text, estado);
            MessageBox.Show("Datos registrados.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "MRP", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
            limpiar();
            Btn_agregar.Enabled = true;
            Btn_guardar.Enabled = false;
            Btn_modificar.Enabled = false;
            Btn_eliminar.Enabled = false;
            //actualiza tabla
            Dgv_consultaFormulaDetalle.Rows.Clear();
            MostrarTabla();
            Txt_cantidad.Enabled = false;
            Cbo_medida.Enabled = false;
            Btn_buscarMateriaPrima.Enabled = false;
            if (Dgv_consultaFormulaDetalle.RowCount == 0)
            {

            }
            else
            {
                Btn_seleccionar.Enabled = true;
            }
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            if (Txt_codigodetalle.Text == "" | Txt_materiaprima.Text == "" | Txt_cantidad.Text == "" | Cbo_medida.Text == "")
            {
                MessageBox.Show("Debe seleccionar una columna de la tabla");
            }
            else
            {
                string estado = "1";
                OdbcDataReader cita = logic.modificarformuladetalle(Txt_codigoformula.Text, Txt_codigodetalle.Text, Txt_materiaprima.Text, Double.Parse(Txt_cantidad.Text), Cbo_medida.Text, estado);
                logic.bitacora("0", slocalIP, smacAddresses, suser, "MRP", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);
                MessageBox.Show("Datos modificados correctamente.");
                limpiar();
                Btn_agregar.Enabled = true;
                Btn_guardar.Enabled = false;
                Btn_modificar.Enabled = false;
                Btn_eliminar.Enabled = false;
                //actualiza tabla
                Dgv_consultaFormulaDetalle.Rows.Clear();
                MostrarTabla();
                Txt_cantidad.Enabled = false;
                Cbo_medida.Enabled = false;
                Btn_buscarMateriaPrima.Enabled = false;
                if (Dgv_consultaFormulaDetalle.RowCount == 0)
                {

                }
                else
                {
                    Btn_seleccionar.Enabled = true;
                }
            }           
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Txt_codigodetalle.Text == "" | Txt_materiaprima.Text == "" | Txt_cantidad.Text == "" | Cbo_medida.Text == "")
            {
                MessageBox.Show("Debe seleccionar una columna de la tabla");


            }
            else
            {
                OdbcDataReader cita = logic.eliminarformuladetalle(Txt_codigodetalle.Text);
                logic.bitacora("0", slocalIP, smacAddresses, suser, "MRP", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);
                MessageBox.Show("Eliminado Correctamentee.");
                limpiar();
                Btn_agregar.Enabled = true;
                Btn_guardar.Enabled = false;
                Btn_modificar.Enabled = false;
                Btn_eliminar.Enabled = false;

                //actualiza tabla
                Dgv_consultaFormulaDetalle.Rows.Clear();
                MostrarTabla();
                Txt_cantidad.Enabled = false;
                Cbo_medida.Enabled = false;
                Btn_buscarMateriaPrima.Enabled = false;

                if (Dgv_consultaFormulaDetalle.RowCount == 0)
                {

                }
                else
                {
                    Btn_seleccionar.Enabled = true;
                }
            }
        }

        private void Txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Camposdecimales(e);
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarayuda = logic.consultaayuda("84");
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
