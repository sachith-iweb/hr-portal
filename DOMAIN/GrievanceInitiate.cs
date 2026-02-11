using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN
{
    public class GrievanceInitiate
    {
        public int CompanyId { get; set; }
      
        public int EmployeeId { get; set; }
        public int GrievanceCategoryId { get; set; }
        public string Description { get; set; }
        public string GrievanceSummary { get; set; }
        public int UserId { get; set; }
        public int PreferredResolvingApprochId { get; set; }
    }
}
