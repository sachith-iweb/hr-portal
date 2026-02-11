using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN
{
    public class CompanyWiseLeaveUnitsDetails
    {
        private int leaveUnitId;
        private int companyId;
        private string unitName;
        private float value;
        private int maxNoOfUnits;
        private bool isActive;
        private int createdUserId;
        private int modifiedUserId;
        
        public int LeaveUnitId
        {
            get { return leaveUnitId; }
            set { leaveUnitId = value; }
        }

        public int CompanyId
        {
            get { return companyId; }
            set { companyId = value; }
        }

        public string UnitName
        {
            get { return unitName; }
            set { unitName = value; }
        }

        public float Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public int MaxNoOfUnits
        {
            get { return maxNoOfUnits; }
            set { maxNoOfUnits = value; }
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
