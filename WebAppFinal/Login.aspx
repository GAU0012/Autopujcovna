<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebAppFinal.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            <strong><span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Přihlašení&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:Button ID="Button2" runat="server" Height="20px" Text="Back" />
            </strong>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Registerpage.aspx">Nová Registrace</asp:HyperLink>
            <br />
            <br />
            Login&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="logintxt" runat="server"></asp:TextBox>
            <br />
            <br />
            Heslo&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="heslotxt" runat="server" OnTextChanged="heslotxt_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Login" Width="110px" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
