<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Creating a New Table.aspx.cs" Inherits="Linq.Creating_a_New_Table" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <center>
        <asp:Button ID="btn_1" runat="server" Text="Create Table" OnClick="btn_1_Click" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Create Table With Identity" 
            onclick="Button1_Click"  />
    </center>
</asp:Content>
