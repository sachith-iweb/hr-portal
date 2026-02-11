using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;

using System.Data;

namespace DATA
{
    public class DesignationWiseLeaveTypeDetailsEntry
    {

        public void Insert(DesignationWiseLeaveTypeDetails designationWiseLeaveTypeDetails, string operation) 
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.DesignationWiseLeaveTypeDetails.CompanyID, designationWiseLeaveTypeDetails.CompanyID);
            spParameter.Add(WellKnownParameters.DesignationWiseLeaveTypeDetails.createdUserId, designationWiseLeaveTypeDetails.CreatedUserId);
            spParameter.Add(WellKnownParameters.DesignationWiseLeaveTypeDetails.DesignationID, designationWiseLeaveTypeDetails.DesignationID);
            spParameter.Add(WellKnownParameters.DesignationWiseLeaveTypeDetails.DesignationWiseLeaveTypeID, designationWiseLeaveTypeDetails.DesignationWiseLeaveTypeID);
            spParameter.Add(WellKnownParameters.DesignationWiseLeaveTypeDetails.isActive, designationWiseLeaveTypeDetails.IsActive);
            spParameter.Add(WellKnownParameters.DesignationWiseLeaveTypeDetails.LeaveTypeID, designationWiseLeaveTypeDetails.LeaveTypeID);
            spParameter.Add(WellKnownParameters.DesignationWiseLeaveTypeDetails.modifiedUserId, designationWiseLeaveTypeDetails.ModifiedUserId);
            spParameter.Add(WellKnownParameters.DesignationWiseLeaveTypeDetails.Operation, operation);

            DataBaseUtilities.DataBaseUtilities.Insert("InsertDesignationWiseLeaveType", spParameter);
        }

        public DataTable Select(DesignationWiseLeaveTypeDetails designationWiseLeaveTypeDetails) 
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.DesignationWiseLeaveTypeDetails.CompanyID, designationWiseLeaveTypeDetails.CompanyID);
            spParameter.Add(WellKnownParameters.DesignationWiseLeaveTypeDetails.modifiedUserId, designationWiseLeaveTypeDetails.ModifiedUserId); // to get current user 
            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllDesignationWiseLeaveType",spParameter);
        }

        public DataTable SelectThis(DesignationWiseLeaveTypeDetails designationWiseLeaveTypeDetails)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.DesignationWiseLeaveTypeDetails.CompanyID, designationWiseLeaveTypeDetails.CompanyID);
            spParameter.Add(WellKnownParameters.DesignationWiseLeaveTypeDetails.DesignationID, designationWiseLeaveTypeDetails.DesignationID);
            spParameter.Add(WellKnownParameters.DesignationWiseLeaveTypeDetails.LeaveTypeID, designationWiseLeaveTypeDetails.LeaveTypeID);
            return DataBaseUtilities.DataBaseUtilities.Select("SelectThisDesignationWiseLeaveType", spParameter);
        }


        public void Delete(DesignationWiseLeaveTypeDetails designationLeaveTypeDetails) 
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();

            spParameter.Add(WellKnownParameters.DesignationWiseLeaveTypeDetails.DesignationWiseLeaveTypeID, designationLeaveTypeDetails.DesignationWiseLeaveTypeID);

            DataBaseUtilities.DataBaseUtilities.Delete("DeleteDesignationWiseLeaveType",spParameter);
        }
    }
}
