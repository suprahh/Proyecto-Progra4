﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace WebApplication2.App_Code
{
    public static class Buscar
    {
       
        public static bool BuscarUsuario (string user, string contraseña)
        {
            Conexion cadena = new Conexion();
            SqlConnection con = new SqlConnection(cadena.Conectar());
            con.Open();
            string consulta = "select * from TAB_USUARIOS where USERNAME = '" + user + "' and PASSWORD = '" + contraseña + "'";
            SqlDataAdapter conCadena = new SqlDataAdapter(consulta, con);
            
            if ( conCadena.UpdateBatchSize== 1)
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
            con.Close();
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
            con.Close();
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
            con.Close();
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
            con.Close();
            return productos;
        }
    }
}