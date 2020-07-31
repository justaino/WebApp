<%@ Page Title="" Language="C#" MasterPageFile="~/PrimaryMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="E_Commerce_Website.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="hide" runat="server">
        <div id="primary-content">
            <div class="wrapper">
                <h3>Login</h3>
                <h4>
                    <asp:Label ID="lblUsername" AssociatedControlID="txtUsername" runat="server" Text="Username"></asp:Label>
                    <asp:TextBox runat="server" ID="txtUsername" CssClass="defaultTextBox"></asp:TextBox>
                </h4>
                <asp:RequiredFieldValidator ID="rfvUsername" ControlToValidate="txtUsername"
                    ValidationGroup="Login" ErrorMessage="Please enter your username" runat="server"></asp:RequiredFieldValidator>


                <h4>
                    <asp:Label ID="LabelPassword" AssociatedControlID="txtPassword" runat="server" Text="Password"></asp:Label>
                    <asp:TextBox runat="server" TextMode="Password" ID="txtPassword" CssClass="defaultTextBox"></asp:TextBox>
                </h4>
                <asp:RequiredFieldValidator ID="rfvPassword" ControlToValidate="txtPassword"
                    ValidationGroup="Login" ErrorMessage="Please enter your password" Display="Dynamic" runat="server"></asp:RequiredFieldValidator>

                <p>Don't have an account? Sign Up <a href="Register.aspx">Here</a></p>

                <asp:Button runat="server" Text="Login" CssClass="button-2" ID="btnSignIn" />
                <h6>
                    <asp:Label ID="lblLoggedIn" runat="server" Text=" "></asp:Label></h6>

            </div>
        </div>
    </div>
    <div id="signIn" runat="server">
        <div class="wrapper">
            <h3>
                <asp:Label ID="lblLogInSuccess" runat="server" Text="You are already Signed in!"></asp:Label></h3>
            <asp:Button ID="btnLogOut" Text="Sign Out" runat="server" OnClick="btnLogOut_Click1" CssClass="button-2" />
        </div>
    </div>

    <div id="logged" runat="server">
        <div class="wrapper">
            <h3>
                <asp:Label ID="lblLogged" runat="server" Text="You have successfully signed out!"></asp:Label></h3>
        </div>
    </div>

</asp:Content>
