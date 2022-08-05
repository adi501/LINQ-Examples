<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Insert_data.aspx.cs" Inherits="Linq.Insert_data" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <center>
        <table>
            <tr>
                <td>
                    Name:
                </td>
                <td>
                    <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <asp:Button ID="btn_submit" runat="server" Text="Submit" 
                        onclick="btn_submit_Click" />
                </td>
            </tr>
        </table>
    </center>
</asp:Content>
