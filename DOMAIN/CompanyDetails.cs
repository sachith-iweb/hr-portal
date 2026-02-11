using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN
{
    public class CompanyDetails
    {
        public CompanyDetails()
        {
        }

        private static int companyId;
        public int CompanyId { get { return companyId; } set { companyId = value; } }

        private string name;
        public string Name { get { return name; } set { name = value; } }

        private bool isActive;
        public bool IsActive { get { return isActive; } set { isActive = value; } }

        private int createdOrModifiedUserId;
        public int CreatedOrModifiedUserId { get { return createdOrModifiedUserId; } set { createdOrModifiedUserId = value; } }
    }
}
