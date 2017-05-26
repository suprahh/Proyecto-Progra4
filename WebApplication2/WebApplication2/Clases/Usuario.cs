using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Clases
{
    public class Usuario
    {
        private int rut;
        private string Nombre;
        private string mail;
        private string username;
        private string password;
        private bool privilegio;

        public Usuario(int rut, string nombre, string mail, string username, string password, bool privilegio)
        {
            this.Rut = rut;
            Nombre1 = nombre;
            this.Mail = mail;
            this.Username = username;
            this.Password = password;
            this.Privilegio = privilegio;
        }

        public int Rut { get => rut; set => rut = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public bool Privilegio { get => privilegio; set => privilegio = value; }
    }
}