<%@ Page Title="" Language="C#" MasterPageFile="~/userprofile.Master" AutoEventWireup="true" CodeBehind="interests.aspx.cs" Inherits="HRM_UserProfile.interests" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="divGroupBlock">
        <div class="divGroupBlockHeader">
            Interest Informations
        </div>

        <div class="divGroupBlockBody">

          <div class="divGroupBlockHeaderSmall">Add / Edit Interest Details</div>
            <div class="divGroupBlockBody">


             <table cellpadding="5">
        <tr>
            <td class="auto-style4" >
                <asp:Label ID="Label2" runat="server" Text="Interest" CssClass="labal"></asp:Label>
            </td>
            <td class="auto-style6" >
                <asp:Label ID="Label5" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td class="auto-style5" >
                <telerik:RadTextBox ID="txtInterest" Runat="server" CssClass="textBoxes" Skin="Silk" Width="500px">
                </telerik:RadTextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="r1" runat="server" ControlToValidate="txtInterest" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4" >
                <asp:Label ID="Label3" runat="server" Text="Remarks" CssClass="labal"></asp:Label>
            </td>
            <td class="auto-style6" >
                <asp:Label ID="Label6" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td class="auto-style5" >
                <telerik:RadTextBox ID="txtRemarks" Runat="server" TextMode="MultiLine" 
                    CssClass="textBoxes" Skin="Silk" Width="500px">
                </telerik:RadTextBox>
            </td>
            <td> 
                <asp:RequiredFieldValidator ID="r2" runat="server" ControlToValidate="txtRemarks" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4" >
                &nbsp;</td>
            <td class="auto-style6" >
                &nbsp;</td>
            <td class="auto-style5" >
                <asp:CheckBox ID="chkActive" runat="server" Text="Active" 
                    CssClass="checkBoxes" Checked="True" />
            </td>
            <td>
                <asp:HiddenField ID="hdnEmployeeWiseInterestId" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4" >
                &nbsp;</td>
            <td class="auto-style6" >
                &nbsp;</td>
            <td class="auto-style5" >
                
                <asp:Button ID="btnSave" runat="server" CssClass="btnCheckForChanges" Height="35px" Text="Request To Change" Width="250px" OnClick="btnSave_Click" ValidationGroup="r" />
                 &nbsp;                               
                <asp:Button ID="btnReset" runat="server" CssClass="btnResetToDefault" Height="35px" Text="Reset To Default" Width="200px" OnClick="btnReset_Click" />
                                          
 
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
            </div>
                                        
 
<div class="divGroupBlockHeaderSmall">Existing Interest Details</div>
            <div class="divGroupBlockBody">
    <telerik:RadGrid ID="dgEmployeeWiseInterestDetails" runat="server" 
        AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" Skin="Silk" 
        onitemcommand="dgEmployeeWiseInterestDetails_ItemCommand" 
        onneeddatasource="dgEmployeeWiseInterestDetails_NeedDataSource" 
        onpageindexchanged="dgEmployeeWiseInterestDetails_PageIndexChanged" 
        onpagesizechanged="dgEmployeeWiseInterestDetails_PageSizeChanged" 
        onsortcommand="dgEmployeeWiseInterestDetails_SortCommand" PageSize="5" Width="100%" GroupPanelPosition="Top">
        <ExportSettings FileName="EmployeeWiseInterestDetails">
            <Pdf PageHeight="297mm" PageWidth="210mm" PaperSize="A4" />
        </ExportSettings>
<MasterTableView>
<RowIndicatorColumn Visible="False">
<HeaderStyle Width="41px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Created="True">
<HeaderStyle Width="41px"></HeaderStyle>
</ExpandCollapseColumn>
    <CommandItemSettings ShowAddNewRecordButton="False" 
        ShowExportToCsvButton="True" ShowExportToPdfButton="True" 
        ShowRefreshButton="False" />
    <Columns>
        <telerik:GridBoundColumn DataField="EmployeeWiseInterestId" 
            HeaderText="EmployeeWiseInterestId" UniqueName="EmployeeWiseInterestId" 
            Display="False" FilterControlWidth="80%">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="EmployeeId" HeaderText="EmployeeId" 
            UniqueName="EmployeeId" Display="False" FilterControlWidth="80%">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="EmployeeName" HeaderText="EmployeeName" 
            UniqueName="EmployeeName" FilterControlWidth="80%" Visible="False">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Interest" HeaderText="Interest" 
            UniqueName="Interest" FilterControlWidth="80%">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Remarks" HeaderText="Remarks" 
            UniqueName="Remarks" FilterControlWidth="80%">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IsActive" HeaderText="IsActive" 
            UniqueName="IsActive" Display="False" FilterControlWidth="80%">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridCheckBoxColumn DataField="IsActive" HeaderText="Active" 
            UniqueName="IsActive1" FilterControlWidth="80%">
            <ItemStyle Width="15px" />
        </telerik:GridCheckBoxColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Select" 
            Text="Edit" UniqueName="Edit" ImageUrl="~/images/btn_edit.png">
            <ItemStyle Width="10px" />
        </telerik:GridButtonColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
            ImageUrl="~/Img/deleteRecordBtn.gif" Text="Delete" UniqueName="Delete" 
            ConfirmText="Are you sure you want to delete this record ?" 
            ConfirmTitle="Confirmation..." ConfirmDialogType="RadWindow" 
            ConfirmDialogHeight="150px" Visible="False">
            <ItemStyle Width="10px" />
        </telerik:GridButtonColumn>
    </Columns>
</MasterTableView>
    </telerik:RadGrid>
</div>



        </div>
    </div> 


    

</asp:Content>
