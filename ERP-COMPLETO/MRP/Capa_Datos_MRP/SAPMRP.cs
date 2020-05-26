using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos_MRP
{
  public class SAPMRP
    {
        Conexion cn = new Conexion();
        OdbcCommand comm;
        //--------------------------------------------------------------------Metodo General--------------------------------------------------------------------//

        public OdbcDataReader insertarbitacora(string sCodigo, string sip, string Smac, string susuario, string sdepartamento, string sfechahora, string saccion, string sformulario)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into bitacora values(" + sCodigo + ", '" + sip + "', '" + Smac + "' ,'" + susuario + "','" + sdepartamento + "','" + sfechahora + "','" + saccion + "','" + sformulario + "');";
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

        public OdbcDataReader Insertar(string[] datos)
        {
            string query = "";
            for (int i = 1; i < datos.Length; i++)
            {
                query += "'";
                query += datos[i];
                if (i == datos.Length - 1)
                    query += "'";
                else
                    query += "',";
            }
            try
            {
                cn.conexionbd();
                string consulta = "insert into " + datos[0] + " values(" + query + ");";
                Console.WriteLine(consulta);
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

        public OdbcDataReader Eliminar(string[] datos)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE " + datos[0] + " set estado='0' where " + datos[2] + " = '" + datos[1] + "';";
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

        public OdbcDataReader Modificar(string[] datos, string[] campos)
        {
            string query = "";
            int n = 1;
            query += " set ";
            for (int i = 2; i < datos.Length; i++)
            {
                query += campos[n];
                query += " = '";
                query += datos[i];
                if (i == datos.Length - 1)
                    query += "'";
                else
                    query += "',";
                n++;
            }

            try
            {
                cn.conexionbd();
                string consulta = "UPDATE " + datos[0] + query + " where " + campos[0] + " = '" + datos[1] + "';";
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


        public OdbcDataReader consultaEstandar()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM estandardecalidad WHERE estado = 1 ;";
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


        public OdbcDataReader consultaEstacion()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM estacion WHERE estado = 1 ;";
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

        public OdbcDataReader consultaGastos()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM gastos_indirectos WHERE estado = 1 ;";
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


        public OdbcDataReader consultaProduccion(string sCProduccion)
        {
            try
            {
                cn.conexionbd();
                string consulta = "Select fe.pkidformulaencabezado , fe.pkidProducto, fd.pkidProducto, fd.cantidad, p.Precio from formula_encabezado fe inner join formula_detalle fd on fe.pkidformulaencabezado = fd.pkidformulaencabezado inner join detalle_produccion dp on fd.pkidformulaencabezado = dp.pkidformula inner join producto p on p.pkidProducto = fe.pkidProducto inner join procesoproduccion pc on pc.pkidencabezadop = dp.pkidencabezadop  where pc.pkidprocesoproduccion ='" + sCProduccion + "';";
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

        public OdbcDataReader consultaGastosP(string sCGastos)
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM gastos_indirectos WHERE pkidgastos_indirectos ='"+sCGastos+"';";
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


        public OdbcDataReader consultaManoO(string sCProduccion)
        {
            try
            {
                cn.conexionbd();
                string consulta = "Select e.pkidestacion, e.nombre, e.pkcodigoempleado, p.sueldo from estacion e inner join procesoproduccion pp on pp.pkidestacion = e.pkidestacion inner join empleado em on em.pkcodigoempleado = e.pkcodigoempleado inner join puesto p on p.fkcodigoempleado = em.pkcodigoempleado where pp.pkidprocesoproduccion = '" + sCProduccion + "'; ";
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


        public OdbcDataReader InsertarCostosF(string sCFabricacion, string sPProduccion, string sMerma, string sCosto)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into costodefabricacion values(" + sCFabricacion + ", '" + sPProduccion + "' ,'" + sMerma +
                    "' ,'" + sCosto + "');";
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

        public OdbcDataReader consultaCostos()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM costodefabricacion;";
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

        //--Paulis
        //---------------------------------------------------------------------------------MODIFICAR-TIPOMERMA-------------------------------------------------------------------------------
        public OdbcDataReader modificartipomerma(string scodigo, string snombre, string sdescripcion, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE tipomerma set nombre='" + snombre + "',descripcion='" + sdescripcion + "',estado='" + sestado + "' where pkidtipomerma='" + scodigo + "';";
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
        //---------------------------------------------------------------------------------INSERTAR-TIPOMERMA-------------------------------------------------------------------------------
        public OdbcDataReader insertartipomerma(string scodigo, string snombre, string sdescripcion, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into tipomerma values(" + scodigo + ", '" + snombre + "' ,'" + sdescripcion + "','" + sestado + "');";
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
        //---------------------------------------------------------------------------------ELIMINAR-TIPOMERMA------------------------------------------------------------------------------
        public OdbcDataReader eliminartipomerma(string scodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE tipomerma set estado='0' where pkidtipomerma='" + scodigo + "';";
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
        //---------------------------------------------------------------------------------CONSULTAR-TIPOMERMA-------------------------------------------------------------------------------
        public OdbcDataReader consultartipomerma()
        {
            int campo = 1;
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM tipomerma WHERE estado = " + campo + " ;", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }

        }
        //---------------------------------------------------------------------------------MODIFICAR-MERMA-------------------------------------------------------------------------------
        public OdbcDataReader modificarmerma(string scodigo, string stipomerma, string sproducto, double dcantidad, double dvalor, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE merma set pkidtipomerma='" + stipomerma + "',pkidProducto='" + sproducto + "',cantidad='" + dcantidad + "',valor='" + dvalor + "',estado='" + sestado + "' where pkidmerma='" + scodigo + "';";
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
        //---------------------------------------------------------------------------------INSERTAR-MERMA-------------------------------------------------------------------------------
        public OdbcDataReader insertarmerma(string scodigo, string stipomerma, string sproducto, double dcantidad, double dvalor, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into merma values(" + scodigo + ", '" + stipomerma + "' ,'" + sproducto + "','" + dcantidad + "','" + dvalor + "','" + sestado + "');";
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
        //---------------------------------------------------------------------------------ELIMINAR-MERMA------------------------------------------------------------------------------
        public OdbcDataReader eliminarmerma(string scodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE merma set estado='0' where pkidmerma='" + scodigo + "';";
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
        //---------------------------------------------------------------------------------CONSULTAR-MERMA-------------------------------------------------------------------------------
        public OdbcDataReader consultarmerma()
        {
            int campo = 1;
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM merma WHERE estado = " + campo + " ;", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }

        }
        //---------------------------------------------------------------------------------MODIFICAR-FORMULA-------------------------------------------------------------------------------
        public OdbcDataReader modificarformulaencabezado(string scodigo, string snombre, string sdescripcion, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE formula_encabezado set pkidProducto='" + snombre + "',descripcion='" + sdescripcion + "',estado='" + sestado + "' where pkidformulaencabezado='" + scodigo + "';";
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
        //---------------------------------------------------------------------------------INSERTAR-FORMULA-------------------------------------------------------------------------------
        public OdbcDataReader insertarformulaencabezado(string scodigo, string snombre, string sdescripcion, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into formula_encabezado values(" + scodigo + ", '" + snombre + "' ,'" + sdescripcion + "','" + sestado + "');";
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
        //---------------------------------------------------------------------------------ELIMINAR-FORMULA------------------------------------------------------------------------------
        public OdbcDataReader eliminarformulaencabezado(string scodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE formula_encabezado set estado='0' where pkidformulaencabezado='" + scodigo + "';";
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
        //---------------------------------------------------------------------------------CONSULTAR-FORMULA-------------------------------------------------------------------------------
        public OdbcDataReader consultarformulaencabezado()
        {
            int campo = 1;
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM formula_encabezado WHERE estado = " + campo + " ;", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }

        }
        //---------------------------------------------------------------------------------CONSULTAR-FORMULADETALLE1-------------------------------------------------------------------------------
        public OdbcDataReader consultarformuladetalle(string codigoencabezado)
        {
            int campo = 1;
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM formula_detalle WHERE estado = " + campo + " AND pkidformulaencabezado= " + codigoencabezado + ";", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }

        }
        //---------------------------------------------------------------------------------MODIFICAR-FORMULADETALLE-------------------------------------------------------------------------------
        public OdbcDataReader modificarformuladetalle(string scodigoformula, string scodigo, string smateria, double dcantidad, string smedida, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE formula_detalle set pkidformulaencabezado='" + scodigoformula + "',pkidproducto='" + smateria + "',cantidad='" + dcantidad + "',medida='" + smedida + "',estado='" + sestado + "' where linea='" + scodigo + "';";
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
        //---------------------------------------------------------------------------------INSERTAR-FORMULADETALLE-------------------------------------------------------------------------------
        public OdbcDataReader insertarformuladetalle(string scodigoformula, string scodigo, string smateria, double dcantidad, string smedida, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into formula_detalle values(" + scodigoformula + ", '" + scodigo + "' ,'" + smateria + "','" + dcantidad + "','" + smedida + "','" + sestado + "');";
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
        //---------------------------------------------------------------------------------ELIMINAR-FORMULADETALLE------------------------------------------------------------------------------
        public OdbcDataReader eliminarformuladetalle(string scodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE formula_detalle set estado='0' where linea='" + scodigo + "';";
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
        //---------------------------------------------------------------------------------CONSULTAR-FORMULADETALLE-------------------------------------------------------------------------------
        public OdbcDataReader consultarformuladet()
        {
            int campo = 1;
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM formula_detalle WHERE estado = " + campo + " ;", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }

        }
        //---------------------------------------------------------------------------------INSERTAR-ESTACION A PRODUCCION-------------------------------------------------------------------------------
        public OdbcDataReader insertarprocesoproduccion( string sproduccion, string sestacion)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into procesoproduccion values( '" + sproduccion + "' ,'" + sestacion + "');";
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
        //---------------------------------------------------------------------------------CONSULTAR-ASIGNACION-------------------------------------------------------------------------------
        public OdbcDataReader consultarasignacion()
        {
            int campo = 1;
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM procesoproduccion WHERE estado = " + campo + " ;", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }

        }
        //---------------------------------------------------------------------------------CONSULTAR-MATERIA PRIMA-------------------------------------------------------------------------------
        public OdbcDataReader consultarmateriaprima()
        {
            int campo = 1;
            int tipoproducto = 1;
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM producto WHERE estado = " + campo + " AND pktipo_producto = " + tipoproducto + ";", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }

        }
        //---------------------------------------------------------------------------------CONSULTAR-PRODUCTO TERMINADO-------------------------------------------------------------------------------
        public OdbcDataReader consultarproductoterminado()
        {
            int campo = 1;
            int tipoproducto = 2;
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM producto WHERE estado = " + campo + " AND pktipo_producto = " + tipoproducto + ";", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }

        }
        //---------------------------------------------------------------------------------CONSULTAR-PROCESO PRODUCCION-------------------------------------------------------------------------------
        public OdbcDataReader consultarprocesoproduccion()
        {
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM procesoproduccion ;", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }

        }
        //---------------------------------------------------------------------------------INSERTAR-CONTROL CALIDAD A PRODUCTO-------------------------------------------------------------------------------
        public OdbcDataReader insertarproductocontrolcalidad( string sproduccion, string sestandar, string sdescripcion, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into producto_control_calidad values(" + sproduccion + ", '" + sestandar + "' ,'" + sdescripcion + "','" + sestado + "');";
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
        public OdbcDataReader consultarproduccion()
        {
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM encabezado_produccion where estado = 1 ;", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }

        }

    }
}
