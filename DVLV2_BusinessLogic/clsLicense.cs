using DVLD2_DataAccess;
using DVLV2_BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DVLD2
{

    public class clsLicense
    {
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public enIssueReason IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        public enum enIssueReason
        {
            FirstTime = 1, Renew, ReplacementforDamaged, ReplacementforLost
        }
        public string IssueReasonText
        {
            get 
            {
                switch(IssueReason)
                {
                    case enIssueReason.FirstTime:
                        return "First Time";

                        case enIssueReason.Renew:
                        return "Renew Time";

                    case enIssueReason.ReplacementforDamaged:
                        return "Replacement for Damaged";

                    case enIssueReason.ReplacementforLost:
                        return "Replacement for Lost";
                }
                return "";
            }
        }

        enum enMode { AddNewLicense , UpdateLicense };

        enMode Mode;
        clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
            DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees,
            bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = (enIssueReason)IssueReason;
            this.CreatedByUserID = CreatedByUserID;

            Mode = enMode.UpdateLicense; 

        }

        public clsLicense()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClass = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = -1;
            this.IsActive = false;
            this.IssueReason = 0;
            this.CreatedByUserID = -1;

            Mode = enMode.AddNewLicense;
        }

        public static DataTable GetAllLocalLicense(int LicenseID)
        {
            return clsLicenseData.GetAllLicenses(LicenseID);
        }

        public static DataTable GetAllLicensesByPersonID(int PersonID)
        {
            return clsLicenseData.GetAllLicensesByPersonID(PersonID);
        }

        public static clsLicense FindByLicenseID(int LicenseID)
        {
            bool isFound = false;
            int ApplicationID = -1; int DriverID = -1; int LicenseClass = -1;
            DateTime IssueDate = DateTime.Now;  DateTime ExpirationDate = DateTime.Now;
            string Notes = ""; decimal PaidFees = 0;
            bool IsActive = false; byte IssueReason = 0; int CreatedByUserID = 0;

            isFound = clsLicenseData.FindByLicenseID(LicenseID, ref ApplicationID,
                ref DriverID, ref LicenseClass,
           ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees,
           ref IsActive, ref IssueReason, ref CreatedByUserID);

            if (isFound)
                return new clsLicense(LicenseID,  ApplicationID,  DriverID,  LicenseClass,
            IssueDate,  ExpirationDate,  Notes,  PaidFees,
            IsActive,  IssueReason,  CreatedByUserID);
            else
                return null;

        }

        bool AddNew()
        {
            this.LicenseID = clsLicenseData.AddNewLicense(ApplicationID,
                DriverID, LicenseClass,
            IssueDate, ExpirationDate, Notes, PaidFees,
            IsActive,(byte) IssueReason, CreatedByUserID);
            return (this.LicenseID != -1);
        }
        bool Update()
        {
            return clsLicenseData.UpdateLicense(this.LicenseID,this.ApplicationID,
                this.DriverID, this.LicenseClass,
            this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees,
            this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);
        }
      bool DeactivateLicense()
        {
            return clsLicenseData.DeactivateLicense(this.LicenseID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNewLicense:
                    {
                        if (AddNew())
                        {
                            Mode = enMode.UpdateLicense;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.UpdateLicense:
                    return Update();

            }
            return false;
        }
        public static bool Delete(int LicenseID)
        {
            return clsLicenseData.DeleteLicense(LicenseID);
        }

        public static bool HasActiveLicense(int ApplicationID)
        {
            return clsLicenseData.HasActiveLicense(ApplicationID);
        }


        public static bool IsLicenseActive(int LicenseID)
        {
            return clsLicenseData.IsLicenseActive(LicenseID);
        }

        public clsLicense RenewDriverLicense(string Note, int CreatedByUserID)
        {

            clsApplications OldApplication =
                clsApplications.FindApplicationByApplicationID(ApplicationID);

            clsApplications NewApplication = new clsApplications();

            NewApplication.ApplicantPersonID = OldApplication.ApplicantPersonID;
            NewApplication.ApplicationStatus = clsApplications.enStatus.eNew;
            NewApplication.ApplicationDate = DateTime.Now;
            NewApplication.ApplicationTypeID = (byte)clsApplications.enApplicationType.eRenewDrivingLicense;
            NewApplication.PaidFees = clsApplicationTypes.FindApplicationByApplicationTypeID(
                (byte)clsApplications.enApplicationType.
                eRenewDrivingLicense).ApplicationFees;
            NewApplication.CreatedByUserID = CreatedByUserID;

            if (!NewApplication.Save())
            {
                return null;
            }


            clsLicense NewLicense = new clsLicense();

            NewLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenseClasses
                .FindLicenseByLicenseClassID(LicenseClass).DefaultValidityLength);
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.Notes = Note;
            NewLicense.LicenseClass = LicenseClass;
            NewLicense.CreatedByUserID = CreatedByUserID;
            NewLicense.PaidFees = PaidFees;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = enIssueReason.Renew;
            NewLicense.DriverID = DriverID;
            NewLicense.ApplicationID = NewApplication.ApplicationID;

            if (!NewLicense.Save())
            {
                return null;
            }

            this.DeactivateLicense();

            return NewLicense;

        }

        public clsLicense ReplaceDriveringLicenseForDemaged( int CreatedByUserID)
        {

            clsApplications OldApplication =
               clsApplications.FindApplicationByApplicationID(ApplicationID);

            clsApplications NewApplication = new clsApplications();

            NewApplication.ApplicantPersonID = OldApplication.ApplicantPersonID;
            NewApplication.ApplicationStatus = clsApplications.enStatus.eNew;
            NewApplication.ApplicationDate = DateTime.Now;
            NewApplication.ApplicationTypeID =
                (byte)clsApplications.enApplicationType.eRenewDrivingLicense;
            NewApplication.PaidFees = clsApplicationTypes.FindApplicationByApplicationTypeID(
                (byte)clsApplications.enApplicationType.
                eRenewDrivingLicense).ApplicationFees;
            NewApplication.CreatedByUserID = CreatedByUserID;

            if (!NewApplication.Save())
            {
                return null;
            }

            clsLicense NewLicense = new clsLicense();

            NewLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenseClasses
                .FindLicenseByLicenseClassID(LicenseClass).DefaultValidityLength);
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.Notes = Notes;
            NewLicense.LicenseClass = LicenseClass;
            NewLicense.CreatedByUserID = CreatedByUserID;
            NewLicense.PaidFees = PaidFees;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = enIssueReason.ReplacementforDamaged;
            NewLicense.DriverID = DriverID;
            NewLicense.ApplicationID = NewApplication.ApplicationID;

            if (!NewLicense.Save())
            {
                return null;
            }

            this.DeactivateLicense();

            return NewLicense;

        }

    }
}
