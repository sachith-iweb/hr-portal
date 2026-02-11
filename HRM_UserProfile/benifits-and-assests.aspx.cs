using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SERVICE;
using DOMAIN;
using Telerik.Web.UI;

namespace HRM_UserProfile
{
    public partial class benifits_and_assests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    FillGrid();                   
                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

     
        
        private void FillGrid()
        {
            try
            {
                dgBenifts.DataSource = null;
                dgBenifts.DataSource = new EmployeeWiseBenifitsAndAssestsService().SelectBenifitHeader(Session["EmployeeId"].ToString());
                dgBenifts.DataBind();

            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx", false);
            }
        }
        
    }
}