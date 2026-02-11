using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;
using System.Data;

namespace DATA
{
    public class EmployeeWiseTalentDetailsEntry
    {
        public void Insert(EmployeeWiseTalentDetails employeeWiseTalentDetails, string operation)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.EmployeeWiseTalentDetails.Remarks, employeeWiseTalentDetails.Remarks);
            spParameter.Add(WellKnownParameters.EmployeeWiseTalentDetails.EmployeeId, employeeWiseTalentDetails.EmployeeId);
            spParameter.Add(WellKnownParameters.EmployeeWiseTalentDetails.EmployeeWiseTalentId, employeeWiseTalentDetails.EmployeeWiseTalentId);
            spParameter.Add(WellKnownParameters.EmployeeWiseTalentDetails.IsActive, employeeWiseTalentDetails.IsActive);
            spParameter.Add(WellKnownParameters.EmployeeWiseTalentDetails.Operation, operation);
            spParameter.Add(WellKnownParameters.EmployeeWiseTalentDetails.TalentSubCatId, employeeWiseTalentDetails.TalentSubCatId);
            spParameter.Add(WellKnownParameters.EmployeeWiseTalentDetails.User, employeeWiseTalentDetails.User);

            DataBaseUtilities.DataBaseUtilities.Insert("InsertEmployeeWiseTalent", spParameter);
        }

        public DataTable SelectAll(string employeeId)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.EmployeeWiseTalentDetails.EmployeeId, employeeId);
            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllEmployeeWiseTalent",spParameter);
        }

      
        public void Delete(EmployeeWiseTalentDetails employeeWiseTalentDetails)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.EmployeeWiseTalentDetails.EmployeeWiseTalentId, employeeWiseTalentDetails.EmployeeWiseTalentId);

            DataBaseUtilities.DataBaseUtilities.Delete("DeleteEmployeeWiseTalent",spParameter);
        }
    }
}
