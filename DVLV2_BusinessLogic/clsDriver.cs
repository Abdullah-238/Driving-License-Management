using DVLD2_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DVLV2_BusinessLogic
{

    public class clsDriver
    {
        public int DriverID { get; set; }
        public int CreatedByUserID { get; set; }

        public int PersonID { get; set; }

        public DateTime CreatedDate { get; set; }

        enum enMode { AddNewDriver , UpdateDriver}

        enMode Mode = enMode.AddNewDriver;

        clsDriver(int driverID,  int personID,  int createdByUserID,
            DateTime createdDate)
        {
            this.DriverID = driverID;
            this.PersonID = personID;
            this.CreatedByUserID = createdByUserID;
            this.CreatedDate = createdDate;

            Mode = enMode.UpdateDriver; 
        }

        public clsDriver()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now;

            Mode = enMode.AddNewDriver;
        }

        public static clsDriver FindDriverByDriverID(int DriverID)
        {
            bool isFound = false;
            int PersonID = 0; DateTime CreatedByUserID = DateTime.Now;
            int CreatedDate = 0;



            isFound = clsDriverData.FindByDriverID(DriverID, ref PersonID, ref CreatedDate,
                ref CreatedByUserID);

            if (isFound)
                return new clsDriver(DriverID,  PersonID,  CreatedDate,
                 CreatedByUserID);
            else
                return null;

        }


        public static clsDriver FindDriverByPersonID(int PersonID )
        {
            bool isFound = false;
            int DriverID = 0; DateTime CreatedByUserID = DateTime.Now;
            int CreatedDate = 0;



            isFound = clsDriverData.FindByPersonID(PersonID , ref DriverID, ref CreatedDate,
                ref CreatedByUserID);

            if (isFound)
                return new clsDriver(DriverID, PersonID, CreatedDate,
                 CreatedByUserID);
            else
                return null;

        }


        bool AddNew()
        {
            this.DriverID = clsDriverData.AddNewDriver(PersonID, 
                 CreatedByUserID, CreatedDate);

            return (this.DriverID != -1);
        }
        bool Update()
        {
            return clsDriverData.UpdateDriver(this.DriverID, this.PersonID,
                this.CreatedByUserID, this.CreatedDate);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNewDriver:
                    {
                        if (AddNew())
                        {
                            Mode = enMode.UpdateDriver;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.UpdateDriver:
                    return Update();

            }
            return false;
        }

        public static bool Delete(int DriverID)
        {
            return clsDriverData.DeleteDriver(DriverID);
        }

    }
}
