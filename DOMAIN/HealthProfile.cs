using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class HealthProfile
    {
        private int employeeWiseHelthProfileID;
        private int employeeID;
        private int bloodGroupID;
        private string familyDoctorName;
        private string familyDoctorAddress;
        private string familyDoctorContactNo;
        public string FamilyDoctorHospital { get; set; }

        private string familyDoctorEmail;
        private string alergies;
        private string illness;
        private bool isActive;

        public int UserId { get; set; }
   
      

        // Getters And Setters

        public int EmployeeWiseHelthProfileID
        {
            get { return employeeWiseHelthProfileID; }
            set { employeeWiseHelthProfileID = value; }
        }

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public int BloodGroupID
        {
            get { return bloodGroupID; }
            set { bloodGroupID = value; }
        }

        public string FamilyDoctorName
        {
            get { return familyDoctorName; }
            set { familyDoctorName = value; }
        }

        public string FamilyDoctorAddress
        {
            get { return familyDoctorAddress; }
            set { familyDoctorAddress = value; }
        }

        public string FamilyDoctorContactNo
        {
            get { return familyDoctorContactNo; }
            set { familyDoctorContactNo = value; }
        }

        public string FamilyDoctorEmail
        {
            get { return familyDoctorEmail; }
            set { familyDoctorEmail = value; }
        }

        public string Alergies
        {
            get { return alergies; }
            set { alergies = value; }
        }

        public string Illness
        {
            get { return illness; }
            set { illness = value; }
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

       
    }
}