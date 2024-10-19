using DVLD2_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLV2_BusinessLogic
{
    public class clsPeople
    {
        public int PersonID { get; set; }
       public string NationalNo { get; set; }         
       public string FirstName { get; set; }  
       public string SecondName { get; set; }
       public string ThirdName { get; set; }
       public string LastName { get; set; }
       public DateTime DateOfBirth { get; set; }
       public byte Gendor { get; set; }
       public string Address { get; set; }
       public string Phone { get; set; }    
       public string Email { get; set; }    
       public int NationalityCountryID { get; set; }    
       public string ImagePath { get; set; }

       public string FullName
        {
            get
            {
                return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
            }
        }
        enum enMode { AddNewPerson , UpdatePerson};
        
        enMode Mode = enMode.AddNewPerson;
       private clsPeople (int personID, string nationalNo,
           string firstName, string secondName, 
           string thirdName, string lastName, DateTime dateOfBirth,
           byte gendor, string address, string phone, string email, 
           int nationalityCountryID, string imagePath)
        {
            this.PersonID = personID;
            this.NationalNo = nationalNo;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gendor = gendor;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.NationalityCountryID = nationalityCountryID;
            this.ImagePath = imagePath;

            Mode = enMode.UpdatePerson;
        }

        public clsPeople()
        {
            this.PersonID = 0; 
            this.NationalNo =  "" ;
            this.FirstName  =  "" ;
            this.SecondName =  "" ;
            this.ThirdName  =  "" ;
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = 0;
            this.Address = ""; 
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = 0;
            this.ImagePath = ""; 

            Mode = enMode.AddNewPerson;
        }
        public static DataTable GetPeople()
        {
            return clsPersonData.GetAllPeople();
        }
        public static clsPeople Find(int PersonID)
        {
            bool isFound = false;
            string nationalNo = ""; string firstName = "";  string secondName = "";
            string thirdName = ""; string lastName = "";DateTime dateOfBirth = DateTime.Now;
            byte gendor = 0; string address = "";  string phone = ""; string email = "";
            int nationalityCountryID = 0;  string imagePath = "";

            isFound = clsPersonData.FindByPersonID(PersonID, ref nationalNo, ref firstName, ref secondName,
            ref thirdName, ref lastName, ref dateOfBirth, ref gendor, ref address,
            ref phone, ref email, ref nationalityCountryID, ref imagePath);

            if (isFound)
                return new clsPeople(PersonID, nationalNo, firstName, secondName,
               thirdName, lastName, dateOfBirth, gendor, address,
               phone, email, nationalityCountryID, imagePath);
            else
            return null;       

        }
        public static clsPeople Find(string NationalNo)
        {
            bool isFound = false;
            int personID = 0; string firstName = ""; string secondName = "";
            string thirdName = ""; string lastName = ""; DateTime dateOfBirth = DateTime.Now;
            byte gendor = 0; string address = ""; string phone = ""; string email = "";
            int nationalityCountryID = 0; string imagePath = "";

            isFound = clsPersonData.FindByNationalNo(NationalNo, ref personID, ref firstName, ref secondName,
            ref thirdName, ref lastName, ref dateOfBirth, ref gendor, ref address,
            ref phone, ref email, ref nationalityCountryID, ref imagePath);

            if (isFound)
                return new clsPeople( personID, NationalNo, firstName, secondName,
               thirdName, lastName, dateOfBirth, gendor, address,
               phone, email, nationalityCountryID, imagePath);
            else
                return null;

        }
        bool AddNew()
        {
            this.PersonID = clsPersonData.AddNewPerson(NationalNo, FirstName,
                SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address,
                Phone, Email, NationalityCountryID, ImagePath);

            return (this.PersonID != -1);
        }
        bool Update()
        {
            return clsPersonData.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName,
                this.LastName, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNewPerson:
                    {
                      if (AddNew())
                        {
                            Mode = enMode.UpdatePerson;
                            return true;
                        }
                     else
                        return false;
                    }
                case enMode.UpdatePerson:
                    return Update();
                     
            }
            return false;
        }
        public static bool isPersonFoundByNationalNo(string NationalNo)
        {
            return clsPersonData.IsPersonExsitByNationalNo(NationalNo);
        }

        public static bool Delete(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }

        public static bool isPersonFoundByPersonID(int PersonID)
        {
            return clsPersonData.IsPersonExsitByPersonID(PersonID);
        }

    }
}
