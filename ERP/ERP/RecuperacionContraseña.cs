using CapaDatos_ERP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace ERP
{
    public partial class RecuperacionContraseña : Form
    {
        public RecuperacionContraseña()
        {
            InitializeComponent();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void Btn_minimzar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var user = new Sentencias();
            var result = user.recoverPassword(Txt_pass.Text);
            Lbl_resultado.Text = result;
        }

    }
}
