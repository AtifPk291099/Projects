<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="addvacancy.aspx.cs" Inherits="addvacancy" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table>
<tr>
<td>
Company Id
</td>
<td>

    <asp:TextBox ID="txtcompanyid" runat="server"></asp:TextBox>

</td>

</tr>
<tr>
<td>

    Job Profile</td>
<td>

    <asp:TextBox ID="txtjobprofile" runat="server"></asp:TextBox>

</td>

</tr>
<tr>
<td>

    Salary</td>
<td>

    <asp:TextBox ID="txtsal" runat="server"></asp:TextBox>

</td>

</tr>

<tr>
<td>

    Eligibility Criteria</td>
<td>

    <asp:TextBox ID="txtdetails" runat="server" TextMode="MultiLine"></asp:TextBox>

</td>

</tr>

<tr>
<td>

    Bond<br />
    (leave blank if no bond)</td>
<td>

    <asp:TextBox ID="txtbond" runat="server" TextMode="MultiLine"></asp:TextBox>

</td>

</tr>

<tr>
<td>

    Email</td>
<td>

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

</td>
</tr>

<tr>
<td>

</td>
<td>

    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Post" />

</td>

</tr>

</table>

</asp:Content>