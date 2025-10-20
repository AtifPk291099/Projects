<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h2> Welcome To The Campus</h2></center><hr style="width:90%;" />
   <center><h3>Get Your DreamJob Today</h3></center>
   <hr style="width:90%;" />
   <table width="100%"><tr><td>
   <center><a href="Clogin.aspx" style="color:ThreeDFace; text-decoration:none"><h2>Company Login</h2></a></center>
   </td><td>
   <center><a href= "Login.aspx" style="color:ThreeDFace; text-decoration:none"><h2>Student Login</h2></a></center>
   </td>
   </tr>
   <tr>
   <td colspan="2">
   <center><a href="Admin.aspx" style="color:ThreeDFace; text-decoration:none"><h2>Admin Login</h2></a></center>
   </td>
   </tr>
   </table>
</asp:Content>