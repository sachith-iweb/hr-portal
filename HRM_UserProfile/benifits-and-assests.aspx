<%@ Page Title="" Language="C#" MasterPageFile="~/userprofile.Master" AutoEventWireup="true" CodeBehind="benifits-and-assests.aspx.cs" Inherits="HRM_UserProfile.benifits_and_assests" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="divGroupBlock">
        <div class="divGroupBlockHeader">
            Benifits &amp; Assests Received
        </div>

        <div class="divGroupBlockBody">

             <telerik:RadGrid ID="dgBenifts" runat="server" Skin="Silk">
             </telerik:RadGrid>


        </div>
    </div> 


     </asp:Content>
