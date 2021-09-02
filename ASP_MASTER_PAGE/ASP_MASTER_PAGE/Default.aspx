<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP_MASTER_PAGE._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Lorem Ipsum</h1>
        <p class="lead">Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit... No hay nadie que ame el dolor mismo, que lo busque, lo encuentre y lo quiera, simplemente porque es el dolor."</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Leer más &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Panel de Comerciantes</h2>
            <p>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource2" EmptyDataText="No hay registros de datos para mostrar." Height="218px" Width="300px">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                        <asp:BoundField DataField="apellido1" HeaderText="apellido1" SortExpression="apellido1" />
                        <asp:BoundField DataField="apellido2" HeaderText="apellido2" SortExpression="apellido2" />
                        <asp:BoundField DataField="ciudad" HeaderText="ciudad" SortExpression="ciudad" />
                        <asp:BoundField DataField="comision" HeaderText="comision" SortExpression="comision" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:SimulacroSQLMartesConnectionString %>" SelectCommand="SELECT * FROM [Comercial]"></asp:SqlDataSource>
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Panel de Clientes</h2>
            <p>
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource3" EmptyDataText="No hay registros de datos para mostrar." Height="198px" Width="282px">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                        <asp:BoundField DataField="apellido1" HeaderText="apellido1" SortExpression="apellido1" />
                        <asp:BoundField DataField="apellido2" HeaderText="apellido2" SortExpression="apellido2" />
                        <asp:BoundField DataField="ciudad" HeaderText="ciudad" SortExpression="ciudad" />
                        <asp:BoundField DataField="categoria" HeaderText="categoria" SortExpression="categoria" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:SimulacroSQLMartesConnectionString %>" SelectCommand="SELECT * FROM [Cliente]"></asp:SqlDataSource>
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Panel de Pedidos</h2>
            <p>
                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource4" EmptyDataText="No hay registros de datos para mostrar." Height="247px" Width="284px">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="cantidad" HeaderText="cantidad" SortExpression="cantidad" />
                        <asp:BoundField DataField="fecha" HeaderText="fecha" SortExpression="fecha" />
                        <asp:BoundField DataField="id_cliente" HeaderText="id_cliente" SortExpression="id_cliente" />
                        <asp:BoundField DataField="id_comercial" HeaderText="id_comercial" SortExpression="id_comercial" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:SimulacroSQLMartesConnectionString %>" SelectCommand="SELECT * FROM [Pedido]"></asp:SqlDataSource>
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
