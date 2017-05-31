<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="True" CodeBehind="~/Forms/MantenedorProductos.aspx.cs" Inherits="WebApplication2.Forms.MantenedorProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 277px;
        }
        .auto-style2 {
            margin-left: 0px;
        }
        .auto-style3 {
            width: 241px;
            margin-left: 0px;
        }
        .auto-style4 {
            width: 241px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCuadroLogin" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table style="width: 100%;">
        <tr>
            <td class="auto-style1"> <asp:Button ID="ButtonAgregarProducto" runat="server" Text="Agregar Producto" OnClick="ButtonAgregarProducto_Click" /> </td>
            <td class="auto-style3"> <asp:Button ID="ButtonBUscarProducto" runat="server" Text="Buscar Producto" OnClick="ButtonBUscarProducto_Click" /></td>
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
                  <asp:DropDownList ID="DropDownListCategoria" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="NOM_CAT" DataValueField="ID_CAT"></asp:DropDownList>
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PcfastoryConnectionString %>" SelectCommand="SELECT * FROM [TAB_CATEGORIA]"></asp:SqlDataSource>
                  <br />
                  <asp:Button ID="ButtonInsertProducto" runat="server" Text="Agregar"  Width="117px" OnClick="ButtonInsertProducto_Click" /><br />
                  <asp:Label ID="LabelRespuestaAgregar" runat="server" Text=""></asp:Label>

                   </asp:Panel> 
                  </td>
              <td class="auto-style4">
                  <asp:Panel ID="PanelMostrarProducto" Visible="false" runat="server">
                      <asp:Label ID="Label7" runat="server" Text="Buscar por : "></asp:Label>
                      <asp:DropDownList ID="DropDownListInfoProducto" runat="server" OnSelectedIndexChanged="DropDownListInfoProducto_SelectedIndexChanged" AutoPostBack="True">
                          <asp:ListItem Value="0">Selecciona una Opcion</asp:ListItem>
                          <asp:ListItem Value="1">Nombre</asp:ListItem>
                          <asp:ListItem Value="2">Codigo</asp:ListItem>
                          <asp:ListItem Value="3">Precio</asp:ListItem>

                      </asp:DropDownList>

                  </asp:Panel>
              </td>
              <td> 
                  <asp:Panel ID="BusquedaProducto" runat="server" Visible="false" CssClass="auto-style2">
                      <asp:Label ID="LabelTipoPro" runat="server" Text="Orden a dar : "></asp:Label> <asp:TextBox ID="TextBoxBusquedaP" runat="server"></asp:TextBox> <br />
                      <asp:Button ID="ButtonBuscarP" runat="server" Text="Button" Width="211px" OnClick="ButtonBuscarP_Click" /><br />
                      <asp:Label ID="LabelverNombre" runat="server" Text="aqui vemos si busco el producto"></asp:Label> <br />
                      <asp:Panel ID="PanelProductoDataList" Visible="false" runat="server">
                          <asp:GridView ID="GridViewProductosEncontrados" runat="server">

                          </asp:GridView>
                          <asp:DetailsView ID="DetailsViewProducto" runat="server" Height="50px" Width="125px" AutoGenerateRows="False"  >
                          
                             
                         
                          
                             
                              <Fields>
                                  <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                                  <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                                  <asp:BoundField DataField="Precio" HeaderText="Precio" />
                                  <asp:BoundField DataField="Stock" HeaderText="Stock" />
                                  <asp:TemplateField HeaderText="Foto">
                                      <ItemTemplate>
                                          <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("Foto") %>' />
                                      </ItemTemplate>
                                  </asp:TemplateField>
                                  <asp:BoundField DataField="IdCategoria" HeaderText="Id Categoria" />
                              </Fields>
                          
                             
                         
                          
                             
                          </asp:DetailsView>
                      </asp:Panel>

                  </asp:Panel>
              </td>
              </table>
</asp:Content>
