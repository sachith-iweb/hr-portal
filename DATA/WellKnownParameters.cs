using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DATA
{
    public static class WellKnownParameters
    {
        internal static class TerminationFeedbackAnswers
        {
            public static string TerminationFeedbackQuestionWiseAnswersId = "@TerminationFeedbackQuestionWiseAnswersId";
            public static string QuestionId = "@QuestionId";
            public static string ListOfValueHeaderId = "@ListOfValueHeaderId";
            public static string BoundValue = "@BoundValue";
            public static string DisplayValue = "@DisplayValue";
            public static string Remark = "@Remark";
            public static string User = "@User";
            public static string Operation = "@Operation";
        }
        internal static class TerminationFeedback
        {
            public static string TerminationFeedBackQId = "@TerminationFeedBackQId";
            public static string Question = "@Question";
            public static string ListValueHeaderId = "@ListValueHeaderId";
            public static string IsActive = "@IsActive";
            public static string Operation = "@Operation";
            public static string User = "@User";
        }
        internal static class ListOfAttributes
        {
            public static string Id = "@Id";
            public static string DetailId = "@DetailId";
            public static string Name = "@Name";
            public static string IsActive = "@IsActive";
            public static string UserId = "@UserId";
            public static string DisplayValue = "@DisplayValue";
            public static string BoundValue = "@BoundValue";
            public static string Operation = "@Operation";
            public static string HeaderId = "@HeaderId";

        }
        internal static class EmployeeWiseTalentDetails
        {
            public static string EmployeeWiseTalentId = "@EmployeeWiseTalentId";
            public static string EmployeeId = "@EmployeeId";
            public static string TalentSubCatId = "@TalentSubCatId";
            public static string @Remarks = "@Remarks";
            public static string IsActive = "@IsActive";
            public static string User = "@User";
            public static string Operation = "@Operation";
        }
        internal static class TalentSubCategoryDetails
        {
            public static string TalentSubCategoryId = "@TalentSubCategoryId";
            public static string TalentCategoryId = "@TalentCategoryId";
            public static string TalentSubCatName = "@TalentSubCatName";
            public static string IsActive = "@IsActive";
            public static string UserId = "@UserId";
            public static string Operation = "@Operation";
        }
        internal static class TalentCategoryDetails
        {
            public static string TalentCategoryId = "@TalentCategoryId";
            public static string TalentCatName = "@TalentCatName";
            public static string IsActive = "@IsActive";
            public static string UserId = "@UserId";
            public static string Operation = "@Operation";
        }
        internal static class DepartmentDetails
        {
            public const string DepartmentId = "@DepartmentId ";
            public const string CompanyId = "@CompanyId";
            public const string Name = "@Name";
            public const string IsActive = "@IsActive";
            public const string UserId = "@UserId";
            public const string Operation = "@Operation";
        }
        internal static class DesignationsByUsingDepartments
        {
            public const string DepartmentID = "@DepartmentID";
            public const string CompanyId = "@CompanyId";
        }
        internal static class CompanyDetails
        {
            public static string companyId = "@companyID";
            public static string name = "@name";
            public static string isActive = "@isActive";
            public static string userId = "@userId";
            public static string operation = "@operation";

        }
        internal static class CompanyWiseLeaveUnits
        {
            public static string LeaveUnitId = "@LeaveUnitId";
            public static string CompanyId = "@CompanyId";
            public static string UnitName = "@UnitName";
            public static string Value = "@Value";
            public static string MaxNoOfUnits = "@MaxNoOfUnits";
            public static string IsActive = "@IsActive";
            public static string CreatedUserId = "@CreatedUserId";
            public static string ModifiedUserId = "@ModifiedUserId";
            public static string Operation = "@Operation";
        }
        internal static class EmployeeDetails
        {
            public const string employeeID = "@employeeID";
            public const string companyId = "@companyId";
            public const string employeeCode = "@employeeCode";
            public const string titleID = "@titleID";
            public const string profileName = "@profileName";
            public const string firstName = "@firstName";
            public const string middleName = "@middleName";
            public const string lastName = "@lastName";
            public const string dateOfBirth = "@dateOfBirth";
            public const string nameWithInitials = "@nameWithInitials";
            public const string nationalityID = "@nationalityID";
            public const string raceID = "@raceID";
            public const string religionID = "@religionID";
            public const string sex = "@sex";
            public const string civilStatusID = "@civilStatusID";
            public const string communicationTypeID1 = "@communicationTypeID1";
            public const string communicationDetail1 = "@communicationDetail1";
            public const string communicationTypeID2 = "@communicationTypeID2";
            public const string communicationDetail2 = "@communicationDetail2";
            public const string communicationTypeID3 = "@communicationTypeID3";
            public const string communicationDetail3 = "@communicationDetail3";
            public const string communicationTypeID4 = "@communicationTypeID4";
            public const string communicationDetail4 = "@communicationDetail4";
            public const string communicationTypeID5 = "@communicationTypeID5";
            public const string communicationDetail5 = "@communicationDetail5";
            public const string designationID = "@designationID";
            public const string branchID = "@branchID";
            public const string departmentID = "@departmentID";
            public const string costCenterID = "@costCenterID";
            public const string gradeID = "@gradeID";
            public const string statusID = "@statusID";
            public const string isActive = "@isActive";
            public const string createdUserId = "@createdUserId";
            public const string modifiedUserId = "@modifiedUserId";
            public const string Operation = "@Operation";
            public const string ClassificationHeaderId = "@ClassificationHeaderId";
            public const string ClassifiactionDetailsId = "@ClassifiactionDetailsId";
            public const string Remarks = "@Remarks ";
            public const string ReportingDesignationSlotId = "@reportingDesignationSlotId";
            public const string DesignationSlotId = "@designationSlotId";
            public const string dateOfJoin = "@dateOfJoin";
            public const string probationPeriod = "@probationPeriod";
            public const string workFlowId = "@WorkFlowId";

            //for report
            public const string DOBFromDate = "@DOBFromDate";
            public const string DOBToDate = "@DOBToDate";

            //for procees allocation
            public const string UserId = "@UserId";
            public const string processId = "@processId";

        }
        internal static class DesignationWiseLeaveTypeDetails
        {
            public const string DesignationWiseLeaveTypeID = "@designationWiseLeaveTypeID";
            public const string CompanyID = "@companyID";
            public const string EmployeeId = "@EmployeeId";
            public const string DesignationID = "@designationID";
            public const string LeaveTypeID = "@leaveTypeID";
            public const string isActive = "@isActive";
            public const string createdUserId = "@createdUserID";
            public const string modifiedUserId = "@modifiedUserID";
            public const string Operation = "@Operation";
        }
        internal static class LeaveRequest
        {
            public static string leaveRequestId = "@leaveRequestId";
            public static string requestDate = "@requestDate";
            public static string employeeId = "@employeeId"; //employeeId
            public static string leaveTypeId = "@leaveTypeId";
            public static string status = "@status";
            public static string fromDate = "@fromDate";
            public static string toDate = "@toDate";
            public static string remark = "@remark";
            public static string noOfUnits = "@noOfUnits";
            public static string leaveUnitId = "@leaveUnitId";
            public static string isActive = "@isActive";
            public static string createdUserId = "@createdUserId";
            public static string modifiedUserId = "@modifiedUserId";
            public static string operation = "@Operation";

            // Report
            public static string requestDateTo = "@requestDateTo";
            public static string requestDateFrom = "@requestDateFrom";
            public const string departmentID = "@departmentID";
            public const string designationID = "@designationID";

        }
        internal static class OutstationAllowance
        {
            public static string outstationAllowanceId = "@outstationAllowanceId";
            public static string requestDate = "@requestDate";
            public static string employeeId = "@employeeId";
            public static string customer = "@customer";
            public static string reason = "@reason";
            public static string fromDate = "@fromDate";
            public static string toDate = "@toDate";
            public static string overstayNights = "@overstayNights";
            public static string holidayNights = "@holidayNights";
            public static string other = "@other";
            public static string status = "@status";
            public static string isActive = "@isActive";
            public static string createdUserId = "@createdUserId";
            public static string modifiedUserId = "@modifiedUserId";
            public static string operation = "@Operation";
        }
        internal static class Userdetails
        {
            public const string Id = "@Id";
            public const string userId = "@userId";
            public const string UserName = "@UserName";
            public const string UserPass = "@password";
            public const string EmployeeId = "@EmployeeId";
            public const string IsFirstTime = "@IsFirstTime";
            public const string QuationCode1 = "@QuationCode1";
            public const string QuationCode2 = "@QuationCode2";
            public const string Answer1 = "@Answer1";
            public const string Answer2 = "@Answer2";
            public const string Operation = "@Operation";
            public const string sysType = "@sysType";
            public const string isActive = "@IsActive";
        }
        internal static class EmployeeWiseAchievementDetails
        {
            public const string employeeWiseAchievementId = "@employeeWiseAchievementID";
            public const string employeeID = "@employeeId";
            public const string yearDate = "@yearDate";
            public const string educationLevelId = "@educationLevelId";
            public const string achievement = "@achievement";
            public const string remarks = "@remarks";
            public const string isActive = "@isActive";
            public const string createdUserId = "@createdUserId";
            public const string modifiedUserId = "@modifiedUserId";
            public const string Operation = "@Operation";
            public const string companyId = "@companyId";
        }

        internal static class EmployeeWiseInterestDetails
        {
            public const string EmployeeWiseInterestId = "@EmployeeWiseInterestId";
            public const string CompanyID = "@companyID";
            public const string EmployeeId = "@EmployeeId";
            public const string Interest = "@Interest";
            public const string Remarks = "@Remarks";
            public const string IsActive = "@IsActive";
            public const string UserId = "@UserId";
            public const string Operation = "@Operation";
        }

        internal static class EmployeeWiseQualificationDetails
        {
            public const string employeeWiseQualificationId = "@employeeWiseQualificationId";
            public const string employeeID = "@employeeID";
            public const string courseTitle = "@courseTitle";
            public const string educationLevelId = "@educationLevelId";
            public const string institute = "@institute";
            public const string yearOfCompletion = "@yearOfCompletion";
            public const string remarks = "@remarks";
            public const string isActive = "@isActive";
            public const string createdUserId = "@createdUserId";
            public const string modifiedUserId = "@modifiedUserId";
            public const string Operation = "@Operation";
            public const string companyId = "@companyId";
        }
        internal static class EmployeeWiseRelationshipDetails
        {
            public const string EmployeeWiseRelationshipId = "@EmployeeWiseRelationshipId";
            public const string EmployeeId = "@EmployeeId";
            public const string RelationshipId = "@RelationshipId";
            public const string Name = "@Name";
            public const string DateOfBirth = "@DateOfBirth";
            public const string CivilStatusId = "@CivilStatusId";
            public const string Email = "@Email";
            public const string Telephone = "@Telephone";
            public const string Address = "@Address";
            public const string Remarks = "@Remarks";
            public const string PriorityId = "@PriorityId";
            public const string WorkPlace = "@WorkPlace";
            public const string WorkPlaceAddress = "@WorkPlaceAddress";
            public const string WorkPlaceTelephoneNumber = "@WorkPlaceTelephoneNumber";
            public const string IsActive = "@IsActive ";
            public const string UserId = "@UserId";
            public const string Operationn = "@Operation";
            public const string CompanyId = "@companyId";
        }

        internal static class EmployeeWiseHelthProfileDetails
        {
            public const string employeeWiseHelthProfileID = "@employeeWiseHelthProfileID";
            public const string employeeID = "@employeeID";
            public const string companyID = "@companyID";
            public const string bloodGroupID = "@bloodGroupID";
            public const string familyDoctorName = "@familyDoctorName";
            public const string familyDoctorAddress = "@familyDoctorAddress";
            public const string familyDoctorContactNo = "@familyDoctorContactNo";
            public const string familyDoctorEmail = "@familyDoctorEmail";
            public const string familyDoctorHospital = "@familyDoctorHospital";
            public const string alergies = "@alergies";
            public const string illness = "@illness";
            public const string isActive = "@isActive";
            public const string UserId = "@UserId";      
        }
    }
}