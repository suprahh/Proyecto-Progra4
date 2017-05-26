﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace WebApplication2.Clases
{
    public static class Datos
    {
        public static bool AgregarUsuario (Usuario user)
        {
            Conexion cadena = new Conexion();
            SqlConnection con = new SqlConnection(cadena.Conectar());
            con.Open();
            int privilegio = user.Privilegio == true ? 1 : 0;
            string consulta = "insert into TBL_USUARIOS(RUT, NOMBRE_USER, EMAIL_USER, USERNAME, PASSWORD, TIPO_USER ) values (" +
                                                                                                                                user.Rut + ",'" +
                                                                                                                                user.Nombre1 + "','" +
                                                                                                                                user.Mail + "','" +
                                                                                                                                user.Username + "','" +
                                                                                                                                user.Password + "'," +
                                                                                                                                privilegio + ")";
            SqlCommand conCadena = new SqlCommand(consulta, con);
            if (conCadena.ExecuteNonQuery()==1)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }

        public static bool AgregarProducto (Producto p)
        {
            Conexion cadena = new Conexion();
            SqlConnection con = new SqlConnection(cadena.Conectar());
            con.Open();
            string consulta = "insert into TBL_PRODUCTO (NOM_PRO, DESCRIPCION_PRO, PRECIO_PRO, STOCK_PRO, FOTO_PRO, ID_CAT) value ('" + p.Nombre + "','" +
                                                                                                                                      p.Descripcion + "'," +
                                                                                                                                      p.Precio + "," +
                                                                                                                                      p.Stock + ",'" +
                                                                                                                                      p.Foto + "'," +
                                                                                                                                      p.IdCategoria + ")";
            SqlCommand conCadena = new SqlCommand(consulta, con);
            if (conCadena.ExecuteNonQuery()==1)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
           
            }

        }

      

    }
}