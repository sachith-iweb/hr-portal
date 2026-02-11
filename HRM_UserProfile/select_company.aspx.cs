using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DOMAIN;
using SERVICE;
using Telerik.Web.UI;

namespace HRM_UserProfile
{
    public partial class select_company : System.Web.UI.Page
    {
        CompanyDetails companyDetails = new CompanyDetails();
        CompanyDetailsService companyDetailsService = new CompanyDetailsService();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    companyDetails.CreatedOrModifiedUserId = Convert.ToInt32(Session["UserId"]);

                    cmbCompany.DataSource = null;
                    cmbCompany.DataBind();

                    cmbCompany.DataSource = companyDetailsService.Select(companyDetails);
                    cmbCompany.DataTextField = CommonParameterNames.CommonTableColumnNames.CompanyDetails.companyName;
                    cmbCompany.DataValueField = CommonParameterNames.CommonTableColumnNames.CompanyDetails.compantId;
                    cmbCompany.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCompany.SelectedIndex > 0)
                {
                    //Session["CompanyId"] = cmbCompany.SelectedValue;
                    //Session["CompanyGroup"] = true;
                    //Session["CompanyName"] = cmbCompany.Text;

                    Page.ClientScript.RegisterClientScriptBlock(GetType(), "CloseScript", "refreshParentPage()", true);
                    
                }
                else
                {
                    Session["CompanyId"] = null; ;
                    Session["CompanyGroup"] = null;
                    Session["CompanyName"] = null;

                    // Page.ClientScript.RegisterClientScriptBlock(GetType(), "CloseScript", "CloseThisPage()", true);
                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterClientScriptBlock(GetType(), "CloseScript", "CloseThisPage()", true);
        }

        protected void cmbCompany_DataBound(object sender, EventArgs e)
        {
            cmbCompany.Items.Insert(0, new RadComboBoxItem("------------ Select Company ----------", "0"));
        }

        protected void cmbCompany_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            if (cmbCompany.SelectedIndex > 0)
            {
                Session["CompanyId"] = cmbCompany.SelectedValue;
                Session["CompanyGroup"] = true;
                Session["CompanyName"] = cmbCompany.Text;
            }
        }
    }
}