<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Borrar.aspx.cs" Inherits="ASP_MASTER_PAGE.Borrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

  <div>
        <h2>Bajas de clientes</h2>
        <div>
            <label>Introduce el Id a eliminar </label>
            <asp:DropDownList ID="ddlID2" runat="server" DataSourceID="SqlDataSource1" DataTextField="id" DataValueField="id">
            </asp:DropDownList> 
            <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click" />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SimulacroSQLMartesConnectionString %>" SelectCommand="SELECT * FROM [Cliente]"></asp:SqlDataSource>
         </div>
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar." Height="171px" Width="490px">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                    <asp:BoundField DataField="apellido1" HeaderText="apellido1" SortExpression="apellido1" />
                    <asp:BoundField DataField="apellido2" HeaderText="apellido2" SortExpression="apellido2" />
                    <asp:BoundField DataField="ciudad" HeaderText="ciudad" SortExpression="ciudad" />
                    <asp:BoundField DataField="categoria" HeaderText="categoria" SortExpression="categoria" />
                </Columns>
            </asp:GridView>
        </div>
       <div>
            <asp:Label ID="txtError3" runat="server" Text=""></asp:Label>
        </div>

    </div>


</asp:Content>
