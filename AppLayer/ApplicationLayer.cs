using CinemaDataLayer;
namespace CinemaAppLayer
{
    public class ApplicationLayer
    {

        static public bool ValidateInputs(string data)
        {

            if (data == "")
            {
               return true;
    
            }
            return false;
        }
        static public bool ValidateInt(int data)
        {
      

            if (data < 0)
            {
                return true;
               
            }
            return false;
        }

       
        static public bool IterateData(bool ok, char exit)
        {
          

                if (exit == 'Y' || exit == 'y')
                {

                    ok = true;

                }
                else if (exit == 'N' || exit == 'n')
                {
                    ok = false;
                  
                }
 
            return ok;
        }
        static public bool IterateData2(bool ok2, char exit1)
        {
            if (exit1 == 'Y' || exit1 == 'y' || exit1 == 'N' || exit1 == 'n')
            {
                ok2 = true;
              
            }
            else
            {
                ok2 = false;

            }
            return ok2;
        }
        //ReadData
        public static void Display_Transaction()
        {
            List<string> dataContent = TxtFileStream.ReadFile();

            foreach (var data in dataContent)
            {
                Console.WriteLine($"{data.ToUpper()}\n");
            }
        }
        public static string Search(string finds)
        {
         TxtFileStream.SearchTransactInFile(finds);

            return finds;
        }
    }
}