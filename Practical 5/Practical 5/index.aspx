<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Practical_5.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Select Leave Date</title>
</head>

<body>

    <form id="form1" runat="server">

        <h2>Select Leave Date</h2>

        <asp:Calendar
            ID="Calendar1"
            runat="server"
            OnSelectionChanged="Calendar1_SelectionChanged">
        </asp:Calendar>

        <br />

        <asp:Label
            ID="lblDate"
            runat="server">
        </asp:Label>

        <br />
        <br />

        <asp:Button
            ID="btnContinue"
            runat="server"
            Text="Continue"
            OnClick="btnContinue_Click" />

        <br />
        <br />

        <asp:Button
    ID="btnLogout"
    runat="server"
    Text="Logout"
    OnClick="btnLogout_Click" />

    </form>

</body>
</html>