using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Clases;

namespace WebApplication2.Forms
{
    public partial class MantenedorProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ButtonAgregarProducto_Click(object sender, EventArgs e)
        {
            PanelAgregarProducto.Visible = true;
            PanelMostrarProducto.Visible = false;
        }

        protected void DropDownListInfoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListInfoProducto.SelectedValue!="nada")
            {
            BusquedaProducto.Visible = true;
            LabelTipoPro.Text = "buscardo por "+ DropDownListInfoProducto.SelectedValue.ToString()+" : ";
            }
            else
            {
                BusquedaProducto.Visible = false;
            }
            
        }

        protected void ButtonBUscarProducto_Click(object sender, EventArgs e)
        {
            PanelMostrarProducto.Visible = true;
            PanelAgregarProducto.Visible = false;
        }

        protected void ButtonInsertProducto_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.Nombre=TextBoxNombreProducto.Text;
            p.Descripcion = TextBoxDescripcion.Text;
            p.Precio = int.Parse(TextBoxPrecio.Text);
            p.Stock = int.Parse(TextBoxStock.Text);
            p.Foto = "~/FotoArticulos/" + FileUploadFoto.FileName;
            FileUploadFoto.SaveAs(Server.MapPath("~/FotoArticulos/" + FileUploadFoto.FileName));
            p.IdCategoria=int.Parse(DropDownListCategoria.SelectedValue);
            if (Datos.AgregarProducto(p))
            {
                LabelRespuestaAgregar.Text = "agregado exitosamente";
            }
            else
            {
                LabelRespuestaAgregar.Text = "un error al agregar producto";
            }

        }
    }
}