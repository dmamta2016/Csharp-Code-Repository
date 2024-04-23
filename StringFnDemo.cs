//Author: Mr. John Doe 
//Date Created: 2nd Oct 2004
//Description: This program demonstrates the use of Length property of String class in C#

using System;
using System.Text; 

	class StringFnDemo
	{
		/// The main entry point for the application.
		
		static void Main(string[] args)
		{
			int result;
			Console.Write("Enter the first string:");
			string str1 = Console.ReadLine();
			Console.Write("Enter the second string:");
			string str2 = Console.ReadLine();
			result = string.Compare(str1,str2);
			if(result == 0)
			{
				Console.WriteLine("Both the strings are equal");
			}
			else
			{
				Console.WriteLine("The strings are unequal");
			}
								
		}
	}
