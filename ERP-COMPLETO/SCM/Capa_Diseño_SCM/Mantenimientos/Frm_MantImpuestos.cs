﻿using System;
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
using Capa_Diseño_SCM.Consultas;
using Capa_Logica_SCM;
using CapaDiseño.Consulta;

namespace Capa_Diseño_SCM.Mantenimientos
{
    public partial class Frm_MantImpuestos : Form
    {
        LIFSCM logic = new LIFSCM();
        string scampo;
        string suser;
        string tipopermiso;

        string slocalIP;
        string smacAddresses;
        public Frm_MantImpuestos(String susuario, String permiso)
        {
            InitializeComponent();
            scampo = logic.siguiente("impuestos", "pkidImpuesto");
            obtenerip();
            suser = susuario;
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_borrar.Enabled = false;
            Btn_consultar.Enabled = false;
            bloqueartxt();
            this.Text = "Impuestos";
            Txt_Cod.Text = scampo;
            txt_descripcion.Enabled = false;
            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = false;
            txt_valor.Enabled = false;
            tipopermiso = permiso;
        }

        /*---------------------------------------------------Codigo general------------------------------------------------------------------------------------------*/
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

            /*------------------------*/
            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = false;
            txt_descripcion.Enabled = false;
            txt_valor.Enabled = false;
        }
        public void desbloqueartxt()
        {
            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = true;
            txt_descripcion.Enabled = true;
            txt_valor.Enabled = true;
        }
        public void limpiar()
        {
            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = false;
            txt_descripcion.Enabled = false;
            Txt_Cod.Text = "";
            Txt_nombre.Text = "";
            txt_descripcion.Text = "";
            txt_valor.Text = "";
            scampo = logic.siguiente("impuestos", "pkidImpuesto");
            Txt_Cod.Text = scampo;
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frm_MantImpuestos_Load(object sender, EventArgs e)
        {

        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            permisos();
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarayuda = logic.consultaayuda("60");
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

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.InsertarImpuesto(Txt_Cod.Text, Txt_nombre.Text, txt_descripcion.Text, txt_valor.Text);
            MessageBox.Show("Datos registrados.");
            limpiar();
            logic.bitacora("0", slocalIP, smacAddresses, suser, "SCM", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);      
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.modificarImpuesto(Txt_Cod.Text, Txt_nombre.Text, txt_descripcion.Text, txt_valor.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "SCM", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);
            MessageBox.Show("Datos modificados correctamente.");
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarImpuesto(Txt_Cod.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "SCM", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);
            MessageBox.Show("Eliminado Correctamentee.");
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaImpuesto concep = new Frm_consultaImpuesto();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_Cod.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombre.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[1].Value.ToString();
                txt_descripcion.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[2].Value.ToString();
                txt_valor.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[3].Value.ToString();
            }
        }
    }
}
