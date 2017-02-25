<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" 
    Inherits="vatplan.asp.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Nowy produkt</h2>
    <asp:ValidationSummary runat="server" ShowModelStateErrors="true" />
    <asp:FormView runat="server" ID="addProductForm"
        ItemType="vatplan.asp.Models.ProductVM"
        InsertMethod="addProductForm_InsertItem"
        OnItemInserted="addProductForm_ItemInserted"
        DefaultMode="Insert"
        RenderOuterTable="False">
        <InsertItemTemplate>
            <fieldset>
                <ol>
                    <asp:DynamicEntity runat="server" Mode="Insert" />
                    <%--<li>
                        <label>Nazwa</label>
                        <asp:TextBox ID="Name"  runat="server" />
                    </li>
                    <li>
                        <label>Opis</label>
                        <asp:TextBox ID="Description" runat="server" />
                    </li>--%>
                </ol>
                <asp:Button runat="server" Text="Zapisz" CommandName="Insert" />
                <asp:Button runat="server" Text="Anuluj" ID="cancelButton"
                     CausesValidation="false" OnClick="cancelButton_Click"/>
            </fieldset>
        </InsertItemTemplate>
    </asp:FormView>
</asp:Content>
