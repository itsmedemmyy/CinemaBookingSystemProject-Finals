using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaDataLayer;
namespace CinemaAppLayer
{
    public class BookingApp
    {
        public static List<string> MovieList(List<string> Movies)
        {
            Movies.Add($"Doctor Strange in the Multiverse of Madness");
            Movies.Add($"Thor Love and Thunder");
            Movies.Add($"Black Panther Wakanda Forever");
            Movies.Add($"Guardian of the Galaxy Vol.3");
            Movies.Add("Minions: The Rise of Gru");

            for (int a = 0; a < Movies.Count; a++)
            {
                
            }
            return Movies;
        }
        private static Random random = new Random();
        public static int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }
        public static string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);

           
            char offset = lowerCase ? 'a' : 'A'; 
            const int lettersOffset = 26; // A...Z or a..z: length = 26  

            for (var i = 0; i < size; i++)
            {
                var chariz = (char)random.Next(offset, offset + lettersOffset);
                builder.Append(chariz);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }

        // Generates a both string and number.  
        // 3-LowerCase + 4-Digits + 2-UpperCase  
        public static string CustomerNum()
        {
            var cusnum = new StringBuilder();
           
            cusnum.Append(RandomString(2));
            cusnum.Append(RandomString(3, true));
            cusnum.Append(RandomNumber(1000, 9999));
           
            return cusnum.ToString();
        }
        public static int Price(int a, int price)
        {
            List<string> m = new List<string>();
            MovieList(m);
            
                if (a == 0)
                {
                    price = 357;
                }
                else if (a == 1)
                {
                    price = 350;
                }
                else if (a == 2)
                {
                    price = 370;
                }
                else if (a == 3)
                {
                    price = 365;
                }
                else if (a == 4)
                {
                    price = 300;
                }

            return price;
        }
        public static int Ticket(int ticket)
        {
            ticket = Convert.ToInt32(Console.ReadLine());
            return ticket;
        }
        public static int TotalPrice(int price, int ticket)
        {
            return price * ticket;
        }   
        public static string Date(string date)
        {
            DateTime dat = DateTime.Now;
            date = dat.ToString("MM/dd/yyyy");
            return date;
        }
        //saving
        public static List<string> AddData(List<string> add)
        {
            TxtFileStream.CreateUpdateFile(false, add);
            
            return add;
        }
       
        public static void MovieListDisplay()  //UI or app layer?
        {
            List<string> Movie1 = new List<string>();

            Console.WriteLine("Now Showing Movies...\n");

            Movie1.Add($"Movie: Doctor Strange in the Multiverse of Madness\nPrice: Php 357\nTime: 12:15 17:50 19:00 ");
            Movie1.Add($"Movie: Thor Love and Thunder\nPrice: Php 350\nTime: 13:20 15:10 18:00");
            Movie1.Add($"Movie: Black Panther Wakanda Forever\nPrice: Php 370\nTime: 10:20 12:05 16:00");
            Movie1.Add($"Movie: Guardian of the Galaxy Vol.3\nPrice: Php 365\nTime: 14:20 16:12 19:00");
            Movie1.Add($"Movie: Minions: The Rise of Gru\nPrice: Php 300\nTime: 09:40 14:12 18:30");

            for (int a = 0; a < Movie1.Count; a++)
            {
                Console.WriteLine("Movie Number: " + a);
                Console.WriteLine(Movie1[a] + "\n");

            }

        }
    }
}
