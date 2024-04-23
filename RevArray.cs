//Author: Mr. John Doe 
//Date Created: 28th Sept 2004
//Description: This program demonstrates the methods of  
//Array class

using System;

class RevArray
{
	static void Main()
	{
		int[] ArrayToReverse = {1,2,3,4,5,6,7};
	
		Console.WriteLine("Contents of Array before Reversing:\n");	
		DisplayArray(ArrayToReverse); 
		//Displays the Contents of the Array

		Array.Reverse(ArrayToReverse); 
		//Reverses the Array Contents
	
		Console.WriteLine("\n\nContents of Array after Reversing:\n");
		DisplayArray(ArrayToReverse); 
		//Displays the Contents after //Reversing
	}	

	public static void DisplayArray(Array pArray)
	{
		foreach(int t in pArray) 
		{
			Console.WriteLine(t);
		}
	}

}
