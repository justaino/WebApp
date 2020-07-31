<%@ Page Title="" Language="C#" MasterPageFile="~/PrimaryMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="E_Commerce_Website.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="primary-content">
        <div class="wrapper">
            <h3>Register</h3>
            <h4>
                <asp:Label ID="lblUsername" runat="server" Text="First Name:"></asp:Label>
                <asp:TextBox runat="server" ID="txtFirstName" CssClass="defaultTextBox"></asp:TextBox>
            </h4>
            <h4>
                <asp:Label ID="Label1" runat="server" Text="Last Name:"></asp:Label>
                <asp:TextBox runat="server" ID="txtLastName" CssClass="defaultTextBox"></asp:TextBox>
            </h4>
            <h4>
                <asp:Label ID="Label2" runat="server" Text="Username:"></asp:Label>
                <asp:TextBox runat="server" ID="txtUsername" CssClass="defaultTextBox"></asp:TextBox>
            </h4>
            <h4>
                <asp:Label ID="Label3" runat="server" Text="Password:"></asp:Label>
                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="defaultTextBox"></asp:TextBox>
            </h4>
            <h4>
                <asp:Label ID="Label4" runat="server" Text="Confirm Password:"></asp:Label>
                <asp:TextBox runat="server" ID="txtPasswordConfirm" TextMode="Password" CssClass="defaultTextBox"></asp:TextBox>
            </h4>



            <p>
                <asp:Label ID="lblAlreadyExists" runat="server"></asp:Label></p>


            <asp:Button runat="server" Text="Register" CssClass="button-2" ID="btnSignIn" />
            <h6>
                <asp:Label ID="lblLoggedIn" runat="server" Text=" "></asp:Label></h6>

        </div>
    </div>
</asp:Content>
