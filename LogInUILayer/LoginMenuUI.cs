
using LoginAppLayer;
using CinemaBookingSystem1;
namespace LoginUILayer
{
    public class LoginMenuUI
    {
        static void Main(string[] args)
        { 
            Start();
        }
        public static void Start()
        {
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
            Console.WriteLine("       WELOCOME TO CINEMA BOOKING SYSTEM!        ");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-\n");
            Console.WriteLine("Select 1 = Enter as Admin");
            Console.WriteLine("Select 2 = Enter as Employee");
            Console.WriteLine("Select 3 = To Exit");
            Console.Write("\n");

            //validating purposes
            ApplicationLayer Input = new ApplicationLayer();

            Console.Write("Input: ");
            Input.Input = Console.ReadLine();

            switch (Input.Input)
            {
                case "1":
                    Console.Write("\n");
                    AdminAccesscode();
                    break;
                case "2":
                    Console.Write("\n");
                    Employeeportal();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Write("\n");
                    Console.WriteLine("Incorrect Input. Try Again...\n");
                    Start();
                    break;
            }
        }

        public static void AdminAccesscode()
        {
            ApplicationLayer AdminInput = new ApplicationLayer();


            Console.Write("Admin Access Code: ");
            AdminInput.Input = ApplicationLayer.ReadPassword("");
            if (ApplicationLayer.Adminval(true, AdminInput.Input))
            {
                Console.WriteLine("\nAdmin Accessed\n\n");
                Adminportal();
            }
            else
            {
                Console.WriteLine("\nAccess Denied!\n");
                AdminAccesscode();
            }
        }
        public static void Adminportal()
        {
            ApplicationLayer AdminInput = new ApplicationLayer();

            Console.WriteLine("ADMIN ACCOUNT LOG IN\n");
            Console.Write("Username: ");
            AdminInput.AUsername = Console.ReadLine();
            if (ApplicationLayer.validateStr(AdminInput.AUsername))
            {
                Console.Write("\n\n");
                Start();
            }
            Console.Write("Password: ");
            AdminInput.APassword = ApplicationLayer.ReadPassword("");
            if (ApplicationLayer.AdminLogIn(true,AdminInput.AUsername, AdminInput.APassword))
            {
                Console.Write("\n");
                Admin();
            }
            else
            {
                Console.WriteLine("\nAdmin Login failed\n");
                Adminportal();
            }

        }
        public static void Employeeportal()
        {
            ApplicationLayer EmployeeInput = new ApplicationLayer();

            Console.WriteLine("EMPLOYEE ACCOUNT LOG IN\n");
            Console.Write("Username: ");
            EmployeeInput.EUsername = Console.ReadLine();
            if (ApplicationLayer.validateStr(EmployeeInput.EUsername))
            {
                Console.Write("\n\n");
                Start();
            }
            Console.Write("Password: ");
            EmployeeInput.EPassword = ApplicationLayer.ReadPassword("");
            if(ApplicationLayer.EmployeeLogIn(true,EmployeeInput.EUsername, EmployeeInput.EPassword))
            {
                Console.WriteLine("\nEmployee Login succesful\n\n");
                Console.WriteLine($"Employee Name:  {EmployeeInput.EUsername}");
                CineUILayer.StartingMenu();
            }
            else
            {
                Console.WriteLine("\nEmployee Login failed\n");
                Employeeportal();
            }
            

        }

        public static void Admin()
        {
            ApplicationLayer Input = new ApplicationLayer();
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
            Console.WriteLine("                  Welcome  Admin                ");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-\n");

            Console.WriteLine("Select 1 = Add Admin Account");
            Console.WriteLine("Select 2 = Add Employee Account");
            Console.WriteLine("Select 3 = Back to Main Portal");
            Console.Write("\nInput: ");
            Input.Input = Console.ReadLine();
           
            switch (Input.Input)
            {
                case "1":
                    Console.WriteLine("\n\nADMIN SIGN UP\n");
                    Console.Write("New Username: ");
                    Input.AUsername = Console.ReadLine();
                  
                    Console.Write("New Password: ");
                    Input.APassword = ApplicationLayer.ReadPassword("");
                    ApplicationLayer.AdminSignUp(Input.AUsername, Input.APassword);
                    Console.WriteLine("\nSuccessfully Stored!." + "\n");
                    Admin();
                    break;

                case "2":
                    Console.WriteLine("\n\nEMPLOYEE SIGN UP\n");
                    Console.Write("New Username: ");
                    Input.EUsername = Console.ReadLine();
                    Console.Write("New Password: ");
                    Input.EPassword = ApplicationLayer.ReadPassword("");
                    ApplicationLayer.EmployeeSignUp(Input.EUsername, Input.EPassword);
                    Console.WriteLine("\nSuccessfully Stored!." + "\n");
                    Admin();
                    break;
                case "3":
                    Console.Write("\n");
                    Start();
                    break;
                default:
                    Console.WriteLine("\nInvalid Input. Try Again...\n");
                    Admin();
                    break;
            }
        }
       
    }
}

