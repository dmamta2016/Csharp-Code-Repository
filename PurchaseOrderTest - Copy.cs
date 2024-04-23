/*
 * PurchaseOrderTest.cs
 * 
 * Copyright © 2007 Aptech Software Limited. All rights reserved.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{

    class PurchaseOrder
    {
        /// <summary>
        /// Byte field to store order ID.
        /// </summary>
        private byte _orderID;

        /// <summary>
        /// DateTime field to store order date.
        /// </summary>
        private DateTime _orderDate;

        /// <summary>
        /// String field to store customer name.
        /// </summary>
        private string _customerName;

        /// <summary>
        /// Byte field to store total quantity of products.
        /// </summary>
        private byte _totalQuantity;

        /// <summary>
        /// Float field to store total amount of products.
        /// </summary>
        private float _totalAmount;

        /// <summary>
        /// Array of byte type to store the product ID.
        /// </summary>
        private byte[] productID;

        /// <summary>
        /// Array of string to store the product name.
        /// </summary>
        private string[] productName;

        /// <summary>
        /// Array of byte type to store the product quantity.
        /// </summary>
        private byte[] quantity;

        /// <summary>
        /// Array of float type to store the product price.
        /// </summary>
        private float[] price;

        /// <summary>
        /// Array of float type to store the cost of product.
        /// </summary>
        private float[] amount;

        /// <summary>
        /// Method to accept purchase order details.
        /// </summary>
        /// <returns>Returns true or false</returns>
        public bool AcceptOrderDetails()
        {
            // Accepting and validating the order details using
            // a try-catch block
            try
            {
                Console.WriteLine("Enter Purchase Order Details:");
                OrderID:
                Console.Write("Order ID : ");
                _orderID = Convert.ToByte(Console.ReadLine());
                if (_orderID <= 0)
                {
                    Console.WriteLine("Order ID must be greater than zero");
                    goto OrderID;
                }
                OrderDate:
                Console.Write("Order date [DD/MM/YYYY] : ");
                _orderDate = Convert.ToDateTime(Console.ReadLine());
                if (_orderDate > DateTime.Today)
                {
                    Console.WriteLine("Order date cannot not be greater than today's date");
                    goto OrderDate;
                }
                CustomerName:
                Console.Write("Customer name : ");
                _customerName = Console.ReadLine();
                if (_customerName == "")
                {
                    Console.WriteLine("Invalid customer name!\n");
                    goto CustomerName;
                }
            }
            // Catching an exception if the user enters any invalid order details
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Method to accept product details.
        /// </summary>
        /// <returns>Returns true or false</returns>
        public bool AcceptProductDetails()
        {
            // Accepting and validating the product details using
            // a try-catch block
            byte noOfProducts;
            try
            {
                NoOfProducts:
                Console.Write("Enter number of products in purchase order : ");
                noOfProducts = Convert.ToByte(Console.ReadLine());
                if (noOfProducts <= 0)
                {
                    Console.WriteLine("Number of products ordered must be greater than zero");
                    goto NoOfProducts;
                }

                productID = new byte[noOfProducts];
                productName = new string[noOfProducts];
                quantity = new byte[noOfProducts];
                price = new float[noOfProducts];
                amount = new float[noOfProducts];

                for (int i = 0; i < noOfProducts; i++)
                {
                    ProductID:
                    try
                    {
                        Console.WriteLine("\nEnter Product Details:");
                        Console.Write("Product ID : ");
                        productID[i] = Convert.ToByte(Console.ReadLine());
                        if (productID[i] <= 0)
                        {
                            Console.WriteLine("Product ID must be greater than zero");
                            goto ProductID;
                        }
                    }
                    catch (FormatException objEx)
                    {
                        Console.WriteLine("Error : {0}\n", objEx.Message);
                        goto ProductID;
                    }

                    ProductName:
                    Console.Write("Product Name : ");
                    productName[i] = Console.ReadLine();
                    if (productName[i] == "")
                    {
                        Console.WriteLine("Invalid product name!");
                        goto ProductName;
                    }

                    try
                    {
                        Quantity:
                        try
                        {

                            Console.Write("Quantity : ");
                            quantity[i] = Convert.ToByte(Console.ReadLine());
                            if (quantity[i] <= 0)
                            {
                                Console.WriteLine("Quantity of product must be greater than zero");
                                goto Quantity;
                            }
                        }
                        catch (FormatException objEx)
                        {
                            Console.WriteLine("Error : {0}\n", objEx.Message);
                            goto Quantity;
                        }

                        Price:
                        try
                        {
                            Console.Write("Price : ");
                            price[i] = Convert.ToSingle(Console.ReadLine());
                            if (price[i] <= 0)
                            {
                                Console.WriteLine("Price of product must be greater than zero");
                                goto Price;
                            }
                            amount[i] = quantity[i] * price[i];
                        }
                        catch (FormatException objEx)
                        {
                            Console.WriteLine("Error : {0}\n", objEx.Message);
                            goto Price;
                        }
                    }
                    // Catching an exception if the user enters any value
                    // greater than the capacity of float type
                    catch (OverflowException objEx)
                    {
                        Console.WriteLine("Error : {0}\n", objEx.Message);
                        return false;
                    }
                }
            }
            // Catching an exception if the user enters any invalid product details
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}\n", objEx.Message);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Method to calculate total quantity and amount of the product.
        /// </summary>
        public void CalculateAmount()
        {
            // Calculating the total quantity and amount of the product
            try
            {
                for (int i = 0; i < productID.Length; i++)
                {
                    _totalQuantity = (byte)(_totalQuantity + quantity[i]);
                    _totalAmount = _totalAmount + amount[i];
                }
            }
            // Catching the exception if the total quantity or amount after being calculated becomes 
            // higher than the capacity of their respective data types
            catch (OverflowException objEx)
            {
                Console.WriteLine("Error : {0}\n", objEx.Message);
            }
        }

        /// <summary>
        /// Method to display the details of purchase order.
        /// </summary>
        public void DisplayOrderDetails()
        {
            // Displaying the details of purchase order
            Console.WriteLine("\nOrder Details:");
            Console.WriteLine("----------------");
            Console.WriteLine("Order ID : {0}", _orderID);
            Console.WriteLine("Order Date : {0}", _orderDate.ToShortDateString());
            Console.WriteLine("Customer Name : {0}", _customerName);
            Console.WriteLine("Total Quantity : {0}", _totalQuantity);
            Console.WriteLine("Total Amount : {0:C2}", _totalAmount);
        }

        /// <summary>
        /// Method to display product details.
        /// </summary>
        public void DisplayProductDetails()
        {
            // Displaying the details of products
            Console.WriteLine("\nProduct Details:");
            Console.WriteLine("----------------");
            Console.WriteLine("Product ID \tProduct Name \tQuantity \tPrice \tAmount");
            for (int i = 0; i < productID.Length; i++)
            {
                Console.Write("{0} \t\t{1} \t\t{2} \t\t", productID[i], productName[i], quantity[i]);
                Console.WriteLine("{0} \t{1}", price[i], amount[i]);
            }
        }
    }


/// <summary>
/// Class PurchaseOrderTest is used to test the PurchaseOrder class.
/// </summary>
/// <remarks>The program also demonstrates the use of finally block.</remarks>
class PurchaseOrderTest
    {
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args"> A list of command line arguments</param>
        static void Main(string[] args)
        {
            // Creating a reference of PurchaseOrder class
            PurchaseOrder objPurchaseOrder;

        AcceptOrder:
            // Character variable to store choice
            char choice = 'N';
            try
            {
                // Creating an object of the PurchaseOrder class
                objPurchaseOrder = new PurchaseOrder();

                // Invoking the AcceptOrderDetails method of the PurchaseOrder class
                // to accept the details of purchase order
                if (objPurchaseOrder.AcceptOrderDetails())
                {
                    // Invoking the AcceptProductDetails method of the PurchaseOrder class
                    // to accept order details
                    if (objPurchaseOrder.AcceptProductDetails())
                    {
                        // Invoking the CalculateAmount method of the PurchaseOrder class
                        // to calculate total quantity and amount
                        objPurchaseOrder.CalculateAmount();

                        // Invoking the DisplayOrderDetails method of the PurchaseOrder class
                        // to display order details
                        objPurchaseOrder.DisplayOrderDetails();

                        // Invoking the DisplayProductDetails method of the PurchaseOrder class
                        // to display the details of product
                        objPurchaseOrder.DisplayProductDetails();
                    }
                }
            }
            // Catching an exception if the user enters any invalid details
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
            // Checking if the user wishes to add more records
            finally
            {
                try
                {
                    objPurchaseOrder = null;
                    Console.Write("\nDo you want to add details for another purchase order [Y/N]? ");
                    choice = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception objEx)
                {
                    Console.WriteLine("Error : {0}", objEx.Message);
                }
            }
            if (choice == 'Y' || choice == 'y')
                goto AcceptOrder;
            Console.ReadKey();
        }
        
    }
}
