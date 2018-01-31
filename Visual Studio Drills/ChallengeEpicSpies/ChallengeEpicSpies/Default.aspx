<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" MaintainScrollPositionOnPostback="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
            <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" Width="146px" />
                <br />
                <br />
                Spy New Assignment Form</h1>
            <p>
                Spy Code Name:
                <asp:TextBox ID="codenameTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                New Assignment Name:
                <asp:TextBox ID="assignmentTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                &nbsp;</p>
            <p>
                End Date of Previous Assignment:<asp:Calendar ID="Calendar1" runat="server" SelectedDate="2018-01-31"></asp:Calendar>
            </p>
            <p>
                &nbsp;</p>
            <p>
                Start Date of New Assignment:<asp:Calendar ID="Calendar2" runat="server" ></asp:Calendar>
            </p>
            <p>
                &nbsp;</p>
            <p>
                Projected End Date of New Assignment:<asp:Calendar ID="Calendar3" runat="server"></asp:Calendar>
            </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="okButton" runat="server" Font-Names="Arial" OnClick="Button1_Click" Text="Assign Spy" />
            </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Label ID="resultLabel" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
