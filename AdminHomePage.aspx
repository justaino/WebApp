<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AdminHomePage.aspx.cs" Inherits="E_Commerce_Website.AdminHomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="secondary-content">
        <div class="wrapper">
            <div id="primary-content">
                <h3>Take Control Of The Products On Your Website </h3>
            </div>

            <ul>
                <asp:Repeater ID="rptProductInfo" runat="server">
                    <ItemTemplate>
                        <li style="list-style: none">
                            <div class="clear"></div>
                            <div class="overlay">
                                <!--code from moodle-->
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

                                <asp:Button runat="server" ID="btnEdit" Text="Edit" CommandName="Edit"
                                    CommandArgument='<%#Eval("ItemID") %>' OnCommand="btnEdit_Command" CssClass="button-4" />

                                <asp:Button runat="server" ID="btnDelete" Text="Delete" CommandName="Delete"
                                    CommandArgument='<%#Eval("ItemID") %>' OnCommand="btnDelete_Command" CssClass="button-4" />



                            </div>
                            <br />
                            <br />
                            <br />
                        </li>
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
