using System;
namespace CSVHelperAndJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("# Read data from CSV & Write data in CSV\n");

            Console.WriteLine("Enter 1 : To Read the Person Contact as CSV file\n" +
                "Enter 2 : To  Read the Person Contact as JSON file\n");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CSVHandler.ImplementCSVDataHandling();
                    break;
                case 2:
                    ReadCSV_And_WriteJSON.ImplementCSVToJSON();
                    break;
            }
          Console.ReadKey();
        }
    }
}