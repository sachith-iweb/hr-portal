using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;

using System.Data.SqlClient;
using System.Data;

namespace DATA
{
    public class LeaveRequestEntry
    {
        public void Insert(LeaveRequest leaveRequest,string operation) 
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();

            spParameter.Add(WellKnownParameters.LeaveRequest.createdUserId, leaveRequest.CreatedUserId);
            spParameter.Add(WellKnownParameters.LeaveRequest.employeeId, leaveRequest.EmployeeId);
            spParameter.Add(WellKnownParameters.LeaveRequest.fromDate, leaveRequest.FromDate);
            spParameter.Add(WellKnownParameters.LeaveRequest.isActive, leaveRequest.IsActive);
            spParameter.Add(WellKnownParameters.LeaveRequest.leaveRequestId, leaveRequest.LeaveRequestId);
            spParameter.Add(WellKnownParameters.LeaveRequest.leaveTypeId, leaveRequest.LeaveTypeId);
            spParameter.Add(WellKnownParameters.LeaveRequest.leaveUnitId, leaveRequest.LeaveUnitId);
            spParameter.Add(WellKnownParameters.LeaveRequest.modifiedUserId, leaveRequest.ModifiedUserId);
            spParameter.Add(WellKnownParameters.LeaveRequest.noOfUnits, leaveRequest.NoOfUnits);
            spParameter.Add(WellKnownParameters.LeaveRequest.operation, operation);
            spParameter.Add(WellKnownParameters.LeaveRequest.remark, leaveRequest.Remark);
            spParameter.Add(WellKnownParameters.LeaveRequest.requestDate, leaveRequest.RequestDate);
            spParameter.Add(WellKnownParameters.LeaveRequest.status, leaveRequest.Status);
            spParameter.Add(WellKnownParameters.LeaveRequest.toDate, leaveRequest.ToDate);
            spParameter.Add("@IsSendEmail", leaveRequest.IsSendEmail);
            spParameter.Add("@ActingEmployeeId", leaveRequest.ActingEmployee);

            DataBaseUtilities.DataBaseUtilities.Insert("InsertLeaveRequest", spParameter);
            
        }

        public DataTable Select(LeaveRequest leaveRequest) 
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.LeaveRequest.employeeId, leaveRequest.EmployeeId);
            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllLeaveRequest", spParameter);
        }

        public DataTable SelectThis(LeaveRequest leaveRequest)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.LeaveRequest.employeeId, leaveRequest.EmployeeId);
            spParameter.Add(WellKnownParameters.LeaveRequest.toDate, leaveRequest.ToDate);
            spParameter.Add(WellKnownParameters.LeaveRequest.fromDate, leaveRequest.FromDate);

            return DataBaseUtilities.DataBaseUtilities.Select("SelectThisLeaveRequest", spParameter);
        }

        public DataTable SelectLeaveRequestReport(LeaveRequest leaveRequest) 
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();

            spParameter.Add(WellKnownParameters.LeaveRequest.requestDateTo, leaveRequest.RequestDateTo);
            spParameter.Add(WellKnownParameters.LeaveRequest.requestDateFrom, leaveRequest.RequestDateFrom);
            spParameter.Add(WellKnownParameters.LeaveRequest.employeeId, leaveRequest.EmployeeId);
            spParameter.Add(WellKnownParameters.LeaveRequest.leaveTypeId, leaveRequest.LeaveTypeId);
            spParameter.Add(WellKnownParameters.LeaveRequest.status, leaveRequest.Status);
            spParameter.Add(WellKnownParameters.LeaveRequest.fromDate, leaveRequest.FromDate);
            spParameter.Add(WellKnownParameters.LeaveRequest.toDate, leaveRequest.ToDate);
            spParameter.Add(WellKnownParameters.LeaveRequest.leaveUnitId, leaveRequest.LeaveUnitId);
            spParameter.Add(WellKnownParameters.LeaveRequest.departmentID, leaveRequest.DepartmentId);
            spParameter.Add(WellKnownParameters.LeaveRequest.designationID, leaveRequest.DesignationId);

            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllLeaveRequestReport", spParameter);
        }

        public void Delete(LeaveRequest leaveRequest) 
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.LeaveRequest.leaveRequestId, leaveRequest.LeaveRequestId);
            DataBaseUtilities.DataBaseUtilities.Delete("DeleteLeaveRequest", spParameter);
        }

        public DataTable SelectLeaveRequestFlowWiseStatus(int leaveRequsetId)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add("@LeaveRequestId", leaveRequsetId);
            return DataBaseUtilities.DataBaseUtilities.Select("Select_LeaveRequestApprovalFlowStatus", spParameter);
        }
    }
}
