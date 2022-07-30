using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaDataLayer;
namespace CinemaAppLayer
{
    public class CancellationApp
    {
      
        public static void DisplayData1()
        {
            List<string> dataContent = TxtFileStream.ReadFile();

            foreach (var data in dataContent)
            {
                  Console.WriteLine($"{data}\n");
            }
        }
       public static string Remove(string remove)
        {
            TxtFileStream.DeleteTransactInFile(remove);
            return remove;
            
        }
        public static bool Continue_cancel(bool cont, char y)
        {
            try
            {
                cont = false;
                y = Convert.ToChar(Console.ReadLine());
                if(y == 'Y' || y == 'y')  
                {
                    cont = true;
                    ApplicationLayer.IterateData(true, y);
                }
                else
                {
                    ApplicationLayer.IterateData(false, y);
                }

            }catch(Exception e)
            {

            }
            
            return cont;
        }
       static public bool ValidateIfcancel(bool v, string s)
        {
          
              List<string> dataContent1 = TxtFileStream.ReadFile();

            foreach (var data in dataContent1)
            {
                  if (!data.Contains(s))
                {
                    v = true;
                    
                }
                else
                {
                    v = false;

                }

            }
            return v;
        }
    }
}
