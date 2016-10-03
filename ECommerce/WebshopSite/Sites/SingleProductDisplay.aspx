<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SingleProductDisplay.aspx.cs" Inherits="WebshopSite.Sites.SingleProductDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="AsideContent" runat="server">



        <div class="col-md-3" id="AsideContainer" runat="server">
           

</div>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <link href="../Style/Stylesheet.css" rel="stylesheet" />

        <div id="ProductContainer" runat="server">
            
            <div id="left" class="col-md-3 col-sm-12">
            <asp:Label ID="lbl_productname" runat="server" ></asp:Label>
            <br />
            <img class="auto-style1" src="../Images/Tröja.png" />
            </div>
            <div id="right" class="col-md-3 col-sm-12">
            <asp:Label ID="lbl_description" runat="server">Description</asp:Label>
            <p id="description" runat="server"></p>
            <asp:Label ID="lbl_size" runat="server"></asp:Label><br />
            <asp:Label ID="lbl_color" runat="server"></asp:Label>
                
            <br />
            <asp:Label ID="lbl_unitinstock" runat="server">[lbl_unitinstock]</asp:Label>
            <br />
            <br />
            <div id="choicecontainer" runat="server">
                <asp:DropDownList ID="ddl_color" runat="server" AutoPostBack="True" OnTextChanged="Choices_SelectedIndexChanged"></asp:DropDownList>
                <asp:DropDownList ID="ddl_size" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_size_SelectedIndexChanged"></asp:DropDownList>
            </div>
            <br />
            <asp:Button ID="btn_addtocart" runat="server" Text="Add to cart" OnClick="btn_buy_Click" />
            </div>
             </div>
</asp:Content>
