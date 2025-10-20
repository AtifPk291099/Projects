<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Clogin.aspx.cs" Inherits="Clogin" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
<tr>
<td align="center" colspan="2">
<h2>Company Login</h2>

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

<tr>
<td colspan="2">
Not a member ? <a href="Cregistration.aspx">Register Now</a>    
</td>
</tr>

</table>




</asp:Content>