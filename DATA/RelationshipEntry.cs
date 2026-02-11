using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DOMAIN;

namespace DATA
{
    public class RelationshipEntry
    {
        public DataTable SelectCivilStatus()
        {
            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllCivilStatusDetails");
        }

        public DataTable SelectRelationships()
        {
            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllRelationshipDetails");
        }

        public DataTable SelectEmployeeWiseRelationshipDetails(int employeeId)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add("@EmployeeId", employeeId);            
            return DataBaseUtilities.DataBaseUtilities.Select("EmployeeProfile_SelectEmployeeWiseRelationshipDetails", spParameters);
        }

        public DataTable SelectEmployeeWiseRelationshipDetailsNotApproved(int employeeId, int employeeWiseRelationshipId)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add("@EmployeeId", employeeId);
            spParameters.Add("@EmployeeWiseRelationshipId", employeeWiseRelationshipId);
            return DataBaseUtilities.DataBaseUtilities.Select("EmployeeProfile_SelectEmployeeWiseRelationshipDetailsNotApproved", spParameters);
        }

        public void Insert(EmployeeWiseRelationshipDetails employeeWiseRelationshipDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.EmployeeWiseRelationshipDetails.Address, employeeWiseRelationshipDetails.Address);
            spParameters.Add(WellKnownParameters.EmployeeWiseRelationshipDetails.CivilStatusId, employeeWiseRelationshipDetails.CivilStatusId);
            spParameters.Add(WellKnownParameters.EmployeeWiseRelationshipDetails.DateOfBirth, employeeWiseRelationshipDetails.DateOfBirth);
            spParameters.Add(WellKnownParameters.EmployeeWiseRelationshipDetails.Email, employeeWiseRelationshipDetails.Email);
            spParameters.Add(WellKnownParameters.EmployeeWiseRelationshipDetails.EmployeeId, employeeWiseRelationshipDetails.EmployeeId);
            spParameters.Add(WellKnownParameters.EmployeeWiseRelationshipDetails.EmployeeWiseRelationshipId, employeeWiseRelationshipDetails.EmployeeWiseRelationshipId);
            spParameters.Add(WellKnownParameters.EmployeeWiseRelationshipDetails.IsActive, employeeWiseRelationshipDetails.IsActive);
            spParameters.Add(WellKnownParameters.EmployeeWiseRelationshipDetails.Name, employeeWiseRelationshipDetails.Name);       
            spParameters.Add(WellKnownParameters.EmployeeWiseRelationshipDetails.PriorityId, employeeWiseRelationshipDetails.PriorityId);
            spParameters.Add(WellKnownParameters.EmployeeWiseRelationshipDetails.RelationshipId, employeeWiseRelationshipDetails.RelationshipId);
            spParameters.Add(WellKnownParameters.EmployeeWiseRelationshipDetails.Remarks, employeeWiseRelationshipDetails.Remarks);
            spParameters.Add(WellKnownParameters.EmployeeWiseRelationshipDetails.Telephone, employeeWiseRelationshipDetails.Telephone);
            spParameters.Add(WellKnownParameters.EmployeeWiseRelationshipDetails.UserId, employeeWiseRelationshipDetails.UserId);
            spParameters.Add(WellKnownParameters.EmployeeWiseRelationshipDetails.WorkPlace, employeeWiseRelationshipDetails.WorkPlace);
            spParameters.Add(WellKnownParameters.EmployeeWiseRelationshipDetails.WorkPlaceAddress, employeeWiseRelationshipDetails.WorkPlaceAddress);
            spParameters.Add(WellKnownParameters.EmployeeWiseRelationshipDetails.WorkPlaceTelephoneNumber, employeeWiseRelationshipDetails.WorkPlaceTelephoneNumber);

            DataBaseUtilities.DataBaseUtilities.Insert("EmployeeProfile_InsertEmployeeWiseRelationshipDetails", spParameters);
        }
    }
}