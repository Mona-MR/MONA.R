<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="MONA.R.Form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Move" OnClick="Button1_Click" />
            <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <hr>
        <asp:Button ID="Button2" runat="server" Text="Quary Button" OnClick="Button2_Click" />
        <asp:Label ID="Label1" runat="server" Text="Quary String"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
