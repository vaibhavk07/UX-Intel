<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="HTMLAnalyze.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
        <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3/jquery.min.js" ></script>
    <script type="text/javascript" >

        //var functionAfterLoad = function () {
        //    // finding username 
        //    var goodthings = ""
        //    var badthings = ""
        //    var maxlength = ''
        //    var txtUserName = $('#addwebpage').find("[type=text]");
        //    if (txtUserName.length == 1) {
        //        var maxlength = txtUserName.attr('maxlength');
        //        goodthings = "<b>USERNAME</b>"
        //        badthings = "<b>USERNAME</b>"
        //        if (maxlength != '') {
        //            goodthings = goodthings + "</br>" + "User Name Has Maxlength =" + maxlength;
        //        }
        //        else {
        //            badthings = badthings + "</br>" + "User Name MUST HAVE Maxlength";
        //        }
        //        var tabindex = txtUserName.attr('tabindex');
        //        if (tabindex != '') {
        //            goodthings = goodthings + "</br>" + "User Name Has tabindex =" + tabindex;
        //        }
        //        else {
        //            badthings = badthings + "</br>" + "User Name MUST HAVE tabindex";
        //        }
        //        var placeholder = txtUserName.attr('placeholder');
        //        if (placeholder != '') {
        //            goodthings = goodthings + "</br>" + "User Name Has placeholder =" + placeholder;
        //        }
        //        else {
        //            badthings = badthings + "</br>" + "User Name MUST HAVE placeholder";
        //        }
        //    }
        //    else {
        //        // we need to write some custom logic while parsing global sites 
        //    }
        //    // finding password 
        //    var txtPassword = $('#addwebpage').find("[type=password]");
        //    if (txtPassword.length == 1) {
        //        var maxlength = txtPassword.attr('maxlength');
        //        goodthings = goodthings + "<br/><b>Password</b>"
        //        badthings = badthings + "</br><b>Password</b>"
        //        if (maxlength != '') {
        //            goodthings = goodthings + "</br>" + "Password Has Maxlength =" + maxlength;
        //        }
        //        else {
        //            badthings = badthings + "</br>" + "Password MUST HAVE Maxlength";
        //        }
        //        var tabindex = txtPassword.attr('tabindex');
        //        if (tabindex != '') {
        //            goodthings = goodthings + "</br>" + "Password Has tabindex =" + tabindex;
        //        }
        //        else {
        //            badthings = badthings + "</br>" + "Password MUST HAVE tabindex";
        //        }
        //        var placeholder = txtPassword.attr('placeholder');
        //        if (placeholder != '') {
        //            goodthings = goodthings + "</br>" + "Password Has placeholder =" + placeholder;
        //        }
        //        else {
        //            badthings = badthings + "</br>" + "Password MUST HAVE placeholder";
        //        }
        //    }
        //    else {
        //        // we need to write some custom logic while parsing global sites 
        //    }
        //    // finding remember be checkbox 
        //    var chkremeberme = $('#addwebpage').find("[type=chekbox]");
        //    if (chkremeberme.length == 1) {
        //    }
        //    else {
        //    }
        //    // finding Sign In Button
        //    var btnSignIN = $("#addwebpage").find("[type=submit]");
        //    $("#goodThings").html(goodthings);
        //    $("#badThings").html(badthings);
        //}
    </script>
</head>
<body>
    <form id="adddynamicwebform93y73nu38soso82hen" runat="server">
    <div>
         <asp:Label Id="lblurl" runat="server" Text="URL : "></asp:Label>
    <asp:TextBox ID="txturl" runat="server"></asp:TextBox>
        <asp:Button ID="btnparser" runat="server" Text="Know your HTML" OnClick="btnparser_Click"/>
        
        <input type="button" value="lets Analyze" id="BTNanalyze" runat="server" visible="false"  onclick="functionAfterLoad()" />
        
        <table width="100%"><tr>
            <td width="50%">
                <div id="goodThings">                 
                </div>
            </td>
            <td width="50%">
                <div id="badThings">
                </div>
            </td>
               </tr></table>
        <br />

        <div id="addwebpage" runat="server"></div>
        <div id="addstyle" runat="server"></div>
         <div id="addlink" runat="server"></div>
        <div id="addscript" runat="server"></div>
        </div>
    </form>
</body>
</html>