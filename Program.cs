using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* public interface IAccount
 {
     bool AcceptDetails();
     double CalculateInterest();
     double GetBalance();
     void Display();
 }
 class FixedAccount : IAccount
 {
     /// <summary>
     /// String field to store the account holder name.
     /// </summary>
     private string _accountHolder;

     /// <summary>
     /// Long field to store the account number.
     /// </summary>
     private long _accountNumber;

     /// <summary>
     /// Float field to store the interest rate.
     /// </summary>
     private float _interestRate;

     /// <summary>
     /// Integer field to store the years of deposit.
     /// </summary>
     private int _numberOfYears;

     /// <summary>
     /// Double field to store the interest earned on the deposit amount.
     /// </summary>
     private double _interestEarned;

     /// <summary>
     /// Double field to store the total balance including the interest earned.
     /// </summary>
     private double _totalBalance;

     /// <summary>
     /// Double field to store the amount deposited by the user.
     /// </summary>
     private double _deposit;

                 /// <summary>
     /// Method to accept the details of account holder and the amount deposited.
     /// </summary>
     /// <returns>Returns a boolean value</returns>
     public bool AcceptDetails()
{
 bool flag=true;
 try { 
         // String variable to store the user input
         string input;
         //Enter the name of the account holder
         _accountHolder = Console.ReadLine();
          //Enter the account number: 
         input = Console.ReadLine();
         _accountNumber = Convert.ToInt64(input);
        if (_accountNumber <= 0)
         {
             Console.WriteLine("Account number cannot be zero or negative.");
             flag = false;
         }

 //Enter the deposit amount
     _deposit = Convert.ToDouble(Console.ReadLine());
         if (_deposit <= 0)
         {
             Console.WriteLine("Invalid amount");
         flag = false;

         }
         char choice = Convert.ToChar(Console.ReadLine());

         switch (choice)
         {
             case 'A':
             case 'a':
                 _numberOfYears = 1;
                 break;
             case 'B':
             case 'b':
                 _numberOfYears = 3;
                 break;
             case 'C':
             case 'c':
                 _numberOfYears = 5;
                 break;
             default:
                 Console.WriteLine("Invalid choice");
             flag = false;
                 return false;
         }
         return flag;
 }
 catch (FormatException objFormatOne)
 {
     Console.WriteLine("Error: " + objFormatOne.Message);
     Console.ReadKey();
     return false;
 }
}

     /// <summary>
     /// Method to calculate the interest earned on the amount deposited.
     /// </summary>
     /// <returns>Returns the interest amount earned</returns>
     public double CalculateInterest()
     {
         if (_deposit <= 50000)
         {
             if (_numberOfYears == 1)
             {
                 _interestRate = 3.5F;
             }
             else if (_numberOfYears == 3)
             {
                 _interestRate = 4;
             }
             else
             {
                 _interestRate = 4.5F;
             }
         }
         else if ((_deposit > 50000) && (_deposit <= 200000))
         {
             if (_numberOfYears == 1)
             {
                 _interestRate = 5;
             }
             else if (_numberOfYears == 3)
             {
                 _interestRate = 5.5F;
             }
             else
             {
                 _interestRate = 6;
             }
         }
         else
         {
             if (_numberOfYears == 1)
             {
                 _interestRate = 6.5F;
             }
             else if (_numberOfYears == 3)
             {
                 _interestRate = 7;
             }
             else
             {
                 _interestRate = 7.5F;
             }
         }
         return ((_deposit * _numberOfYears * _interestRate) / 100);
     }

     /// <summary>
     /// Method to calculate the total amount received on the maturity date.
     /// </summary>
     /// <returns>Returns the total amount</returns>
     public double GetBalance()
     {
         _interestEarned = CalculateInterest();
         return (_deposit + _interestEarned);
     }

     /// <summary>
     /// Method to display the account details.
     /// </summary>
     public void Display()
     {
         _totalBalance = GetBalance();
          Console.WriteLine("Maturity Amount: " + _totalBalance);
     }
}

/// <summary>
/// Class FixedAccountTest is used to test the FixedAccount class.
/// </summary>
class FixedAccountTest
{
/// <summary>
/// The entry point for the application.
/// </summary>
/// <param name="args">A list of command line arguments</param>
static void Main(string[] args)
{
 // Creating an object of the FixedAccount class
 FixedAccount objFixed = new FixedAccount();
 // Invoking and checking the return value of the AcceptDetails
 // of FixedAccount class
 if (!objFixed.AcceptDetails())
 {
     Console.WriteLine("Cannot process the data. Error occurred.");
     Console.ReadKey(); 
     return;
 }
 else
 {
     // Invoking the Display method of the FixedAccount class
     objFixed.Display();
 }
}
}
*/

/*NEW WORKING SOLUTION 
public interface IAccount
{
bool AcceptDetails();
double CalculateInterest();
double GetBalance();
void Display();
}
class FixedAccount : IAccount
{
/// <summary>
/// String field to store the account holder name.
/// </summary>
private string _accountHolder;

/// <summary>
/// Long field to store the account number.
/// </summary>
private long _accountNumber;

/// <summary>
/// Float field to store the interest rate.
/// </summary>
private float _interestRate;

/// <summary>
/// Integer field to store the years of deposit.
/// </summary>
private int _numberOfYears;

/// <summary>
/// Double field to store the interest earned on the deposit amount.
/// </summary>
private double _interestEarned;

/// <summary>
/// Double field to store the total balance including the interest earned.
/// </summary>
private double _totalBalance;

/// <summary>
/// Double field to store the amount deposited by the user.
/// </summary>
private double _deposit;

/// <summary>
/// Method to accept the details of account holder and the amount deposited.
/// </summary>
/// <returns>Returns a boolean value</returns>
public bool AcceptDetails()
{
    bool flag = true;
    try
    {
        // String variable to store the user input
        string input;
        //Enter the name of the account holder
        _accountHolder = Console.ReadLine();
        //Enter the account number: 
        input = Console.ReadLine();
        _accountNumber = Convert.ToInt64(input);
        if (_accountNumber <= 0)
        {
            Console.WriteLine("Account number cannot be zero or negative.");
            flag = false;
        }

        //Enter the deposit amount
        _deposit = Convert.ToDouble(Console.ReadLine());
        if (_deposit <= 0)
        {
            Console.WriteLine("Invalid amount");
            flag = false;

        }
        char choice = Convert.ToChar(Console.ReadLine());

        switch (choice)
        {
            case 'A':
            case 'a':
                _numberOfYears = 1;
                break;
            case 'B':
            case 'b':
                _numberOfYears = 3;
                break;
            case 'C':
            case 'c':
                _numberOfYears = 5;
                break;
            default:
                Console.WriteLine("Invalid choice");
                flag = false;
                return false;
        }
        return flag;
    }
    catch (FormatException objFormatOne)
    {
        Console.WriteLine("Error: " + objFormatOne.Message);
        Console.ReadKey();
        return false;
    }
}

/// <summary>
/// Method to calculate the interest earned on the amount deposited.
/// </summary>
/// <returns>Returns the interest amount earned</returns>
public double CalculateInterest()
{
    if (_numberOfYears == 1)
    {
        _interestRate = 6.5F;
    }
    else if (_numberOfYears == 3)
    {
        _interestRate = 7;
    }
    else
    {
        _interestRate = 7.5F;
    }
    return ((_deposit * _numberOfYears * _interestRate) / 100);
}

/// <summary>
/// Method to calculate the total amount received on the maturity date.
/// </summary>
/// <returns>Returns the total amount</returns>
public double GetBalance()
{
    _interestEarned = CalculateInterest();
    return (_deposit + _interestEarned);
}

/// <summary>
/// Method to display the account details.
/// </summary>
public void Display()
{
    _totalBalance = GetBalance();
    Console.WriteLine("Maturity Amount: " + _totalBalance);
    Console.ReadKey();
}
}

/// <summary>
/// Class FixedAccountTest is used to test the FixedAccount class.
/// </summary>
class FixedAccountTest
{
/// <summary>
/// The entry point for the application.
/// </summary>
/// <param name="args">A list of command line arguments</param>
static void Main(string[] args)
{
    // Creating an object of the FixedAccount class
    FixedAccount objFixed = new FixedAccount();
    // Invoking and checking the return value of the AcceptDetails
    // of FixedAccount class
    if (!objFixed.AcceptDetails())
    {
        Console.WriteLine("Cannot process the data. Error occurred.");
        Console.ReadKey();
        return;
    }
    else
    {
        // Invoking the Display method of the FixedAccount class
        objFixed.Display();
    }
}
}
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingMall
{
    // Declaring a delegate which takes a double value as a 
    // parameter and returns a double value.
    public delegate double Rebate(double val);

    // Declaring a delegate with no parameters.
    public delegate bool Call();

    /// <summary>
    /// This program demonstrates the use of delegates.
    /// 
    /// Class ElectronicStore accepts product details from the user, 
    /// calculates discount, and total value.
    /// </summary>
    public class ElectronicStore
    {
        /// <summary>
        /// Float field to store the discount rate.
        /// </summary>
        internal float Rate;

        /// <summary>
        /// Double field to store the item price.
        /// </summary>
        internal double ItemPrice = 0;

        /// <summary>
        /// Integer field to store the quantity of the products sold.
        /// </summary>
        internal int Quantity = 0;
        /// <summary>
        /// Method to accept the details of product.
        /// </summary>
        public bool AcceptDetails()
        {
            try
            {
                ItemPrice = Convert.ToDouble(Console.ReadLine());

                if (ItemPrice < 0)
                {
                    Console.WriteLine("Product price cannot be negative");
                    return false;
                }
            }
            catch (FormatException objFormatOne)
            {
                Console.WriteLine("Error: " + objFormatOne.Message);
                return false;
            }
            try
            {
                Quantity = Convert.ToInt32(Console.ReadLine());
                if (Quantity < 0)
                {
                    Console.WriteLine("Quantity cannot be negative");
                    return false;
                }
            }
            catch (FormatException objFormatTwo)
            {
                Console.WriteLine("Error: " + objFormatTwo.Message);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Method to calculate discount based on the total value of goods sold.
        /// </summary>
        /// <param name="val">Accepts the total value of goods sold</param>
        /// <returns>Returns discount amount</returns>
        public double Discount(double val)
        {
            // Double variable to store the discount value.
            double discount;
            if (val <= 1000)
            {
                discount = val * 0.1;
                Rate = 10;
            }
            else if ((val > 1000) && (val <= 2000))
            {
                discount = val * 0.2;
                Rate = 20;
            }
            else if ((val > 2000) && (val <= 3000))
            {
                discount = val * 0.3;
                Rate = 30;
            }
            else
            {
                discount = val * 0.5;
                Rate = 50;
            }
            return discount;
        }

        /// <summary>
        /// Method to calculate the total value of goods sold.
        /// </summary>
        /// <returns>Returns the total value of goods sold</returns>
        public double ValueOfGoods()
        {
            double value = Quantity * ItemPrice;
            return value;
        }
    }
    /// <summary>
    /// Class ElectronicStoreTest is used to test the ElectronicStore class and display the product details.
    /// </summary>
    class ElectronicStoreTest
    {
        // Creating an object of the ElectronicStore class.
        ElectronicStore objStore = new ElectronicStore();

        /// <summary>
        /// Method to display the product details.
        /// </summary>
        bool Display()
        {
            // Instantiating the Rebate delegate and associating the 
            // Discount() method with it
            Rebate objRebate = new Rebate(objStore.Discount);
            double total = objStore.ValueOfGoods();
            //Invoking the delegate with the parameter total
            double value = objRebate(total);
            double netValue = total - value;
            Console.WriteLine();
            Console.WriteLine("Total Price: " + total);
            Console.WriteLine("Discount: " + value);
            Console.WriteLine("Net Value: " + netValue);
            return true;
        }

        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args"> A list of command line arguments</param>
        static void Main(string[] args)
        {
            // Instantiating the ElectronicStoreTest class.
            ElectronicStoreTest objTest = new ElectronicStoreTest();

            Call objCall = new Call(objTest.objStore.AcceptDetails);

            if (objCall() == true)
            {
                // Removing a method reference from the delegate Call
                objCall -= new Call(objTest.objStore.AcceptDetails);

                // Adding another method reference to the same delegate Call
                objCall += new Call(objTest.Display);

                // Invoking the delegate
                objCall();
            }
            else
            {
                return;
            }


        }
    }
}

