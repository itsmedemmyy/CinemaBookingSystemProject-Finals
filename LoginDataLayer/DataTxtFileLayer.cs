namespace LoginDataLayer
{
    public class DataTxtFileLayer
    {
        private string AdminfilePath = @"C:\Users\maglinte\source\repos\CinemaBookingSystem\LoginDataLayer\bin\Debug\net6.0\AdminCreds.txt";
        private string EmployeefilePath = @"C:\Users\maglinte\source\repos\CinemaBookingSystem\LoginDataLayer\bin\Debug\net6.0\EmployeeCreds.txt";
        public bool AdminLogin(bool isALogin,string input)
        {
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(AdminfilePath).ToList();

            if (lines.Contains(input))
            {
                isALogin = true;

            }
            else
            {
                isALogin=false;
               
            }
            return isALogin;

        }

        public bool EmployeeLogin(bool isElogin, string input)
        {
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(EmployeefilePath).ToList();

            if (lines.Contains(input))
            {
                isElogin = true;
               
            }
            else
            {
                isElogin = false;
              
            }
            return isElogin;

        }

        public void AdminSignUp(string input)
        {
            using (StreamWriter sw = File.AppendText(AdminfilePath))
            {
                sw.WriteLine("\n");
                sw.WriteLine(input);

            }
           
        }
        public void EmployeeSignUp(string input)
        {
            using (StreamWriter sw = File.AppendText(EmployeefilePath))
            {
                sw.WriteLine("\n");
                sw.WriteLine(input);

            }
          
        }
    }
}