<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="HTMLAnalyze.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:Label Id="lblurl" runat="server" Text="URL : "></asp:Label>
    <asp:TextBox ID="txturl" runat="server"></asp:TextBox>
        <asp:Button ID="btnparser" runat="server" Text="Know your HTML" OnClick="btnparser_Click"/>
        <%--<asp:TextBox ID="txtResponse" runat="server"></asp:TextBox>--%>
        <br />
        <textarea rows="4" cols="50" id="txtResponse" runat="server">
        </textarea>
    </div>
    </form>
</body>
</html>
