<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user-form.aspx.cs" Inherits="WebApplication1.user_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Customer Registration"></asp:Label>
        <br />
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="tbName" runat="server" Width="226px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="tbEmail" runat="server" Width="226px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Zipcode"></asp:Label>
            <asp:TextBox ID="tbZipcode" runat="server" Width="209px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="tbUsername" runat="server" Width="194px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="tbPassword" TextMode="Password" runat="server" Width="192px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="btnAdd_Click" />
        </div>
            
    </form>

    </body>
</html>
