using CinemaVariables;
namespace CinemaDataLayer
{
    public class TxtFileStream
    {
         private static string FullPath = @"C:\Users\maglinte\source\repos\CinemaBookingSystem\CinemaDataLayer\bin\Debug\net6.0\Booking_Transact" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";

        public static void CreateUpdateFile(bool isNewFile, List<string> dataInput)
        {
            if (isNewFile)
            {
                using (StreamWriter file = File.CreateText(FullPath))
                {

                    WriteTransactionInFile(file, dataInput);
                }
            }
            else
            {
                using (StreamWriter file = File.AppendText(FullPath))
                {
                    WriteTransactionInFile(file, dataInput);
                }
            }
        }

        private static void WriteTransactionInFile(StreamWriter file, List<string> dataInput)
        {
            foreach (var data in dataInput)
            {
                file.WriteLine(data);
            }
        }

        public static List<string> ReadFile()
        {
            List<string> dataContent = new List<string>();

            using (StreamReader sr = new StreamReader(FullPath))
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    dataContent.Add(line);
                    line = sr.ReadLine();
                }
            }

            return dataContent;
        }

        public static bool DeleteTransactInFile(string dataToDelete)
        {
            List<string> existingData = ReadFile(); // string list for read
            List<string> tempItems = new List<string>(); //create new string list 

            if (existingData.Count > 0) //if files exist count = 1
            {
                foreach (var data in existingData) // read each line in txtfile
                {
                    if (!data.Contains(dataToDelete)) //search specified data not in file
                    {
                        tempItems.Add(data); // that data will be added in list
                    }
                }
                File.Delete(FullPath); // delete existing file
                CreateUpdateFile(true, tempItems); //creates new file with other existing data
                                                   //but without specified data that been chosen to  remove
                return true;
            }

            return false;
        }
        public static bool SearchTransactInFile(string dataToSearch)
        {
            String line;
            using (StreamReader file = new StreamReader(FullPath))
            {

               while ((line = file.ReadLine()) != null) // search specified item in file if it's contains
                {

                    while (line.Contains(dataToSearch))
                    {
                        Console.WriteLine(line);
                        break;
                    } 
                }

                return true;
            }
        }
        }
    }
