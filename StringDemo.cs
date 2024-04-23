//Author: Mr. John Doe 
//Date Created: 2nd Oct 2004
//Description: This program demonstrates an application using
//the String class

using System;
using System.Text;

	class StringDemo
	{
	    // The main entry point for the application.
		static void Main(string[] args)
		{
			int strLen;
			string revStr = "";
			Console.Write("Type a string to reverse:");
			string str1 = Console.ReadLine();
			strLen = str1.Length;
			Console.WriteLine("Length of the string is" + " " + strLen);
			for(int index = strLen-1;index >= 0;index--)
			{
				revStr += str1[index];
			}
			Console.WriteLine("The reversed string is:" + revStr);
			Console.ReadLine();
			//replace all a's with z's
			Console.Write("Type a string: ");
			string str2 = Console.ReadLine();
			Console.WriteLine("All the 'a's in string replaced with 'z'" + str2.Replace('a','z'));
			Console.ReadLine();
			int strLen2 = str2.Length;
			Console.Write("Input the number of characters of the string to retrieve");
			int num = int.Parse(Console.ReadLine());
			string initOfString = str2.Substring(0,num);
			string endOfString = str2.Substring((strLen2-num),num);
			Console.WriteLine("The first {0} characters of the string are {1}", num,initOfString);
			Console.WriteLine("The last {0} characters of the string are {1}", num,endOfString);
			Console.ReadLine();
		}
	}
