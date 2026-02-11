using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;

using System.Data;

namespace DATA
{
    public class CompanyWiseLeaveUnitsEntry
    {
        public void Insert(CompanyWiseLeaveUnitsDetails companyWiseLeaveUnitsDetails, string operation)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();

            spParameter.Add(WellKnownParameters.CompanyWiseLeaveUnits.CompanyId, companyWiseLeaveUnitsDetails.CompanyId);
            spParameter.Add(WellKnownParameters.CompanyWiseLeaveUnits.CreatedUserId, companyWiseLeaveUnitsDetails.CreatedUserId);
            spParameter.Add(WellKnownParameters.CompanyWiseLeaveUnits.IsActive, companyWiseLeaveUnitsDetails.IsActive);
            spParameter.Add(WellKnownParameters.CompanyWiseLeaveUnits.LeaveUnitId, companyWiseLeaveUnitsDetails.LeaveUnitId);
            spParameter.Add(WellKnownParameters.CompanyWiseLeaveUnits.MaxNoOfUnits, companyWiseLeaveUnitsDetails.MaxNoOfUnits);
            spParameter.Add(WellKnownParameters.CompanyWiseLeaveUnits.ModifiedUserId, companyWiseLeaveUnitsDetails.ModifiedUserId);
            spParameter.Add(WellKnownParameters.CompanyWiseLeaveUnits.Operation, operation);
            spParameter.Add(WellKnownParameters.CompanyWiseLeaveUnits.UnitName, companyWiseLeaveUnitsDetails.UnitName);
            spParameter.Add(WellKnownParameters.CompanyWiseLeaveUnits.Value, companyWiseLeaveUnitsDetails.Value);

            DataBaseUtilities.DataBaseUtilities.Insert("InsertCompanyWiseLeaveUnits", spParameter);
        }

        public DataTable Select(CompanyWiseLeaveUnitsDetails companyWiseLeaveUnitsDetails)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.CompanyWiseLeaveUnits.CompanyId, companyWiseLeaveUnitsDetails.CompanyId);

            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllCompanyWiseLeaveUnits", spParameter);
        }

        public DataTable SelectThisCompanyWiseLeaveUnitsByLeaveUnit(CompanyWiseLeaveUnitsDetails companyWiseLeaveUnitsDetails)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.CompanyWiseLeaveUnits.LeaveUnitId, companyWiseLeaveUnitsDetails.LeaveUnitId);
            return DataBaseUtilities.DataBaseUtilities.Select("SelectThisCompanyWiseLeaveUnitsByLeaveUnit", spParameter);
        }

        public DataTable SelectThis(CompanyWiseLeaveUnitsDetails companyWiseLeaveUnitsDetails)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.CompanyWiseLeaveUnits.CompanyId, companyWiseLeaveUnitsDetails.CompanyId);
            spParameter.Add(WellKnownParameters.CompanyWiseLeaveUnits.UnitName, companyWiseLeaveUnitsDetails.UnitName);
            spParameter.Add(WellKnownParameters.CompanyWiseLeaveUnits.Value, companyWiseLeaveUnitsDetails.Value);

            return DataBaseUtilities.DataBaseUtilities.Select("SelectThisCompanyWiseLeaveUnits", spParameter);
        }

        public void Delete(CompanyWiseLeaveUnitsDetails companyWiseLeaveUnitsDetails)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.CompanyWiseLeaveUnits.LeaveUnitId, companyWiseLeaveUnitsDetails.LeaveUnitId);

            DataBaseUtilities.DataBaseUtilities.Delete("DeleteCompanyWiseLeaveUnits", spParameter);
        }


    }
}
