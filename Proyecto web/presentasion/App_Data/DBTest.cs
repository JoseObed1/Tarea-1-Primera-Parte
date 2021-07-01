using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication3.App_Data;


namespace WebApplication3
{
    public class DBTest
    {
        db_a7664c_tarea1Entities db = new db_a7664c_tarea1Entities();

        public void VisualizarDatos(string id)
        {
            Cuentas cuentas = db.Cuentas.Find(id);
            System.Diagnostics.Debug.WriteLine(cuentas.Correo.ToString());
        }
        
        public void NuevoUsuario(Cuentas datos)
        {
            /*Cuentas temporal = new Cuentas();
            temporal.Username = user;
            temporal.Password = contra;
            temporal.Compania = compania;
            temporal.Correo = correo;
            temporal.Foto = null;*/

            db.Cuentas.Add(datos);
            db.SaveChanges();
        }

        public void EditarUsuario(Cuentas elemento)
        {
            db.Entry(elemento).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void BorrarUsuario(string id)
        {
            Cuentas tempo = db.Cuentas.Find(id);
            db.Cuentas.Remove(tempo);
            db.SaveChanges();
        }

        public bool ValidarLogin(string correo, string contra)
        {
            var existe = db.Cuentas.FirstOrDefault(tempolog => tempolog.Correo == correo && tempolog.Password == contra);

            if (existe != null)
            {
                System.Diagnostics.Debug.WriteLine("X-potato!");
                return true;
            }

            else
            {
                System.Diagnostics.Debug.WriteLine("Sad Programmer Noises");
                return false;
            }
        }

    }
}