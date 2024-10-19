
using DVLD2_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLV2_BusinessLogic
{
    public class clsApplications
    {
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public enStatus ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public enum enMode { AddNewApplication, UpdateApplication };
        public string StatusText
        {
            get
            {

                switch (ApplicationStatus)
                {
                    case enStatus.eNew:
                        return "New";
                    case enStatus.eCanel:
                        return "Cancelled";
                    case enStatus.eCompleted:
                        return "Completed";
                    default:
                        return "Unknown";
                }
            }

        }

        public enMode Mode = enMode.AddNewApplication;

        public enum enApplicationType { eAddNewLocalApplication =1, eRenewDrivingLicense , eReplacementforaLostDrivingLicense ,
                                         eReplacementforaDamagedDrivingLicense , eReleaseDetainedDrivingLicsense , eNewInternationalLicense
                                        , eRetakeTest }

        public enum enStatus
        {
          eNew = 1, eCanel ,  eCompleted
        }

        protected clsApplications(int applicationID, int applicantPersonID, DateTime applicationDate,
            int applicationTypeID
            , byte applicationStatus, DateTime lastStatusDate, decimal paidFees,
            int createdByUserID)
        {
            ApplicationID = applicationID;
            ApplicantPersonID = applicantPersonID;
            ApplicationDate = applicationDate;
            ApplicationTypeID = applicationTypeID;
            ApplicationStatus = (enStatus)applicationStatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;

            Mode = enMode.UpdateApplication;

        }

        public clsApplications()
        {
            this.ApplicationID = 0;
            this.ApplicantPersonID = 0;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = 0;
            this.ApplicationStatus = 0;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = 0;

            Mode = enMode.AddNewApplication;
        }

        public static clsApplications FindApplicationByApplicationID(int applicationID)
        {
            bool isFound = false;
            int applicantPersonID = 0; DateTime applicationDate = DateTime.Now;
            byte applicationStatus = 0; DateTime lastStatusDate = DateTime.Now;
            int applicationTypeID = 0;
            decimal paidFee = 0; int createdByUserID = 0;


            isFound = clsApplicationsData.FindByApplicationID(applicationID, ref applicantPersonID
                , ref applicationDate, ref applicationTypeID, ref applicationStatus, ref lastStatusDate,
                ref paidFee,
                ref createdByUserID);

            if (isFound)
                return new clsApplications(applicationID, applicantPersonID
                , applicationDate, applicationTypeID, applicationStatus, lastStatusDate, paidFee,
                 createdByUserID);
            else
                return null;

        }

        bool AddNew()
        {
            this.ApplicationID = clsApplicationsData.AddNewApplication(ApplicantPersonID, ApplicationDate,
                ApplicationTypeID, (byte)ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            return (this.ApplicationID != -1);
        }
        bool Update()
        {
            return clsApplicationsData.UpdateApplication(this.ApplicationID, this.ApplicantPersonID,
               this.ApplicationDate, this.ApplicationTypeID, (byte)this.ApplicationStatus, this.LastStatusDate,
               this.PaidFees, this.CreatedByUserID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNewApplication:
                    {
                        if (AddNew())
                        {
                            Mode = enMode.UpdateApplication;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.UpdateApplication:
                    return Update();

            }
            return false;
        }
        public bool Delete()
        {
            return clsApplicationsData.DeleteApplication(ApplicationID);
        }

        public static bool CheckPersonHasApplcation(int ApplicantPersonID, int LicenseClassID)
        {
            return clsApplicationsData.CheckPersonHasApplcation(ApplicantPersonID, LicenseClassID);
        }

        public static bool CancelApplication(int ApplicationID)
        {
            return clsApplicationsData.CancelApplication(ApplicationID);
        }
    }
}
