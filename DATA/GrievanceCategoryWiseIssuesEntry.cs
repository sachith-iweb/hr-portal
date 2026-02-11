using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;
using System.Data;

namespace DATA
{
    public class GrievanceCategoryWiseIssuesEntry
    {
        public void Insert(GrievanceCategoryWiseIssues grievanceCategoryWiseIssues, string operation)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add("@Id", grievanceCategoryWiseIssues.Id);
            spParameters.Add("@Name", grievanceCategoryWiseIssues.Name);
            spParameters.Add("@IsActive", grievanceCategoryWiseIssues.IsActive);
            spParameters.Add("@UserId", grievanceCategoryWiseIssues.UserId);
            spParameters.Add("@Operations", operation);
            spParameters.Add("@GrievanceCategoryId", grievanceCategoryWiseIssues.GrievanceCategoryId);
            DataBaseUtilities.DataBaseUtilities.Insert("InsertGrievanceCategoryWiseIssues", spParameters);
        }

        public DataTable Select(GrievanceCategoryWiseIssues grievanceCategoryWiseIssues)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add("@Id", grievanceCategoryWiseIssues.Id);
            spParameters.Add("@Name", grievanceCategoryWiseIssues.Name);
            spParameters.Add("@IsActive", grievanceCategoryWiseIssues.IsActive);
            spParameters.Add("@GrievanceCategoryId", grievanceCategoryWiseIssues.GrievanceCategoryId);
            return DataBaseUtilities.DataBaseUtilities.Select("SelectGrievanceCategoryWiseIssues", spParameters);
        }

        public void Delete(GrievanceCategoryWiseIssues grievanceCategoryWiseIssues)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add("@Id", grievanceCategoryWiseIssues.Id);
            DataBaseUtilities.DataBaseUtilities.Delete("DeleteGrievanceCategoryWiseIssues", spParameters);
        }
    }
}
