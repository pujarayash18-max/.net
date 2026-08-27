<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Practical_5.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Login</title>
</head>

<body>

<form id="form1" runat="server">

    <h2>Login</h2>

    <label>User ID:</label>
    <br />

    <asp:TextBox
        ID="txtUserId"
        runat="server">
    </asp:TextBox>

    <br />
    <br />

    <label>Password:</label>
    <br />

    <asp:TextBox
        ID="txtPassword"
        runat="server"
        TextMode="Password">
    </asp:TextBox>

    <br />
    <br />

    <asp:CheckBox
        ID="chkRemember"
        runat="server"
        Text=" Remember Me" />

    <br />
    <br />

    <asp:Button
        ID="btnLogin"
        runat="server"
        Text="Login"
        OnClick="btnLogin_Click" />

    <br />
    <br />

    <asp:Label
        ID="lblMessage"
        runat="server">
    </asp:Label>

</form>

</body>
</html>