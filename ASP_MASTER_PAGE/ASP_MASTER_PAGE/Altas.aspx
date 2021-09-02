﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Altas.aspx.cs" Inherits="ASP_MASTER_PAGE.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2>Altas de clientes</h2>
        <div>
            <label>Id:</label>
            <asp:TextBox ID="txtID" runat="server" Width="245px"></asp:TextBox>
        </div>
        <div>
            <label>Nombre: </label>
            <asp:TextBox ID="txtNombre" runat="server" Width="245px"></asp:TextBox>
        </div>
        <div>
            <label>Apellido 1: </label>
            <asp:TextBox ID="txtApe1" runat="server" Width="245px"></asp:TextBox>
        </div>
        <div>
            <label>Apellido 2:</label>
            <asp:TextBox ID="txtApe2" runat="server" Width="245px"></asp:TextBox>
        </div>
        <div>
            <label>Ciudad: </label>
            <asp:TextBox ID="txtCiudad" runat="server" Width="245px"></asp:TextBox>
        </div>
        <div>
            <label>Categoría:</label>
            <asp:TextBox ID="txtCategoria" runat="server" Width="245px"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="btnAnadir" runat="server" Text="Añadir" OnClick="btnAnadir_Click" />
        </div>
        <div>
            <asp:Label ID="txtError" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
