<%@ Page Title="" Language="C#" MasterPageFile="~/Exam.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="NewCURD.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="EmployeeId" HeaderText="Employee ID" SortExpression="EmployeeId" />
            <asp:BoundField DataField="EmployeeName" HeaderText="Employee Name" SortExpression="EmployeeName" />
            <asp:BoundField DataField="EmployeeCity" HeaderText="Employee City" SortExpression="EmployeeCity" />
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Delete" ShowHeader="True" Text="Delete" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getAllEmployees" TypeName="NewCURD.Dal.Dal"></asp:ObjectDataSource>
    <br />
    <br />
        <a runat="server" class="nav-link" href="~/CURD/INSERT.aspx">Register</a>
</asp:Content>
