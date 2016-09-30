<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SingleProductDisplay.aspx.cs" Inherits="WebshopSite.Sites.SingleProductDisplay" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <link href="../Style/Stylesheet.css" rel="stylesheet" />


 <div class="row">
        <div class="col-md-8" id="ProductContainer" runat="server">
            
             
            <br />
            <asp:Label ID="lbl_productname" runat="server" Text="Label"></asp:Label>
            <br />
            <img class="auto-style1" src="../Images/Tröja.png" /><br />
            <br />
            <asp:Label ID="lbl_despcription" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="ddl_color" runat="server" OnSelectedIndexChanged="ddl_color_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:DropDownList ID="ddl_size" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btn_buy" runat="server" Text="Button" />
            
             
        </div> 
</div>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            width: 300px;
            height: 300px;
        }
    </style>
</asp:Content>
