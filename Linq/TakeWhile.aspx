<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TakeWhile.aspx.cs" Inherits="Linq.TakeWhile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <center>
        This sample TakeWhile to return rows starting from the beginning of the table until a number is hit that is not less than some rows(103).
        <asp:GridView ID="gv1" runat="server">
        </asp:GridView>
    </center>
</asp:Content>
