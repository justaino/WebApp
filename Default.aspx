<%@ Page Title="" Language="C#" MasterPageFile="~/PrimaryMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="E_Commerce_Website.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="banner-image">
        <div class="wrapper">
            <h2><strong>PineApple </strong>
                <br />
                Bringing Innovation To A Whole New Level!</h2>
            <a href="Products.aspx" class="button-1">View Products</a>
        </div>
    </div>

    <div id="features">
        <div class="wrapper">
            <ul>
                <li class="feature-1" style="list-style:none">
                    <h4>Privacy</h4>
                    <p>At PineApple, your privacy is our number one priority and that is what our business model is based on, so you can be rest assured that your data is safe with us.</p>
                </li>
                <li class="feature-2" style="list-style:none">
                    <h4>Easy To Use</h4>
                    <p>PineApple products are super easy to use. Everyone can use it from your 5 year old sibling to you grand aunt. Give it a go and tell us what you think.</p>
                </li>
                <li class="feature-3" style="list-style:none">
                    <h4>Great Design</h4>
                    <p>Here at PineApple, our products have the most amazing design, take a look at the shop to see what interests you!</p>
                </li>
                <div class="clear"></div>
            </ul>
        </div>
    </div>

    <div id="primary-content">
        <div class="wrapper">
            <article>
                <h3>Featured Content</h3>
                <p>Watch the video below that highlights just a few of what our products actually have to offer you. You will enjoy it. </p>

                <video id="video1" width="940" height="527" autoplay>
                    <source src="images/its_actually_apple.mp4" type="video/mp4" />

                </video>
            </article>
        </div>



    </div>

</asp:Content>
