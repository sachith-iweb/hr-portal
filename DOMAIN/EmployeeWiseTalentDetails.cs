using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN
{
    public class EmployeeWiseTalentDetails
    {

        public int EmployeeWiseTalentId { get; set; }
        public int EmployeeId { get; set; }
        public int TalentSubCatId { get; set; }
        public string Remarks { get; set; }
        public bool IsActive { get; set; }
        public int User { get; set; }

    }
}
