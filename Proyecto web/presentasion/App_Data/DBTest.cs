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

    }
}