using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN
{
    public class EmployeeWiseAchievementDetails
    {
        private int employeeWiseAchievementId;
        private int employeeID;
        private int yearDate;
        private string achievement;
        private string remarks;
        private bool isActive;
        private int createdUserId;
        private int modifiedUserId;
        private int companyId;

        

        //Get Set Methods

        public int EmployeeWiseAchievementId
        {
            get { return employeeWiseAchievementId; }
            set { employeeWiseAchievementId = value; }
        }

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public int YearDate
        {
            get { return yearDate; }
            set { yearDate = value; }
        }

        public string Achievement
        {
            get { return achievement; }
            set { achievement = value; }
        }

        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
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

        public int CompanyId
        {
            get { return companyId; }
            set { companyId = value; }
        }
    }
}
