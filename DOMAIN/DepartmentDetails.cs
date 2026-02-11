using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN
{
   public class DepartmentDetails
    {
        private int departmentId;
        public int DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }

        private int companyId;
        public int CompanyId
        {
            get { return companyId; }
            set { companyId = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private bool isActive;
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        private int userId;
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }     
    }
}
