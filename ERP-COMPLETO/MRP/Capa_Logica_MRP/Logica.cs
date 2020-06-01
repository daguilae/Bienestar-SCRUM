using Capa_Datos_MRP;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica_MRP
{
    
    public class Logica
    {
        Sentencias sn = new Sentencias();

        public string siguiente(string tabla, string campo)
        {
            string llave = sn.obtenerfinal(tabla, campo);
            return llave;
        }

        public OdbcDataReader consultaayuda(string id)
        {
            return sn.consultaayudas(id);
        }

        public OdbcDataReader consultageneral(string tabla)
        {
            return sn.consultageneral(tabla);
        }

        public OdbcDataReader consultafiltro(string tabla, string campobusqueda)
        {
            return sn.consultafiltro(tabla, campobusqueda);
        }

        public OdbcDataReader consultarpedidos(string tabla, string campobusqueda)
        {
            return sn.consultafiltro(tabla, campobusqueda);
        }

        public OdbcDataReader insertarop(string codigo, string fecharealizacion, string fecgaentrega, string detalle, string estado)
        {
            return sn.insertarordendeproduccion(codigo, fecharealizacion, fecgaentrega, detalle,estado);
        }

        public OdbcDataReader insertarp(string scodigo, string sproducto, string sestado, string scodempelado, string scantidad,string sordendeproduccion)
        {
            return sn.insertarpedido(scodigo, sproducto, sestado, scodempelado, scantidad, sordendeproduccion);
        }

        public OdbcDataReader consultareporte(string sCodigo)
        {
            return sn.obtenerReporte(sCodigo);

        }
    }
}
