using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN
{
    public class EmployeeWiseRelationshipDetails
    {
        private int employeeWiseRelationshipId;
        public int EmployeeWiseRelationshipId
        {
            get { return employeeWiseRelationshipId; }
            set { employeeWiseRelationshipId = value; }
        }

        private int employeeId;
        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        
        private int relationshipId;
        public int RelationshipId
        {
            get { return relationshipId; }
            set { relationshipId = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private DateTime dateOfBirth;
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        private int civilStatusId;
        public int CivilStatusId
        {
            get { return civilStatusId; }
            set { civilStatusId = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string telephone;
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string remarks;
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }

        private int priorityId;
        public int PriorityId
        {
            get { return priorityId; }
            set { priorityId = value; }
        }

        private string workPlace;
        public string WorkPlace
        {
            get { return workPlace; }
            set { workPlace = value; }
        }

        private string workPlaceAddress;
        public string WorkPlaceAddress
        {
            get { return workPlaceAddress; }
            set { workPlaceAddress = value; }
        }

        private string workPlaceTelephoneNumber;
        public string WorkPlaceTelephoneNumber
        {
            get { return workPlaceTelephoneNumber; }
            set { workPlaceTelephoneNumber = value; }
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

        private int companyId;
        public int CompanyId
        {
            get { return companyId; }
            set { companyId = value; }
        }

    }
}
