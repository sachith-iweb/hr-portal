 <%@ Page Title="" Language="C#" MasterPageFile="~/userprofile.Master" AutoEventWireup="true" CodeBehind="overview.aspx.cs" Inherits="HRM_UserProfile.overview" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Charting" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        
            td{
                  vertical-align:top;
             }

        
    </style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <% 
        if (Convert.ToInt32(Session["HomePageLoadCount"].ToString())==1)
        {        
   %>
    <div class="welcomeMsg" title="Click to close">
      <table>
          <tr>
              <td>
                  <img src="images/welcome_again.png" width="120"/>
              </td>
              <td align="right">
                 <h3 style="text-transform:uppercase;"> Welcome to your profile</h3>
                  You have logged as  : <span style="font-size:15px;">
                  <%Response.Write(Session["NameWithInitials"].ToString());%></span>

                  <br />
                  Manage your profile at your fingertips.
              </td>
          </tr>
      </table>
    </div>

<%
}
    Session["HomePageLoadCount"] = Convert.ToInt32(Session["HomePageLoadCount"].ToString()) + 1;
 %>
    <div class="divGroupBlock">
        <div class="divGroupBlockHeader">
            Profile Overview
        </div>

        <div class="divGroupBlockBody">

            <table width="100%" cellpadding="5" cellspacing="5">
                <tr>
                    <td>
                         
                            <div class="divGroupBlockHeaderSmall">Latest notifications  (<span style="color:#ff0000"> <asp:Label ID="lblUnReadVsReadNotifications" runat="server" Text="0/0">  </asp:Label></span>
                                )</div>
                             <div class="divGroupBlockBody"> 
                                 <telerik:RadGrid ID="dgLatestNotofications" runat="server" Skin="Silk" AutoGenerateColumns="False" OnNeedDataSource="dgLeaveAllocation_NeedDataSource" PageSize="5" Height="205px" Width="100%">
                                     <ClientSettings>
                                         <Scrolling AllowScroll="True" UseStaticHeaders="True" />
                                     </ClientSettings>
                                     <MasterTableView>
                                         <Columns>
                                             <telerik:GridBoundColumn DataField="Id" FilterControlAltText="Filter Id column" HeaderText="Id" UniqueName="Id" Visible="False">
                                                 <ColumnValidationSettings>
                                                     <ModelErrorMessage Text="" />
                                                 </ColumnValidationSettings>
                                             </telerik:GridBoundColumn>
                                             <telerik:GridBoundColumn DataField="SubjectShort" FilterControlAltText="Filter SubjectShort column" HeaderText="Subject" UniqueName="SubjectShort">
                                                 <ColumnValidationSettings>
                                                     <ModelErrorMessage Text="" />
                                                 </ColumnValidationSettings>
                                             </telerik:GridBoundColumn>
                                             <telerik:GridHyperLinkColumn AllowSorting="False" DataNavigateUrlFields="View" FilterControlAltText="Filter View column" Text="View" UniqueName="View">
                                             </telerik:GridHyperLinkColumn>
                                             <telerik:GridBoundColumn DataField="IsRead" FilterControlAltText="Filter IsRead column" HeaderText="IsRead" UniqueName="IsRead" Visible="False">
                                                 <ColumnValidationSettings>
                                                     <ModelErrorMessage Text="" />
                                                 </ColumnValidationSettings>
                                             </telerik:GridBoundColumn>
                                         </Columns>
                                     </MasterTableView>
                                 </telerik:RadGrid>
                            </div>
                       
                    </td>
                    <td width="260px">

                            <div class="divGroupBlockHeaderSmall">Leave ALlocation vs balaNce (<span style="color:#ff0000"> <asp:Label ID="lblLeaveTotal" runat="server" Text="0/0">  </asp:Label></span>
                                )</div>
                             <div class="divGroupBlockBody"> 
                                 <telerik:RadGrid ID="dgLeaveAllocation" runat="server" Skin="Silk" AutoGenerateColumns="False" OnNeedDataSource="dgLeaveAllocation_NeedDataSource" PageSize="5" AllowSorting="True" Height="205px">
                                     <MasterTableView>
                                         <Columns>
                                             <telerik:GridBoundColumn DataField="LeaveType" FilterControlAltText="Filter LeaveType column" HeaderText="Leave Type" UniqueName="LeaveType">
                                                 <ColumnValidationSettings>
                                                     <ModelErrorMessage Text="" />
                                                 </ColumnValidationSettings>
                                             </telerik:GridBoundColumn>
                                             <telerik:GridBoundColumn DataField="EntitleDays" FilterControlAltText="Filter EntitleDays column" HeaderText="Entitle Days" UniqueName="EntitleDays">
                                                 <ColumnValidationSettings>
                                                     <ModelErrorMessage Text="" />
                                                 </ColumnValidationSettings>
                                                 <HeaderStyle HorizontalAlign="Right" />
                                                 <ItemStyle HorizontalAlign="Right" />
                                             </telerik:GridBoundColumn>
                                             <telerik:GridBoundColumn DataField="BalanceDays" FilterControlAltText="Filter BalanceDays column" HeaderText="Balance Days" UniqueName="BalanceDays">
                                                 <ColumnValidationSettings>
                                                     <ModelErrorMessage Text="" />
                                                 </ColumnValidationSettings>
                                                 <HeaderStyle HorizontalAlign="Right" />
                                                 <ItemStyle HorizontalAlign="Right" />
                                             </telerik:GridBoundColumn>
                                         </Columns>
                                     </MasterTableView>
                                 </telerik:RadGrid>
                            </div>
                      

                    </td>
                    <td width="240px">

                           
                            <div class="divGroupBlockHeaderSmall">Company Leave Calendar (<span style="color:#ff0000"><asp:Label ID="lblFinancialYear" runat="server" Text="0000"></asp:Label></span>)</div>
                             <div class="divGroupBlockBody">
                                 <center>
                                 <telerik:RadCalendar ID="radLeaveCalander" runat="server" Skin="Silk" Width="200px" EnableMultiSelect="False" EnableWeekends="True" FastNavigationNextText="&amp;lt;&amp;lt;" SelectedDate="">
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
                                     </center>
                             </div>
                   

                    </td>
                </tr>

                <tr>
                    <td colspan="2">

                        
                         <div class="divGroupBlock">
                            <div class="divGroupBlockHeaderSmall">leave utilization (<span style="color:#ff0000"> <asp:Label ID="lblLeaveTotalinUtilization" runat="server" Text="0/0">  </asp:Label></span>
                                )</div>
                             <div class="divGroupBlockBody"> 

                                  <telerik:RadChart ID="radChartLeaveUtilization" runat="server" Skin="Colorful" Width="680px">
                        <Appearance>
                            <Border Visible="False" Width="0" />
                        </Appearance>
                        <Series>
                            <telerik:ChartSeries Name="Series 1">
                                <Appearance>
                                    <FillStyle MainColor="255, 186, 74" SecondColor="255, 244, 227">
                                    </FillStyle>
                                    <Border Color="DimGray" />
                                </Appearance>
                            </telerik:ChartSeries>
                            <telerik:ChartSeries Name="Series 2">
                                <Appearance>
                                    <FillStyle MainColor="21, 197, 22" SecondColor="218, 246, 218">
                                    </FillStyle>
                                    <Border Color="DimGray" />
                                </Appearance>
                            </telerik:ChartSeries>
                        </Series>
                        <Legend>
                            <Appearance>
                                <ItemTextAppearance TextProperties-Color="DimGray">
                                </ItemTextAppearance>
                                <Border Color="DimGray" />
                            </Appearance>
                        </Legend>
                        <PlotArea>
                            <XAxis>
                                <Appearance>
                                    <MajorGridLines Color="DimGray" Width="0" />
                                </Appearance>
                                <AxisLabel>
                                    <TextBlock>
                                        <Appearance TextProperties-Font="Verdana, 9.75pt, style=Bold">
                                        </Appearance>
                                    </TextBlock>
                                </AxisLabel>
                            </XAxis>
                            <YAxis>
                                <Appearance>
                                    <MajorGridLines Color="DimGray" />
                                </Appearance>
                                <AxisLabel>
                                    <TextBlock>
                                        <Appearance TextProperties-Font="Verdana, 9.75pt, style=Bold">
                                        </Appearance>
                                    </TextBlock>
                                </AxisLabel>
                            </YAxis>
                            <YAxis2>
                                <AxisLabel>
                                    <TextBlock>
                                        <Appearance TextProperties-Font="Verdana, 9.75pt, style=Bold">
                                        </Appearance>
                                    </TextBlock>
                                </AxisLabel>
                            </YAxis2>
                            <Appearance Corners="Round, Round, Round, Round, 6">
                                <FillStyle FillType="Solid" MainColor="White">
                                </FillStyle>
                                <Border Color="DimGray" />
                            </Appearance>
                        </PlotArea>
                        <ChartTitle Visible="False">
                            <Appearance Visible="False" Position-AlignedPosition="Top" Corners="Round, Round, Round, Round, 6"
                                Dimensions-Margins="4%, 10px, 14px, 0%">
                                <FillStyle GammaCorrection="False" MainColor="224, 224, 224">
                                </FillStyle>
                                <Border Color="DimGray" />
                            </Appearance>
                            <TextBlock Visible="False">
                                <Appearance TextProperties-Font="Verdana, 11.25pt">
                                </Appearance>
                            </TextBlock>
                        </ChartTitle>
                    </telerik:RadChart>

                            </div>
                        </div>

                    </td>
                    <td>

                         <div class="divGroupBlockHeaderSmall">Company Event Calendar (<span style="color:#ff0000"><asp:Label ID="Label2" runat="server" Text="0000"></asp:Label></span>)</div>
                             <div class="divGroupBlockBody">
                                 <center>
                                 <telerik:RadCalendar ID="RadCalendar1" runat="server" Skin="Silk" Width="200px" EnableMultiSelect="False" EnableWeekends="True" FastNavigationNextText="&amp;lt;&amp;lt;" SelectedDate="">
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
                                     </center>
                             </div>

                         <div class="divGroupBlockHeaderSmall">  
                                Detail Leave Calendar (<span style="color:#ff0000"> <asp:Label ID="lblFinancialYear1" runat="server" Text="0000">  </asp:Label></span>
                                )                     
                             </div>
                            <div class="divGroupBlockBody">                           
                                <asp:HyperLink ID="Label1" NavigateUrl="leave_calander.aspx" runat="server"  Text="Click Here To View" style="font-size: 14px; color: #3399FF"></asp:HyperLink>
                             </div>




                    </td>
                </tr>

            </table>


        </div>
    </div> 
</asp:Content>
