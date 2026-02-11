using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;

using System.Data.SqlClient;
using System.Data;

namespace DATA
{
   public class DesignationDetailsEntry
    {       
        public DataTable SelectDesignationsByDepartments(DesignationDetails designationDetails)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.DesignationsByUsingDepartments.CompanyId, designationDetails.CompanyId);
            spParameter.Add(WellKnownParameters.DesignationsByUsingDepartments.DepartmentID, designationDetails.DepartmentId);
            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllDesignationsByUsingDepartments", spParameter);
        }
    }
}
