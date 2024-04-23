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
        }
    }
}
