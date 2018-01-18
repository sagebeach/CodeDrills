<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Simple_Calculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .fontstyle {
            font-family: Arial, Helvetica, sans-serif;
        }
        .resultLabelStyle {
            background-color: #008080;
            font-weight: 700;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="fontstyle">
            <h1>Simple Calculator</h1>
            <br />
            First Value: <asp:TextBox ID="value1TextBox" runat="server" Width="90px"></asp:TextBox>
            <br />
            Second Value:
            <asp:TextBox ID="value2TextBox" runat="server" Width="90px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="additionButton" runat="server" OnClick="additionButton_Click" Text="+" />
&nbsp;<asp:Button ID="subtractionButton" runat="server" Text="-" OnClick="subtractionButton_Click" />
&nbsp;<asp:Button ID="multiplicationButton" runat="server" Text="*" Width="16px" OnClick="multiplicationButton_Click" />
&nbsp;<asp:Button ID="divisionButton" runat="server" Text="/" OnClick="divisionButton_Click" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server" CssClass="resultLabelStyle"></asp:Label>
        </div>
    </form>
</body>
</html>
