<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ASP_MASTER_PAGE.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Mi página de contacto.</h3>
    <address>
        Marqués de San Esteban<br />
        Xixón, Spain<br />
        <abbr title="Phone">Tlfno:</abbr>
        425.555.0100</address>
    <div>
        <img alt="marketing" longdesc="el marketing es uno de los objetivo de nuestra empresa" src="file:///C:/Users/AsataTarde/Desktop/inesmallada/curso_net/ASP_MASTER_PAGE/ASP_MASTER_PAGE/img/marketing.jpg" style="width: 296px; height: 170px" />
    </div>
    <div>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@nacho.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@ine.com</a>
    </div>
</asp:Content>
