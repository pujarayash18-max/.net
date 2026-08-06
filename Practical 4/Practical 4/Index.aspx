<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Practical_4.Index" UnobtrusiveValidationMode="None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Event Registration</title>
</head>
<body>

<form id="form1" runat="server">

    <h2>Online Event Registration</h2>

    <asp:Image ID="Image1" runat="server" ImageUrl="~/images/logo.jpeg" />

    <hr />

    <table>

        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Student Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtStudentName" runat="server"></asp:TextBox>
            </td>
             <td>
                 <asp:RequiredFieldValidator ID="rfvName" runat="server"
                    ControlToValidate="txtStudentName"
                    ErrorMessage="Studen Name is Required"
                    ForeColor="Red" Text="*" />
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="GR Number"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEnrollment" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator
                    ID="rfvGR"
                    runat="server"
                    ControlToValidate="txtEnrollment"
                    ErrorMessage="GR Number is required"
                    ForeColor="Red" />
                    <br/>
                <asp:RegularExpressionValidator
                    ID="revGR"
                    runat="server"
                    ControlToValidate="txtEnrollment"
                    ValidationExpression="^\d{6}$"
                    ErrorMessage="GR Number must be exactly 6 digits"
                    ForeColor="Red" />
                </td>
        </tr>
        
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Age"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RangeValidator
                    ID="RangeValidator2"
                    runat="server"
                    ControlToValidate="TextBox1"
                    Type="Integer"
                    MinimumValue="18"
                    MaximumValue="40"
                    ErrorMessage="Age must be between 18 and 40"
                    ForeColor="Red" />
            </td>
        </tr>
        
        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator
                    ID="rfvPassword"
                    runat="server"
                    ControlToValidate="TextBox2"
                    ErrorMessage="Password is required"
                    ForeColor="Red" />
            </td>
        </tr>
        
        <tr>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Confirm Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator
                    ID="rfvConfirmPassword"
                    runat="server"
                    ControlToValidate="TextBox3"
                    ErrorMessage="Confirm Password is required"
                    ForeColor="Red" />

                    <br />

                <asp:CompareValidator
                    ID="CompareValidator1"
                    runat="server"
                    ControlToValidate="TextBox3"
                    ControlToCompare="TextBox2"
                    ErrorMessage="Passwords do not match"
                    ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator
                    ID="rfvEmail"
                    runat="server"
                    ControlToValidate="txtEmail"
                    ErrorMessage="Email is required"
                    ForeColor="Red" />

                <br />

                <asp:RegularExpressionValidator

                    ID="revEmail"
                    runat="server"
                    ControlToValidate="txtEmail"
                    ValidationExpression="^\w+([-.']\w+)*@\w+([-.]\w+)*\.\w{2,4}$"
                    ErrorMessage="Enter a valid email address"
                    ForeColor="Red" />
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Mobile Number"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator
                    ID="rfvMobile"
                    runat="server"
                    ControlToValidate="txtMobile"
                    ErrorMessage="Mobile Number is required"
                    ForeColor="Red" />

                <br />

                <asp:RegularExpressionValidator
                    ID="revMobile"
                    runat="server"
                    ControlToValidate="txtMobile"
                    ValidationExpression="^[6-9]\d{9}$"
                    ErrorMessage="Enter a valid 10-digit mobile number"
                    ForeColor="Red" />
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Department"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlDepartment" runat="server">
                    <asp:ListItem Value="">--Select Department--</asp:ListItem>
                    <asp:ListItem Value="CE">CE</asp:ListItem>
                    <asp:ListItem Value="EC">EC</asp:ListItem>
                    <asp:ListItem Value="ICT">ICT</asp:ListItem>
                    <asp:ListItem Value="AI">AI</asp:ListItem>
                </asp:DropDownList>

            </td>
            <td>
                <asp:RequiredFieldValidator
                    ID="rfvDepartment"
                    runat="server"
                    ControlToValidate="ddlDepartment"
                    InitialValue=""
                    ErrorMessage="Select Department"
                    ForeColor="Red" />
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Gender"></asp:Label>
            </td>
            <td>
                <asp:RadioButtonList ID="rblGender" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                <asp:RequiredFieldValidator
                    ID="rfvGender"
                    runat="server"
                    ControlToValidate="rblGender"
                    ErrorMessage="Select Gender"
                    ForeColor="Red" />
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Select Event"></asp:Label>
            </td>
            <td>
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Coding Competition" /><br />
                <asp:CheckBox ID="CheckBox2" runat="server" Text="Poster Presentation" /><br />
                <asp:CheckBox ID="CheckBox3" runat="server" Text="Project Expo" />
            </td>
            <td>
                <asp:CustomValidator
                    ID="cvEvent"
                    runat="server"
                    ErrorMessage="Select at least one event"
                    ForeColor="Red"
                    OnServerValidate="cvEvent_ServerValidate" />
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Select Date"></asp:Label>
            </td>
            <td>
                <asp:Calendar ID="Calendar1" runat="server"
                    OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            </td>
            <td>
                <asp:CustomValidator
                    ID="cvDate"
                    runat="server"
                    ErrorMessage="Please select a date"
                    ForeColor="Red"
                    OnServerValidate="cvDate_ServerValidate" />
            </td>
        </tr>

        
        <tr>
    <td colspan="3" align="center">
        <asp:Button ID="Button1" runat="server"
            Text="Submit"
            OnClick="btnSubmit_Click" />

        &nbsp;&nbsp;

        <asp:Button ID="btnClear" runat="server"
            Text="Clear"
            CausesValidation="false"
            OnClick="btnClear_Click" />
    </td>
</tr>
    </table>

    <hr />

    <asp:Panel ID="pnlResult" runat="server" Visible="false">

    <h3>Entered Details</h3>

    <table border="1" cellpadding="5">

        <tr>
            <td><b>Student Name</b></td>
            <td><asp:Label ID="lblStudentName" runat="server"></asp:Label></td>
        </tr>

        <tr>
            <td><b>GR Number</b></td>
            <td><asp:Label ID="lblEnrollment" runat="server"></asp:Label></td>
        </tr>

        <tr>
            <td><b>Age</b></td>
            <td><asp:Label ID="lblAge" runat="server"></asp:Label></td>
        </tr>

        <tr>
            <td><b>Password</b></td>
            <td><asp:Label ID="lblPassword" runat="server"></asp:Label></td>
        </tr>

        <tr>
            <td><b>Confirm Password</b></td>
            <td><asp:Label ID="lblConfirmPassword" runat="server"></asp:Label></td>
        </tr>

        <tr>
            <td><b>Email</b></td>
            <td><asp:Label ID="lblEmail" runat="server"></asp:Label></td>
        </tr>

        <tr>
            <td><b>Mobile Number</b></td>
            <td><asp:Label ID="lblMobile" runat="server"></asp:Label></td>
        </tr>

        <tr>
            <td><b>Department</b></td>
            <td><asp:Label ID="lblDepartment" runat="server"></asp:Label></td>
        </tr>

        <tr>
            <td><b>Gender</b></td>
            <td><asp:Label ID="lblGender" runat="server"></asp:Label></td>
        </tr>

        <tr>
            <td><b>Selected Event</b></td>
            <td><asp:Label ID="lblEvent" runat="server"></asp:Label></td>
        </tr>

        <tr>
            <td><b>Selected Date</b></td>
            <td><asp:Label ID="lblDate" runat="server"></asp:Label></td>
        </tr>

    </table>

</asp:Panel>

</form>

</body>
</html>