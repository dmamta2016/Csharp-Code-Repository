using System;



/// <summary>	
/// Summary description for SalesAdminManagement1.	
/// </summary>	

	public class TestWeek
	{	
		public TestWeek()
		{	
 		DateTime today = DateTime.Today.Date;
		int weekday=-1;
switch (today.DayOfWeek)
{
case DayOfWeek.Saturday: weekday=6; break;
case DayOfWeek.Friday: weekday=5;break;
case DayOfWeek.Thursday: weekday=4;break;
case DayOfWeek.Wednesday: weekday=3;break;
case DayOfWeek.Tuesday: weekday=2;break;
case DayOfWeek.Monday: weekday=1;break;
case DayOfWeek.Sunday: weekday=0;break;
}
		Console.WriteLine(weekday);
		DateTime answer = today.AddDays(-weekday);

		Console.WriteLine(answer);
		
		
		}	
		
		public static void Main()
		{
		TestWeek x = new TestWeek();
		
		}

	}

	


