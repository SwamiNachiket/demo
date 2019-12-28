<%@ Page Title="" Language="C#" MasterPageFile="~/Exam.Master" AutoEventWireup="true" CodeBehind="INSERT.aspx.cs" Inherits="NewCURD.CURD.INSERT" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table border="1" align="center">

        <tr>
<td>EmployeeId </td><td>
    <asp:TextBox ID="empid" type="number" runat="server"></asp:TextBox></td>
</tr>
   
<tr>
<td>EmployeeName </td><td>
    <asp:TextBox ID="employeename" type="text" runat="server"></asp:TextBox></td>
</tr>
        <tr>
<td>City </td><td><asp:TextBox ID="City" type="text" runat="server"></asp:TextBox></td>
</tr>
     <tr>
   <td> <asp:LinkButton ID="LinkButton1" type="reset" runat="server">Reset</asp:LinkButton></td>
   <td> <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Register</asp:LinkButton></td>
</tr>

</table>
     <a runat="server" class="nav-link" href="~/Home.aspx">Home</a>

</asp:Content>
