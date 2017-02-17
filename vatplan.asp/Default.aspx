<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="vatplan.asp.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView runat="server" ID="productsGrid"
        ItemType="PlanVat.Domain.DB.Products" DataKeyNames="Id"
        SelectMethod="productsGrid_GetData"
        AutoGenerateColumns="true">

    </asp:GridView>
</asp:Content>
