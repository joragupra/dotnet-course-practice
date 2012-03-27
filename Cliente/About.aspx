<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="About.aspx.cs" Inherits="Cliente.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        About
    </h2>
    <p>
        <asp:Button ID="objButton" runat="server" onclick="CargarClientesLondres" 
            Text="Cargar clientes de Londres!" />
    </p>
    <p>
        <asp:GridView ID="objGridView" runat="server">
        </asp:GridView>
    </p>
</asp:Content>
