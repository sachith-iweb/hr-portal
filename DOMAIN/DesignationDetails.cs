using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN
{
    public class DesignationDetails
    {
        private int designationID;
        private string name;
        private bool isActive;
        private int createdUserID;
        private int modifiedUserID;
        //private string operation;
        private int departmentId;

        public int DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }

        public int DesignationID
        {
            get { return designationID; }
            set { designationID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }

        }

        public int CreatedUserID
        {
            get { return createdUserID; }
            set { createdUserID = value; }
        }

        public int ModifiedUserID
        {
            get { return modifiedUserID; }
            set { modifiedUserID = value; }
        }

        private int companyId;

        public int CompanyId
        {
            get { return companyId; }
            set { companyId = value; }
        }
      
    }
}
