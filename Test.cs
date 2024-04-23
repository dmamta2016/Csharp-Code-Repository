//Author: Mr. John Doe 
//Date Created: 10th Aug 2004
using System;

class Test{
public void test()
{
       Console.WriteLine("Test");
}
}

class MainTest:Test{


public new void test()
{
       Console.WriteLine("MainTest");
}
}
class Demo{
public static void Main()  
{
Test t=new Test();
MainTest mt=new MainTest();
t.test();
mt.test();
Console.WriteLine("here");

}
}