<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"  CodeFile="Register.aspx.cs" Inherits="_Default" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <table>
<tr>
<td colspan="2">
<h2>Job Seeker Register</h2>
</td>
</tr>

<tr>
<td colspan="2">
All fields marked * are compulsary
</td>
</tr>

<tr>
<td>
First Name
</td>
<td>

    <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>

    *<asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
        runat="server" ControlToValidate="txtfname" 
        ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z]+$">Enter 
    valid name</asp:RegularExpressionValidator>

</td>
</tr>

<tr>
<td>
Middle Name
</td>
<td>

    <asp:TextBox ID="txtmname" runat="server"></asp:TextBox>

    *<asp:RegularExpressionValidator ID="RegularExpressionValidator2" 
        runat="server" ControlToValidate="txtmname" 
        ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z]+$">Enter 
    valid name</asp:RegularExpressionValidator>

</td>
</tr>

<tr>
<td>
Last Name
</td>
<td>

    <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>

    *<asp:RegularExpressionValidator ID="RegularExpressionValidator3" 
        runat="server" ControlToValidate="txtlname" 
        ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z]+$">Enter 
    valid name</asp:RegularExpressionValidator>

</td>
</tr>

<tr>
<td>

    <asp:Label ID="Label2" runat="server" Text="Gender"></asp:Label>

</td>
<td>

    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:DropDownList>

</td>
</tr>

<tr>
<td>
Email
</td>
<td>

    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>

    *<asp:RegularExpressionValidator ID="RegularExpressionValidator4" 
        runat="server" ErrorMessage="RegularExpressionValidator" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
        ControlToValidate="txtemail">Enter Valid Email</asp:RegularExpressionValidator>

</td>
</tr>

<tr>
<td>
Contact No
</td>
<td>

    <asp:TextBox ID="txtcontact" MaxLength="10" runat="server"></asp:TextBox>

    *<asp:RegularExpressionValidator ID="RegularExpressionValidator5" 
        runat="server" ErrorMessage="RegularExpressionValidator" 
        ValidationExpression="^[7-9][0-9]{9}$" ControlToValidate="txtcontact">Enter Valid Contact
    </asp:RegularExpressionValidator>

</td>
</tr>

<tr>
<td>
City
</td>
<td>

    <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>

</td>
</tr>

<tr>
<td>
Address
</td>
<td>

    <asp:TextBox ID="txtaddress" runat="server" TextMode="MultiLine"></asp:TextBox>

</td>
</tr>
<tr>
<td>Photo</td>
<td>
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <br />
    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Upload" />
    <br />
    <asp:Image ID="Image1"  ImageUrl="images\\default.png" runat="server" Height="100px" Width="150px" />
                                                </td>
</tr>


<tr>
<td>
    Dob</td>
<td>

    <asp:TextBox ID="txtdob" runat="server" ></asp:TextBox>

</td>
</tr>
<tr>
<td>
Age</td>
<td>

    <asp:TextBox ID="txtage" min="18" type="number" runat="server" ></asp:TextBox>

</td>
</tr>
<tr>
<td>
    School</td>
<td>

    <asp:TextBox ID="txtschool" runat="server" ></asp:TextBox>

</td>
</tr>
<tr>
<td>
    Year of Passing</td>
<td>

    <asp:TextBox ID="txtsyearofpass" runat="server" ></asp:TextBox>

</td>
</tr>
<tr>
<td>
    University</td>
<td>

    <asp:TextBox ID="txtsuniversity" runat="server" ></asp:TextBox>

</td>
</tr>
<tr>
<td>
Percentage</td>
<td>

    <asp:TextBox ID="txtsaggregate" runat="server" ></asp:TextBox>

</td>
</tr>

<tr>
<td>
    Junior College</td>
<td>

    <asp:TextBox ID="txthsc" runat="server" ></asp:TextBox>

</td>
</tr>
<tr>
<td>
    Year of Passing</td>
<td>

    <asp:TextBox ID="txthyearofpass" runat="server" ></asp:TextBox>

</td>
</tr>
<tr>
<td>
    University</td>
<td>

    <asp:TextBox ID="txthuniversity" runat="server" ></asp:TextBox>

</td>
</tr>
<tr>
<td>
Percentage</td>
<td>

    <asp:TextBox ID="txthaggregate" runat="server" ></asp:TextBox>

</td>
</tr>

<tr>
<td>
    College</td>
<td>

    <asp:TextBox ID="txtcoll" runat="server" ></asp:TextBox>

</td>
</tr>
<tr>
<td>
    Year of Passing</td>
<td>

    <asp:TextBox ID="txtcyearofpass" runat="server" ></asp:TextBox>

</td>
</tr>
<tr>
<td>
    University</td>
<td>

    <asp:TextBox ID="txtcuniversity" runat="server" ></asp:TextBox>

</td>
</tr>
<tr>
<td>
Percentage</td>
<td>

    <asp:TextBox ID="txtcaggregate" runat="server" ></asp:TextBox>

</td>
</tr>
<tr>
<td>
Department</td>
<td>

    

    <asp:DropDownList ID="ddldepartment" runat="server">
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
    Extra Cirriculars</td>
<td>

    <asp:TextBox ID="txtextracirr" runat="server" ></asp:TextBox>

</td>
<tr>
<td>
    Other Qualifications</td>
<td>

    <asp:TextBox ID="txtotherqualification" runat="server" ></asp:TextBox>

</td>
</tr>



<tr>
<td>
    Username</td>
<td>

    <asp:TextBox ID="txtusername" runat="server" 
        ontextchanged="txtusername_TextChanged"></asp:TextBox>

    *<asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Check" />
    <asp:Label ID="lblusername" runat="server" ForeColor="#3333CC"></asp:Label>
    </td>
</tr>


<tr>
<td>
    Password</td>
<td>

    <asp:TextBox ID="txtpassword" runat="server" Enabled="False" 
        TextMode="Password"></asp:TextBox>

    *</td>
</tr>

<tr>
<td>
Uid
</td>
<td>

    <asp:TextBox ID="txtuid" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>

</td>
</tr>

<tr>
<td>

    Resume</td>
<td>

    <asp:FileUpload ID="FileUpload2" runat="server" />

</td>
</tr>

<tr>
<td colspan="2">

   

    <asp:Label ID="Label1" runat="server" ForeColor="Red" 
        Text="Please enter all required fields" Visible="False"></asp:Label>

   

</td>
</tr>

<tr>
<td colspan="2">

    <asp:Button ID="Button1" runat="server" Text="Register" 
        onclick="Button1_Click" />

</td>
</tr>
</table>
</center>
</asp:Content>
