<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Company.aspx.cs" Inherits="BAHRAIN_TOURS.Company1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container">    <div style="margin-bottom:5px">        <table>            <tr>                <td>                    Search by Company Name                 </td>                <td>                    <asp:TextBox runat="server" ID="txtSearch" style="margin-left:3px;"></asp:TextBox>                </td>                <td>                    <asp:Button runat="server" ID="btnSearch" Text="Search" style="margin-left:3px;" class="btn btn-success" OnClick="btnSearch_Click"/>                </td>            </tr>        </table>    </div>    <div style="">      <asp:GridView ID="GridViewCompany" runat="server"></asp:GridView>    </div></div>
</asp:Content>
