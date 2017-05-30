using System;
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
            string consulta = "insert into TAB_USUARIOS(RUT, NOMBRE_USER, EMAIL_USER, USERNAME, PASSWORD, TIPO_USER ) values (" +
                                                                                                                                user.Rut + ",'" +
                                                                                                                                user.Nombre + "','" +
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
            string consulta = "insert into TAB_PRODUCTO (NOM_PRO, DESCRIPCION_PRO, PRECIO_PRO, STOCK_PRO, FOTO_PRO, ID_CAT) values ('" + p.Nombre + "','" +
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

        public static Producto  BproductoId (int id)
        {
            Conexion cadena = new Conexion();
            SqlConnection con = new SqlConnection(cadena.Conectar());
            con.Open();
            string consulta = "select * from TAB_PRODUCTO where ID_PRO=" + id;
            SqlDataAdapter conCadena = new SqlDataAdapter(consulta, con);
            DataTable tabla = new DataTable();
            conCadena.Fill(tabla);
            
                Producto p = new Producto();
                foreach (DataRow row in tabla.Rows)
                {
                    p.Nombre =(string) row[0];
                    p.Descripcion = (string)row[1];
                    p.Precio = (int)row[2];
                    p.Stock = (int)row[3];
                    p.Foto = (string)row[4];
                    p.IdCategoria = (int)row[5];
                   
                }
            return p;
           } 

      

    }
}