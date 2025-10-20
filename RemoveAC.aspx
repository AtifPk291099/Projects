<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RemoveAC.aspx.cs" Inherits="RemoveAC" %>

<asp:Content ID="Body" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div>

    <br />
    <asp:Label ID="Label4" runat="server" Font-Size="X-Large" Font-Underline="True" 
        Text="Check Student"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Student ID  :-"></asp:Label>
&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Search" />
    <br />
    <br />
    <asp:Panel ID="Panel1" runat="server" Height="208px" Visible="False">
        <br />
        <asp:Label ID="Label6" runat="server" Text="Name  :-"></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Mobile No  :-"></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        &nbsp;<asp:Label ID="Label8" runat="server" Text="Email :-"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Remove" />
&nbsp;
        <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="Clear" 
            Width="72px" />
    </asp:Panel>

</div>
</asp:Content>