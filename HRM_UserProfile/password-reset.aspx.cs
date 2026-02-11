using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using jQueryNotification.Helper;

namespace HRM_UserProfile
{
    public partial class password_reset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtUsername.Text = Session["EmployeeCode"].ToString();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (r1.IsValid && r2.IsValid && r3.IsValid && r5.IsValid)
                {
                    if (txtCurrentPassword.Text.Equals(Session["EmployeePassword"]))
                    {
                        if (txtNewPassword.Text.Trim().Equals(txtNewPasswordAgain.Text.Trim()))
                        {
                            DOMAIN.UserDetails userDetails = new DOMAIN.UserDetails();

                            userDetails.Id = Convert.ToInt32(Session["UserId"].ToString());
                            userDetails.IsActive = true;
                            userDetails.UserId = Convert.ToInt32(Session["UserId"].ToString());
                            //userDetails.UserName = txtUserName.Text.Trim().ToLower();
                            userDetails.UserName = Session["Username"].ToString().Trim();
                            userDetails.EmployeeId = Convert.ToInt32(Session["EmployeeId"].ToString().Trim());
                            userDetails.UserPassword = txtNewPassword.Text.Trim();
                            userDetails.PasswordPolicy = 0;

                            new SERVICE.UserDetailsService().Update(userDetails);
                            SERVICE.DataBaseTransactions.CommitTransactions();
                            this.ShowSuccessfulNotification("Password changed successfully.");
                        }
                        else
                        {
                            this.ShowWarningNotification("New password and re-type password not match.");
                        }
                    }
                    else
                    {
                        this.ShowWarningNotification("Current password invalid.");
                    } 
                }
                else
                {
                    this.ShowWarningNotification("You have missed some required fields.");
                }
            }
            catch (Exception ex)
            {
                SERVICE.DataBaseTransactions.RollbackTransactions();
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx", false);
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtNewPasswordAgain.Text = "";
        }
    }
}