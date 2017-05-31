using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Clases;
using System.Data;
using System.Data.SqlClient;

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
                PanelMostrarProducto.Visible = false;
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
                this.Page.Response.Write("<script language='JavaScript'>window.alert('se agrego correctamente');</script>");
            }
            else
            {
                this.Page.Response.Write("<script language='JavaScript'>window.alert('error al ingresar producto');</script>");
            }

        }

        protected void ButtonBuscarP_Click(object sender, EventArgs e)
        {
            List<Producto> productos = new List<Producto>();
            switch (int.Parse(DropDownListInfoProducto.SelectedValue))
            {
             
               case 1:
                    PanelProductoDataList.Visible = true;
                    PanelProductoEncontrado.Visible = false;
                    GridViewProductosEncontrados.DataSource = Datos.BproductoNombre(TextBoxBusquedaP.Text);
                    GridViewProductosEncontrados.DataBind();
                    break;
                case 2:

                    PanelProductoDataList.Visible = false;
                    PanelProductoEncontrado.Visible = true;
                   
                    Producto p = Datos.BproductoId(int.Parse(TextBoxBusquedaP.Text));

                    productos.Add(p);
                    DetailsViewProducto.DataSource= productos;
                    DetailsViewProducto.DataBind();
                    break;
                case 3:
                    PanelProductoDataList.Visible = true;
                    PanelProductoEncontrado.Visible = false;
                    GridViewProductosEncontrados.DataSource = Datos.BproductoPrecio(int.Parse(TextBoxBusquedaP.Text));
                    GridViewProductosEncontrados.DataBind();
                    break;
                

                default:
                    this.Page.Response.Write("<script language='JavaScript'>window.alert('selecciona una categoria para buscar');</script>");
                    break;
            }  
        }
    }
}