using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN
{
    public class EmployeeWiseInterestDetails
    {
        private int employeeWiseInterestId;
        public int EmployeeWiseInterestId
        {
            get { return employeeWiseInterestId; }
            set { employeeWiseInterestId = value; }
        }

        private int employeeId;
        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        private string interest;
        public string Interest
        {
            get { return interest; }
            set { interest = value; }
        }

        private string remarks;
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
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

        private string operation;
        public string Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        private int companyId;

        public int CompanyId
        {
            get { return companyId; }
            set { companyId = value; }
        }

    }
}
