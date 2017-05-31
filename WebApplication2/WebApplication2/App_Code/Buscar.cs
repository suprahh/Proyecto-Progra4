using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace WebApplication2.Clases
{
    public static class Buscar
    {
        public static bool AgregarUsuario(Usuario user)
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
            if (conCadena.ExecuteNonQuery() == 1)
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

        public static bool AgregarProducto(Producto p)
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
            if (conCadena.ExecuteNonQuery() == 1)
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

        public static Producto BproductoId(int id)
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

                p.Nombre = (string)row[1];
                p.Descripcion = (string)row[2];
                p.Precio = (int)row[3];
                p.Stock = (int)row[4];
                p.Foto = (string)row[5];
                p.IdCategoria = (int)row[6];

            }
            return p;
        }

        public static List<Producto> BproductoNombre(string nombre)
        {
            List<Producto> productos = new List<Producto>();
            Conexion cadena = new Conexion();
            SqlConnection con = new SqlConnection(cadena.Conectar());
            con.Open();
            string consulta = "select * from TAB_PRODUCTO where NOM_PRO like '%" + nombre + "%'";
            SqlDataAdapter conCadena = new SqlDataAdapter(consulta, con);
            DataTable tabla = new DataTable();
            conCadena.Fill(tabla);

            Producto p = new Producto();

            foreach (DataRow row in tabla.Rows)
            {
                p.Id = (int)row[0];
                p.Nombre = (string)row[1];
                p.Descripcion = (string)row[2];
                p.Precio = (int)row[3];
                p.Stock = (int)row[4];
                p.Foto = (string)row[5];
                p.IdCategoria = (int)row[6];
                productos.Add(p);
            }
            return productos;
        }

        public static List<Producto> BproductoPrecio(int precio)
        {
            List<Producto> productos = new List<Producto>();
            Conexion cadena = new Conexion();
            SqlConnection con = new SqlConnection(cadena.Conectar());
            con.Open();
            string consulta = "select * from TAB_PRODUCTO where PRECIO_PRO = " + precio;
            SqlDataAdapter conCadena = new SqlDataAdapter(consulta, con);
            DataTable tabla = new DataTable();
            conCadena.Fill(tabla);

            Producto p = new Producto();

            foreach (DataRow row in tabla.Rows)
            {
                p.Id = (int)row[0];
                p.Nombre = (string)row[1];
                p.Descripcion = (string)row[2];
                p.Precio = (int)row[3];
                p.Stock = (int)row[4];
                p.Foto = (string)row[5];
                p.IdCategoria = (int)row[6];
                productos.Add(p);
            }
            return productos;
         }
        public static List<Producto> BproductoCategoria(string categoria)
        {
            List<Producto> productos = new List<Producto>();
            Conexion cadena = new Conexion();
            SqlConnection con = new SqlConnection(cadena.Conectar());
            con.Open();
            string consulta = "select * from TAB_PRODUCTO where ID_CAT = " + categoria;
            SqlDataAdapter conCadena = new SqlDataAdapter(consulta, con);
            DataTable tabla = new DataTable();
            conCadena.Fill(tabla);

            Producto p = new Producto();

            foreach (DataRow row in tabla.Rows)
            {
                p.Id = (int)row[0];
                p.Nombre = (string)row[1];
                p.Descripcion = (string)row[2];
                p.Precio = (int)row[3];
                p.Stock = (int)row[4];
                p.Foto = (string)row[5];
                p.IdCategoria = (int)row[6];
                productos.Add(p);
            }
            return productos;
        }
    }
}