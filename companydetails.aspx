<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="companydetails.aspx.cs" Inherits="companydetails" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table>
<tr>
<td>
Job Profile
</td>
<td>

    <asp:TextBox ID="txtprofile" runat="server"></asp:TextBox>

</td>
</tr>
<tr>
<td>
Salary
    Range</td>
<td>

    <asp:TextBox ID="txtsal1" runat="server" Width="82px"></asp:TextBox>
    -<asp:TextBox ID="txtsal2" runat="server" Width="92px"></asp:TextBox>

</td>
</tr>



<tr>
<td>

</td>
<td>

    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Search" />

</td>
</tr>



<tr>
<td colspan="2">
    <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" 
        BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" 
        GridLines="None">
        <FooterStyle BackColor="Tan" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
            HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
    </asp:GridView>
    </td>
</tr>

</table>

</asp:Content> 