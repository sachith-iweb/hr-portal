<%@ Page Title="" Language="C#" MasterPageFile="~/userprofile.Master" AutoEventWireup="true" CodeBehind="error.aspx.cs" Inherits="HRM_UserProfile.error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style4 {
        font-size: large;
    }
    .auto-style5 {
        color: #333333;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <center>
        <img src="images/error_face.png" />
        <br />
        <h1 style="color:darkred; text-transform:uppercase;">Ohh... There is an technical error ...!</h1>
        <span style="font-size:16px;">Please contact service provider for assistance.<br />
        <br />
        </span>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/overview.aspx">OVERALL VIEW</asp:HyperLink>
&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/default.aspx">LOGOUT</asp:HyperLink>
        <br />  <br />
        <hr class="line" />
      
        <strong><span class="auto-style4">
        <br />
        <span class="auto-style5">Error Details.</span>
        <br /></span></strong><br />
        <asp:Label ID="lblErrorHeader" runat="server" Text="" style="font-size: large; color: #333333"></asp:Label>
        <br /><br />
        <asp:Label ID="lblStackTrace" runat="server" Text="" style="color: #333333"></asp:Label>

    </center>
</asp:Content>
