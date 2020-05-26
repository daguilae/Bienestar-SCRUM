using Capa_Datos_MRP;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica_MRP
{
    public class LFCMRP
    {
        SCFMRP sn = new SCFMRP();

        public string siguiente(string tabla, string campo)
        {
            string llave = sn.obtenerfinal(tabla, campo);
            return llave;
        }

        public OdbcDataReader bitacora(string sCodigo, string sip, string Smac, string susuario, string sdepartamento, string sfechahora, string saccion, string sformulario)
        {
            return sn.insertarbitacora(sCodigo, sip, Smac, susuario, sdepartamento, sfechahora, saccion, sformulario);
        }

        public OdbcDataReader consultaayuda(string id)
        {
            return sn.consultaayudas(id);
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

        public OdbcDataReader ConsultaHoraExtra()
        {
            return sn.consultarHoraExtra();
        }

        public OdbcDataReader ConsultaCuentasContables()
        {
            return sn.consultarCuentasContables();
        }

        public OdbcDataReader Insertarencabezado(string pkidpolizaencabezado_MRP, string fecha_inicio, string fecha_fin, string Descripcion)
        {
            return sn.Insertarencabezado(pkidpolizaencabezado_MRP, fecha_inicio, fecha_fin, Descripcion);
        }

        public OdbcDataReader Insertardetalle(string pkidpolizaencabezado_MRP, int pkcodigocuenta, string debe, string haber)
        {
            return sn.Insertardetalle(pkidpolizaencabezado_MRP, pkcodigocuenta, debe, haber);
        }

        public OdbcDataReader sueldobase()
        {
            return sn.mostrarsueldo();
        }

        public OdbcDataReader horasextras()
        {
            return sn.mostrarhoras();
        }

        public OdbcDataReader mostrarcuenta()
        {
            return sn.mostrarcuentas();
        }

        public OdbcDataReader materiaprima()
        {
            return sn.totalmateria();
        }
        public OdbcDataReader gastosextras()
        {
            return sn.totalgastos();
        }

        public OdbcDataReader iguales(string numero)
        {
            return sn.sumasiguales(numero);
        }

        public OdbcDataReader cuentascontables(string gasto)
        {
            return sn.suministros(gasto);
        }
        public OdbcDataReader updatecuenta(string codigo, string nombre, string monto)
        {
            return sn.actualizarcuenta(codigo, nombre, monto);
        }

        public OdbcDataReader newcuenta(string codigo, string nombre, string monto)
        {
            return sn.nuevacuenta(codigo, nombre, monto);
        }
    }
}
