<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SingleProductDisplay.aspx.cs" Inherits="WebshopSite.Sites.SingleProductDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="AsideContent" runat="server">



        <div class="col-md-2" id="AsideContainer" runat="server">
           filler

</div>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <link href="../Style/Stylesheet.css" rel="stylesheet" />

        <div class="col-md-10" id="ProductContainer" runat="server">
            
             
            <br />
            <asp:Label ID="lbl_productname" runat="server" Text='<%# Eval("ProductName")%>' ></asp:Label>
            <br />
            <img class="auto-style1" src="../Images/Tröja.png" /><br />
            <br />
            <asp:Label ID="lbl_unitinstock" runat="server">[lbl_unitinstock]</asp:Label>
            <br />
            <asp:Label ID="lbl_despcription" runat="server"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="ddl_color" runat="server" OnSelectedIndexChanged="ddl_color_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:DropDownList ID="ddl_size" runat="server" >
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btn_buy" runat="server" Text="Add to cart" OnClick="btn_buy_Click" />
            
             
        </div> 
</asp:Content>
