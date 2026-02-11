using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA.DataBaseUtilities;
using DOMAIN;


namespace DATA
{
    public class BasicInformationEntry
    {
        #region Select
        public DataTable SelectTitle()
        {
            try
            {
                return DataBaseUtilities.DataBaseUtilities.Select("SelectAllTitleDetails");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable SelectNationality()
        {
            try
            {
                return DataBaseUtilities.DataBaseUtilities.Select("SelectAllNationalityDetails");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable SelectRace()
        {
            try
            {
                return DataBaseUtilities.DataBaseUtilities.Select("SelectAllRaceDetails");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable SelectReligion()
        {
            try
            {
                return DataBaseUtilities.DataBaseUtilities.Select("SelectAllReligionDetails");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable SelectCivilStatus()
        {
            try
            {
                return DataBaseUtilities.DataBaseUtilities.Select("SelectAllCivilStatusDetails");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable SelectBasicDetails(int employeeId)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add("@UserId", employeeId);
                return DataBaseUtilities.DataBaseUtilities.Select("EmployeeProfile_SelectCurrentEmployeeBasicDetails", spParameters);
            }
            catch (Exception)
            {

                throw;
            }

        }
        #endregion

        public void InsertEmployeeBasicInformation(EmployeeBasicInformation employeeBasicInformation)
        {
           try 
	        {	        
		    Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add("@Id",employeeBasicInformation.Id);
            
            spParameters.Add("@TitleId", employeeBasicInformation.TitleId);
            spParameters.Add("@NationalityId", employeeBasicInformation.NationalityId);
            spParameters.Add("@RaceId", employeeBasicInformation.RaceId);
            spParameters.Add("@ReligionId", employeeBasicInformation.ReligionId);
            spParameters.Add("@CivilStatusId", employeeBasicInformation.CivilStatusId);
            spParameters.Add("@Gender", employeeBasicInformation.Gender);
            spParameters.Add("@FirstName", employeeBasicInformation.FirstName);
            spParameters.Add("@MiddleName", employeeBasicInformation.MiddleName);
            spParameters.Add("@LastName", employeeBasicInformation.LastName);
            spParameters.Add("@NameWithInitials", employeeBasicInformation.NameWithInitials);
            spParameters.Add("@DateOfBirth", employeeBasicInformation.DateOfBirth);
            spParameters.Add("@RequestedUserId", employeeBasicInformation.RequestedUserId);
            DataBaseUtilities.DataBaseUtilities.Insert("EmployeeProfile_InsertEmployeeProfileBasicInformations",spParameters);
	        }
	        catch (Exception ex)
	        {		
		        throw ex;
	        }
        }

        public DataTable SelectEmployeeBasicInformationNotApproved(EmployeeBasicInformation employeeBasicInformation)
        {
           try 
	        {	        
		        Dictionary<string, object> spParameters = new Dictionary<string, object>();        
                spParameters.Add("@RequestedUserId", employeeBasicInformation.RequestedUserId);
                return DataBaseUtilities.DataBaseUtilities.Select("EmployeeProfile_SelectEmployeeProfileBasicInformationNotApproved",spParameters);
	        }
	        catch (Exception ex)
	        {		
		        throw ex;
	        }
        }
    }
}