using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaVariables;
using CinemaAppLayer;
namespace CinemaBookingSystem1
{
    internal class CancellationUI
    {
        //Book Cancellation or Remove interface
        internal static void Remove()
        {
            Console.WriteLine("\n\n\t\t\t\t\t\t   BOOKING CANCELLATION        ");
            Console.Write("\n\n");
            CinemaAppLayer.CancellationApp.DisplayData1();

            try
            {
                Console.Write("Enter Customer No.:");
                String cusnum = Console.ReadLine();

                if (ApplicationLayer.ValidateInputs(cusnum))
                {
                    Console.Write("\n\n");
                    CineUILayer.StartingMenu();
                }
                else if (CancellationApp.ValidateIfcancel(true, cusnum))
                {
                    Console.Write("Customer num does not exist. Try again..");
                    Remove();
                }

                String cancel = $"Customer Number: {cusnum}";
                Console.Write("\nAre you sure? (Y/N):");
                char sige = Convert.ToChar(Console.ReadLine());
                Console.Write("\n");

                //removing
                if (ApplicationLayer.IterateData2(true, sige))
                {
                    if (ApplicationLayer.IterateData(true, sige))
                    {
                        CancellationApp.Remove(cancel);
                       Console.Write("Cancelled\n\n");
                         continueCancel();
                    }
                    else
                    {
                        Remove();
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Input");
                    Remove();
                }


            }
            catch (Exception hala)
            {
                Console.WriteLine();
                Console.WriteLine(hala.Message + "Try Again...");
                Console.WriteLine();
                Remove();
            }

        }
        private static void continueCancel()
        {
            Console.Write("Do you want to cancel again?(Y/N):");
            try
            {
                char sige2 = Convert.ToChar(Console.ReadLine());

                if (ApplicationLayer.IterateData2(true, sige2))
                {
                    if (ApplicationLayer.IterateData(true, sige2))
                    {
                        Remove();
                    }
                    else
                    {
                        Console.Write("\n");
                        CineUILayer.StartingMenu();
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Input");
                    continueCancel();
                }
            }
            catch (Exception ito)
            {
                Console.WriteLine("\nPlease Enter Y or N...");
                Console.WriteLine();
                continueCancel();

            }
        }
    }
}
