using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.App_Code;


namespace WebApplication2
{
    public partial class MantenedorUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBoxIdb.Visible = false;
            TextBoxRutb.Visible = false;
            TextBoxNombreb.Visible = false;
            TextBoxEmailb.Visible = false;
            TextBoxUserb.Visible = false;
        }

        protected void ButtonAgregarUsuario_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Rut = int.Parse(TextBoxRut.Text);
            user.Nombre = TextBoxNombre.Text;
            user.Mail = TextBoxMail.Text;
            user.Username = TextBoxUser.Text;
            user.Password = TextBoxContraseña.Text;
            user.Privilegio = false;
            if (Agregar.AgregarUsuario(user))
            {
                this.Page.Response.Write("<script language='JavaScript'>window.alert('se agrego correctamente');</script>");
            }
            else this.Page.Response.Write("<script language='JavaScript'>window.alert('error al ingresar producto');</script>");

        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            PanelBuscarUsuario.Visible = true;
            PanelAgregarusuario.Visible = false;
        }

        protected void ButtonBuscarUsuario_Click(object sender, EventArgs e)
        {

        }

        protected void RadioButtonId_CheckedChanged(object sender, EventArgs e)
        {

            List<bool> eleccion = new List<bool>();
            eleccion.Add(RadioButtonId.Checked);
            eleccion.Add(RadioButtonRut.Checked);
            eleccion.Add(RadioButtonNombre.Checked);
            eleccion.Add(RadioButtonEmail.Checked);
            eleccion.Add(RadioButtonUser.Checked);
            int puntero = 0;

            foreach (var radioSelect in eleccion)
            {
                if (radioSelect == true)
                {
                    break;
                }
                puntero++;
            }

            switch (puntero)
            {
                case 0:
                    TextBoxIdb.Visible = true;
                    break;
                case 1:
                    TextBoxRutb.Visible = true;
                    break;
                case 2:
                    TextBoxNombreb.Visible = true;
                    break;
                case 3:
                    TextBoxEmailb.Visible = true;
                    break;
                case 4:
                    TextBoxUserb.Visible = true;
                    break;
                default:
                    break;
            }
        }

        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
            PanelAgregarusuario.Visible = true;
            PanelBuscarUsuario.Visible = false;
        }
    }
}