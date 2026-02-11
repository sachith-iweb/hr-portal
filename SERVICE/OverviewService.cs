using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DATA;
using System.Data;

namespace SERVICE
{
    public class OverviewService
    {
        public DataTable SelectCompanyLeaveCalander(string companyId)
        {
            return new OverviewEntry().SelectCompanyLeaveCalander(companyId);
        }

        public DataTable SelectLeaveAllocationAndBalace(string employeeId)
        {
            return new OverviewEntry().SelectLeaveAllocationAndBalace(employeeId);
        }

        public DataTable SelectEmployeeNotifications(string employeeId, string id)
        {
            return new OverviewEntry().SelectEmployeeNotifications(employeeId,id);
        }

        public void UpdateEmployeeNotificationsReadStatus(string employeeId, string id)
        {
            new OverviewEntry().UpdateEmployeeNotificationsReadStatus(employeeId, id);
        }

        public DataTable SelectEmployeeLeaveUtilization(string employeeId)
        {
            return new OverviewEntry().SelectEmployeeLeaveUtilization(employeeId);
        }
    }
}