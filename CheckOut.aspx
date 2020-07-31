<%@ Page Title="" Language="C#" MasterPageFile="~/PrimaryMaster.Master" AutoEventWireup="true" CodeBehind="CheckOut.aspx.cs" Inherits="E_Commerce_Website.CheckOut" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="primary-content">
        <div class="wrapper">


            <div id="features">
                <div class="wrapper">
                    <ul>
                        <asp:Repeater ID="rptCheckOut" runat="server">
                            <ItemTemplate>
                                <li style="list-style:none">
                                    <!--code from moodle-->
                                    <img src='data:image/jpg;base64,
                                <%# Eval("Image") != System.DBNull.Value ? Convert.ToBase64String((byte[])Eval("Image")): string.Empty%>'
                                        alt="image" width="201" height="259" />
                                    <h4><%#Eval("Title") %></h4>
                                    <p><%#Eval("Description") %></p>
                                    <p>€<%# (string.Format("{0:c}", Eval("Price").ToString())) %></p>
                                    <asp:LinkButton ID="lbtnDelete" OnCommand="lbtnDelete_Command" CommandArgument='<%#Eval("ItemID")%>' runat="server" Text="Delete"></asp:LinkButton>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>


                    </ul>
                </div>
            </div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <div class="clear"></div>
            <div>
                <h3><strong>Your Total Is: </strong>
                    <asp:Label ID="lblTotal" runat="server"></asp:Label></h3>
                <asp:Button ID="btnBack" Text="Buy Now!" runat="server" CssClass="button-2" OnClick="btnBack_Click" />
            </div>
            <div class="clear"></div>
        </div>
    </div>
</asp:Content>
