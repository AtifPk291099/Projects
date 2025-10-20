<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Cregistration.aspx.cs" Inherits="Cregistration" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table>
<tr>
<td>Company Name
</td>
<td>
    <asp:TextBox ID="txtcname"  required="" runat="server"></asp:TextBox>
</td>
<td>
</td>
</tr>

<tr>
<td>Established
</td>
<td>
    <asp:TextBox ID="txtestablished"   required="" runat="server"></asp:TextBox>
</td>
<td>
</td>
</tr>


<tr>
<td>Email
</td>
<td>
    <asp:TextBox ID="txtemail"  required="" runat="server"></asp:TextBox>
</td>
<td>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ControlToValidate="txtemail" ErrorMessage="Invalid Email" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
</td>
</tr>

<tr>
<td>Contact
</td>
<td>
    <asp:TextBox ID="txtcontact"  required="" runat="server"></asp:TextBox>
</td>
<td>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
        ErrorMessage="Enter Valid Contact" ValidationExpression="[0-9]{10}" 
        ControlToValidate="txtcontact"></asp:RegularExpressionValidator>
</td>
</tr>

<tr>
<td>HR Name
</td>
<td>
    <asp:TextBox ID="txthrname" runat="server"></asp:TextBox>
</td>
<td>
</td>
</tr>

<tr>
<td>Your Id
</td>
<td>
   
    <asp:TextBox ID="txtuid" runat="server" Enabled="False"></asp:TextBox>
   
</td>
<td>
</td>
</tr>

<tr>
<td>Username
</td>
<td>
    <asp:TextBox ID="txtuname" runat="server"></asp:TextBox>
</td>
<td>
</td>
</tr>

<tr>
<td>Password
</td>
<td>
    <asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox>
</td>
<td>
</td>
</tr>

<tr>
<td>
</td>
<td>
    <asp:Button ID="Post" runat="server" onclick="Post_Click" Text="Register" />
</td>
<td>
</td>
</tr>

</table>

</asp:Content>