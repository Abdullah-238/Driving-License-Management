using DVLD2_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLV2_BusinessLogic
{
    public class clsUser
    {

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
      
        enum enMode { AddNewUser, UpdateUser };

        enMode Mode = enMode.AddNewUser;
      
        clsUser(int userID, int personID, string userName, string password, bool isActive)
        {
            UserID = userID;
            PersonID = personID;
            UserName = userName;
            Password = password;
            IsActive = isActive;
            Mode = enMode.UpdateUser;
        }

        public clsUser()
        {
            this.PersonID = 0;
            this.UserID = 0;
            this.UserName = "";
            this.Password = "";
            this.IsActive = true;

            Mode = enMode.AddNewUser;
        }
        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }
        public static clsUser FindUserByUserID(int UserID)
        {
            bool isFound = false;
            int PersonID = 0; bool IsActive = true;
            string UserName = ""; string Password = "";
           


            isFound = clsUserData.FindUserByUserID(UserID, ref PersonID, ref UserName,
                ref Password, ref IsActive);

            if (isFound)
                return new clsUser(UserID, PersonID, UserName,
                 Password, IsActive);
            else
                return null;

        }

        public static clsUser FindByPersonID(int PersonID)
        {
            bool isFound = false;
            int UserID = 0; bool IsActive = true;
            string UserName = ""; string Password = "";



            isFound = clsUserData.FindUserByPersonID(PersonID , ref UserID, ref UserName,
                ref Password, ref IsActive);

            if (isFound)
                return new clsUser(UserID, PersonID, UserName,
                 Password, IsActive);
            else
                return null;

        }
        public static clsUser FindByUserNameAndPassword(string UserName , string Password)
        {
            bool isFound = false;
            int UserID = 0; bool IsActive = true; int PersonID = 0;

            isFound = clsUserData.FindUserByUserNameAndPassword(UserName , Password, ref UserID, ref PersonID
                , ref IsActive);

            if (isFound)
                return new clsUser(UserID, PersonID, UserName,
                 Password, IsActive);
            else
                return null;
        }

        bool AddNew()
        {
            this.UserID = clsUserData.AddNewUser(PersonID,UserName,Password,IsActive);
               
            return (this.UserID != -1);
        }
        bool Update()
        {
            return clsUserData.UpdateUser(this.UserID,this.PersonID, this.UserName, this.Password, this.IsActive);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNewUser:
                    {
                        if (AddNew())
                        {
                            Mode = enMode.UpdateUser;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.UpdateUser:
                    return Update();

            }
            return false;
        }
       
        public static bool Delete(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static bool isUserFoundByUserName(string UserName)
        {
            return clsUserData.IsUserExsitByUserName(UserName);
        }
        public static bool isUserFoundByUserID(int UserID)
        {
            return clsUserData.IsUserExsitByUserID(UserID);
        }

        public static bool isUserFoundByPersonID(int PersonID)
        {
            return clsUserData.IsUserExsitByPersonID(PersonID);
        }

    }
}
