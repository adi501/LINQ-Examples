<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reading_XML_using_LINQ.aspx.cs" Inherits="Linq.Reading_XML_using_LINQ" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    Country:
    <asp:DropDownList ID="ddl_Country" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddl_Country_SelectedIndexChanged"></asp:DropDownList><br />
    City:
    <asp:DropDownList ID="ddl_City" runat="server"></asp:DropDownList><br />
</asp:Content>
