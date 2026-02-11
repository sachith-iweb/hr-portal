using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN
{
    public class DesignationWiseLeaveTypeDetails
    {
        private int designationWiseLeaveTypeID;
        private int companyID;
        private int designationID;
        private int leaveTypeID;
        private bool isActive;
        private int createdUserId;
        private int modifiedUserId;

        //Get Set Methods

        public int DesignationWiseLeaveTypeID
        {
            get { return designationWiseLeaveTypeID; }
            set { designationWiseLeaveTypeID = value; }
        }

        public int CompanyID
        {
            get { return companyID; }
            set { companyID = value; }
        }

        public int DesignationID
        {
            get { return designationID; }
            set { designationID = value; }
        }

        public int LeaveTypeID
        {
            get { return leaveTypeID; }
            set { leaveTypeID = value; }
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public int CreatedUserId
        {
            get { return createdUserId; }
            set { createdUserId = value; }
        }

        public int ModifiedUserId
        {
            get { return modifiedUserId; }
            set { modifiedUserId = value; }
        }
    }
}
