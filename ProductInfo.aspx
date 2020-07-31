<%@ Page Title="" Language="C#" MasterPageFile="~/PrimaryMaster.Master" AutoEventWireup="true" CodeBehind="ProductInfo.aspx.cs" Inherits="E_Commerce_Website.ProductInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="primary-content">
        <div class="wrapper">
            <article>

                <h3>
                    <img src='data:image/jpg;base64,
                                <%# Eval("Image") != System.DBNull.Value ? Convert.ToBase64String((byte[])Eval("Image")): string.Empty%>'
                        alt="image" id="img" runat="server" width="201" height="259" /></h3>

                <h1>
                    <asp:Label ID="lblProductName" runat="server"></asp:Label>
                </h1>

                <br />

                <p>
                    <asp:Label ID="lblDescription" runat="server"></asp:Label></p>

                <br />

                <p>Get it now for only
                    <asp:Label ID="lblPrice" runat="server"></asp:Label></p>

                <br />

                <br />
                <asp:Button runat="server" ID="btnAdd" Text="Add to cart" CommandName="Add"
                    CommandArgument='<%#Eval("ItemID") %>' OnCommand="btnAdd_Command" CssClass="button-2" />

                <asp:Button ID="btnBack" Text="Go Back" runat="server" CssClass="button-2" OnClick="btnBack_Click" />
            </article>
        </div>
    </div>
</asp:Content>
