using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;
using System.Data;

namespace DATA
{
    public class GrievanceActionsEntry
    {
        public void Insert(GrievanceActions grievanceActions,string operation)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add("@Operation", operation);
            spParameters.Add("@Name", grievanceActions.Name);
            spParameters.Add("@IsActive", grievanceActions.IsActive);
            spParameters.Add("@UserId", grievanceActions.UserId);
            spParameters.Add("@Id", grievanceActions.Id);
            DataBaseUtilities.DataBaseUtilities.Insert("InsertGrievanceActions", spParameters);
        }

        public DataTable Select(GrievanceActions grievanceActions)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();           
            spParameters.Add("@Name", grievanceActions.Name);
            spParameters.Add("@IsActive", grievanceActions.IsActive);            
            spParameters.Add("@Id", grievanceActions.Id);
            return DataBaseUtilities.DataBaseUtilities.Select("SelectGrievanceActions", spParameters);
        }

        public void Delete(GrievanceActions grievanceActions)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();  
            spParameters.Add("@Id", grievanceActions.Id);
            DataBaseUtilities.DataBaseUtilities.Insert("DeleteGrievanceActions", spParameters);
        }
    }
}
