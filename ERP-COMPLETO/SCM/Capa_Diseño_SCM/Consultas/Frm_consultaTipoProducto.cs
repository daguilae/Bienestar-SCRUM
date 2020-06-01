﻿using Capa_Logica_SCM;
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

namespace Capa_Diseño_SCM.Consultas
{
    public partial class Frm_consultaTipoProducto : Form
    {
        LIPSCM logic = new LIPSCM();

        public Frm_consultaTipoProducto()
        {
            InitializeComponent();
            MostrarConsulta();
        }

        public void MostrarConsulta()
        {

            OdbcDataReader mostrarDatos = logic.ConsultatipoProd();
            try
            {
                while (mostrarDatos.Read())
                {

                    Dgv_consultaProd.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetString(3));

                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Pnl_nombreForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaProd.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Dgv_consultaProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consultaProd.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frm_consultaTipoProducto_Load(object sender, EventArgs e)
        {
            Dgv_consultaProd.Rows.Clear();
            MostrarConsulta();
        }
    }
}
