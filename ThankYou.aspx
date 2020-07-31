<%@ Page Title="" Language="C#" MasterPageFile="~/PrimaryMaster.Master" AutoEventWireup="true" CodeBehind="ThankYou.aspx.cs" Inherits="E_Commerce_Website.ThankYou" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="primary-content">
        <div class="wrapper">
            <h3><asp:Label ID="lblThankYou" runat="server" ></asp:Label></h3>
            <asp:Button ID="lblHome" Text="Home" runat="server" CssClass="button-2" OnClick="lblHome_Click" />
        </div>
    </div>
</asp:Content>
