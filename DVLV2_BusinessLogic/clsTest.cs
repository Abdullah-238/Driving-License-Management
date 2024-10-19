using DVLD2_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLV2_BusinessLogic
{
    public class clsTest
    {

        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }
        public bool TestResult { get; set; }

        enum enMode { AddNewTest, UpdateTest };

        enMode Mode = enMode.AddNewTest;

        clsTest(int TestID, int TestAppointmentID, string Notes,
             int CreatedByUserID, bool TestResult)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestID = TestID;
            this.Notes = Notes;
            this.TestResult = TestResult;
            this.CreatedByUserID = CreatedByUserID;

            Mode = enMode.UpdateTest;
        }

        public clsTest()
        {
            this.TestAppointmentID = -1;
            this.TestID = -1;
            this.Notes = "";
            this.CreatedByUserID = -1;
            this.TestResult = false;

            Mode = enMode.AddNewTest;
        }

        bool AddNew()
        {
            this.TestID = clsTestsData
                .AddNewTest(TestAppointmentID, TestResult, Notes, CreatedByUserID);

            return (this.TestAppointmentID != -1);
        }

        bool Update()
        {
            return clsTestsData.UpdateTest(this.TestID, this.TestAppointmentID,
                this.TestResult, this.Notes, this.CreatedByUserID);
        }


        public bool Save()
        {

            clsTestAppointments testAppointments = clsTestAppointments.FindTestByTestAppointmentID(
                this.TestAppointmentID);

            testAppointments.IsLocked = true;

            if (!testAppointments.Save())
                return false; 

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
    }

}
