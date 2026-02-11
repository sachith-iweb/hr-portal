using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DATA.DataBaseUtilities;
using System.Data;

namespace DATA
{
    public class EmployeeWiseBenifitsAndAssestsEntry
    {
        public DataTable SelectBenifitHeader(string employeeId)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add("@EmployeeId", employeeId);
            return DataBaseUtilities.DataBaseUtilities.Select("EmployeeProfile_SelectThisEmployeeWiseBenifitHeaderDetails", spParameters);
        }
    }
}