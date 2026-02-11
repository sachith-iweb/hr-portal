using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN
{
    public class EmployeeWiseQualificationDetails
    {
        private int employeeWiseQualificationId;
        private int employeeID;
        private string courseTitle;
        private int educationLevelId;
        private string institute;
        private int yearOfCompletion;
        private string remarks;
        private bool isActive;
        private int createdUserId;
        private int modifiedUserId;
        private int companyId;

       
        //Get Set Methods

        public int EmployeeWiseQualificationId
        {
            get { return employeeWiseQualificationId; }
            set { employeeWiseQualificationId = value; }
        }

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string CourseTitle
        {
            get { return courseTitle; }
            set { courseTitle = value; }
        }

        public int EducationLevelId
        {
            get { return educationLevelId; }
            set { educationLevelId = value; }
        }

        public string Institute
        {
            get { return institute; }
            set { institute = value; }
        }

        public int YearOfCompletion
        {
            get { return yearOfCompletion; }
            set { yearOfCompletion = value; }
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
