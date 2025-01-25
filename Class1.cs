namespace ClassLibraryForUnitTest
{
    public class Employee
    {

        public bool CheckForValidEmpID(int empid)
        { 
        if (empid > 0) {return true;}
        return false;
        
        }

        public string ValidateUser(string username, string password)
        {
            string msg = null;
            if (username != null || password != null)
            {
                if (username == "Ana" && password == "Ana@12345")
                {
                    msg = "Welcome " + username;
                }
            }
            else {
                msg = "Check your credentials.";
            
            }
            return msg;
        
        }
    }
}
