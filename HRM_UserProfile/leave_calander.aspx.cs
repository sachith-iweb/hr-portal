using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Telerik.Web.UI;
using SERVICE;

namespace HRM_UserProfile
{
    public partial class leave_calander : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    FillLeaveCalander();
                    FillDetailLeaveDescriptions();
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

                    for (int i = 1; i < dtCompanyLeaveCalander.Rows.Count; i++)
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

        private void FillDetailLeaveDescriptions()
        {
            try
            {
                DataTable dtCompanyLeaveCalander = new OverviewService().SelectCompanyLeaveCalander(Session["CompanyId"].ToString());
                radLstDetailLeaveDescriptions.DataSource = dtCompanyLeaveCalander;
                radLstDetailLeaveDescriptions.DataBind();
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        protected void radLstDetailLeaveDescriptions_NeedDataSource(object sender, RadListViewNeedDataSourceEventArgs e)
        {
            try
            {
                DataTable dtCompanyLeaveCalander = new OverviewService().SelectCompanyLeaveCalander(Session["CompanyId"].ToString());
                radLstDetailLeaveDescriptions.DataSource = dtCompanyLeaveCalander;
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