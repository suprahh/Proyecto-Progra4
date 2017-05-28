using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2.Forms
{
    public partial class MantenedorProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAgregarProducto_Click(object sender, EventArgs e)
        {
            PanelAgregarProducto.Visible = true; ;
        }
    }
}