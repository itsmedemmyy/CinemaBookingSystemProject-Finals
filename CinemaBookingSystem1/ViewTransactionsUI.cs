using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaVariables;
using CinemaAppLayer;
namespace CinemaBookingSystem1
{
    internal class ViewTransactionsUI
    {
        //ViewAll/ Read Interface
        internal static void ReadTransact()
        {
            Console.WriteLine("\n\n\t\t\t\t\t\t  ********BOOKED TRANSACTION DATA********\n\n");
            CinemaAppLayer.ApplicationLayer.Display_Transaction();
            Back();
        }

        //Search interface
        internal static void Search()
        {

            Variables find = new Variables();
            Console.Write("Enter Customer Number:");
            find.CusNum = Console.ReadLine();
            if (ApplicationLayer.ValidateInputs(find.CusNum))
            {
                Console.Write("\n\n");
                Search();
            }
            else if (find.CusNum.Where(char.IsLetterOrDigit).Count() != 9)
            {
                Console.Write("\n");
                Console.WriteLine("Data does not exist\n");
                continueSearchin();
            }
            //searching..
            Console.WriteLine();
            ApplicationLayer.Search(find.CusNum);
            continueSearchin();
        }
        private static void continueSearchin()
        {
            Console.Write("\nContinue searching? (Y/N):");
            try
            {
                char go = Convert.ToChar(Console.ReadLine());

                if (ApplicationLayer.IterateData2(true, go))
                {
                    if (ApplicationLayer.IterateData(true, go))
                    {
                        Console.Write("\n\n");
                        Search();
                    }
                    else
                    {
                        Console.Write("\n\n");
                        CineUILayer.StartingMenu();
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Input");
                    continueSearchin();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("\nPlease Enter Y or N...");
                Console.WriteLine();
                continueSearchin();
            }
        }
        private static void Back()
        {
            Console.Write("\nGo to Main Menu? (Y/N):");
            try
            {
                char go = Convert.ToChar(Console.ReadLine());

                if (ApplicationLayer.IterateData2(true, go))
                {
                    if (ApplicationLayer.IterateData(true, go))
                    {
                        Console.Write("\n\n");
                        CineUILayer.StartingMenu();
                    }
                    else
                    {
                        Back();
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Input");
                    Back();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("\nPlease Enter Y or N...");
                Console.WriteLine();
                Back();
            }

        }
    }
}
