using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA;
using System.Data;
using DOMAIN;

namespace SERVICE
{
    public class LeaveRequestService
    {
        LeaveRequestEntry leaveRequestEntry = new LeaveRequestEntry();

        public void Insert(LeaveRequest leaveRequest)
        {
            leaveRequestEntry.Insert(leaveRequest,"I");
        }

        public void Update(LeaveRequest leaveRequest)
        {
            leaveRequestEntry.Insert(leaveRequest, "U");
        }

        public DataTable Select(LeaveRequest leaveRequest)
        {
            return leaveRequestEntry.Select(leaveRequest);
        }

        public DataTable SelectThis(LeaveRequest leaveRequest)
        {
            return leaveRequestEntry.SelectThis(leaveRequest);
        }

        public void Delete(LeaveRequest leaveRequest)
        {
            leaveRequestEntry.Delete(leaveRequest);
        }

        public DataTable SelectLeaveRequestReport(LeaveRequest leaveRequest)
        {
            return leaveRequestEntry.SelectLeaveRequestReport(leaveRequest);
        }

        public DataTable SelectLeaveRequestFlowWiseStatus(int leaveRequsetId)
        {
            return leaveRequestEntry.SelectLeaveRequestFlowWiseStatus(leaveRequsetId);
        }
    }
}
