using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace DATA
{
    public class OverviewEntry
    {
        public DataTable SelectCompanyLeaveCalander(string companyId)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add("@CompanyId", companyId);
            return DataBaseUtilities.DataBaseUtilities.Select("EmployeeProfile_SelectCompanyLeaveCalander",spParameters);
        }

        public DataTable SelectLeaveAllocationAndBalace(string employeeId)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add("@EmployeeId", employeeId);
            return DataBaseUtilities.DataBaseUtilities.Select("EmployeeProfile_SelectEmployeeLeaveAllocationAndBalance", spParameters);
        }

        public DataTable SelectEmployeeNotifications(string employeeId, string id)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add("@Id", id);
            spParameters.Add("@EmployeeId", employeeId);
            return DataBaseUtilities.DataBaseUtilities.Select("EmployeeProfile_SelectEmployeeNotifications", spParameters);
        }

        public void UpdateEmployeeNotificationsReadStatus(string employeeId, string id)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add("@EmployeeId", employeeId);
            spParameters.Add("@Id", id);
            DataBaseUtilities.DataBaseUtilities.Insert("EmployeeProfile_UpdateEmployeeNotificationsReadStatus", spParameters);
        }


        public DataTable SelectEmployeeLeaveUtilization(string employeeId)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add("@EmployeeId", employeeId);
            return DataBaseUtilities.DataBaseUtilities.Select("EmployeeProfile_SelectEmployeeLeaveUtilization", spParameters);
        }


    }
}