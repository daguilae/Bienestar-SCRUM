
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
using CapaDiseño.Procesos;
using CapaDatos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using CapaLogica;
using CapaDiseño.Consulta;

namespace CapaDiseño.Procesos
{

    public partial class Frm_Convocatoria : Form
    {
        Logica logic = new Logica();
        string[] valores = new string[7];
        public Frm_Convocatoria()
        {
            InitializeComponent();
            txt_mediocomunicacion.Enabled = false;
            Txt_tipocontratacion.Enabled = false;
            Txt_Id.Enabled = false;
            MostrarConsulta();

        }

        public void MostrarConsulta()
        {
            DGV_PERFIL.Rows.Clear();
            try
            {
                Conexion conexion = new Conexion();
                string consultaMostrar = "SELECT * FROM perfil_encabezado WHERE estado='1';";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conexionbd());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                string consultaMostrar2 = "SELECT * FROM perfil_detalle WHERE estado='1';";
                OdbcCommand comm2 = new OdbcCommand(consultaMostrar2, conexion.conexionbd());
                OdbcDataReader mostrarDatos2 = comm2.ExecuteReader();
                int contador = 0;
                while (mostrarDatos.Read() && mostrarDatos2.Read())
                {
                    contador = 0;
                    DGV_PERFIL.Refresh();
                    for (int n = 1; n < 7; n++)
                    {
                        if (mostrarDatos2.GetString(n) == "1")
                            valores[contador] = "Si";
                        else
                            valores[contador] = "No";

                        contador++;
                    }
                    DGV_PERFIL.Rows.Add(mostrarDatos.GetString(0), valores[0], valores[1], valores[2], valores[3], valores[4], valores[5], mostrarDatos2.GetString(7), mostrarDatos2.GetString(8));

                }
                comm.Connection.Close();
                mostrarDatos.Close();
                comm2.Connection.Close();
                mostrarDatos2.Close();
            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }
        /*
        public void MostrarConsulta()
        {
            DGV_PERFIL.Rows.Clear();
            try
            {
                Conexion conexion = new Conexion();
                string consultaMostrar = "SELECT * FROM perfil_detalle WHERE estado='1';";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conexionbd());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();
                while (mostrarDatos.Read())
                {
                    DGV_PERFIL.Refresh();
                    DGV_PERFIL.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetString(3), mostrarDatos.GetString(4), mostrarDatos.GetString(5), mostrarDatos.GetString(6), mostrarDatos.GetString(7), mostrarDatos.GetString(8));
                }
                comm.Connection.Close();
                mostrarDatos.Close();
            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }
        */
        private void Frm_Convocatoria_Load(object sender, EventArgs e)
        {
            DGV_PERFIL.Rows.Clear();
            MostrarConsulta();
        }

        private void Cbo_TipoC_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Cbo_MC_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {

           


        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {

            
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarEmpleado = logic.consultaayuda("18");
            try
            {
                while (mostrarEmpleado.Read())
                {
                    ruta = mostrarEmpleado.GetString(1);
                    indice = mostrarEmpleado.GetString(2);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            Help.ShowHelp(this, ruta, indice);
        }

        private void btn_producción_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleado concep = new Frm_consultaEmpleado();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_Id.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void btn_contratacion_Click(object sender, EventArgs e)
        {
            Frm_TipoContratacion concep = new Frm_TipoContratacion();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_tipocontratacion.Text = concep.Dgv_consultaContratacion.Rows[concep.Dgv_consultaContratacion.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void btn_comunicacion_Click(object sender, EventArgs e)
        {
            Frm_consultaMediodeComunicacion concep = new Frm_consultaMediodeComunicacion();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                txt_mediocomunicacion.Text = concep.Dgv_consultaMedios.Rows[concep.Dgv_consultaMedios.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void Btn_Imprimir_Click_1(object sender, EventArgs e)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("Convo.pdf", FileMode.Create)); // asignamos el nombre de archivo
            // Importante Abrir el documento
            doc.Open();
            // Creamos un titulo personalizado con tamaño de fuente 18 y color Azul
            Paragraph title = new Paragraph();

            title.Add("CONVOCATORIA DE TRABAJO ");
            doc.Add(title);
            // Agregamos un parrafo vacio como separacion.
            doc.Add(new Paragraph(" "));

            // Empezamos a crear la tabla, definimos una tabla de 6 columnas
            PdfPTable table = new PdfPTable(4);
            // Esta es la primera fila
            table.AddCell("ID Empleado Creador");
            table.AddCell("Fecha");
            table.AddCell("Tipo de Contratacion");
            table.AddCell("Medio de Comunicacion");

            // Segunda fila
            table.AddCell(Txt_Id.Text);
            table.AddCell(DTP_fEHCA.Text);
            table.AddCell(Txt_tipocontratacion.Text);
            table.AddCell(txt_mediocomunicacion.Text);

            // DOS LINEAS DE SEPARACION
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));

            title.Add("REQUISITOS");
            doc.Add(title);
            doc.Add(new Paragraph(" "));

            // Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(DGV_PERFIL.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 85;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;


            //Adding Header row
            foreach (DataGridViewColumn column in DGV_PERFIL.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in DGV_PERFIL.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }
            }


            //Exporting to PDF
            string folderPath = "C:\\PDF\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + Txt_NombrePDF.Text + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Add(table);
                pdfDoc.Close();
                stream.Close();

                MessageBox.Show("El documneto ha sido creado, dirijase a la carpeta PDF en su Disco C");
            }

            Txt_Id.Clear();
            txt_mediocomunicacion.Clear();
            Txt_NombrePDF.Clear();
            Txt_tipocontratacion.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Txt_Id.Clear();
            txt_mediocomunicacion.Clear();
            Txt_NombrePDF.Clear();
            Txt_tipocontratacion.Clear();
            
        }
    }
}
