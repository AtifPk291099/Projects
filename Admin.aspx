<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<asp:Content ID="body" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <table>
<tr>
<td align="center" colspan="2">
<h2>Admin Login</h2>

</td>
</tr>


<tr>
<td>

    <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>

</td>
<td>

    <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>

</td>
</tr>

<tr>
<td>

    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>

</td>
<td>

    <asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox>

</td>
</tr>


<tr>
<td>

  

    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Login" />

  

</td>
<td>

  

    <asp:Button ID="Button2" runat="server" Text="Cancel" onclick="Button2_Click" />

  

</td>
</tr>

</table>
</asp:Content>
