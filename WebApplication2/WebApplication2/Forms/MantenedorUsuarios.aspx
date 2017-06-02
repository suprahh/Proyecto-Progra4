<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MantenedorUsuarios.aspx.cs" Inherits="WebApplication2.MantenedorUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCuadroLogin" runat="server">
   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="labelregistro">
    <div>
         <asp:Button ID="ButtonAgregar"  runat="server" Text="Agregar Usuario" OnClick="ButtonAgregar_Click" />
     </div>
    
    <div>
         <asp:Panel Visible="false" ID="PanelAgregarusuario" runat="server">
        <div>  
            <asp:Label ID="Label1" runat="server" Text="Rut : "></asp:Label>
            <asp:TextBox ID="TextBoxRut" runat="server"></asp:TextBox>
        </div>
        <div>  
            <asp:Label ID="Label2" runat="server" Text="Nombre :"></asp:Label>
            <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
        </div>
        <div>  
            <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TextBoxMail" runat="server"></asp:TextBox>
        </div>
        <div>  
            <asp:Label ID="Label4" runat="server" Text="Usuario :"></asp:Label>
            <asp:TextBox ID="TextBoxUser" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Contraseña :"></asp:Label>
            <asp:TextBox ID="TextBoxContraseña" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="ButtonAgregarUsuario" runat="server" Text="Agregar" OnClick="ButtonAgregarUsuario_Click" />
        </div>
      </asp:Panel>
    </div>
  </div>  
    <div>
        <div>
            <asp:Button ID="ButtonBuscar" runat="server" Text="Buscar Usuario" OnClick="ButtonBuscar_Click" />
        </div>
        <div class="labelregistro">
            <asp:Panel ID="PanelBuscarUsuario" Visible="false" runat="server">
                <div>
                    <asp:RadioButton GroupName="BuscarUsuario" ID="RadioButtonId" Text="ID :" AutoPostBack="true" OnCheckedChanged="RadioButtonId_CheckedChanged" runat="server" />
                    <asp:TextBox ID="TextBoxIdb" Visible="false" runat="server"></asp:TextBox>
                </div>
                 <div>
                    <asp:RadioButton GroupName="BuscarUsuario" ID="RadioButtonRut" Text="Rut :" AutoPostBack="true" OnCheckedChanged="RadioButtonId_CheckedChanged"  runat="server" />
                    <asp:TextBox ID="TextBoxRutb" Visible="false" runat="server"></asp:TextBox>
                </div>
                 <div>
                    <asp:RadioButton GroupName="BuscarUsuario" ID="RadioButtonNombre" Text="Nombre :" AutoPostBack="true" OnCheckedChanged="RadioButtonId_CheckedChanged" runat="server" />
                    <asp:TextBox ID="TextBoxNombreb" Visible="false" runat="server"></asp:TextBox>
                </div>
                 <div>
                    <asp:RadioButton GroupName="BuscarUsuario" ID="RadioButtonEmail" Text="Email :" AutoPostBack="true" OnCheckedChanged="RadioButtonId_CheckedChanged" runat="server" />
                    <asp:TextBox ID="TextBoxEmailb" Visible="false" runat="server"></asp:TextBox>
                </div>
                 <div>
                    <asp:RadioButton GroupName="BuscarUsuario" ID="RadioButtonUser" Text="User :" AutoPostBack="true" OnCheckedChanged="RadioButtonId_CheckedChanged" runat="server" />
                    <asp:TextBox ID="TextBoxUserb" Visible="false" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Button ID="ButtonBuscarUsuario" runat="server" Text="Button" />
                </div>
            </asp:Panel>
        </div>
    </div>
</asp:Content>
