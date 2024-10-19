using DVLD2;
using DVLD2_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLD2.clsLicense;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLV2_BusinessLogic
{
    public class clsLocalDrivingLicenseApplications :  clsApplications
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public clsLicenseClasses LicenseClasses; 
       
        enum enMode { AddNewLocalLicenseApplication, UpdateLocalLicenseApplication };

        enMode Mode = enMode.AddNewLocalLicenseApplication;

         clsLocalDrivingLicenseApplications(int localDrivingLicenseApplicationID,
             int licenseClassID ,int applicationID, int applicantPersonID, DateTime applicationDate, int applicationTypeID
            , byte applicationStatus, DateTime lastStatusDate, decimal paidFees,
            int createdByUserID ) 
        {
            this.LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            this.LicenseClassID = licenseClassID;
            this.ApplicationID = applicationID;
            this.ApplicantPersonID = applicantPersonID;
            this.ApplicationDate = applicationDate;
            this.ApplicationTypeID = applicationTypeID;
            this.ApplicationStatus = (enStatus)applicationStatus;
            this.LastStatusDate = lastStatusDate;
            this.PaidFees = paidFees;
            this.CreatedByUserID = createdByUserID;
            this.LicenseClasses = clsLicenseClasses.FindLicenseByLicenseClassID(licenseClassID);

            Mode = enMode.UpdateLocalLicenseApplication;

        }

        public clsLocalDrivingLicenseApplications()
        {
            this.LocalDrivingLicenseApplicationID = 0;
            this.LicenseClassID = 0;
   
            Mode = enMode.AddNewLocalLicenseApplication;
        }

        public static clsLocalDrivingLicenseApplications 
            FindApplicationByLocalApplicationID(int LocalDrivingLicenseApplicationID)
        {
            bool isFound = false;
            int applicationID = -1;
            int licenseClassID = -1;

            isFound = clsLocalDrivingLicenseApplicationsData.FindByLocalApplicationID(
                LocalDrivingLicenseApplicationID, ref applicationID, ref licenseClassID );

            if (isFound)
            {
                clsApplications Application =
                    clsApplications.FindApplicationByApplicationID(applicationID);

                return new clsLocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID,
                  licenseClassID, applicationID, Application.ApplicantPersonID, Application.ApplicationDate,
                  Application.ApplicationTypeID,(byte)Application.ApplicationStatus, Application.LastStatusDate,
                  Application.PaidFees , Application.CreatedByUserID);
            }
               
            else
                return null;

        }

        bool AddNew()
        {
            this.LocalDrivingLicenseApplicationID = 
                clsLocalDrivingLicenseApplicationsData.
                AddNewLocalApplication(ApplicationID, LicenseClassID);

            return (this.ApplicationID != -1);
        }
        bool UpdateLocalApplication()
        {
            return clsLocalDrivingLicenseApplicationsData.UpdateLocalApplication(
                this.LocalDrivingLicenseApplicationID,
                this.ApplicationID, this.LicenseClassID);
        }
         public bool Save()
        {

            base.Mode = (clsApplications.enMode)Mode; 
            if (!base.Save())
                return false;

            switch (Mode)
            {
                case enMode.AddNewLocalLicenseApplication:
                    {
                        if (AddNew())
                        {
                            Mode = enMode.UpdateLocalLicenseApplication;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.UpdateLocalLicenseApplication:
                    return UpdateLocalApplication();

            }
            return false;
        }

        public  bool Delete()
        {
           
            bool DeleteLocalApplication = 
                clsLocalDrivingLicenseApplicationsData.DeleteLocalApplication
                (LocalDrivingLicenseApplicationID);

            if (DeleteLocalApplication)
                return base.Delete();
            return false; 
        }

        public static DataTable GetAllDrivingLocalLicenseApplication()
        {
            return clsLocalDrivingLicenseApplicationsData.GetAllDrivingLocalLicenseApplication();
        }

        public int IssueLicenseForFirstTime(string Note , int UserId)
        {
            int DriverID = -1;

            clsDriver Driver = clsDriver.FindDriverByPersonID(this.ApplicantPersonID);

            if (Driver == null)
            {
                Driver = new clsDriver();

                Driver.PersonID = this.ApplicantPersonID;
                Driver.CreatedDate = DateTime.Now;
                Driver.CreatedByUserID = UserId;

                if (Driver.Save())
                    DriverID = Driver.DriverID;
                else
                    return -1;
            }
            else
                DriverID = Driver.DriverID;

            clsLicense License = new clsLicense();

            License.ApplicationID = this.ApplicationID;
            License.Notes = Note;
            License.LicenseClass = this.LicenseClassID;
            License.CreatedByUserID = UserId;
            License.ExpirationDate = DateTime.Now.AddDays(
                this.LicenseClasses.DefaultValidityLength);
            License.IssueDate = DateTime.Now;
            License.PaidFees = this.LicenseClasses.ClassFees;
            License.IsActive = true;
            License.IssueReason = enIssueReason.FirstTime;


            License.DriverID = Driver.DriverID;

            if (License.Save())
            {
                return License.LicenseID;
            }
            else
                return -1;
            
        }
    } 
}
