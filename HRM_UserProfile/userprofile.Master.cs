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
    public partial class userprofile : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Timeout = 30;
                if ( Session["CompanyId"] == null ||  Session["EmployeeId"] == null || Session["UserId"] == null)
                {
                    Response.Redirect("default.aspx");
                }

               // lblLoggedCompany.Text = Session["CompanyName"].ToString();
                DataTable dtProfileHeaderDetails = new ProfilrHeaderService().SelectProfileHeader(Convert.ToInt32(Session["UserId"]));

                if (dtProfileHeaderDetails.Rows.Count > 0)
                {
                    lblCompanies.Text = dtProfileHeaderDetails.Rows[0]["Companies"].ToString();
                    lblBranch.Text = dtProfileHeaderDetails.Rows[0]["Branch"].ToString();
                    lblCompanyEmail.Text = dtProfileHeaderDetails.Rows[0]["Email"].ToString();
                    lblDepartment.Text = dtProfileHeaderDetails.Rows[0]["Department"].ToString();
                    lblDesignation.Text = dtProfileHeaderDetails.Rows[0]["Designation"].ToString();
                    lblEmployeCode.Text = dtProfileHeaderDetails.Rows[0]["EmployeeCode"].ToString();
                    lblEmployeeName.Text = dtProfileHeaderDetails.Rows[0]["Name"].ToString();
                    lblStatus.Text = dtProfileHeaderDetails.Rows[0]["Status"].ToString();

                    if (dtProfileHeaderDetails.Rows[0]["StatusID"].ToString().ToString() == "4")
                    {
                        for (int i = 0; i < RadMenu1.Items.Count; i++)
                        {

                            if (RadMenu1.Items[i].Value == "E")
                            {
                                RadMenu1.Items[i].Enabled = false;
                            }
                            else
                            {
                                RadMenu1.Items[i].Enabled = true;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < RadMenu1.Items.Count; i++)
                        {
                            if (RadMenu1.Items[i].Value == "E")
                            {
                                RadMenu1.Items[i].Enabled = true;
                            }
                            else
                            {
                                RadMenu1.Items[i].Enabled = false;
                            }
                        }
                    }

                    lblStatus.ForeColor = System.Drawing.Color.FromName(dtProfileHeaderDetails.Rows[0]["StatusColor"].ToString());


                    if (dtProfileHeaderDetails.Rows[0]["ProfileImage"].ToString().Length > 0)
                    {
                        byte[] imgArray = (byte[])dtProfileHeaderDetails.Rows[0]["ProfileImage"];
                        profileImage.Src = "data:image/png;base64," + Convert.ToBase64String(imgArray); 
                    }
                }
                
            }         
             
        }

        protected void btnLogout_Click(object sender, ImageClickEventArgs e)
        {
            Session["CompanyId"] = null;
            Session["EmployeeId"] = null;
            Session["UserId"] = null;

            Response.Redirect("default.aspx");
        }
             
    }
}