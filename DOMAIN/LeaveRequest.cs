using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN
{
    public class LeaveRequest
    {
        private int leaveRequestId;
        private DateTime requestDate;
        private int employeeId;
        private int leaveTypeId;
        private char status;
        private DateTime fromDate;
        private DateTime toDate;
        private string remark;
        private int noOfUnits;
        private int leaveUnitId;
        private bool isActive;
        private int createdUserId;      
        private int modifiedUserId;
        private DateTime requestDateTo;
        private DateTime requestDateFrom;
        private int departmentId;  
        private int designationId;

        

        #region Methods -> GET & SET

        public int LeaveRequestId
        {
            get { return leaveRequestId; }
            set { leaveRequestId = value; }
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

        public int LeaveTypeId
        {
            get { return leaveTypeId; }
            set { leaveTypeId = value; }
        }

        public char Status
        {
            get { return status; }
            set { status = value; }
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

        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }

        public double NoOfUnits
        {
            get;
            set;
        }

        public int LeaveUnitId
        {
            get { return leaveUnitId; }
            set { leaveUnitId = value; }
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
        
        public DateTime RequestDateTo
        {
            get { return requestDateTo; }
            set { requestDateTo = value; }
        }
        public DateTime RequestDateFrom
        {
            get { return requestDateFrom; }
            set { requestDateFrom = value; }
        }
        public int DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }

        public int DesignationId
        {
            get { return designationId; }
            set { designationId = value; }
        }

        public int ActingEmployee { get; set; }
        public bool IsSendEmail { get; set; }

        #endregion

    }
}
