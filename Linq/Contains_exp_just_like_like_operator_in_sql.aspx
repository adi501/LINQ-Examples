<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Contains_exp_just_like_like_operator_in_sql.aspx.cs" Inherits="Linq.Contains_exp_just_like_like_operator_in_sql" %>

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
                    <asp:Button ID="btn_search" runat="server" Text="Search" 
                        onclick="btn_search_Click" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="gv1" runat="server">
        </asp:GridView>
    </center>
</asp:Content>
