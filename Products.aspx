<%@ Page Title="" Language="C#" MasterPageFile="~/PrimaryMaster.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="E_Commerce_Website.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="secondary-content">
        <div class="wrapper">

            <ul>
                <asp:Repeater ID="rptProductInfo" runat="server">
                    <ItemTemplate>
                        <!--  <article style="background:url('images/iphone.jpg');">-->
                        <li style="list-style: none">

                            <div class="clear"></div>
                            <div class="overlay">
                                <img src='data:image/jpg;base64,
                                <%# Eval("Image") != System.DBNull.Value ? Convert.ToBase64String((byte[])Eval("Image")): string.Empty%>'
                                    alt="image" width="110" height="138" />
                                <h4>
                                    <asp:Label runat="server" ID="lblProductName" Text='<%#Eval("Title") %>'></asp:Label>
                                </h4>

                                <p>
                                    <asp:Label runat="server" ID="lblDesc" Text='<%#Eval("Description") %>'></asp:Label>
                                </p>

                                <p>
                                    <small>
                                        <asp:Label runat="server" ID="lblPrice" Text='<%#Eval("Price",  "{0:c}") %>'></asp:Label>
                                    </small>
                                </p>

                                <asp:Button runat="server" ID="btnView" Text="More" CommandName="More"
                                    CommandArgument='<%#Eval("ItemID") %>' OnCommand="btnView_Command" CssClass="button-4" />

                                <asp:Button runat="server" ID="btnAdd" Text="Add to cart" CommandName="Add"
                                    CommandArgument='<%#Eval("ItemID") %>' OnCommand="btnAdd_Command" CssClass="button-3" />

                                <div class="clear"></div>
                            </div>
                            <div class="clear"></div>
                            <br />
                            <br />
                            <br />
                        </li>
                        <!--  </article>-->
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
            <div class="clear"></div>

            <br />
            <br />

            <div class="clear"></div>
        </div>
    </div>

</asp:Content>
