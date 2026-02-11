using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SERVICE;
using System.Data;

namespace HRM_UserProfile
{
    public partial class notifications : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Request.QueryString.Count > 0)
                    {
                        if (Request.QueryString["id"] != null)
                        {
                            FillNotifications(Request.QueryString["id"].ToString());

                            if (Request.QueryString["status"] != null)
                            {
                                if (Request.QueryString["status"] == "0")
                                {
                                    UpdateReadStatus(Request.QueryString["id"].ToString());
                                }

                            }
                        }
                        else
                        {
                            FillNotifications("0");
                        }
                    }
                    else
                    {
                        FillNotifications("0");
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

        private void UpdateReadStatus(string id)
        {
            try
            {
                new OverviewService().UpdateEmployeeNotificationsReadStatus(Session["EmployeeId"].ToString(), id);
                DataBaseTransactions.CommitTransactions();
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        private void FillNotifications(string id)
        {
            try
            {
                radLstNotifications.DataSource = new OverviewService().SelectEmployeeNotifications(Session["EmployeeId"].ToString(), id);
                radLstNotifications.DataBind();
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        protected void radLstNotifications_NeedDataSource(object sender, Telerik.Web.UI.RadListViewNeedDataSourceEventArgs e)
        {
            try
            {
                radLstNotifications.DataSource = new OverviewService().SelectEmployeeNotifications(Session["EmployeeId"].ToString(), "0");
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