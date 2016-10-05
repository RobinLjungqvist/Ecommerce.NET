<%@ Page Title="Receipt" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="receipt.aspx.cs" Inherits="WebshopSite.Sites.receipt" %>

<asp:Content ID="contactinformation" ContentPlaceHolderID="AsideContent" runat="server">
    <div id="CategoryContainer" class="col-md-2" runat="server">
       
    </div>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Style/Stylesheet.css" rel="stylesheet" />
    <div>
                
            </div>
    <div id="CheckoutContent" class="col-md-6" runat="server">
        <h2><%: Title %></h2>
        <div id="orderinfo" runat="server">
            <h4>Delivery adress</h4>
             <asp:Label class="reg_lbl" runat="server" AssociatedControlID="txtbox_name">Name:</asp:Label><asp:textbox ID="txtbox_name" CssClass="text_box" runat="server" Enabled="False"></asp:textbox><br />
                 <asp:Label class="reg_lbl" runat="server" AssociatedControlID="txtbox_adress">Adress:</asp:Label><asp:textbox ID="txtbox_adress" CssClass="text_box" runat="server" Enabled="False"></asp:textbox><br />
                 <asp:Label class="reg_lbl" runat="server" AssociatedControlID="txtbox_city">City:</asp:Label><asp:textbox ID="txtbox_city" CssClass="text_box" runat="server" Enabled="False"></asp:textbox><br />
                 <asp:Label class="reg_lbl" runat="server" AssociatedControlID="txtbox_zipcode">Zipcode:</asp:Label><asp:textbox ID="txtbox_zipcode" CssClass="text_box" runat="server" Enabled="False"></asp:textbox><br />
            <hr />
            <div id="ordertotalcontainer" runat="server"><label id="lbl_ordertotal">Order Total:</label><label id="ordertotalsum" runat="server"></label></div>

            <asp:Button runat="server" Text="Keep Shopping" CssClass="btn_keepshopping" ID="btn_keepshopping" OnClick="btn_keepshopping_Click"/>
            <h4>Products</h4>

            <div id="orderproducts" runat="server"></div>
        </div>

        <div id="OrderDetails" runat="server" visible="false">
             <div class="formcol">
               

                 
             </div>
            
        </div>

    </div>
</asp:Content>
