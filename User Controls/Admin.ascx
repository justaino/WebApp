<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Admin.ascx.cs" Inherits="E_Commerce_Website.Admin" %>
  
        <div class="wrapper">
            <div id="footer-info">
            <h4>Admin Login</h4>
            <h5><asp:Label ID="lblUsername" AssociatedControlID="txtUsername" runat="server" Text="Username"></asp:Label> <asp:TextBox runat="server" ID="txtUsername"  CssClass="defaultTextBox"></asp:TextBox> </h5>
            <asp:RequiredFieldValidator ID="rfvUsername" ControlToValidate="txtUsername"
                validationgroup="Login" ErrorMessage="Please enter your username" runat="server"></asp:RequiredFieldValidator>


  <h5><asp:Label ID="LabelPassword" AssociatedControlID="txtPassword" runat="server" Text="Password"></asp:Label> <asp:TextBox runat="server" TextMode="Password" ID="txtPassword" CssClass="defaultTextBox"></asp:TextBox> </h5>
            <asp:RequiredFieldValidator ID="rfvPassword" ControlToValidate="txtPassword"
                validationgroup="Login" ErrorMessage="Please enter your password" Display="Dynamic" runat="server"></asp:RequiredFieldValidator>


            <asp:Button runat="server" Text="Login" CssClass="button-2" ID="btnSignIn" OnClick="btnSignIn_Click" />
            <h5><asp:Label ID="lblLoggedIn" runat="server" Text=" "></asp:Label></h5>
            </div>
        </div>
    