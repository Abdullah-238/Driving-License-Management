using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLV2_BusinessLogic
{
    public  class clsTestTypes
    {
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal TestTypeFees { get; set; }

        public enum enTestType { eVisonTest =1 , eWrittenTest , eStreetTest};
        clsTestTypes(int testTypeID, string testTypeTitle
            , string testTypeDescription, decimal testTypeFees)
        {
            this.TestTypeID = testTypeID;
            this.TestTypeTitle = testTypeTitle;
            this.TestTypeDescription = testTypeDescription;
            this.TestTypeFees = testTypeFees;
        }
        public static DataTable GetAllTestTypes()
        {
            return clsTestTypesData.GetAllTestTypes();
        }
        public static clsTestTypes FindTestTypeID(int TestTypeID)
        {
            bool isFound = false;
            string TestTypeTitle = ""; decimal TestTypeFees = 0;
            string TestTypeDescription = "";


            isFound = clsTestTypesData.FindByTestTypes(TestTypeID, ref TestTypeTitle,ref TestTypeDescription
                ,ref TestTypeFees);

            if (isFound)
                return new clsTestTypes(TestTypeID,  TestTypeTitle,  TestTypeDescription,
                 TestTypeFees);
            else
                return null;

        }
        public bool UpdateTest()
        {
            return clsTestTypesData.Update(this.TestTypeID,
                this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
        }

    }
}
