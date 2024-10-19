using DVLD2_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLV2_BusinessLogic
{
    public class clsInternationalLicense : clsApplications
    {
        public int InternationalLicenseID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }

        enum enMode { AddNewInternationalLicense , UpdateInternationalLiicense};

        enMode Mode = enMode.AddNewInternationalLicense; 

        clsInternationalLicense (int internationalLicenseID, int driverID,
            int issuedUsingLocalLicenseID,
            DateTime issueDate, DateTime expirationDate, bool isActive ,
            int applicationID, int applicantPersonID, DateTime applicationDate, int applicationTypeID
            , byte applicationStatus, DateTime lastStatusDate, decimal paidFees,
            int createdByUserID)
        {
            this.InternationalLicenseID = internationalLicenseID;
            this.ApplicationID             = applicationID;
            this.DriverID                  = driverID;
            this.IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            this.IssueDate                 = issueDate;
            this.ExpirationDate            = expirationDate;
            this.IsActive                  = isActive;
            this.ApplicantPersonID = applicantPersonID;
            this.ApplicationDate = applicationDate;
            this.ApplicationTypeID = applicationTypeID;
            this.ApplicationStatus = (enStatus)applicationStatus;
            this.LastStatusDate = lastStatusDate;
            this.PaidFees = paidFees;
            this.CreatedByUserID = createdByUserID;

            Mode = enMode.UpdateInternationalLiicense; 
        }

        public clsInternationalLicense()
        {
            InternationalLicenseID = 0;
            ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;
            IssueDate = DateTime.Now; 
            ExpirationDate = DateTime.Now; ;
            IsActive = false;
            CreatedByUserID = 0;

            Mode = enMode.AddNewInternationalLicense;

        }

        public static DataTable GetAllInternationalLicenes(int LicenseID)
        {
            return clsInternationalLicenseData.GetAllINternationalLicenses(LicenseID);
        }


        public static clsInternationalLicense
            FindInternationalLicenseByLicenseID(int issuedUsingLocalLicenseID )
        {
            bool isFound = false;
            int applicationID = 0; int driverID = 0;  int internationalLicenseID = 0;
            DateTime issueDate = DateTime.Now; DateTime expirationDate = DateTime.Now;
            bool isActive = false;
            int CreatedByUserID = 0;



            isFound = clsInternationalLicenseData.FindByLicenseID
                (ref internationalLicenseID,
            ref applicationID, ref driverID,
             issuedUsingLocalLicenseID,
            ref issueDate, ref expirationDate,
            ref isActive, ref CreatedByUserID);

            if (isFound)
            {
                clsApplications Application =
                   clsApplications.FindApplicationByApplicationID(applicationID);

                return new clsInternationalLicense(internationalLicenseID,
                  driverID,
           issuedUsingLocalLicenseID,
           issueDate, expirationDate, isActive, Application.ApplicationID, Application.ApplicantPersonID
           , Application.ApplicationDate, Application.ApplicationTypeID,(byte) Application.ApplicationStatus,
           Application.LastStatusDate, Application.PaidFees, Application.CreatedByUserID);
            }
              
            else
                return null;

        }


        bool AddNew()
        {
            this.InternationalLicenseID = clsInternationalLicenseData.
                AddNewInternationalLicense(ApplicationID,  DriverID,
             IssuedUsingLocalLicenseID,
             IssueDate,  ExpirationDate,  IsActive,  CreatedByUserID);

            return (this.InternationalLicenseID != -1);
        }
        bool Update()
        {
            return clsInternationalLicenseData.UpdateInternationalLicenseID(
                this.InternationalLicenseID,this.ApplicationID,this.DriverID,this.IssuedUsingLocalLicenseID,
                this.IssueDate,this.ExpirationDate,this.IsActive,this.CreatedByUserID);
        }
        public bool Save()
        {
            base.Mode = (clsApplications.enMode)Mode;
            if (!base.Save())
                return false;


            switch (Mode)
            {
                case enMode.AddNewInternationalLicense:
                    {
                        if (AddNew())
                        {
                            Mode = enMode.UpdateInternationalLiicense;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.UpdateInternationalLiicense:
                    return Update();

            }
            return false;
        }

        public static bool Delete(int internationalLicenseID)
        {
            return clsInternationalLicenseData.DeleteInternationalLicenseID(internationalLicenseID);
        }

        public static bool IsDriverHasActiveInternationalLicense(int LicenseID)
        {
            return clsInternationalLicenseData.IsDriverHasActiveInternationalLicense(LicenseID);
        }

    }
}
