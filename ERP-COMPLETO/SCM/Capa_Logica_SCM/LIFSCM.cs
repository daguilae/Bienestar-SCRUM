﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos_SCM;
using System.Data.Odbc;

namespace Capa_Logica_SCM
{
    public class LIFSCM
    {
        Sentencias sn1 = new Sentencias();
 
        /*-----------------------------------------------------------------------Metodos Generales------------------------------------------------------------*/
        public string siguiente(string tabla, string campo)
        {
            string llave = sn1.obtenerfinal(tabla, campo);
            return llave;
        }
        public OdbcDataReader bitacora(string sCodigo, string sip, string Smac, string susuario, string sdepartamento, string sfechahora, string saccion, string sformulario)
        {
            return sn1.insertarbitacora(sCodigo, sip, Smac, susuario, sdepartamento, sfechahora, saccion, sformulario);
        }
        public OdbcDataReader consultaayuda(string id)
        {
            return sn1.consultaayudas(id);
        }

        SIFSCM sn = new SIFSCM();
        //------------------------------------------------------------------------------------------------------CONSULTA IMPUESTO-------------------------------------------------------//

        public OdbcDataReader consultaImpuesto()
        {
            return sn.consultaImpuesto();
        }


        //------------------------------------------------------------------------------------------------------INSERTS IMPUESTO-------------------------------------------------------//
        public OdbcDataReader InsertarImpuesto(string sCodigo, string sNombre, string sTipoconcepto, string sValor)
        {
            return sn.InsertarImpuesto(sCodigo, sNombre, sTipoconcepto, sValor);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //------------------------------------------------------------------------------------------------------UPDATE IMPUESTO-------------------------------------------------------//
        public OdbcDataReader modificarImpuesto(string sCodigo, string sNombre, string sTipoconcepto, string sValor)
        {
            return sn.modificarImpuesto(sCodigo, sNombre, sTipoconcepto, sValor);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------UPDATE ELIMINAR IMPUESTO-------------------------------------------------------//
        public OdbcDataReader eliminarImpuesto(string sCodigo)
        {
            return sn.eliminarImpuesto(sCodigo);

        }
        //------------------------------------------------------------------------------------------------------CONSULTA ENCABEZADO ORDEN DE COMPRA------------------------------------------------------//

        public OdbcDataReader consultaOrdenCompraEncabezado()
        {
            return sn.consultaOrdenCompraEncabezado();
        }

        //------------------------------------------------------------------------------------------------------CONSULTA PROVEEDOR-ORDEN DE COMPRA-----------------------------------------------------//

        public OdbcDataReader consultaProveedorOrden(string sCod)
        {
            return sn.consultaProveedorOrden(sCod);
        }

        //------------------------------------------------------------------------------------------------------CONSULTA DETALLE ORDEN DE COMPRA-----------------------------------------------------//

        public OdbcDataReader consultaDetalleOrden(string sCod)
        {
            return sn.consultaDetalleOrden(sCod);
        }

        //------------------------------------------------------------------------------------------------------INGRESO ENCABEZADO FACTURA PROVEEDOR----------------------------------------------------//

        public OdbcDataReader ingresoEncabezadoFactura(string sCOD, string sCODOrden, string sCODEmpleado, string sSerie, string sFactura, string fecha, string sImpuesto, string sTotalImpuesto, string sTotal, string sDescuento)
        {
            return sn.InsertarFacturaProveedor(sCOD, sCODOrden, sCODEmpleado, sSerie, sFactura, fecha, sImpuesto, sTotalImpuesto, sTotal, sDescuento);
        }

        //------------------------------------------------------------------------------------------------------INGRESO DETALLE FACTURA PROVEEDOR----------------------------------------------------//

        public OdbcDataReader InsertarFacturaProveedorDetalle(string sCodEncabezado, string sCodProducto, string sCantidad, string sPrecioUnitario, string sSubTotal)
        {
            return sn.InsertarFacturaProveedorDetalle(sCodEncabezado, sCodProducto, sCantidad, sPrecioUnitario, sSubTotal);
        }


        //------------------------------------------------------------------------------------------------------INGRESO MOVIMIENTO GENERAL----------------------------------------------------//

        public OdbcDataReader InsertarMovimientoGeneral(string sCodProducto, string sCantidad, string sFecha, string sDocumento)
        {
            return sn.InsertarMovimientoGeneral(sCodProducto, sCantidad, sFecha, sDocumento);
        }

        //------------------------------------------------------------------------------------------------------CONSULTA IMPUESTO y EMPLEADO-------------------------------------------------------//

        public OdbcDataReader consultaempleado()
        {
            return sn.consultaempleados();
        }
        public OdbcDataReader formasdepago()
        {
            return sn.formaspago();
        }

        public OdbcDataReader productosmostrar(string sIdProveedor)
        {
            return sn.mostrarproductos(sIdProveedor);

        }
        public OdbcDataReader impuestos()
        {
            return sn.sumaimpustos();

        }

        public OdbcDataReader insertarencabezado(string pkencabezado, string codproveedor, string formapago, string fechapedido, string fecharequerida, string codempleado, string observaciones, string impuesto, string total, string descuento)

        {
            return sn.InsertarEncabezadoOrdenCompra(pkencabezado, codproveedor, formapago, fechapedido, fecharequerida, codempleado, observaciones, impuesto, total, descuento)
        ;

        }

        public OdbcDataReader insertardetalle(string codigo, string producto, string cantidad, string total)

        {
            return sn.InsertardetallerdenCompra(codigo, producto, cantidad, total)
        ;

        }
        public OdbcDataReader codorden()

        {
            return sn.ordencod();

        }

        public OdbcDataReader facturas()

        {
            return sn.consultafac()
        ;

        }

        public OdbcDataReader detalle(string sCodfactura)

        {
            return sn.consultadetallefactura(sCodfactura)
        ;

        }

        public OdbcDataReader dev(string pkcodigodev, string pkidEncabezadoFacturaP, string pkcodigoempleado, string fkIdOrdenCompra, string numerofactura, string total, string motivo)


        {
            return sn.Insertardevolucion(pkcodigodev, pkidEncabezadoFacturaP, pkcodigoempleado, fkIdOrdenCompra, numerofactura, total, motivo)

        ;

        }

        public OdbcDataReader movi(string pkidProducto, string concepto, string documento, string cantidad, string fecha)


        {
            return sn.movimientogenerarl(pkidProducto, concepto, documento, cantidad, fecha)

        ;

        }



    }
}
