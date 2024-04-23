//Author: Mr. John Doe 
//Date Created: 10th Oct 2004
//Description: This program demonstrates the use of reflection 

namespace ReflectionExample
{
using System;

public class RefExample1
{
	public int addition(int a, int b)
	{
	return a+b;
	}

	
	public static int Main()
	{
		Type t1= typeof(RefExample1); 	//Class Reference
		RefExample1 obj1=new RefExample1();
		Type t2 = obj1.GetType();	// Object Reference
		Console.WriteLine("The type of obj1 is :  {0} ", t2);
		Console.WriteLine("The type of RefExample is :  {0}", t1);
Console.WriteLine("The Namespace of RefExample is :  {0} ", t1.Namespace);
		return 0;
	}
}

}
