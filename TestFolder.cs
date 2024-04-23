using System;
using System.IO;

namespace SupermarketProject
{
	public class TestDate
	{
		public static void Main()
		{

              DateTime dt = DateTime.Today;
			string currentDate = dt.ToString("dd/MM/yyyy") ;
			string logFileName,folder;
		    logFileName=currentDate.Substring(0,2)+".txt";
			folder = @".\"+currentDate.Substring(6,4);
			Console.WriteLine (folder);
			folder = folder +@"\"+currentDate.Substring(3,2);
		// Determine whether the directory for logfile exists.
            if (Directory.Exists(folder)) 
            {
                Console.WriteLine("That folder exists already.");
             }

            // Try to create the directory.
         DirectoryInfo dInfo =  Directory.CreateDirectory(folder);
         Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(folder));
         StreamWriter logFile = new StreamWriter (folder+@"\"+logFileName);
         Console.WriteLine("File created "+folder+@"\"+logFileName);
logFile.WriteLine ("Teller Id:\tBillNo:\tStockId:\tQuantity:\tUnitPrice");
logFile.WriteLine("======================================");
			logFile.Close();
		}
	}
}
