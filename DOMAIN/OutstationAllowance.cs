using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN
{
    public class OutstationAllowance
    {
        private int outstationAllowanceId;
        private DateTime requestDate;
        private int employeeId;
        private string customer;
        private string reason;
        private DateTime fromDate;
        private DateTime toDate;
        private int overstayNights;
        private int holidayNights;
        private int other;
        private char status;
        private bool isActive;
        private int createdUserId;
        private int modifiedUserId;

        #region Methods -> GET & SET

        public int OutstationAllowanceId
        {
            get { return outstationAllowanceId; }
            set { outstationAllowanceId = value; }
        }

        public DateTime RequestDate
        {
            get { return requestDate; }
            set { requestDate = value; }
        }

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }

        public DateTime FromDate
        {
            get { return fromDate; }
            set { fromDate = value; }
        }

        public DateTime ToDate
        {
            get { return toDate; }
            set { toDate = value; }
        }

        public int OverstayNights
        {
            get { return overstayNights; }
            set { overstayNights = value; }
        }

        public int HolidayNights
        {
            get { return holidayNights; }
            set { holidayNights = value; }
        }

        public int Other
        {
            get { return other; }
            set { other = value; }
        }

        public char Status
        {
            get { return status; }
            set { status = value; }
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

        #endregion

    }
}
