<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page3.aspx.cs" Inherits="MONA.R.Page3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="FirstNme">
            </asp:Label>  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <hr />
            <asp:Label ID="Label2" runat="server" Text="LastName">
            </asp:Label>  <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <hr />
            <asp:Button ID="Button1" runat="server" Text="Set" OnClick="Button1_Click" /> 
            <asp:Button ID="Button2" runat="server" Text="Restore" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
