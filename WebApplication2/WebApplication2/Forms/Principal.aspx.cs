using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.App_Code;


namespace WebApplication2.Forms
{
    public partial class Principal : System.Web.UI.Page
    {
        private static int contador = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonIngresar_Click(object sender, EventArgs e)
        {
            string user = TextBoxUsuario.Text;
            string contraseña = TextBoxContraseña.Text;
            if (Buscar.BuscarUsuario(user, contraseña)==true)
            {
                contador = 0;
                Session["user"] = user;
                PanelBienvenida.Visible = true;
                PanelLogin.Visible = false;

                LabelBienvenido.Text = "Bienvenido " + user + " ";
            }
            else
            {
               
                contador++;
                this.Page.Response.Write("<script language='JavaScript'>window.alert('Error en usuario o contraseña');</script>");
            }
        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
           
            PanelLogin.Visible = true;
            Session.Abandon();
        }
    }
}