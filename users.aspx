﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="users.aspx.cs" Inherits="BAHRAIN_TOURS.users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">        <h1 class="text-center" style="color: green">Users Page</h1>        <asp:Label ID="lblSession" runat="server" Text=""></asp:Label>        <div class="row">            <div class="col-md-8">                <div class="row txtrow">                    <div class="col-md-3">                        Id                    </div>                    <div class="col-md-9">                        <asp:TextBox ID="txtID" runat="server" BackColor="#efefef" ReadOnly="true"></asp:TextBox>                    </div>                </div>                <div class="row txtrow">                    <div class="col-md-3">                        Username                    </div>                    <div class="col-md-9">                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>                    </div>                </div>                <div class="row txtrow">                    <div class="col-md-3">                        Password                    </div>                    <div class="col-md-9">                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>                    </div>                </div>                <div class="row txtrow">                    <div class="col-md-3">                        Confirm Password                    </div>                    <div class="col-md-9">                        <asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox>                    </div>                </div>                <div class="row txtrow">                    <div class="col-md-3">                        Phone                    </div>                    <div class="col-md-9">                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>                    </div>                </div>                <div class="row txtrow">                    <div class="col-md-3">                        Email                    </div>                    <div class="col-md-9">                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>                    </div>                </div>                <div class="row txtrow">                    <div class="col-md-3">                        <lable>Approved:</lable>                    </div>                    <div class="col-md-9">                        <asp:TextBox ID="txtApproved" runat="server" Text=""></asp:TextBox>                    </div>                </div>                <div class="row txtrow">                    <div class="col-md-3">                        <lable>Notes:</lable>                    </div>                    <div class="col-md-9">                        <textarea id="txtDesc" cols="20" rows="4" runat="server"></textarea>                    </div>                </div>                <div calss="row txtrow">                    <div class="col-md-9 text-center">                        <asp:Button ID="btnInsert" runat="server" Text="Insert" class="btn btn-success" OnClick="btnInsert_Click" />                        <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn btn-danger" OnClick="btnDelete_Click" />                        <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-warning" OnClick="btnUpdate_Click" />                        <asp:Button ID="btnView" runat="server" Text="View" class="btn btn-info" OnClick="btnView_Click" />                    </div>                    <div class="col-md-3">                    </div>                </div>            </div>            <div class="col-md-4">            </div>        </div>    </div>    <br />    <div class="container">        <asp:GridView ID="grviewUsers" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" AutoGenerateSelectButton="True" OnSelectedIndexChanged="grviewUsers_SelectedIndexChanged">            <AlternatingRowStyle BackColor="#CCCCCC" />            <FooterStyle BackColor="#CCCCCC" />            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />            <SortedAscendingCellStyle BackColor="#F1F1F1" />            <SortedAscendingHeaderStyle BackColor="#808080" />            <SortedDescendingCellStyle BackColor="#CAC9C9" />            <SortedDescendingHeaderStyle BackColor="#383838" />        </asp:GridView>    </div>
</asp:Content>
