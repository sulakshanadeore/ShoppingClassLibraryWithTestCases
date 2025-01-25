using ClassLibraryForUnitTest;

namespace HRLibraryUnitTests
{
    [TestClass]
    public  class EmployeeTests
    {

        Employee emp = null;

   [TestInitialize]
        public void CreateObject()
        {
      Employee  emp = new Employee();

        }


        [TestCleanup]
        public void CleanupObject() 
        {
            emp = null;
        
        }

        [TestMethod]
        public void TestCheckForValidEmpID()
        {
         
            bool actual=emp.CheckForValidEmpID(-1);
            bool expected = true;
            Assert.AreNotEqual(expected,actual);
          //  Assert.-AreEqual(true,actual);
        }


        [TestMethod]
        public void Test_When_ValidateUser_IsSuccess()
        {
            string username = "Ana";
           string actual= emp.ValidateUser(username, "Ana@12345");
            string expected = "Welcome " + username;
            Assert.AreEqual(expected,actual);
        
        
        }
    }
}
