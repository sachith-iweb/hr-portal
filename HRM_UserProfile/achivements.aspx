<%@ Page Title="" Language="C#" MasterPageFile="~/userprofile.Master" AutoEventWireup="true" CodeBehind="achivements.aspx.cs" Inherits="HRM_UserProfile.achivements" %>
<%@ Register src="cntrl_YearPicker.ascx" tagname="cntrl_YearPicker" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="divGroupBlock">
        <div class="divGroupBlockHeader">
           Achievement Informations
        </div>

        <div class="divGroupBlockBody">


            <div class="divGroupBlockHeaderSmall">
                Add / Update Achivements
            </div>

            <div class="divGroupBlockBody">
            <table cellpadding="3" cellspacing="3">
        <tr>
            <td class="auto-style4" >
                <asp:Label ID="Label2" runat="server" Text="Year Date" CssClass="labal"></asp:Label>
            </td>
            <td class="auto-style4" >
                <asp:Label ID="Label6" runat="server" style="font-weight: 700" Text=":" 
                    CssClass="labal"></asp:Label>
            </td>
            <td class="auto-style4">
                <uc1:cntrl_YearPicker ID="cntrl_YearPicker1" runat="server" />
            </td>
            <td class="auto-style4" >
                &nbsp; &nbsp;</td>
            <td class="style1" rowspan="5" >
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Achievement" CssClass="labal"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label7" runat="server" style="font-weight: 700" Text=":" 
                    CssClass="labal"></asp:Label>
            </td>
            <td>
                <telerik:radtextbox ID="txtAchievement" Runat="server" Width="500px" 
                    CssClass="textBoxes" Skin="Silk">
                </telerik:radtextbox>
            </td>
            <td >
                <asp:RequiredFieldValidator ID="r1" runat="server" ControlToValidate="txtAchievement" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Remarks"></asp:Label>
            </td>
            <td >
                :</td>
            <td>
                <telerik:RadTextBox ID="txtRemarks" Runat="server" CssClass="textBoxes" Rows="3" Skin="Silk" TextMode="MultiLine" Width="500px">
                </telerik:RadTextBox>
            </td>
            <td >
                <asp:RequiredFieldValidator ID="r2" runat="server" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r" ControlToValidate="txtRemarks"></asp:RequiredFieldValidator>
            </td>
        </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:CheckBox ID="chkActive" runat="server" CssClass="checkBoxes" Text="Active" Checked="True" Enabled="False" />
                        <asp:HiddenField ID="hdnEmployeeWiseAchivementId" runat="server" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                
                <asp:Button ID="btnSave" runat="server" CssClass="btnCheckForChanges" Height="35px" Text="Request To Change" Width="250px" OnClick="btnSave_Click" ValidationGroup="r" />
                 &nbsp;&nbsp;                               
                <asp:Button ID="btnReset" runat="server" CssClass="btnResetToDefault" Height="35px" Text="Reset To Default" Width="200px" OnClick="btnReset_Click" />
                      
    
                    </td>
                    <td>&nbsp;</td>
                </tr>
        </table>
            </div>
                     
    
<div class="divGroupBlockHeaderSmall">Existing Achivements</div>
<div class="divGroupBlockBody">
    <telerik:RadGrid ID="dgEmployeeWiseAchievement" runat="server" AllowPaging="True" AllowSorting="True" 
        AutoGenerateColumns="False" 
        onitemcommand="dgEmployeeWiseAchievement_ItemCommand" 
        onneeddatasource="dgEmployeeWiseAchievement_NeedDataSource" 
        onpageindexchanged="dgEmployeeWiseAchievement_PageIndexChanged" 
        onpagesizechanged="dgEmployeeWiseAchievement_PageSizeChanged" 
        onselectedindexchanged="dgEmployeeWiseAchievement_SelectedIndexChanged" 
        onsortcommand="dgEmployeeWiseAchievement_SortCommand" Skin="Silk" 
        PageSize="5" GroupPanelPosition="Top">
        <ExportSettings FileName="EmployeeWiseAchievemenetDetails" 
            ExportOnlyData="True">
            <Pdf Creator="Scienter" PageHeight="297mm" PageWidth="210mm" PaperSize="A4" />
        </ExportSettings>
<MasterTableView>
<RowIndicatorColumn Visible="False">
<HeaderStyle Width="41px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn>
<HeaderStyle Width="41px"></HeaderStyle>
</ExpandCollapseColumn>
    <CommandItemSettings 
        ShowExportToCsvButton="True" ShowExportToPdfButton="True" 
        ShowRefreshButton="False" ShowAddNewRecordButton="False" />
    <Columns>
        <telerik:GridBoundColumn DataField="EmployeeWiseAchievementID" Display="False" 
            HeaderText="EmployeeWiseAchievementID" 
            UniqueName="EmployeeWiseAchievementID" FilterControlWidth="90%">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="EmplpyeeID" Display="False" 
            HeaderText="EmplpyeeID" UniqueName="employeeId" FilterControlWidth="90%">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NameWithInitials" 
            HeaderText="Employee Name With Initials" UniqueName="NameWithInitials" 
            FilterControlWidth="90%" Visible="False">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="YearDate" HeaderText="Year Date" 
            UniqueName="YearDate" FilterControlWidth="90%">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Achievement" HeaderText="Achievement" 
            UniqueName="Achievement" FilterControlWidth="90%">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Remarks" HeaderText="Remarks" 
            UniqueName="Remarks" FilterControlWidth="90%">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridCheckBoxColumn DataField="IsActive" HeaderText="Active" 
            UniqueName="IsActive1">
            <ItemStyle Width="15px" />
        </telerik:GridCheckBoxColumn>
        <telerik:GridBoundColumn DataField="IsActive" Display="False" 
            HeaderText="IsActive" UniqueName="IsActive">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Select" 
            ImageUrl="~/images/btn_edit.png" Text="Edit" UniqueName="Edit">
            <ItemStyle Width="10px" />
        </telerik:GridButtonColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
            ImageUrl="~/Img/deleteRecordBtn.gif" Text="Delete" UniqueName="Delete" 
            ConfirmDialogType="RadWindow" 
            ConfirmText="Are you sure you want to delete this record ?" 
            ConfirmTitle="Conformation..." ConfirmDialogHeight="150px" Visible="False">
            <ItemStyle Width="10px" />
        </telerik:GridButtonColumn>
    </Columns>
</MasterTableView>
    </telerik:RadGrid>
 </div>          
         

        </div>
    </div> 



      <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" BackColor="White" EnableEmbeddedSkins="false">
      
     <img src="images/loading_animation.gif" width="150px" style="margin-top:5%"/>
   
    </telerik:RadAjaxLoadingPanel>

</asp:Content>
