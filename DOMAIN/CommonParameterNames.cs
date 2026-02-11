using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public static class CommonParameterNames
    {
        public static class EmployeeWiseRelationshipDetails
        {
            public static string EmployeeWiseRelationshipId = "EmployeeWiseRelationshipId";
            public static string EmployeeId = "EmployeeId";
            public static string EmployeeName = "EmployeeName";
            public static string RelationshipId = "RelationshipId";
            public static string RelationshipName = "RelationshipName";
            public static string Name = "Name";
            public static string DateOfBirth = "DateOfBirth";
            public static string CivilStatusId = "CivilStatusId";
            public static string CivilStatusName = "CivilStatusName";
            public static string Email = "Email";
            public static string Telephone = "Telephone";
            public static string Address = "Address";
            public static string Remarks = "Remarks";
            public static string PriorityId = "PriorityId";
            public static string WorkPlace = "WorkPlace";
            public static string WorkPlaceAddress = "WorkPlaceAddress";
            public static string WorkPlaceTelephoneNumber = "WorkPlaceTelephoneNumber";
            public static string IsActive = "IsActive";
        }

        public static class CommonTableColumnNames
        {
            public static class DepartmentDetails
            {
                public static string DepartmentId = "DepartmentId";
                public static string DepartmentName = "Name";
            }
            public static class CompanyDetails
            {
                public static string companyName = "Name";
                public static string compantId = "Company_ID";
                public static string CompanyGroupOrNot = "CompanyGroupOrNot";
            }

            public static class DesignationDetails
            {
                public static string DesignationName = "Name";
                public static string DesignationId = "DesignationID";
            }

            public static class EmployeeDetails
            {
                public static string EmployeeId = "EmployeeID";
                public static string EmployeeName = "NameWithInitials";
                public static string EmployeeCode = "EmployeeCode";
            }

            public static class TerminationCategories
            {
                public const string TerminationCategoryId = "TerminationCategoryId";
                public const string Name = "Name";
            }
            public static class EducationLevelDetails
            {
                public static string EducationLevelID = "EducationLevelID";
                public static string EducationLevelName = "Name";
            }
            public static class EmployeeWiseInterestDetails
            {
                public static string EmployeeWiseInterestId = "EmployeeWiseInterestId";
                public static string EmployeeId = "EmployeeId";
                public static string Interest = "Interest";
                public static string Remarks = "Remarks";
                public static string IsActive = "IsActive";
                public static string EmployeeName = "EmployeeName";
            }

            public static class EmployeeWiseRelationshipDetails
            {
                public static string EmployeeWiseRelationshipId = "EmployeeWiseRelationshipId";
                public static string EmployeeId = "EmployeeId";
                public static string EmployeeName = "EmployeeName";
                public static string RelationshipId = "RelationshipId";
                public static string RelationshipName = "RelationshipName";
                public static string Name = "Name";
                public static string DateOfBirth = "DateOfBirth";
                public static string CivilStatusId = "CivilStatusId";
                public static string CivilStatusName = "CivilStatusName";
                public static string Email = "Email";
                public static string Telephone = "Telephone";
                public static string Address = "Address";
                public static string Remarks = "Remarks";
                public static string PriorityId = "PriorityId";
                public static string WorkPlace = "WorkPlace";
                public static string WorkPlaceAddress = "WorkPlaceAddress";
                public static string WorkPlaceTelephoneNumber = "WorkPlaceTelephoneNumber";
                public static string IsActive = "IsActive";
            }            
        }

        public static class ItemCommand
        {
            public static string Delete = "Delete";
            public static string Select = "Select";
            public static string AssignCompany = "AssignCompany";

        }
    }
}