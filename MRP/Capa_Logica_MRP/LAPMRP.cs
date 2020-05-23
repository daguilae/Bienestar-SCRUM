using Capa_Datos_MRP;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa_Logica_MRP
{
    public class LAPMRP
    {
        SAPMRP sn = new SAPMRP();
        /*-----------------------------------------------------------------------Metodos Generales------------------------------------------------------------*/
        public OdbcDataReader bitacora(string sCodigo, string sip, string Smac, string susuario, string sdepartamento, string sfechahora, string saccion, string sformulario)
        {
            return sn.insertarbitacora(sCodigo, sip, Smac, susuario, sdepartamento, sfechahora, saccion, sformulario);
        }

        public OdbcDataReader consultaayuda(string id)
        {
            return sn.consultaayudas(id);
        }
        public string siguiente(string tabla, string campo)
        {
            string llave = sn.obtenerfinal(tabla, campo);
            return llave;
        }

        public OdbcDataReader Insertar(string[] datos)
        {
            return sn.Insertar(datos);
        }
        public OdbcDataReader Eliminar(string[] datos)
        {
            return sn.Eliminar(datos);
        }

        public OdbcDataReader Modificar(string[] datos, string[] campos)
        {
            return sn.Modificar(datos, campos);
        }


        public OdbcDataReader consultarEstandar()
        {
            return sn.consultaEstandar();
        }

        public OdbcDataReader consultarEstacion()
        {
            return sn.consultaEstacion();
        }


        public OdbcDataReader consultarGastos()
        {
            return sn.consultaGastos();
        }


        public OdbcDataReader consultaProduccion(string sCProduccion)
        {
            return sn.consultaProduccion(sCProduccion);
        }

        public OdbcDataReader consultaGastosP(string sCGastos)
        {
            return sn.consultaGastosP(sCGastos);
        }

        public OdbcDataReader consultaManoO(string sCProduccion)
        {
            return sn.consultaManoO(sCProduccion);
        }

        public OdbcDataReader InsertarCostosF(string sCFabricacion, string sPProduccion, string sMerma, string sCosto)
        {
            return sn.InsertarCostosF(sCFabricacion,sPProduccion,sMerma,sCosto);
        }

        public OdbcDataReader consultarCostosF()
        {
            return sn.consultaCostos();
        }

        //--Paulis
        //---------------------------------------------------------------------------------MODIFICAR-TipoMemra-------------------------------------------------------------------------------
        public OdbcDataReader modificartipomerma(string scodigo, string snombre, string sdescripcion, string sestado)
        {
            return sn.modificartipomerma(scodigo, snombre, sdescripcion, sestado);
        }
        //---------------------------------------------------------------------------------INSERTAR-TipoMerma-------------------------------------------------------------------------------
        public OdbcDataReader insertartipomerma(string scodigo, string snombre, string sdescripcion, string sestado)
        {
            return sn.insertartipomerma(scodigo, snombre, sdescripcion, sestado);
        }
        //---------------------------------------------------------------------------------ELIMINAR-TipoMerma-------------------------------------------------------------------------------
        public OdbcDataReader eliminartipomerma(string scodigo)
        {
            return sn.eliminartipomerma(scodigo);
        }
        //---------------------------------------------------------------------------------CONSULTAR-TipoMerma-------------------------------------------------------------------------------
        public OdbcDataReader consultartipomerma()
        {
            return sn.consultartipomerma();
        }
        //---------------------------------------------------------------------------------MODIFICAR-Merma-------------------------------------------------------------------------------
        public OdbcDataReader modificarmerma(string scodigo, string stipomerma, string sproducto, double dcantidad, double dvalor, string sestado)
        {
            return sn.modificarmerma(scodigo, stipomerma, sproducto, dcantidad, dvalor, sestado);
        }
        //---------------------------------------------------------------------------------INSERTAR-Merma-------------------------------------------------------------------------------
        public OdbcDataReader insertarmerma(string scodigo, string stipomerma, string sproducto, double dcantidad, double dvalor, string sestado)
        {
            return sn.insertarmerma(scodigo, stipomerma, sproducto, dcantidad, dvalor, sestado);
        }
        //---------------------------------------------------------------------------------ELIMINAR-Merma-------------------------------------------------------------------------------
        public OdbcDataReader eliminarmerma(string scodigo)
        {
            return sn.eliminarmerma(scodigo);
        }
        //---------------------------------------------------------------------------------CONSULTAR-Merma-------------------------------------------------------------------------------
        public OdbcDataReader consultarmerma()
        {
            return sn.consultarmerma();
        }
        //---------------------------------------------------------------------------------MODIFICAR-FORMULA-------------------------------------------------------------------------------
        public OdbcDataReader modificarformulaencabezado(string scodigo, string snombre, string sdescripcion, string sestado)
        {
            return sn.modificarformulaencabezado(scodigo, snombre, sdescripcion, sestado);
        }
        //---------------------------------------------------------------------------------INSERTAR-FORMULA-------------------------------------------------------------------------------
        public OdbcDataReader insertarformulaencabezado(string scodigo, string snombre, string sdescripcion, string sestado)
        {
            return sn.insertarformulaencabezado(scodigo, snombre, sdescripcion, sestado);
        }
        //---------------------------------------------------------------------------------ELIMINAR-FORMULA-------------------------------------------------------------------------------
        public OdbcDataReader eliminarformulaencabezado(string scodigo)
        {
            return sn.eliminarformulaencabezado(scodigo);
        }
        //---------------------------------------------------------------------------------CONSULTAR-FORMULA-------------------------------------------------------------------------------
        public OdbcDataReader consultarformulaencabezado()
        {
            return sn.consultarformulaencabezado();
        }
        //---------------------------------------------------------------------------------CONSULTAR-FORMULA-------------------------------------------------------------------------------
        public OdbcDataReader consultarformuladetalle(string codigoencabezado)
        {
            return sn.consultarformuladetalle(codigoencabezado);
        }
        //---------------------------------------------------------------------------------MODIFICAR-FORMULA DETALLE-------------------------------------------------------------------------------
        public OdbcDataReader modificarformuladetalle(string scodigoformula, string scodigo, string smateria, double dcantidad, string smedida, string sestado)
        {
            return sn.modificarformuladetalle(scodigoformula, scodigo, smateria, dcantidad, smedida, sestado);
        }
        //---------------------------------------------------------------------------------INSERTAR-FORMULA DETALLE-------------------------------------------------------------------------------
        public OdbcDataReader insertarformuladetalle(string scodigoformula, string scodigo, string smateria, double dcantidad, string smedida, string sestado)
        {
            return sn.insertarformuladetalle(scodigoformula, scodigo, smateria, dcantidad, smedida, sestado);
        }
        //---------------------------------------------------------------------------------ELIMINAR-FORMULA DETALLE-------------------------------------------------------------------------------
        public OdbcDataReader eliminarformuladetalle(string scodigo)
        {
            return sn.eliminarformuladetalle(scodigo);
        }
        //---------------------------------------------------------------------------------CONSULTAR-FORMULA DETALLE-------------------------------------------------------------------------------
        public OdbcDataReader consultarformuladet()
        {
            return sn.consultarformuladet();
        }
        //---------------------------------------------------------------------------------INSERTAR-ESTACION A PRODUCCION-------------------------------------------------------------------------------
        public OdbcDataReader insertarprocesoproduccion( string sproduccion, string sestacion)
        {
            return sn.insertarprocesoproduccion( sproduccion, sestacion);
        }
        //---------------------------------------------------------------------------------CONSULTAR-FORMULA DETALLE-------------------------------------------------------------------------------
        public OdbcDataReader consultarasignacion()
        {
            return sn.consultarasignacion();
        }
        //---------------------------------------------------------------------------------CONSULTAR-MATERIA PRIMA-------------------------------------------------------------------------------
        public OdbcDataReader consultarmateriaprima()
        {
            return sn.consultarmateriaprima();
        }
        //---------------------------------------------------------------------------------CONSULTAR-PRODUCTO TERMINADO-------------------------------------------------------------------------------
        public OdbcDataReader consultarproductoterminado()
        {
            return sn.consultarproductoterminado();
        }
        //---------------------------------------------------------------------------------CONSULTAR-PROCESO PRODUCCION-------------------------------------------------------------------------------
        public OdbcDataReader consultarprocesoproduccion()
        {
            return sn.consultarprocesoproduccion();
        }
        //---------------------------------------------------------------------------------INSERTAR-CONTROL CALIDAD PRODUCTO-------------------------------------------------------------------------------
        public OdbcDataReader insertarproductocontrolcalidad(string sproduccion, string sestandar, string sdescripcion,  string sestado)
        {
            return sn.insertarproductocontrolcalidad(sproduccion, sestandar, sdescripcion, sestado);
        }
        //---------------------------------------------------------------------------------CONSULTAR-PROCESO PRODUCCION-------------------------------------------------------------------------------
        public OdbcDataReader consultarproduccion()
        {
            return sn.consultarproduccion();
        }
        //--FinPaulis

    }
}
