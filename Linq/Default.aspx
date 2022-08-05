<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Linq._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div>
        <b>Demo Pages:</b>
        <li><a href="how%20to%20add%20a%20LINQ%20to%20SQL%20Item%20to%20the%20Project.aspx">
            how to add a LINQ to SQL Item to the Project(create Linq in c#)</a> </li>
        <li><a href="Creating%20a%20New%20Table.aspx">Creating a New Table using linq in c#</a>
        </li>
        <li><a href="Insert_data.aspx">Insert data</a></li>
        <li><a href="Select%20query.aspx">Select query</a> </li>
        <li><a href="select%20with%20where.aspx">select with where</a> </li>
        <li><a href="Select%20with%20Stored%20procedure.aspx">Select with Stored procedure</a>
        </li>
        <li><a href="Contains_exp_just_like_like_operator_in_sql.aspx">Contains or just like
            like in sql server</a> </li>
        <li><a href="EndsWith_keyword.aspx">EndsWith keyword</a> </li>
        <li><a href="StartsWith_keyword.aspx">StartsWith keyword</a> </li>
        <br />
        <br />
        <b>References sites:</b>
        <br />
        <li>
            <asp:HyperLink ID="HyperLink1" Target="_blank" NavigateUrl="http://www.wikihow.com/Use-LINQ-to-SQL-in-C-Sharp"
                runat="server">Use-LINQ-to-SQL-in-C-Sharp</asp:HyperLink>
        </li>
        <li>
            <asp:HyperLink ID="HyperLink2" Target="_blank" NavigateUrl="http://www.aspsnippets.com/Articles/Simple-Tutorial-with-example-of-using-LINQ-to-SQL-in-ASPNet-Website-using-C-and-VBNet.aspx"
                runat="server">Simple stored procedure in linq</asp:HyperLink>
        </li>
        <li>
            <asp:HyperLink ID="HyperLink3" Target="_blank" NavigateUrl="http://www.c-sharpcorner.com/uploadfile/dbd951/how-to-use-taketakewhile-and-skipskipwhile-in-linq/"
                runat="server">How to Use Take/TakeWhile and Skip/SkipWhile in LINQ</asp:HyperLink>
        </li>
        <li>
            <asp:HyperLink ID="HyperLink4" Target="_blank" NavigateUrl=" http://www.technicaloverload.com/linq-single-vs-singleordefault-vs-first-vs-firstordefault/"
                runat="server">LINQ Single vs SingleOrDefault vs First vs FirstOrDefault</asp:HyperLink>
        </li>
       
    </div>
</asp:Content>
