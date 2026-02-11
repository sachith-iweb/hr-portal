using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class cntrl_YearPicker : System.Web.UI.UserControl
    {
        List<int> yearGen = new List<int>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                FillCombobox();
                cmbYearPicker.SelectedValue = (DateTime.Now.Year).ToString();
            }
        }

        private void YearGenarator() 
        {
            for (int year = 1990; year <= 2100; year++) 
            {
                yearGen.Add(year);
            }
        }

        private void FillCombobox() 
        {
            YearGenarator();
            cmbYearPicker.DataSource = yearGen;
            cmbYearPicker.DataBind();
        }

        public int SelectedYear() 
        {
            return Convert.ToInt32(cmbYearPicker.SelectedValue);
        }

        public void GridYear(int year) 
        {
            cmbYearPicker.SelectedValue = year.ToString();
        }
    }
}