<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ProductEdit.aspx.cs" Inherits="E_Commerce_Website.ProductEdit" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CK" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/ckeditor/4.6.2/ckeditor.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="primary-content">
        <div class="wrapper">


            <div id="hide" runat="server">
                <h3>Add A New Product To Your Website </h3>

                <h4>
                    <asp:Label ID="lblTitle" Text="Title" AssociatedControlID="txtTitle" runat="server"></asp:Label></h4>

                <asp:TextBox ID="txtTitle" runat="server" CssClass="defaultTextBox"></asp:TextBox>

                <br />
                <h4>
                    <asp:Label ID="lblDescription" Text="Product Description" AssociatedControlID="txtDescription" runat="server"></asp:Label></h4>
                <CK:CKEditorControl runat="server" ID="txtDescription"></CK:CKEditorControl>

                <h4>
                    <asp:Label ID="lblPrice" runat="server" Text="Price" AssociatedControlID="txtPrice"></asp:Label></h4>
                <asp:TextBox runat="server" TextMode="Number" ID="txtPrice" CssClass="defaultTextBox"></asp:TextBox>

                <h6>
                    <asp:Label ID="lblImage" runat="server" Text="Product Image"></asp:Label></h6>
                <br />
                <asp:Image ID="productImage" runat="server" />
                <img id="image" runat="server" width="201" height="259" />
                <asp:FileUpload ID="FileUpload" runat="server" CssClass="defaultTextBox" />

                <br />

                <asp:Button ID="btnEdit" runat="server" Text="Update" CssClass="button-2" OnClick="btnEdit_Click" />

                <p>
                    <asp:Label ID="lblUploaded" runat="server"></asp:Label></p>
                <asp:Button ID="btnBack1" runat="server" Text="Go Back" CssClass="button-2" OnClick="btnBack1_Click" />
            </div>

            <h3>
                <asp:Label ID="lblSuccess" Text="Product Edited Successfully. Redirecting to Admin Homepage." runat="server"></asp:Label></h3>
            <asp:Button ID="btnOK" Text="OK!" runat="server" />
        </div>
    </div>

</asp:Content>
