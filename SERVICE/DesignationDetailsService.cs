using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA;
using DOMAIN;
using System.Data;

namespace SERVICE
{
    public class DesignationDetailsService
    {
        DesignationDetailsEntry designationDetailsEntry = new DesignationDetailsEntry();

        public DataTable SelectDesigntionsByUsingDepartment(DesignationDetails designationDetails)
        {
            return designationDetailsEntry.SelectDesignationsByDepartments(designationDetails);
        }
    }
}
