using CinemaVariables;
namespace CinemaBookingSystem1
{
    public class CineUILayer
    {

        public static void StartingMenu()
        {
            Variables SelectInput = new Variables();
           
            Console.WriteLine("\n\n\t\t\t\t-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
            Console.WriteLine("\n\t\t\t\t\t   WELOCOME TO CINEMA BOOKING SYSTEM!        ");
            Console.WriteLine("\n\t\t\t\t-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
            Console.Write("\n\t\t\t\t\t\t\t\t\t\t");
            Console.WriteLine(SelectInput.dateNow.ToString("D"));
            Console.WriteLine("\n\n\t\t Select 1 --> Booking");
            Console.WriteLine("\n\n\t\t Select 2 --> View All Transactions");
            Console.WriteLine("\n\n\t\t Select 3 --> Search Customer Transaction");
            Console.WriteLine("\n\n\t\t Select 4 --> Exit");
            Console.Write("\n");
            Console.Write("\n\n\t\tSelected input:");
            try
            {
                SelectInput.Selected_num = Convert.ToInt32(Console.ReadLine());
                int userSelect = SelectInput.Selected_num;

                switch (userSelect)
                {
                    case 1:
                        Console.Write("\n");
                        Displaymenu2();

                        break;
                    case 2:
                        Console.Write("\n\n");
                        ViewTransactionsUI.ReadTransact();
                        break;
                    case 3:
                        Console.Write("\n\n");
                        ViewTransactionsUI.Search();
                        break;
                    case 4:
                        Console.Write("\n");
                        Console.Write("GoodBye!\n");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nInvalid input\n");
                        StartingMenu();
                        break;
                }

            }
            catch (Exception not)
            {
                Console.WriteLine("\n\n\t\tInvalid User Input" + not.Message);
                Console.Write("\n");
                StartingMenu();
            }
        }

        internal static void Displaymenu2()
        {
            Variables SelectInput = new Variables();
            List<string> infos = new List<string>();
            Console.WriteLine("\n\n\t\t Select 1 --> Update Cinema Booking");
            Console.WriteLine("\n\n\t\t Select 2 --> Cancel Cinema Booking");
            Console.WriteLine("\n\n\t\t Select 3 --> Back to Main Menu");
            Console.Write("\n");

            Console.Write("\n\n\t\tUser Input:");
            try
            {
                SelectInput.Selected_num = Convert.ToInt32(Console.ReadLine());
                int input = SelectInput.Selected_num;


                switch (input)
                {
                    case 1:
                        Console.Write("\n\n");
                        BookingUI.AddMovie(infos);

                        break;
                    case 2:
                        Console.Write("\n");
                        Console.WriteLine("\n\n\t\tNote: Chosen transaction to cancel will be remove from your data...");
                        CancellationUI.Remove();
                        break;
                    case 3:
                        Console.Write("\n\n");
                        StartingMenu();
                        break;
                    default:
                        Console.WriteLine("\n\n\t\tInvalid input");
                        Displaymenu2();
                        break;
                }
            }
            catch (Exception notnum)
            {

                Console.WriteLine("\n\n\t\tInvalid User Input");
                Console.Write("\n");
                StartingMenu();

            }

        }
    }
}