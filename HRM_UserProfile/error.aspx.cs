using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRM_UserProfile
{
    public partial class error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["ErrorMessage"] !=null && Session["StackTrace"] !=null )
                {
                    lblErrorHeader.Text = Session["ErrorMessage"].ToString();
                    lblStackTrace.Text = Session["StackTrace"].ToString(); 
                }
                else
                {
                    lblErrorHeader.Text = "";
                    lblStackTrace.Text = "No details to view";
                }
            }
        }
    }
}