<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="True" CodeBehind="~/Forms/MantenedorProductos.aspx.cs" Inherits="WebApplication2.Forms.MantenedorProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 277px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCuadroLogin" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table style="width: 100%;">
        <tr>
            <td class="auto-style1"> <asp:Button ID="ButtonAgregarProducto" runat="server" Text="Agregar Producto" OnClick="ButtonAgregarProducto_Click" /> </td>
            <td class="auto-style2"> <asp:Button ID="ButtonBUscarProducto" runat="server" Text="Buscar Producto" /></td>
        </tr>
          <tr>
              <td class="auto-style1"> <asp:Panel ID="PanelAgregarProducto" Visible="false" runat="server">
                  <asp:Label ID="Label1" runat="server" Text="Nombre : "></asp:Label>
                  <asp:TextBox ID="TextBoxNombreProducto" runat="server"></asp:TextBox><br />
                  <asp:Label ID="Label2" runat="server" Text="Descripcion : "></asp:Label>
                  <asp:TextBox ID="TextBoxDescripcion" runat="server" Height="50px" TextMode="MultiLine" Width="175px"></asp:TextBox><br />
                  <asp:Label ID="Label3" runat="server" Text="Precio : "></asp:Label>
                  <asp:TextBox ID="TextBoxPrecio" runat="server"></asp:TextBox><br />
                  <asp:Label ID="Label4" runat="server" Text="Stock : "></asp:Label>
                  <asp:TextBox ID="TextBoxStock" runat="server"></asp:TextBox><br />
                  <asp:Label ID="Label5" runat="server" Text="Foto : "></asp:Label>
                  <asp:FileUpload ID="FileUploadFoto" runat="server" /><br />
                  <asp:Label ID="Label6" runat="server" Text="Categoria : "></asp:Label>
                  <asp:DropDownList ID="DropDownListCategoria" runat="server"></asp:DropDownList><br />
                  <asp:Button ID="ButtonInsertProducto" runat="server" Text="Agregar"  Width="117px" />

                   </asp:Panel> 
              </table>
</asp:Content>
