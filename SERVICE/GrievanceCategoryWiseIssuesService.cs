using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;
using DATA;
using System.Data;

namespace SERVICE
{
    public class GrievanceCategoryWiseIssuesService
    {      
        public DataTable Select(GrievanceCategoryWiseIssues grievanceCategoryWiseIssues)
        {
            return new GrievanceCategoryWiseIssuesEntry().Select(grievanceCategoryWiseIssues);
        }
       
    }
}
