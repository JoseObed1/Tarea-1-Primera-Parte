using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.App_Data;


namespace WebApplication3
{
    public class DBTest
    {
        public void VisualizarDatos(string id)
        {
            Tarea1Entities db = new Tarea1Entities();

            Cuentas cuentas = db.Cuentas.Find(id);
            System.Diagnostics.Debug.WriteLine(cuentas.Correo.ToString());
        }
        /*
        public void NuevoUsuario(string user, string contra)
        {
            Login TempoLog = new Login();
            TempoLog.Username = user;
            TempoLog.Password = contra;

            ejecutor.NuevoUsuario(TempoLog);
        }

        public void EditarUsuario(Login elemento)
        {
            ejecutor.EditarUsuario(elemento);
        }

        public void BorrarUsuario(string id)
        {
            ejecutor.BorrarUsuario(id);
        }

        public bool ValidarLogin(string user, string contra)
        {
            Login TempoLog = new Login();
            TempoLog.Username = user;
            TempoLog.Password = contra;

            if (ejecutor.ValidarLogin(TempoLog) == true)
            {
                System.Diagnostics.Debug.WriteLine("Expotato!");
                return true;
            }

            else
            {
                System.Diagnostics.Debug.WriteLine("Sad Programmer Noises");
                return false;
            }
        }*/

    }
}