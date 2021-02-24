<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TestApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <span> test 2 </span>

        <br />

        <asp:Label ID="Label1" runat="server" Text="test 3">test 3</asp:Label>

        <br />

        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        <br />

        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

        <br />

        <asp:Button ID="Button1" runat="server" Text="+" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="-" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="*" OnClick="Button3_Click" />
        <asp:Button ID="Button4" runat="server" Text="/" OnClick="Button4_Click" />

        <br />

        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

        <br />

        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="textChange">
            <asp:ListItem>Choix1</asp:ListItem>
            <asp:ListItem>Choix2</asp:ListItem>
            <asp:ListItem>Choix3</asp:ListItem>
        </asp:DropDownList>

        <br />

        <asp:Label ID="Label2" runat="server">ville</asp:Label>

    </form>
</body>
</html>
