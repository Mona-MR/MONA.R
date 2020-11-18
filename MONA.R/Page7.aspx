<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page7.aspx.cs" Inherits="MONA.R.Page7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create Cookie" />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <hr />
        <asp:Button ID="Button2" runat="server" Text="Retrieve Cookie" OnClick="Button2_Click" />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Wait To Change After 1 Minute"></asp:Label>
        </p>
            </div>
    </form>
</body>
</html>
