<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebshopSite.About" %>
<asp:Content ID="aboutinformation" ContentPlaceHolderID="AsideContent" runat="server">
    <div id="CategoryContainer" class="col-md-2">
       
    </div>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <h2><%: Title %>.<input id="Text1" type="text" onkeypress="NEJ!" runat="server" /></h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <p style="background-color: #00ebbd"></p>;
        </div>
    <script>
        var test = function(input){
            document.getElementById("Text1").innerText = input;
        }
    </script>
</asp:Content>
