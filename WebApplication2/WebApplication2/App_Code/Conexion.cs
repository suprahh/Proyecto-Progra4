using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Conexion
    {
        public string Conectar()
        {
            string cadena = "Data Source=DESKTOP-3DJ3N69\\DBCARLOS;Initial Catalog=Pcfastory;Integrated Security=True";
            return cadena;
        }

    }
}