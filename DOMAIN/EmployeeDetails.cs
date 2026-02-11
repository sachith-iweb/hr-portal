using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN
{
    public class EmployeeDetails
    {
        #region Variable Collection

        private int employeeID;
        private int companyID;
        private string employeeCode;
        private int titleID;
        private string profileName;
        private string firstName;  
        private string middleName;
        private string lastName;
        private DateTime dateOfBirth;
        private string nameWithInitials;
        private int nationalityID;   
        private int raceID;
        private int religionID;
        private string sex;
        private int civilStatusID;
        private int communicationTypeID1;       
        private string communicationDetail1;
        private int communicationTypeID2;
        private string communicationDetail2;
        private int communicationTypeID3;      
        private string communicationDetail3;
        private int communicationTypeID4;
        private string communicationDetail4;
        private int communicationTypeID5;
        private string communicationDetail5;
        private int designationID;
        private int branchID;
        private int departmentID;
        private int costCenterID;
        private int gradeID;
        private int statusID;
        private int createdUserId;
        private int modifiedUserId;
        private string operation;
        private bool isActive;
        private int classficationHeaderId;
        private int classficationDetailsId;
        private string remarks;
        private int reportingDesignationSlotId;
        private int designationSlotId;
        private int probationPeriod;
        private DateTime dateOfJoin;
        private int workFlowId;

        #endregion

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public int CompanyID
        {
            get { return companyID; }
            set { companyID = value; }
        }

        public string EmployeeCode
        {
            get { return employeeCode; }
            set { employeeCode = value; }
        }
        
        public int TitleID
        {
            get { return titleID; }
            set { titleID = value; }
        }

        public string ProfileName
        {
            get { return profileName; }
            set { profileName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string NameWithInitials
        {
            get { return nameWithInitials; }
            set { nameWithInitials = value; }
        }

        public int NationalityID
        {
            get { return nationalityID; }
            set { nationalityID = value; }
        }

        public int RaceID
        {
            get { return raceID; }
            set { raceID = value; }
        }

        public int ReligionID
        {
            get { return religionID; }
            set { religionID = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public int CivilStatusID
        {
            get { return civilStatusID; }
            set { civilStatusID = value; }
        }

        public int CommunicationTypeID1
        {
            get { return communicationTypeID1; }
            set { communicationTypeID1 = value; }
        }

        public string CommunicationDetail1
        {
            get { return communicationDetail1; }
            set { communicationDetail1 = value; }
        }

        public int CommunicationTypeID2
        {
            get { return communicationTypeID2; }
            set { communicationTypeID2 = value; }
        }

        public string CommunicationDetail2
        {
            get { return communicationDetail2; }
            set { communicationDetail2 = value; }
        }

        public int CommunicationTypeID3
        {
            get { return communicationTypeID3; }
            set { communicationTypeID3 = value; }
        }

        public string CommunicationDetail3
        {
            get { return communicationDetail3; }
            set { communicationDetail3 = value; }
        }

        public int CommunicationTypeID4
        {
            get { return communicationTypeID4; }
            set { communicationTypeID4 = value; }
        }

        public string CommunicationDetail4
        {
            get { return communicationDetail4; }
            set { communicationDetail4 = value; }
        }

        public int CommunicationTypeID5
        {
            get { return communicationTypeID5; }
            set { communicationTypeID5 = value; }
        }

        public string CommunicationDetail5
        {
            get { return communicationDetail5; }
            set { communicationDetail5 = value; }
        }

        public int DesignationID
        {
            get { return designationID; }
            set { designationID = value; }
        }

        public int BranchID
        {
            get { return branchID; }
            set { branchID = value; }
        }

        public int DepartmentID
        {
            get { return departmentID; }
            set { departmentID = value; }
        }

        public int CostCenterID
        {
            get { return costCenterID; }
            set { costCenterID = value; }
        }

        public int GradeID
        {
            get { return gradeID; }
            set { gradeID = value; }
        }

        public int StatusID
        {
            get { return statusID; }
            set { statusID = value; }
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

        public string Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public int ClassficationHeaderId
        {
            get { return classficationHeaderId; }
            set { classficationHeaderId = value; }
        }

        public int ClassficationDetailsId
        {
            get { return classficationDetailsId; }
            set { classficationDetailsId = value; }
        }

        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }

        public int ReportingDesignationSlotId
        {
            get { return reportingDesignationSlotId; }
            set { reportingDesignationSlotId = value; }
        }

        public int DesignationSlotId
        {
            get { return designationSlotId; }
            set { designationSlotId = value; }
        }

        public int ProbationPeriod
        {
            get { return probationPeriod; }
            set { probationPeriod = value; }
        }

        public DateTime DateOfJoin
        {
            get { return dateOfJoin; }
            set { dateOfJoin = value; }
        }

        public int WorkFlowId
        {
            get { return workFlowId; }
            set { workFlowId = value; }
        }


        // For Report
        public DateTime DOBFromDate { get; set; }
        public DateTime DOBToDate { get; set; }

    }
}
