using CapaDatos_ERP;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica_ERP
{
    public class Logica
    {

        Sentencias sn = new Sentencias();
        public bool LoginUser(string user, string pass)
        {
            return sn.consultarusuario(user, pass);
        }
    }
}
