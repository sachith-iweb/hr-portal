using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DOMAIN;

namespace DATA
{
    public class ProfileHeaderEntry
    {
        public DataTable SelectProfileHeader(int employeeId)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add("@UserId", employeeId);
                return DataBaseUtilities.DataBaseUtilities.Select("EmployeeProfile_SelectEmployeeProfileHeaderDetails",spParameters);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}