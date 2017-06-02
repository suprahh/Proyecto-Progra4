using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication2.App_Code
{
    public static class Modificar
    {
        public static bool modificarProducto(Producto p, int tipoCampo)
        {
            Conexion cadena = new Conexion();
            SqlConnection con = new SqlConnection(cadena.Conectar());
            string consulta;
            switch (tipoCampo)
            {
                case 0:
                    consulta = "Update TAB_PRODUCTO set NOM_PRO = " + p.Nombre + " where ID_PRO=" + p.Id;
                   return resModPro(con, consulta);
                 
                case 1:
                    consulta = "Update TAB_PRODUCTO set DESCRIPCION_PRO = " + p.Descripcion + " where ID_PRO=" + p.Id;
                    return resModPro(con, consulta);
                case 2:
                    consulta = "Update TAB_PRODUCTO set PRECIO_PRO = " + p.Precio + " where ID_PRO=" + p.Id;
                    return resModPro(con, consulta);
                case 3:
                    consulta = "Update TAB_PRODUCTO set STOCK_PRO = " + p.Stock + " where ID_PRO=" + p.Id;
                    return resModPro(con, consulta);
                case 4:
                    consulta = "Update TAB_PRODUCTO set FOTO_PRO = " + p.Foto+ " where ID_PRO=" + p.Id;
                    return resModPro(con, consulta);
                default:
                    return false;
            }

           
        }

        public static bool resModPro ( SqlConnection con, string consulta)
        {
            con.Open();
            SqlDataAdapter query = new SqlDataAdapter(consulta, con);
        if (query.UpdateBatchSize == 1)
            {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }
        


    }
}