<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="StudentDetails.aspx.cs" Inherits="StudentDetails" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table>
<tr>
<td>

    SSC Aggregate</td>
<td>

    <asp:TextBox ID="txtssc" runat="server"></asp:TextBox>

</td>
</tr>

<tr>
<td>

    Junior College Aggregate</td>
<td>

    <asp:TextBox ID="txthsc" runat="server"></asp:TextBox>

</td>
</tr>

<tr>
<td>

    College Aggregate</td>
<td>

    <asp:TextBox ID="txtcoll" runat="server"></asp:TextBox>

</td>
</tr>

<tr>
<td>

    Department</td>
<td>

    <asp:DropDownList ID="ddldept" runat="server">
          <asp:ListItem>Arts</asp:ListItem>
        <asp:ListItem>BTech</asp:ListItem>
        <asp:ListItem>BA</asp:ListItem>
        <asp:ListItem>BSC IT</asp:ListItem>
        <asp:ListItem>BSC CS</asp:ListItem>
        <asp:ListItem>BCA</asp:ListItem>
        <asp:ListItem>BCOM</asp:ListItem>
        
    </asp:DropDownList>

</td>
</tr>
<tr>
<td>

   </td>
<td>

   

    <asp:Button ID="Button1" runat="server" Text="Search" onclick="Button1_Click" />

   

</td>
</tr>
<tr>
<td colspan="2">


    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" 
        onrowcommand="GridView1_RowCommand">
    <Columns>
    
    
        
<asp:BoundField DataField="s_fname" HeaderText="First Name" SortExpression="firstname" />

<asp:BoundField DataField="s_lname" HeaderText="Last Name" SortExpression="lastname" />

<asp:BoundField DataField="s_age" HeaderText="Age" SortExpression="Age" />

<asp:BoundField DataField="s_gender" HeaderText="Gender" SortExpression="Gender" />
<asp:BoundField DataField="s_Email" HeaderText="Email" SortExpression="Email" />

<asp:BoundField DataField="s_contact" HeaderText="Contact" SortExpression="Contact" />
<asp:BoundField DataField="s_seen" HeaderText="Last Seen" SortExpression="Last Seen" />

      <asp:TemplateField HeaderText ="Resume">
         <ItemTemplate>

        <asp:LinkButton ID="click" runat ="server" CommandArgument='<%#Eval("s_resume")%>' Text ="Resume" CommandName ="click" ></asp:LinkButton>
      </ItemTemplate>
    </asp:TemplateField>
</Columns>
    </asp:GridView>


    <br />
    <asp:Panel ID="Panel1" runat="server" Height="195px" Visible="False">
        <br />
        <asp:Label ID="Label4" runat="server" Text="Mail To :-"></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Body  :-"></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Height="56px" TextMode="MultiLine" 
            Width="267px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Send" />
    </asp:Panel>
    <br />


</td>
</tr>

</table>

</asp:Content>