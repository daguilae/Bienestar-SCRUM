using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos_MRP
{
    public class Sentencias
    {
        Conexion cn = new Conexion();
        OdbcCommand comm;

        public OdbcDataReader consultageneral(string tabla)
        {
            try
            {
                cn.conexionbd();
                string consultaGraAsis = " select * from " + tabla + ";";
                comm = new OdbcCommand(consultaGraAsis, cn.conexionbd());
                OdbcDataReader mostrarResultados = comm.ExecuteReader();
                return mostrarResultados;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader consultaayudas(string id)
        {
            try
            {
                cn.conexionbd();
                string consultaGraAsis = " select * from ayudas where pkcodigoayuda =" + id + ";";
                comm = new OdbcCommand(consultaGraAsis, cn.conexionbd());
                OdbcDataReader mostrarResultados = comm.ExecuteReader();
                return mostrarResultados;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader consultafiltro(string tabla, string campobusqueda)
        {
            try
            {
                cn.conexionbd();
                string consultaGraAsis = " select * from " + tabla + " WHERE pkidordenproduccion='" + campobusqueda + "';";
                comm = new OdbcCommand(consultaGraAsis, cn.conexionbd());
                OdbcDataReader mostrarResultados = comm.ExecuteReader();
                return mostrarResultados;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader consultarpedidos(string tabla, string campobusqueda)
        {
            try
            {
                cn.conexionbd();
                string consultaGraAsis = " SELECT * FROM " + tabla + " WHERE pkidpedido='" + campobusqueda + "';";
                comm = new OdbcCommand(consultaGraAsis, cn.conexionbd());
                OdbcDataReader mostrarResultados = comm.ExecuteReader();
                return mostrarResultados;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }


        public OdbcDataReader insertarordendeproduccion(string codigo, string fecharealizacion, string fecgaentrega, string detalle, string estado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into orden_produccion values(" + codigo + ", '" + fecharealizacion + "', '" + fecgaentrega + "' ,'" + detalle + "','" + estado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertarpedido(string scodigo, string sproducto, string sestado, string scodempelado, string scantidad, string sordendeproduccion)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into pedido values(" + scodigo + ", '" + sproducto + "', '" + sestado + "' ,'" + scodempelado + "','" + scantidad + "','" + sordendeproduccion + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader obtenerReporte(string id)
        {
            try
            {
                cn.conexionbd();
                string consultaGraAsis = "select * from reportes where pkidreporte =" + id + ";";
                comm = new OdbcCommand(consultaGraAsis, cn.conexionbd());
                OdbcDataReader mostrarResultados = comm.ExecuteReader();
                return mostrarResultados;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }

        public string obtenerfinal(string tabla, string campo)
        {
            String camporesultante = "";
            try
            {
                string sql = "SELECT MAX(" + campo + "+1) FROM " + tabla + ";"; //SELECT MAX(idFuncion) FROM `funciones`     
                OdbcCommand command = new OdbcCommand(sql, cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                camporesultante = reader.GetValue(0).ToString();
                //Console.WriteLine("El resultado es: " + camporesultante);
                if (String.IsNullOrEmpty(camporesultante))
                    camporesultante = "1";
            }
            catch (Exception)
            {
                Console.WriteLine(camporesultante);
            }
            return camporesultante;
        }
    }
}
