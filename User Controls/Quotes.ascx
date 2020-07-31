<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Quotes.ascx.cs" Inherits="E_Commerce_Website.Quotes" %>
<div class="wrapper">
    <div id="footer-info">
        <h4>Quote Of The Page Load</h4>
        <asp:Repeater ID="rptQuotes" runat="server">
            <ItemTemplate>
                <p>
                    <asp:Label ID="lblQuotes" runat="server" Text='<%#Eval("Quote") %>'></asp:Label></p>
                <p>
                    <asp:Label ID="lblAuthor" runat="server" Text='<%#Eval("QuoteAuthor") %>'></asp:Label></p>

            </ItemTemplate>
        </asp:Repeater>

    </div>
</div>
