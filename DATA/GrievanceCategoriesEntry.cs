using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DOMAIN;

namespace DATA
{
    public class GrievanceCategoriesEntry
    {
        public void Insert(GrievanceCategories grievanceCategories, string operation)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add("@Id", grievanceCategories.Id);
            spParameters.Add("@Name", grievanceCategories.Name);
            spParameters.Add("@Description", grievanceCategories.Description);
            spParameters.Add("@IsActive", grievanceCategories.IsActive);
            spParameters.Add("@UserId", grievanceCategories.UserId);
            spParameters.Add("@Operation", operation);
            DataBaseUtilities.DataBaseUtilities.Insert("InsertGrievanceCategories", spParameters);
        }

        public DataTable Select(GrievanceCategories grievanceCategories)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add("@Id", grievanceCategories.Id);
            spParameters.Add("@Name", grievanceCategories.Name);          
            spParameters.Add("@IsActive", grievanceCategories.IsActive);
            return DataBaseUtilities.DataBaseUtilities.Select("SelectGrievanceCategories", spParameters);
        }

        public void Delete(GrievanceCategories grievanceCategories)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add("@Id", grievanceCategories.Id);
            DataBaseUtilities.DataBaseUtilities.Insert("DeleteGrievanceCategories", spParameters);
        }
    }
}
