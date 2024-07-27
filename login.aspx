<%@ Page Title="login page" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="BAHRAIN_TOURS.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="container">
    <h1>Login Page</h1>
     
    <table border="0">
        <tr>
            <td>Username
            </td>
            <td>
                <asp:TextBox class="somespace" runat="server" ID="txtusername"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Password
            </td>
            <td>
                <asp:TextBox class="somespace" runat="server" ID="txtpassword" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="right">
                <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click" class="btn btn-success"/>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="left">
                <asp:Label runat="server" ID="lblmsg" Text=""></asp:Label><asp:SqlDataSource runat="server" ID="sqlData" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Table]"></asp:SqlDataSource>
            </td>
        </tr>
    </table>
</div>
</asp:Content>
