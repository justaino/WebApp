<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="E_Commerce_Website.Create" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CK" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/ckeditor/4.6.2/ckeditor.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="primary-content">
        <div class="wrapper">

            <h3>
                <asp:Label ID="lblSuccess" Text="Product Created Successfully" runat="server"></asp:Label></h3>
            <asp:Button ID="btnCreatePlus" Text="Create Another" runat="server" OnClick="btnCreatePlus_Click" CssClass="button-2" />

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
                <asp:TextBox runat="server" ID="txtPrice" CssClass="defaultTextBox" TextMode="Number"></asp:TextBox>

                <h6>
                    <asp:Label ID="lblUpload" runat="server" Text="Upload Image"></asp:Label></h6>
                <br />
                <asp:FileUpload ID="FileUpload" runat="server" CssClass="defaultTextBox" />

                <br />

                <asp:Button ID="btnUpload" runat="server" Text="Create!" CssClass="button-2" OnClick="btnUpload_Click" />

                <p>
                    <asp:Label ID="lblUploaded" runat="server"></asp:Label></p>
            </div>
        </div>
    </div>
    <asp:Button runat="server" ID="btnCreate" Text="Go Back" CssClass="button-2" OnClick="btnCreate_Click" />

</asp:Content>
