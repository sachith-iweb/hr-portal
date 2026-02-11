using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN
{
    public class UserDetails
    {
        private int id;
        private int userId;
        private string userName;
        private string userPassword;
        private int employeeId;
        private bool isActive;


        public int Id 
        {
            get { return id; }
            set { id = value; }
        }

        public string UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
       
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }



        public int PasswordPolicy { get; set; }
    }
}
