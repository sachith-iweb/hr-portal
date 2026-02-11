using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;

using System.Data;

namespace DATA
{
    public class DepartmentDetailsEntry
    {
        

        public DataTable SelectAllActiveDepartment(DepartmentDetails departmentDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.DepartmentDetails.CompanyId, departmentDetails.CompanyId);

            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllActiveDepartmentDetails", spParameters);
        }

        
    }
}
