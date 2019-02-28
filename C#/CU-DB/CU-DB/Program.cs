using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CU_DB.DataManager;


namespace CU_DB
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Directory Path:");
            var path = Console.ReadLine();
            FileManager fileManager = new FileManager();
            fileManager.InsertFromFolder(path);
            Console.ReadKey();
        }
    }
}
