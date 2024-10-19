using DVLD2;
using DVLD2_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLV2_BusinessLogic
{
    public class clsDetainedLicenses
    {
        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }

        enum enMode { AddNewDetainedLicense, UpdateDetainedLicense };

        enMode Mode = enMode.AddNewDetainedLicense;

        clsDetainedLicenses(int detainID, int LicenseID, DateTime DetainDate, decimal FineFees,
            int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, 
            int ReleaseApplicationID)
        {
            this.DetainID                 = detainID;
            this.LicenseID                = LicenseID;
            this.DetainDate               = DetainDate;
            this.FineFees                 = FineFees;
            this.CreatedByUserID          = CreatedByUserID;
            this.IsReleased               = IsReleased;
            this.ReleaseDate              = ReleaseDate;
            this.ReleasedByUserID         = ReleasedByUserID;
            this.ReleaseApplicationID     = ReleaseApplicationID;

            Mode = enMode.UpdateDetainedLicense;
        }

        public clsDetainedLicenses()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = -1;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.Now;
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;

            Mode = enMode.AddNewDetainedLicense;
        }
        public static DataTable GetDetainedLicenses()
        {
            return clsDetainedLicenseDate.GetAllDetainedLicenses();
        }
        public static clsDetainedLicenses FindByDetainedLicense(int DetainID)
        {
            bool isFound = false;
            int LicenseID = -1;
            DateTime DetainDate = DateTime.Now;
            decimal FineFees = -1;
             int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.Now;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;


            isFound = clsDetainedLicenseDate.FindByDetainID( DetainID, ref  LicenseID, 
                ref  DetainDate, ref  FineFees,
           ref  CreatedByUserID, ref  IsReleased, ref  ReleaseDate,
           ref  ReleasedByUserID, ref  ReleaseApplicationID);

            if (isFound)
                return new clsDetainedLicenses(DetainID,  LicenseID,  DetainDate,  FineFees,
            CreatedByUserID,  IsReleased,  ReleaseDate,  ReleasedByUserID,  ReleaseApplicationID);
            else
                return null;

        }

        bool AddNew()
        {
            this.DetainID = clsDetainedLicenseDate.AddNewDetainLicense
                (
                this.LicenseID,this.DetainDate,this.FineFees,
                this.CreatedByUserID,this.IsReleased , this.ReleaseDate
                , this.ReleasedByUserID,this.ReleaseApplicationID
                );

            return (this.DetainID != -1);
        }
        bool Update()
        {
            return clsDetainedLicenseDate.UpdateDetained(this.DetainID,this.LicenseID, 
                this.DetainDate, this.FineFees,
                this.CreatedByUserID, this.IsReleased, this.ReleaseDate, 
                this.ReleasedByUserID, this.ReleaseApplicationID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNewDetainedLicense:
                    {
                        if (AddNew())
                        {
                            Mode = enMode.UpdateDetainedLicense;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.UpdateDetainedLicense:
                    return Update();

            }
            return false;
        }

        public static clsDetainedLicenses FindByLicenseID(int LicenseID )
        {
            bool isFound = false;
            int detainID = -1;
            DateTime DetainDate = DateTime.Now;
            decimal FineFees = -1;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.Now;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;


            isFound = clsDetainedLicenseDate.FindByLicenseID( 
                LicenseID, ref detainID, ref DetainDate, ref FineFees,
           ref CreatedByUserID, ref IsReleased, ref ReleaseDate, 
           ref ReleasedByUserID, ref ReleaseApplicationID);

            if (isFound)
                return new clsDetainedLicenses(detainID, LicenseID, DetainDate, FineFees,
            CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            else
                return null;

        }

        public bool ReleaseDetainedLicense( int UserID)
        {

            int PersonID = clsDriver.FindDriverByDriverID(
                clsLicense.FindByLicenseID(LicenseID).DriverID).PersonID; 
                
            
         
            clsApplications NewApplication = new clsApplications();

            NewApplication.ApplicationStatus = clsApplications.enStatus.eNew;
            NewApplication.ApplicationDate = DateTime.Now;
            NewApplication.ApplicationTypeID = (byte)clsApplications.enApplicationType.eReleaseDetainedDrivingLicsense;
            NewApplication.PaidFees = clsApplicationTypes.FindApplicationByApplicationTypeID(
                (byte)clsApplications.enApplicationType.eReleaseDetainedDrivingLicsense
                ).ApplicationFees;
            NewApplication.CreatedByUserID = UserID;
            NewApplication.ApplicantPersonID = PersonID;

            if (!NewApplication.Save())
            {
                return false;
            }

            IsReleased = true; 
            ReleaseDate = DateTime.Now;
            ReleasedByUserID = UserID;
            ReleaseApplicationID = NewApplication.ApplicationID;

            if (Save())
                return true;


            return false;

        }

        public static bool IsLicenseDetained(int licenseID)
        {
            return clsDetainedLicenseDate.IsLicenseDetained(licenseID);
        }

    }
}
