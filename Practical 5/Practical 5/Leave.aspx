<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="leave.aspx.cs" Inherits="Practical_5.leave" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Leave Application</title>
</head>

<body>

    <form id="form1" runat="server">

        <h2>Leave Application</h2>

        <div>

            <label>Name</label>
            <br />

            <asp:TextBox
                ID="txtName"
                runat="server">
            </asp:TextBox>

        </div>

        <br />

        <div>

            <label>Date</label>
            <br />

            <asp:Label
                ID="lblDate"
                runat="server">
            </asp:Label>

        </div>

        <br />

        <div>

            <label>Type of Leave</label>
            <br />

            <asp:DropDownList
                ID="ddlLeaveType"
                runat="server">

                <asp:ListItem Text="-- Select Leave Type --" Value="" />
                <asp:ListItem Text="Personal Leave" Value="Personal Leave" />
                <asp:ListItem Text="On Duty Leave" Value="On Duty Leave" />
                <asp:ListItem Text="Medical Leave" Value="Medical Leave" />
                <asp:ListItem Text="Casual Leave" Value="Casual Leave" />

            </asp:DropDownList>

        </div>

        <br />

        <div>

            <label>Leave Reason</label>
            <br />

            <asp:TextBox
                ID="txtReason"
                runat="server"
                TextMode="MultiLine"
                Rows="4">
            </asp:TextBox>

        </div>

        <br />

        <div>

            <label>Work Load</label>
            <br />

            <asp:TextBox
                ID="txtWorkLoad"
                runat="server"
                TextMode="MultiLine"
                Rows="4">
            </asp:TextBox>

        </div>

        <br />

        <asp:Button
            ID="btnSubmit"
            runat="server"
            Text="Submit"
            OnClick="btnSubmit_Click" />

        <br />
        <br />

        <asp:Panel
            ID="pnlResult"
            runat="server"
            Visible="false">

            <h3>Leave Details</h3>

            <p>
                <strong>Name:</strong>
                <asp:Label
                    ID="resultName"
                    runat="server">
                </asp:Label>
            </p>

            <p>
                <strong>Date:</strong>
                <asp:Label
                    ID="resultDate"
                    runat="server">
                </asp:Label>
            </p>

            <p>
                <strong>Type of Leave:</strong>
                <asp:Label
                    ID="resultLeaveType"
                    runat="server">
                </asp:Label>
            </p>

            <p>
                <strong>Leave Reason:</strong>
                <asp:Label
                    ID="resultReason"
                    runat="server">
                </asp:Label>
            </p>

            <p>
                <strong>Work Load:</strong>
                <asp:Label
                    ID="resultWorkLoad"
                    runat="server">
                </asp:Label>
            </p>

        </asp:Panel>
        <asp:Button
    ID="btnLogout"
    runat="server"
    Text="Logout"
    OnClick="btnLogout_Click" />
    </form>

</body>
</html>