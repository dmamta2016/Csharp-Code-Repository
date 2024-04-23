using System;

namespace SupermarketProject
{
	/// <summary>
	/// Summary description for SalesAdminManagement1.
	/// </summary>
	public class TestDate
	{
		public TestDate()
		{
			DateTime d = new DateTime (DateTime.Today.Year, DateTime.Today.Month,DateTime.Today.Date-7);
			Console.WriteLine(d.TosTring());
             
		}
	}
}
