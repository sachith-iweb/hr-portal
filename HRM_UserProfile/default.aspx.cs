using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using SERVICE;
using System.Data;
using Telerik.Web.UI;

namespace HRM_UserProfile
{
    public partial class _default : System.Web.UI.Page
    {
        UserDetails userDetails = new UserDetails();
        UserDetailsService userDetailsService = new UserDetailsService();

        CompanyDetails companyDetails = new CompanyDetails();
        CompanyDetailsService companyDetailsService = new CompanyDetailsService();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                btnLogin.Focus();

                if (Session["CompanyId"] != null)
                {
                    Response.Redirect("overview.aspx",false);
                }

                if (!IsPostBack)
                {
                    //Session["CompanyId"] = "";
                    //Session["CompanyGroup"] = "";
                    //Session["CompanyName"] = ""; 
                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        private void MultipleCompanyAccess()
        {
            try
            {

                companyDetails.CreatedOrModifiedUserId = Convert.ToInt32(Session["UserId"]);

                cmbCompany.DataSource = null;
                cmbCompany.DataBind();

                cmbCompany.DataSource = companyDetailsService.Select(companyDetails);
                cmbCompany.DataTextField = CommonParameterNames.CommonTableColumnNames.CompanyDetails.companyName;
                cmbCompany.DataValueField = CommonParameterNames.CommonTableColumnNames.CompanyDetails.compantId;
                cmbCompany.DataBind();


                RadWindow1.VisibleOnPageLoad = true;
                RadWindow1.Modal = true;
                RadWindow1.Width = 510;
                RadWindow1.Height = 200;

                //RadWindow1.NavigateUrl = "select_company.aspx";
                RadWindow1.Animation = Telerik.Web.UI.WindowAnimation.Fade;

                RadWindowManager1.EnableViewState = true;
                RadWindowManager1.Windows.Add(RadWindow1);
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
         
       
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                userDetails.UserName = txtUsername.Text.Trim().ToLower();
                userDetails.UserPassword = txtPassword.Text.Trim();

                long userId = userDetailsService.ChekLogin(userDetails);
                long employeeId = userDetailsService.GetEmployeeId(userDetails);

                if (userId != -999)
                {
                    userDetails.UserId = Convert.ToInt32(userId);
                    lblMessage.Visible = false;

                    Session["HomePageLoadCount"] = 1;

                    Session["Username"] = userDetails.UserName;
                    Session["UserId"] = userId;

                    DataTable dt = userDetailsService.GetEmployeeName(userDetails);

                    Session["NameWithInitials"] = dt.Rows[0]["NameWithInitials"].ToString();
                    Session["EmployeeId"] = employeeId;

                    Session["EmployeeCode"] = txtUsername.Text.Trim();
                    Session["EmployeePassword"] = txtPassword.Text.Trim();

                    Session["CompanyId"] = dt.Rows[0]["CompanyID"].ToString();
                    Session["CompanyName"] = dt.Rows[0]["CompanyName"].ToString();

                    Response.Redirect("overview.aspx", false);

                    //DataTable dtCompanyDetails = userDetailsService.UserWiseCompanyAccsessDetails(userDetails);

                    //if (dtCompanyDetails.Rows.Count > 0)
                    //{
                    //    Session["CompanyId"] = dtCompanyDetails.Rows[0]["CompanyId"];
                    //    Session["CompanyName"] = dtCompanyDetails.Rows[0]["CompanyName"];
                    //}

                    //if (dtCompanyDetails.Rows.Count > 1)
                    //{
                    //    MultipleCompanyAccess();
                    //}
                    //else if (dtCompanyDetails.Rows.Count == 1)
                    //{
                    //    Session["CompanyGroup"] = false;

                    //    if (userDetailsService.UserWiseCompanyAccsessDetails(userDetails).Rows.Count > 0)
                    //        Session["CompanyId"] = userDetailsService.UserWiseCompanyAccsessDetails(userDetails).Rows[0]["CompanyId"].ToString();
                    //    Response.Redirect("overview.aspx", false);
                    //}
                    //else
                    //{
                    //    lblMessage.Text = "No company assign to this user.";
                    //    lblMessage.Visible = true;
                    //    ResetInputs(true);
                    //}
                }
                else
                {
                    lblMessage.Text = "Username or Password incorrect.";
                    lblMessage.Visible = true;
                    ResetInputs(true);
                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
         
        }

        private void ResetInputs(bool p)
        {
            try
            {
                if (p)
                {
                    txtPassword.Text = "";
                    txtUsername.Text = "";
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
            //if (cmbCompany.SelectedIndex > 0)
            //{
            //    Session["CompanyId"] = cmbCompany.SelectedValue;
            //    Session["CompanyGroup"] = true;
            //    Session["CompanyName"] = cmbCompany.Text;
            //}
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            if (cmbCompany.SelectedIndex > 0)
            {
                Session["CompanyId"] = cmbCompany.SelectedValue;
                Session["CompanyGroup"] = true;
                Session["CompanyName"] = cmbCompany.Text;

                Response.Redirect("overview.aspx?cid=" + cmbCompany.SelectedValue + "&cn=" + cmbCompany.Text + "&cg=1");
                // Page.ClientScript.RegisterClientScriptBlock(GetType(), "CloseScript", "refreshParentPage()", true);

            }
            else
            {
                Session["CompanyId"] = null; ;
                Session["CompanyGroup"] = null;
                Session["CompanyName"] = null;

                // Page.ClientScript.RegisterClientScriptBlock(GetType(), "CloseScript", "CloseThisPage()", true);
            }
        }

       
        
     
      
       
       
    }
}