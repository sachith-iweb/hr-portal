<%@ Page Title="" Language="C#" MasterPageFile="~/userprofile.Master" AutoEventWireup="true" CodeBehind="qualifications.aspx.cs" Inherits="HRM_UserProfile.qualifications" %>
<%@ Register src="cntrl_YearPicker.ascx" tagname="cntrl_YearPicker" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="divGroupBlock">
        <div class="divGroupBlockHeader">
           Qualification Informations
        </div>

        <div class="divGroupBlockBody">


    <div class="divGroupBlockHeaderSmall">Add / Update Qualifications</div>
     <div class="divGroupBlockBody">
     <table cellpadding="5">
        <tr>
            <td class="auto-style6" >
                <asp:Label ID="Label2" runat="server" Text="Course Title" CssClass="labal"></asp:Label>
            </td>
            <td >
                <asp:Label ID="Label7" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td >
                <telerik:RadTextBox ID="txtCourseTitle" Runat="server" CssClass="textBoxes" Skin="Silk" Width="300px">
                </telerik:RadTextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="r1" runat="server" ControlToValidate="txtCourseTitle" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6" >
                <asp:Label ID="Label3" runat="server" Text="Education Level" CssClass="labal"></asp:Label>
            </td>
            <td >
                <asp:Label ID="Label8" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td >
                <telerik:RadComboBox ID="cmbEducationLevel" Runat="server" 
                    CssClass="comboBoxes" Skin="Silk" Width="300px" OnDataBound="cmbEducationLevel_DataBound">
                </telerik:RadComboBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="r2" runat="server" ControlToValidate="cmbEducationLevel" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r" InitialValue="---Select---"></asp:RequiredFieldValidator>
            </td>
        </tr>
                 <tr>
                     <td class="auto-style6">
                         <asp:Label ID="Label4" runat="server" CssClass="labal" Text="Institute"></asp:Label>
                     </td>
                     <td>:</td>
                     <td>
                         <telerik:RadTextBox ID="txtInstitute" Runat="server" CssClass="textBoxes" Skin="Silk" Width="300px">
                         </telerik:RadTextBox>
                     </td>
                     <td>
                         <asp:RequiredFieldValidator ID="r3" runat="server" ControlToValidate="txtInstitute" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style6">
                         <asp:Label ID="Label5" runat="server" CssClass="labal" Text="Year Of Completion"></asp:Label>
                     </td>
                     <td>:</td>
                     <td>
                         <uc1:cntrl_YearPicker ID="cntrl_YearPicker1" runat="server" />
                     </td>
                     <td>&nbsp;</td>
                 </tr>
        <tr>
            <td class="auto-style6" >
                        <asp:Label ID="Label6" runat="server" Text="Remarks" CssClass="labal"></asp:Label>
            </td>
            <td >
                        :</td>
            <td >
                <telerik:RadTextBox ID="txtRemarks" Runat="server" CssClass="textBoxes" Rows="3" Skin="Silk" TextMode="MultiLine" Width="350px">
                </telerik:RadTextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="r4" runat="server" ControlToValidate="txtRemarks" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>
            </td>
        </tr>
                 <tr>
                     <td class="auto-style6">
                         <asp:HiddenField ID="hdnEmployeeWIseQualificationId" runat="server" Value="0" />
                     </td>
                     <td>&nbsp;</td>
                     <td colspan="2">
                         <asp:CheckBox ID="chkActive" runat="server" CssClass="checkBoxes" Text="Active" Checked="True" Enabled="False" />
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style6">
                         &nbsp;</td>
                     <td>&nbsp;</td>
                     <td colspan="2">
   
   
                <asp:Button ID="btnSave" runat="server" CssClass="btnCheckForChanges" Height="35px" Text="Request To Change" Width="250px" OnClick="btnSave_Click" ValidationGroup="r" />
               &nbsp;  &nbsp;
                          <asp:Button ID="btnReset" runat="server" CssClass="btnResetToDefault" Height="35px" Text="Reset To Default" Width="200px" OnClick="btnReset_Click" />
                                 
         
                     </td>
                 </tr>
        </table>
    </div>
   
                         
                                                 
         
                 <div class="divGroupBlockHeaderSmall">Existing Qualifications</div>
     <div class="divGroupBlockBody">   
     <telerik:RadGrid ID="dgEmployeeWiseQualificationDetails" runat="server" AllowPaging="True" AllowSorting="True" 
        AutoGenerateColumns="False" 
        onitemcommand="dgEmployeeWiseQualificationDetails_ItemCommand" 
        onneeddatasource="dgEmployeeWiseQualificationDetails_NeedDataSource" 
        onpageindexchanged="dgEmployeeWiseQualificationDetails_PageIndexChanged" 
        onpagesizechanged="dgEmployeeWiseQualificationDetails_PageSizeChanged" 
        onsortcommand="dgEmployeeWiseQualificationDetails_SortCommand" Skin="Silk" 
                     PageSize="5"  GroupPanelPosition="Top">
         <ExportSettings FileName="EmployeeWiseQualificationDetails">
             <Pdf PageHeight="297mm" PageWidth="210mm" PaperSize="A4" />
         </ExportSettings>
<MasterTableView>
<RowIndicatorColumn Visible="False">
<HeaderStyle Width="41px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn>
<HeaderStyle Width="41px"></HeaderStyle>
</ExpandCollapseColumn>
    <CommandItemSettings ShowAddNewRecordButton="False" 
        ShowExportToCsvButton="True" ShowExportToPdfButton="True" 
        ShowRefreshButton="False" />
    <Columns>
        <telerik:GridBoundColumn DataField="EmployeeWiseQualificationsID" 
            HeaderText="EmployeeWiseQualificationsID" 
            UniqueName="EmployeeWiseQualificationsID" Display="False">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="EmployeeID" HeaderText="EmployeeID" 
            UniqueName="employeeId" Display="False">
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
        <telerik:GridBoundColumn DataField="EducationLevelId" 
            HeaderText="EducationLevelId" UniqueName="educationLevelID" 
            Display="False">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="EducationLevelName" 
            HeaderText="Education Level" UniqueName="EducationLevelName" 
            FilterControlWidth="80%">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="CourseTitle" HeaderText="CourseTitle" 
            UniqueName="CourseTitle" FilterControlWidth="90%">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Institute" HeaderText="Institute" 
            UniqueName="Institute" FilterControlWidth="90%">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="YearOfCompletion" 
            HeaderText="YearOfCompletion" UniqueName="YearOfCompletion" 
            FilterControlWidth="80%">
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
            <ItemStyle Width="5px" />
        </telerik:GridCheckBoxColumn>
        <telerik:GridBoundColumn DataField="IsActive" HeaderText="IsActive" 
            UniqueName="IsActive" Display="False">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Select" 
            ImageUrl="~/images/btn_edit.png" Text="Edit" UniqueName="Edit">
            <ItemStyle Width="5px" />
        </telerik:GridButtonColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
            ImageUrl="~/Img/deleteRecordBtn.gif" Text="Delete" UniqueName="Delete" 
            ConfirmText="Are you sure you want to delete this record ?" 
            ConfirmTitle="Confirmation..." ConfirmDialogType="RadWindow" 
            ConfirmDialogHeight="150px" Visible="False">
            <ItemStyle Width="5px" />
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
