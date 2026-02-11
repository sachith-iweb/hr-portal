using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DOMAIN;

namespace DATA
{
    public class HealthProfileEntry
    {
        public DataTable SelectEmployeeWiseHealthProfile(int employeeId)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add("@employeeID ", employeeId);
                return DataBaseUtilities.DataBaseUtilities.Select("SelectAllEmployeeWiseHealthProfileDetails", spParameters);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable SelectBloodGroupDetails()
        {
            try
            {
                return DataBaseUtilities.DataBaseUtilities.Select("SelectAllActiveBloodGroupDetails");
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Insert(HealthProfile healthProfile)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();

            spParameters.Add(WellKnownParameters.EmployeeWiseHelthProfileDetails.employeeID, healthProfile.EmployeeID);
            spParameters.Add(WellKnownParameters.EmployeeWiseHelthProfileDetails.alergies, healthProfile.Alergies);
            spParameters.Add(WellKnownParameters.EmployeeWiseHelthProfileDetails.bloodGroupID, healthProfile.BloodGroupID);
            spParameters.Add(WellKnownParameters.EmployeeWiseHelthProfileDetails.UserId, healthProfile.UserId);
            spParameters.Add(WellKnownParameters.EmployeeWiseHelthProfileDetails.employeeWiseHelthProfileID, healthProfile.EmployeeWiseHelthProfileID);
            spParameters.Add(WellKnownParameters.EmployeeWiseHelthProfileDetails.familyDoctorAddress, healthProfile.FamilyDoctorAddress);
            spParameters.Add(WellKnownParameters.EmployeeWiseHelthProfileDetails.familyDoctorContactNo, healthProfile.FamilyDoctorContactNo);
            spParameters.Add(WellKnownParameters.EmployeeWiseHelthProfileDetails.familyDoctorEmail, healthProfile.FamilyDoctorEmail);
            spParameters.Add(WellKnownParameters.EmployeeWiseHelthProfileDetails.familyDoctorName, healthProfile.FamilyDoctorName);
            spParameters.Add(WellKnownParameters.EmployeeWiseHelthProfileDetails.familyDoctorHospital, healthProfile.FamilyDoctorHospital);
            spParameters.Add(WellKnownParameters.EmployeeWiseHelthProfileDetails.illness, healthProfile.Illness);
            spParameters.Add(WellKnownParameters.EmployeeWiseHelthProfileDetails.isActive, healthProfile.IsActive);


            DataBaseUtilities.DataBaseUtilities.Insert("EmployeeProfile_InsertEmployeeWiseHelthProfileDetails", spParameters);
        }

        public DataTable SelectEmployeeHealthProfileNotApproved(int employeeId) 
        {
             Dictionary<string, object> spParameters = new Dictionary<string, object>();
             spParameters.Add("@EmployeeId", employeeId);
             return DataBaseUtilities.DataBaseUtilities.Select("EmployeeProfile_SelectEmployeeHealthProfileNotApproved", spParameters);
        }

    }
}