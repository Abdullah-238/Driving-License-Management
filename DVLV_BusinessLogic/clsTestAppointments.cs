using DVLD2_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLV2_BusinessLogic
{
    public class clsTestAppointments
    {

        public int TestAppointmentID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int TestTypeID { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTest { get; set; }
        enum enMode { AddNewTest, UpdateTest };

        enMode Mode = enMode.AddNewTest;

        clsTestAppointments(int TestAppointmentID, int TestTypeID
            , int LocalDrivingLicenseApplicationID, DateTime AppointmentDate,
            decimal PaidFees, int CreatedByUserID, bool IsLockedm, int RetakeTest)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTest = RetakeTest;
            Mode = enMode.UpdateTest;
        }

        public clsTestAppointments()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.RetakeTest = -1;

            Mode = enMode.AddNewTest;
        }

        public static clsTestAppointments FindTestByTestAppointmentID(int TestAppointmentID)
        {
            bool isFound = false;
            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTest = -1;



            isFound = clsTestAppointmentsData.FindByTestAppoinment(TestAppointmentID,
                ref TestTypeID
            , ref LocalDrivingLicenseApplicationID, ref AppointmentDate,
            ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTest);

            if (isFound)
                return new clsTestAppointments(TestAppointmentID,
                 TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate,
             PaidFees, CreatedByUserID, IsLocked, RetakeTest);
            else
                return null;

        }

        public static clsTestAppointments FindTestByLocalApplicationID(int  LocalDrivingLicenseApplicationID)
        {
            bool isFound = false;
            int TestTypeID = -1;
            int TestAppointmentID = -1;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTest = -1;



            isFound = clsTestAppointmentsData.FindTestByLocalApplicationID(ref TestAppointmentID,
                ref TestTypeID
            ,  LocalDrivingLicenseApplicationID, ref AppointmentDate,
            ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTest);

            if (isFound)
                return new clsTestAppointments(TestAppointmentID,
                 TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate,
             PaidFees, CreatedByUserID, IsLocked, RetakeTest);
            else
                return null;

        }

        bool AddNew()
        {
            this.TestAppointmentID = clsTestAppointmentsData
                .AddNewTestAppoinment(TestTypeID, LocalDrivingLicenseApplicationID,
                AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTest);

            return (this.TestAppointmentID != -1);
        }

        bool Update()
        {
            return clsTestAppointmentsData.UpdateTestAppoinment(this.TestAppointmentID,
                this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNewTest:
                    {
                        if (AddNew())
                        {
                            Mode = enMode.UpdateTest;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.UpdateTest:
                    return Update();

            }
            return false;
        }

        public static DataTable GetAllTestAppoinment(int LocalApplicationID)
        {
            return clsTestAppointmentsData.GetAllTestAppoinment(LocalApplicationID);
        }

        public static bool DoesPassedTest(int LocalDrivingLicenseApplicationID,byte TestTypeID)
        {
            return clsTestAppointmentsData.isPassedTest(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        public static byte GetPassedTestCount(int LocalApplicationID)
        {
            return clsTestAppointmentsData.GetPassedTestCount(LocalApplicationID);
        }

        public static byte GetTestTrial(int LocalApplicationID, byte TestTypeID)
        {
            return clsTestAppointmentsData.GetTestTrial(LocalApplicationID, TestTypeID);
        }

        public static bool isHasActiveAppoinment(int LocalDrivingLicenseApplicationID)
        {
            return clsTestAppointmentsData.isHasActiveAppoinment(LocalDrivingLicenseApplicationID);
        }

    }
}
