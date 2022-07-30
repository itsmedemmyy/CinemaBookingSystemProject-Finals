using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaVariables;
using CinemaAppLayer;
namespace CinemaBookingSystem1
{
    internal class BookingUI
    {
        private static Variables add = new Variables();

        //Booking or Adding Interface
        internal static List<string> AddMovie(List<string> Infos)
        {
            CinemaAppLayer.BookingApp.MovieListDisplay();
            List<string> Movies = new List<string>();
            Movies = CinemaAppLayer.BookingApp.MovieList(Movies);

            try
            {
                Console.Write("\n");

                add.CusNum = CinemaAppLayer.BookingApp.CustomerNum();
                Console.WriteLine("Customer No.:" + add.CusNum);
                Console.Write("\n");

                Console.Write("Customer Name:");
                add.CusName = Console.ReadLine();
                if (ApplicationLayer.ValidateInputs(add.CusName))
                {
                    Console.Write("\n\n");
                    AddMovie(Infos);
                }
                Console.Write("\n");
                Console.WriteLine("///Select the Movie Number you Choose///\n");

                Console.Write("Movie Number:");
                add.Number = Convert.ToInt32(Console.ReadLine());
                if (ApplicationLayer.ValidateInt(add.Number))
                {
                    Console.Write("\n\n");
                    CineUILayer.StartingMenu();
                }

                Console.WriteLine("\n\n>> Movie Selected: " + "\"" + Movies[add.Number] + "\"<<");

                Console.Write("\n\nSelected Time (hh:mm):");
                add.Time = Console.ReadLine();
                if (ApplicationLayer.ValidateInputs(add.Time))
                {
                    Console.Write("\n\n");
                    CineUILayer.StartingMenu();
                }

                add.Price = CinemaAppLayer.BookingApp.Price(add.Number, add.Price);
                Console.Write("\nMovie Price:" + add.Price);
                Console.Write("\n");

                Console.Write("\nNo of Ticket(s):");
                add.Ticket = CinemaAppLayer.BookingApp.Ticket(add.Ticket);
                if (ApplicationLayer.ValidateInt(add.Ticket))
                {
                    Console.Write("\n\n");
                    CineUILayer.StartingMenu();
                }
            }
            catch (FormatException format)
            {
                Console.WriteLine();
                Console.WriteLine(format.Message + "Try Again...");
                Console.WriteLine();
                AddMovie(Infos);
            }
            add.Totalprice = CinemaAppLayer.BookingApp.TotalPrice(add.Price, add.Ticket);  //Price Formula
            var date = "";
            var date1 = CinemaAppLayer.BookingApp.Date(date);
            Console.WriteLine("\n" + "Transaction date:" + date1);
            Console.WriteLine($"\nTotal Price: {add.Totalprice}");

            //saving..
            Infos.Add($"Customer Number: {add.CusNum}    Customer: {add.CusName}    Movie: {Movies[add.Number]}    Selected Time: {add.Time}    Ticket: {add.Ticket}" +
            $"   Transaction Date: {date1}    Total Price(Php): {add.Totalprice}");

            CinemaAppLayer.BookingApp.AddData(Infos);

            Console.WriteLine("\nSuccessfulyy Added!\n");

            Console.WriteLine("RECEIPT:\n");

            var added = ($"Customer Number: {add.CusNum}\nCustomer: {add.CusName}\nMovie: {Movies[add.Number]}\n" +
                $"Selected Time: {add.Time}\nTicket: {add.Ticket}\n{date}\nTotal Price: Php {add.Totalprice}");

            Console.WriteLine(added + "\n");

            BookingUI.ContinueAdd(Infos);

            //Loop back or exit

            return Infos;
        }
        private static List<string> ContinueAdd(List<string> a)
        {
            Console.Write("Go back to menu? (Y/N):");
            try
            {
                char c = Convert.ToChar(Console.ReadLine());
                if (ApplicationLayer.IterateData2(true, c))
                {
                    if (ApplicationLayer.IterateData(true, c))
                    {
                        Console.Write("\n");
                        CineUILayer.Displaymenu2();
                    }
                    else
                    {
                        Console.Write("\n");
                        ContinueAdd(a);
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Input");
                    ContinueAdd(a);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("\nPlease Enter Y or N...");
                Console.WriteLine();
                ContinueAdd(a);

            }
            return a;
        }
    }
}
