//Author: Mr. John Doe 
//Date Created: 10th July 2004
//Description: The following code is used for calculating the square of a number
//accepted from the user. 
//
using System;
class SquareTest{
public static string Main()  
{
int number, result;
Console.WriteLine("Enter a number: ");
number=Convert.ToInt32(Console.ReadLine());
result = square(number);
Console.WriteLine ("The square is "+result);
return "5";
}

//Description: The following code is used for calculating the square of a number 
//accepted from the user.
//Parameters passed: 
//Name: number
//Type: int
//Purpose: To hold actual number for which the square is calculated

static int square(int number)
{
    if (number == 0) 
    	 return (0); // 0 is the square for 0
   else
         return (number * number); 
}
}
