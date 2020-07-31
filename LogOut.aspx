<%@ Page Title="" Language="C#" MasterPageFile="~/PrimaryMaster.Master" AutoEventWireup="true" CodeBehind="LogOut.aspx.cs" Inherits="E_Commerce_Website.LogOut" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="hide" runat="server">
        <div id="primary-content">
            <div class="wrapper">
                <h3>You Are Already Signed In</h3>
                <asp:Button ID="btnLogOut" runat="server" CssClass="button-2" Text="Log Out" OnClick="btnLogOut_Click" />
            </div>
        </div>
    </div>
    <h3>
        <asp:Label ID="lblLogged" runat="server" Text="You have successfully signed out!"></asp:Label></h3>

</asp:Content>
