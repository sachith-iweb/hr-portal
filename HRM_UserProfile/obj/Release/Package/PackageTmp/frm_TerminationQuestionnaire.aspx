<%@ Page Title="" Language="C#" MasterPageFile="~/userprofile.Master" AutoEventWireup="true" CodeBehind="frm_TerminationQuestionnaire.aspx.cs" Inherits="HRM_UserProfile.frm_TerminationQuestionnaire" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="divGroupBlockHeader">
    Termination Feedback questionier
</div>

<div class="divGroupBlockBody">  
    
<telerik:RadGrid ID="dgTerminationQuestionnaire" runat="server" 
                    AutoGenerateColumns="False" GridLines="None"  Skin="Silk">
<MasterTableView>
<RowIndicatorColumn>
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn>
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>
    <Columns>
        <telerik:GridBoundColumn DataField="TerminationFeedBackQId" 
            HeaderText="TerminationFeedBackQId" UniqueName="TerminationFeedBackQId" 
            Display="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Question" HeaderText="Question" 
            UniqueName="Question">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="ListValueHeaderId" 
            HeaderText="ListValueHeaderId" UniqueName="ListValueHeaderId" 
            Display="False">
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn HeaderText="Rating" UniqueName="Rating">
            <ItemTemplate>
                <telerik:RadComboBox Skin="Silk" ID="cmbListOfValueDetails" Runat="server">
                </telerik:RadComboBox>
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn HeaderText="Remark" UniqueName="Remark">
            <ItemTemplate>
                <telerik:RadTextBox Skin="Silk" ID="txtRemark" Runat="server" TextMode="MultiLine" 
                    Width="200px">
                </telerik:RadTextBox>
            </ItemTemplate>
        </telerik:GridTemplateColumn>
    </Columns>
</MasterTableView>
                </telerik:RadGrid>

    <table width="100%">
            <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnSave" runat="server" CssClass="btnCheckForChanges" Height="35px" OnClick="btnSave_Click" Text="Submit Feedback" Width="250px" ValidationGroup="r" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
        </tr>
    </table>
</div>
</asp:Content>
