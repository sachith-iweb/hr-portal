using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DOMAIN;
using DATA;

namespace SERVICE
{
    public class GrievanceCategoriesService
    {
        
        public DataTable Select(GrievanceCategories grievanceCategories)
        {
           return new GrievanceCategoriesEntry().Select(grievanceCategories);
        }
       
    }
}
