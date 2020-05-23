using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace CapaDatos_ERP
{
    public class Sentencias
    {

        Conexion cn = new Conexion();
        public bool consultarusuario(string usr, string pass)
        {

            try
            { 
                OdbcCommand command = new OdbcCommand("SELECT usuario.*,CONCAT(guardar, modificar,eliminar,consultar) AS nivel FROM usuario INNER JOIN tipo_usuario  ON usuario.pktipousuario=tipo_usuario.pktipousuario WHERE nombreusuario='"+usr+"' AND passusuario='"+pass+"'; ", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.GetString(2)!=null)
                {                  
                    return true;
                }
                else
                {
                    return false;
                }
                                
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return false;
            }
        }

        public string recoverPassword(string usr)
        {

            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM usuario WHERE nombreusuario = '" + usr + "';", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();                
                if (reader.GetString(2) != null)
                {
                    string userName = reader.GetString(2);
                    string userMail = reader.GetString(5);
                    string accountPassword = reader.GetString(3);
                    var mail = new mail.SystemSupportMail();
                    Console.WriteLine(userMail);
                    mail.sendMail(
                      subject: "SYSTEM: Password recovery request",
                      body: "Hi, " + userName + "\nYou Requested to Recover your password.\n" +
                      "your current password is: " + accountPassword +
                      "\nHowever, we ask that you change your password inmediately once you enter the system.",
                      recipientMail: new List<string> { userMail }
                      );
                    return "Hi, " + userName + "\nYou Requested to Recover your password.\n" +
                      "Please check your mail: " + userMail +
                      "\nHowever, we ask that you change your password inmediately once you enter the system.";
                }
                else
                    return "Sorry, you do not have an account with that mail or username";            

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return "Sorry, you do not have an account with that mail or username";
            }
        }
    }
}
