using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Telerik.Web.UI;
using SERVICE;
using jQueryNotification.Helper;

namespace HRM_UserProfile
{
    public partial class overview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    FillLeaveCalander();
                    FillLeaveAllocationAndBalance();
                    FillNotification();
                    FillLeaveUtilizationChart();

                    if (Request.QueryString["cid"] !=null)
                    {                       
                        Session["CompanyId"] = Request.QueryString["cid"].ToString();
                        Session["CompanyGroup"] = Request.QueryString["cg"].ToString();
                        Session["CompanyName"] = Request.QueryString["cn"].ToString();
                    }

                    
                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        private void FillLeaveCalander()
        {
            try
            {
                DataTable dtCompanyLeaveCalander = new OverviewService().SelectCompanyLeaveCalander(Session["CompanyId"].ToString());

                if (dtCompanyLeaveCalander.Rows.Count > 0)
                {
                    lblFinancialYear.Text = dtCompanyLeaveCalander.Rows[0]["FinancialYear"].ToString();
                    lblFinancialYear1.Text = lblFinancialYear.Text;

                    for (int i = 0; i < dtCompanyLeaveCalander.Rows.Count; i++)
                    {
                        RadCalendarDay leaveDay = new RadCalendarDay();
                        leaveDay.Date = Convert.ToDateTime(dtCompanyLeaveCalander.Rows[i]["Date"].ToString());
                        leaveDay.ToolTip = dtCompanyLeaveCalander.Rows[i]["DetailDescrption"].ToString();

                        leaveDay.ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(dtCompanyLeaveCalander.Rows[i]["LeaveColor"].ToString());
                        radLeaveCalander.SpecialDays.Add(leaveDay);
                        leaveDay.IsSelectable = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
        
        private void FillLeaveAllocationAndBalance()
        {
            try
            {
                dgLeaveAllocation.DataSource = new OverviewService().SelectLeaveAllocationAndBalace(Session["EmployeeId"].ToString());
                dgLeaveAllocation.DataBind();

                decimal totalLeaves = 0;
                decimal balanceLeaves = 0;

                for (int i = 0; i < dgLeaveAllocation.Items.Count; i++)
                {
                    totalLeaves += Convert.ToDecimal(dgLeaveAllocation.Items[i]["EntitleDays"].Text);
                    balanceLeaves += Convert.ToDecimal(dgLeaveAllocation.Items[i]["BalanceDays"].Text);
                }

                lblLeaveTotal.Text = Math.Round(totalLeaves - balanceLeaves, 2).ToString() + "/" + Math.Round(totalLeaves, 2).ToString();
                lblLeaveTotalinUtilization.Text = lblLeaveTotal.Text;
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        private void FillNotification()
        {
            try
            {
                DataTable dtNotifications = new OverviewService().SelectEmployeeNotifications(Session["EmployeeId"].ToString(), "0");
                dgLatestNotofications.DataSource = dtNotifications;
                dgLatestNotofications.DataBind();

                if (dtNotifications.Rows.Count > 0)
                {
                    lblUnReadVsReadNotifications.Text = dtNotifications.Rows[0]["UnReadCount"].ToString() + "/" + dtNotifications.Rows[0]["TotalCount"].ToString();

                    for (int i = 0; i < dtNotifications.Rows.Count; i++)
                    {
                        if (!Convert.ToBoolean(dtNotifications.Rows[i]["IsRead"].ToString()))
                        {
                            dgLatestNotofications.Items[i].Font.Bold = true;
                            dgLatestNotofications.Items[i].ForeColor = System.Drawing.Color.Black;
                        }
                        else
                        {
                            dgLatestNotofications.Items[i].Font.Bold = false;
                            dgLatestNotofications.Items[i].ForeColor = System.Drawing.Color.Gray;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
            
        }

        private void FillLeaveUtilizationChart()
        {
            try
            {
                DataTable dtSource = new OverviewService().SelectEmployeeLeaveUtilization(Session["EmployeeId"].ToString());
                if (dtSource.Rows.Count > 0)
                {
                    RadChart chart = (RadChart)(radChartLeaveUtilization);

                    chart.DataSource = dtSource;
                    chart.PlotArea.XAxis.DataLabelsColumn = "LeaveType";
                    chart.PlotArea.Appearance.Border.Width = 0;

                    chart.Series[0].DataYColumn = "EntitleDays";
                    chart.Series[1].DataYColumn = "BalanceDays";

                    chart.Series[0].Name = "Allocated";
                    chart.Series[1].Name = "Used";

                    // chart.Width = 350;


                    chart.DataBind();


                    chart.PlotArea.YAxis.AutoScale = false;
                    chart.PlotArea.YAxis.AxisMode = Telerik.Charting.ChartYAxisMode.Normal;
                    chart.PlotArea.YAxis.Step = 5;
                    chart.PlotArea.YAxis.MaxValue = Convert.ToDouble(dtSource.Rows[0]["MaxEntitleDays"].ToString()) + 10;

                    chart.Series[0].Appearance.FillStyle.MainColor = System.Drawing.Color.DarkRed;
                    chart.Series[0].Appearance.FillStyle.SecondColor = System.Drawing.Color.DarkRed;

                    chart.Series[1].Appearance.FillStyle.MainColor = System.Drawing.Color.DarkGreen;
                    chart.Series[1].Appearance.FillStyle.SecondColor = System.Drawing.Color.DarkGreen;

                    for (int j = 0; j < dtSource.Rows.Count; j++)
                    {
                        chart.Series[0].Items[j].Label.TextBlock.Text = Math.Round(Convert.ToDouble(dtSource.Rows[j]["EntitleDays"].ToString()), 2).ToString();
                        chart.Series[1].Items[j].Label.TextBlock.Text = Math.Round(Convert.ToDouble(dtSource.Rows[j]["BalanceDays"].ToString()), 2).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        protected void dgLatestNotofications_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {
            try
            {
                dgLatestNotofications.DataSource = new OverviewService().SelectEmployeeNotifications(Session["EmployeeId"].ToString(), "0");
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        protected void dgLeaveAllocation_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {
            try
            {
                dgLeaveAllocation.DataSource = new OverviewService().SelectLeaveAllocationAndBalace(Session["EmployeeId"].ToString());
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
    
    }
}