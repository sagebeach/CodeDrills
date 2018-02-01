<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl="~/epic-spies-logo.jpg" Width="115px" />
                <br />
                <br />
                Asset Performance Tracker</h1>
            <p>
                Asset Name:
                <asp:TextBox ID="assetNameTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                Elections Rigged:
                <asp:TextBox ID="electionsTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                Acts of Subterfuge Performed:
                <asp:TextBox ID="subterfugeTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Add Asset" />
            </p>
            <p>
                <asp:Label ID="resultLabel" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
