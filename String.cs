using System;
using System.IO;
using System.Data;

public class String {
    public static void Main() {
try{
         string linetext;
	TextReader printStream	= new StreamReader(@"D:\ACCP China Junior Sem 3\Project Code\Supermarket2.0\bin\Debug\2004\09\28.txt");
					string deLimiter="\t";

			char [] delimiter=deLimiter.ToCharArray ();
			string[] splitStr = null;
			string[] dataStr = new string [6];
			linetext = printStream.ReadLine();
			linetext = printStream.ReadLine();
			linetext = printStream.ReadLine();
			while (printStream.Peek() >= 0)
			{
			   linetext = printStream.ReadLine();   
			   
			   splitStr = linetext.Split(delimiter,12); 
                           dataStr = new string [6];
		           int index = 0;
 	                   foreach (string singleStr in splitStr)
		           { 
		             if (singleStr.Trim().Length >0)
		             {
			        dataStr[index] = singleStr;
			        index++;
		             }
		           }
 		        foreach (string singleStr in dataStr)
			{
			  Console.WriteLine(singleStr);
			}
			
    }//end of while
    }catch(Exception e){  Console.WriteLine(e.StackTrace);
      Console.WriteLine(e.Message);
    }
    }
    }

