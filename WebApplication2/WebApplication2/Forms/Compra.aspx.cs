﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.App_Code;

namespace WebApplication2.Forms
{
    public partial class Compra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"]!=null)
            {
                Usuario user = (Usuario) Session["user"];
                LabelBienvenida.Text = "bienvenido " + user.Nombre;
            }
            else
            {
                Response.Redirect("~/Forms/Principal.aspx");
            }
            if (Session["carrito"]!=null)
            {
                List<Producto> carrito = new List<Producto>();
              carrito = (List<Producto>)Session["carrito"];
                GridViewCarrito.DataSource = carrito;
                GridViewCarrito.DataBind();
            }
            
        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Forms/Principal.aspx");
        }
    }
}