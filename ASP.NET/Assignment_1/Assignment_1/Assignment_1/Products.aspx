﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Assignment1_ASP.Products" %>
 
<!DOCTYPE html>
 
 
<head runat="server">
<title></title>
</head>
<body>
<form id="form1" runat="server">
<div>
</div>
Product:
<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
<asp:ListItem Value="0">select a product</asp:ListItem>
<asp:ListItem Value="1">Product A</asp:ListItem>
<asp:ListItem Value="2">Product B</asp:ListItem>
<asp:ListItem Value="3">Product C</asp:ListItem>
</asp:DropDownList>
<p>
<asp:Image ID="Image1" runat="server" Height="200px" Width="200px" />
</p>
<asp:Button ID="Button1" runat="server" Text="Show Price" OnClick="Button1_Click" />
<p>
<asp:Label ID="Label1" runat="server" ForeColor="#00CC00" Text="Price will be displayed"></asp:Label>
</p>
</form>
</body>
</html>
