//Author: Mr. John Doe 
//Date Created: 2nd Oct 2004
//Description: This program demonstrates the use of ToUpper 
//and ToLower  methods of String class

using System;
using System.Text; 

class UpperLowerDemo
	{
		// The main entry point for the application.
		static void Main(string[] args)
		{
			Console.Write("Enter your name:");
			string strName=Console.ReadLine();
			Console.WriteLine("Your name in uppercase letters is: "+strName.ToUpper());
			Console.WriteLine("Your name in lowercase letters is: "+strName.ToLower()); 
			Console.ReadLine();
						
		}
	}
