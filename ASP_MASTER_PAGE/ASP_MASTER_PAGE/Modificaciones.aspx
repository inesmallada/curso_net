<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Modificaciones.aspx.cs" Inherits="ASP_MASTER_PAGE.Bajas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <div>
        <h2>Modificación de clientes</h2>
        <div>
            <label>Id:</label>
            <asp:DropDownList ID="ddlID" runat="server" DataSourceID="SqlDataSource1" DataTextField="id" DataValueField="id">
            </asp:DropDownList> 
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SimulacroSQLMartesConnectionString %>" SelectCommand="SELECT * FROM [Cliente]"></asp:SqlDataSource>
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
            <asp:Button ID="btnModi" runat="server" Text="Modificar" OnClick="btnModi_Click" />
        </div>
    </div>
     <div>
            <asp:Label ID="txtError2" runat="server" Text=""></asp:Label>
     </div>

</asp:Content>
