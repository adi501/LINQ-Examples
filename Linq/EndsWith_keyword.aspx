<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="EndsWith_keyword.aspx.cs" Inherits="Linq.EndsWith_keyword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <center>
        <table>
            <tr>
                <td>
                    <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btn_search" runat="server" Text="Search" OnClick="btn_search_Click" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="gv1" runat="server">
        </asp:GridView>
    </center>
</asp:Content>
