 <%@ Page Title="" Language="C#" MasterPageFile="~/userprofile.Master" AutoEventWireup="true" CodeBehind="leave_calander.aspx.cs" Inherits="HRM_UserProfile.leave_calander" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Charting" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        
            td{
                  vertical-align:top;
             }
        
        </style>
</style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="divGroupBlock">
        <div class="divGroupBlockHeader">
            company leave Descriptions,&nbsp; Financial Year <span style="color:#ff0000"> &nbsp;<asp:Label ID="lblFinancialYear" runat="server" Text="0000">  </asp:Label></span>
        </div>

        <div class="divGroupBlockBody">

       

            <table width="100%" cellpadding="5">
                <tr>
                    <td>

                         <div class="divGroupBlock">
                            <div class="divGroupBlockHeaderSmall">Detail Leave Descriptions&nbsp;</div>
                             <div class="divGroupBlockBody">
                                 <telerik:RadListView ID="radLstDetailLeaveDescriptions" runat="server" OnNeedDataSource="radLstDetailLeaveDescriptions_NeedDataSource">                                  

                                     <ItemTemplate>
                                         <table cellpadding="3" cellspacing="3" width="100%">
                                             <tr>
                                                 <td>Date</td>
                                                 <td>Leave Type</td>
                                                 <td>Leave Unit</td>
                                                 <td>&nbsp;</td>
                                             </tr>
                                             <tr>
                                                 <td>
                                                     <asp:Label ForeColor="DarkRed" Font-Bold="true" ID="Label2" runat="server" Text='<%#Eval("LeaveDate")%>' ></asp:Label>
                                                 </td>
                                                 <td>
                                                     <asp:Label ID="Label3" Font-Bold="true" runat="server" Text='<%#Eval("LeaveType")%>'></asp:Label>
                                                 </td>
                                                 <td>
                                                     <asp:Label ID="Label4" Font-Bold="true" runat="server" Text='<%#Eval("LeaveUnit")%>'></asp:Label>
                                                 </td>
                                                 <td>&nbsp;</td>
                                             </tr>
                                             <tr>
                                                 <td colspan="4">
                                                     <asp:Label ID="Label5" runat="server" Text='<%#Eval("Remark")%>' style="font-size: 15px"></asp:Label>
                                                 </td>
                                             </tr>
                                             <tr>
                                                 <td colspan="4"><hr /></td>
                                             </tr>
                                         </table>
                                     </ItemTemplate>
                                 </telerik:RadListView>
                             </div>
                        </div>

                    </td>

                <td width="300px">
                     <div class="divGroupBlock">
                            <div class="divGroupBlockHeaderSmall">Company Leave Calendar</div>
                             <div class="divGroupBlockBody"> 

                                 <telerik:RadCalendar ID="radLeaveCalander" runat="server" Skin="MetroTouch" Width="200px" EnableMultiSelect="False" EnableWeekends="True" FastNavigationNextText="&amp;lt;&amp;lt;" SelectedDate="">
                                     <SpecialDays>
                                         <telerik:RadCalendarDay Date="" Repeatable="Today">
                                             <ItemStyle CssClass="rcToday" />
                                         </telerik:RadCalendarDay>
                                     </SpecialDays>
<WeekendDayStyle CssClass="rcWeekend"></WeekendDayStyle>

<CalendarTableStyle CssClass="rcMainTable"></CalendarTableStyle>

<OtherMonthDayStyle CssClass="rcOtherMonth"></OtherMonthDayStyle>

<OutOfRangeDayStyle CssClass="rcOutOfRange"></OutOfRangeDayStyle>

<DisabledDayStyle CssClass="rcDisabled"></DisabledDayStyle>

<SelectedDayStyle CssClass="rcSelected"></SelectedDayStyle>

<DayOverStyle CssClass="rcHover"></DayOverStyle>

<FastNavigationStyle CssClass="RadCalendarMonthView RadCalendarMonthView_MetroTouch"></FastNavigationStyle>

<ViewSelectorStyle CssClass="rcViewSel"></ViewSelectorStyle>
                                 </telerik:RadCalendar>

                            </div>
                        </div>

                </td>
                </tr>
            </table>

        </div>
    </div> 
</asp:Content>
