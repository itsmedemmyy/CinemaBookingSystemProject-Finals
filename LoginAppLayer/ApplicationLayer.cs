using LoginDataLayer;
namespace LoginAppLayer
{
    public class ApplicationLayer
    {
        //variables
        public string Input { get; set; }
        public string AUsername { get; set; }
        public string APassword { get; set; }
        public string EUsername { get; set; }
        public string EPassword { get; set; }



        //validating variables
        public static int anInt;


        //Validations

        static public bool validateStr(string data)
        {

            if (data == "")
            {
                return true;

            }
            return false;
        }
        public static bool Adminval(bool isAdmin,string Input)
        {

            if (Input == "1234")
            {
                isAdmin = true; 
            }
            else
            {
                isAdmin = false;
                
            }
            return isAdmin;
        }

        public static bool AdminLogIn(bool tru,string Input, string Input2)
        {
            DataTxtFileLayer credcheck = new DataTxtFileLayer();

            String Alogincred = "Username: " + Input + " Password: " + Input2;
            if (credcheck.AdminLogin(true, Alogincred))
            {
                tru = true;
            }
            else 
            {
                tru = false;              
            }
            return tru;

        }

        public static void AdminSignUp(string Input, string Input2)
        {
            DataTxtFileLayer credstore = new DataTxtFileLayer();

            String Alogincred = "Username: " + Input + " Password: " + Input2;
            credstore.AdminSignUp(Alogincred);

        }
        public static void EmployeeSignUp(string Input, string Input2)
        {
            DataTxtFileLayer credstore = new DataTxtFileLayer();

            String Alogincred = "Username: " + Input + " Password: " + Input2;
            credstore.EmployeeSignUp(Alogincred);

        }
        public static bool EmployeeLogIn(bool isEmp,string Input, string Input2)
        {
            DataTxtFileLayer credcheck = new DataTxtFileLayer();

            String Elogincred = "Username: " + Input + " Password: " + Input2;
            if (credcheck.EmployeeLogin(true, Elogincred))
            {
                isEmp = true;
            }
            else
            {
                isEmp = false;    
            }

            return isEmp;

        }
        public static bool wishToContinue(bool wish, char w)
        {
            
                if (w == 'Y' || w == 'y')
                {
                    wish = true;
                }
                else if (w == 'N' || w == 'n')
                {
                    wish = false;
                }

            return wish;
        }
        public static bool valWishTo(bool val, char z)
        {
        if (z == 'Y' || z == 'y' || z == 'N' || z == 'n')
        {
                val = true;
            }
            else
            {
                val = false;
            }
            return val;
        }
        public static string ReadPassword(string pass)
        {
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Escape:
                        return null;
                    case ConsoleKey.Enter:
                        return pass;
                    case ConsoleKey.Backspace:
                        if (pass.Length > 0)
                        {
                            pass = pass.Substring(0, (pass.Length - 1));
                            Console.Write("\b \b");
                        }
                        break;
                    default:
                        pass += key.KeyChar;
                        Console.Write("*");

                        break;
                }

            }

        }

    }
}