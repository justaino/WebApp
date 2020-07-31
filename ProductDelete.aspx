<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ProductDelete.aspx.cs" Inherits="E_Commerce_Website.ProductDelete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="primary-content">
        <div class="wrapper">
            <h3>
                <asp:Label ID="lblSuccess" Text="Product Sucessfully Deleted" runat="server"></asp:Label></h3>
            <asp:Button ID="btnBack1" Text="Go Back" CssClass="button-2" runat="server" OnClick="btnBack_Click1" />
            <div id="hide" runat="server">
                <article>
                    <h3>Are you sure you want to delete the product below?</h3>

                    <h1>
                        <asp:Label ID="lblProductName" runat="server"></asp:Label>
                    </h1>

                    <br />

                    <p>
                        <asp:Label ID="lblDescription" runat="server"></asp:Label></p>

                    <br />

                    <asp:Label ID="lblPrice" runat="server"></asp:Label>

                    <br />
                    <asp:Image ID="productImage" runat="server" />
                    <img id="image" runat="server" width="201" height="259" />
                    <br />
                    <br />
                    <asp:Button runat="server" ID="btnYes" Text="Yes" CommandName="Yes"
                        CommandArgument='<%#Eval("ItemID") %>' OnCommand="btnYes_Command" CssClass="button-2" />

                    <asp:Button ID="btnBack" Text="No" runat="server" CssClass="button-2" OnClick="btnBack_Click" />
                </article>
            </div>
        </div>
    </div>
</asp:Content>
