using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Clases
{
    public class Producto
    {
        private string nombre;
        private string descripcion;
        private int precio;
        private int stock;
        private string foto;
        private int idCategoria;

        public Producto(string nombre, string descripcion, int precio, int stock, string foto, int idCategoria)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Stock = stock;
            this.Foto = foto;
            this.IdCategoria = idCategoria;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Foto { get => foto; set => foto = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
    }
}