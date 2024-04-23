//Author: Mr. John Doe 
//Date Created: 10th Oct 2004
//Description: This program demonstrates the use of Type class 

namespace ReflectionExample
{
	using System;
	using System.Reflection;
	public class RefExample2
	{
		private int sum;

		public void addition(int a, int b)
		{
			sum= a + b;
		}

	
		public static int Main()
		{
			Type t1= typeof(RefExample2); 
			MemberInfo[] memInfo = t1.GetMembers();
			foreach (MemberInfo mInfo in memInfo)
			{
				Console.WriteLine(mInfo);
			}
			Console.ReadLine();
			return 0;
			
		}
	}

}
