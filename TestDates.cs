using System;



/// <summary>	
/// Summary description for SalesAdminManagement1.	
/// </summary>	

	public class TestDate	
	{	
		public TestDate()
		{	
 		DateTime today = DateTime.Today.Date;
		DateTime answer = today.AddDays(-1461);
		//Console.WriteLine("{0: dd/MM/yyyy}", answer);
		Console.WriteLine(answer.ToString("d"));

		Console.WriteLine(answer.Month.ToString());
		Console.WriteLine(answer.Year);
		Console.WriteLine(answer.Day.ToString());	
		
		
		}	
		
		public static void Main()
		{
		TestDate x = new TestDate();
		
		}

	}

	


