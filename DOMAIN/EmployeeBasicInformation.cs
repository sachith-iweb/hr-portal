using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class EmployeeBasicInformation
    {
        public string Id { get; set; }       
        public string TitleId { get; set; }
        public string NationalityId { get; set; }
        public string RaceId { get; set; }
        public string ReligionId { get; set; }
        public string Gender { get; set; }
        public string CivilStatusId { get; set; }
       // public byte[] ProfilePicture { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string NameWithInitials { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string RequestedUserId { get; set; }
    }
}