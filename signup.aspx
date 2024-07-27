<%@ Page Title="Registeration page" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="BAHRAIN_TOURS.signup" %>

<%@ Register Src="~/uc_signup.ascx" TagPrefix="uc1" TagName="uc_signup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>Registeration page</h1>
        <uc1:uc_signup runat="server" ID="uc_signup" />
    </div>
</asp:Content>
