using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Diseño_MRP;
using Capa_Diseño_SCM;
using CapaDiseño;
//using CapaDiseño;
using CapaLogica_ERP;

namespace ERP
{
    public partial class MenuPincipal : Form
    {

        bool estabaierto = false;
        public MenuPincipal()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
#region funciones del formulario generales
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.ContenedorPincipal.Region = region;
            this.Invalidate();
        }
        //---------------------------------------------arastrar form------------------------------------------//
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(135,54,0));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
           // base.OnPaint(e);
           // ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        int lx, ly;
        int sw, sh;

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
          
        }

        private void Paneltitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btn_min_Click(object sender, EventArgs e)
        {
            Btn_max.Visible = true;
            Btn_min.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void Btn_max_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            Btn_max.Visible = false;
            Btn_min.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea salir del programa?", "Warning",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            Application.Exit();
        }

        private void Tmr_hora_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToString("hh:mm:ss");
            lbl_Fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_cerrarsesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea cerrar sesion?", "Warning",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
            Login mainMenu2 = new Login();
            mainMenu2.Show();
            // img_perfil.Image = Image.FromFile("C:/Users/prueb/Desktop/ERP/ERP/ERP/imagenes/logo.png");
        }

        private void Lbl_usuario_Click(object sender, EventArgs e)
        {

        }

        private void Btn_maximizar_Click(object sender, EventArgs e)
        {
           
        }

        private void MenuPincipal_Load(object sender, EventArgs e)
        {
            cargardatos();
            // img_perfil.Image = Image.FromFile("C:/Empresa_Bienestar/Personal/jose.jpg");
            hideSubMenu();
        }

        private void Btn_normal_Click(object sender, EventArgs e)
        {
            
        }
        public void cargardatos()
        {
            lbl_usuario.Text = Cache.nombre;
            img_perfil.Image = Image.FromFile(Cache.foto);
        }

        private void Btn_configuracion_Click(object sender, EventArgs e)
        {
            showSubMenu(Submenu_Configuracion);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //codigo
            hideSubMenu();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            //codigo
            hideSubMenu();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            //codigo
            hideSubMenu();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            //codigo
            hideSubMenu();
        }

        //++++++++++++++++++++++++++++++++++++++++++para submenu
        private void hideSubMenu()
        {
            Submenu_Configuracion.Visible = false;
        }

        private void Btn_RHM_Click(object sender, EventArgs e)
        {
            MDIParent1 mainMenu = new MDIParent1(Cache.nombre,"1111");
            mainMenu.Show();
            this.Hide();


        }

        private void Button6_Click(object sender, EventArgs e)
        {
            MDIMRP mainMenuMRP = new MDIMRP(Cache.nombre);
            mainMenuMRP.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MDISCM mainMenuSCM = new MDISCM(Cache.nombre, "1111");
            mainMenuSCM.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximanmente");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximanmente");
        }

        private void Btn_ayud_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ERP - REALIZADO POR EQUPO SCRUM \n UMG - ULITMO AÑO DE INGENIERIA");
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

    
        #endregion



    }
}
