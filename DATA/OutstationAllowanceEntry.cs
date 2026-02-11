using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;

using System.Data.SqlClient;
using System.Data;

namespace DATA
{
    public class OutstationAllowanceEntry
    {
        public void Insert(OutstationAllowance outstationAllowance, string operation)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();

            spParameter.Add(WellKnownParameters.OutstationAllowance.outstationAllowanceId, outstationAllowance.OutstationAllowanceId);
            spParameter.Add(WellKnownParameters.OutstationAllowance.requestDate, outstationAllowance.RequestDate);
            spParameter.Add(WellKnownParameters.OutstationAllowance.employeeId, outstationAllowance.EmployeeId);
            spParameter.Add(WellKnownParameters.OutstationAllowance.customer, outstationAllowance.Customer);
            spParameter.Add(WellKnownParameters.OutstationAllowance.reason, outstationAllowance.Reason);
            spParameter.Add(WellKnownParameters.OutstationAllowance.fromDate, outstationAllowance.FromDate);
            spParameter.Add(WellKnownParameters.OutstationAllowance.toDate, outstationAllowance.ToDate);
            spParameter.Add(WellKnownParameters.OutstationAllowance.overstayNights, outstationAllowance.OverstayNights);
            spParameter.Add(WellKnownParameters.OutstationAllowance.holidayNights, outstationAllowance.HolidayNights);
            spParameter.Add(WellKnownParameters.OutstationAllowance.other, outstationAllowance.Other);
            spParameter.Add(WellKnownParameters.OutstationAllowance.status, outstationAllowance.Status);
            spParameter.Add(WellKnownParameters.OutstationAllowance.isActive, outstationAllowance.IsActive);
            spParameter.Add(WellKnownParameters.OutstationAllowance.createdUserId, outstationAllowance.CreatedUserId);
            spParameter.Add(WellKnownParameters.OutstationAllowance.modifiedUserId, outstationAllowance.ModifiedUserId);
            spParameter.Add(WellKnownParameters.OutstationAllowance.operation, operation);

            DataBaseUtilities.DataBaseUtilities.Insert("InsertOutstationAllowance", spParameter);
        }

        public DataTable Select(OutstationAllowance outstationAllowance)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.OutstationAllowance.employeeId, outstationAllowance.EmployeeId);
            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllOutstationAllowance", spParameter);
        }

        public void Delete(OutstationAllowance outstationAllowance)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.OutstationAllowance.outstationAllowanceId, outstationAllowance.OutstationAllowanceId);
            DataBaseUtilities.DataBaseUtilities.Delete("DeleteOutstationAllowance", spParameter);
        }

        public DataTable SelectOutstationAllowanceFlowWiseStatus(int outstationAllowanceId)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add("@OutstationAllowanceId", outstationAllowanceId);
            return DataBaseUtilities.DataBaseUtilities.Select("Select_OutstationAllowanceApprovalFlowStatus", spParameter);
        }
    }
}
