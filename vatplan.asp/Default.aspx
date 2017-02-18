<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="Default.aspx.cs" Inherits="vatplan.asp.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Produkty</h1>
    <asp:GridView runat="server" ID="productsGrid"
        ItemType="PlanVat.Domain.DB.Products" DataKeyNames="Id"
        SelectMethod="productsGrid_GetData"
        AutoGenerateColumns="False" AlternatingRowStyle-VerticalAlign="Middle">

        <Columns>
            <asp:DynamicField DataField="Name" HeaderText="Nazwa" />
            <asp:DynamicField DataField="Description" HeaderText="Opis" />
            <asp:DynamicField DataField="PKWiU" HeaderText="PKWiU" />
            
            <asp:TemplateField HeaderText="J.m.">
                <ItemTemplate>
                    <asp:Label Text="<%# Item.UnitsOfMeasure.Name %>" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Stawka Vat">
                <ItemTemplate>
                    <asp:Label Text="<%# Item.VatRates.Name %>" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            
        </Columns>

    </asp:GridView>
</asp:Content>
