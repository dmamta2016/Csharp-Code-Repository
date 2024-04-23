/*
 * PatientListTest.cs
 * 
 * Copyright © 2007 Aptech Software Limited. All rights reserved.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    /// <summary>
    /// Class PatientListTest is used to test the PatientList class.
    /// </summary>
    /// <remarks>The class also performs additional operations,
    /// such as sorting the names of patients and reversing the list</remarks>
    class PatientListTest
    {
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args"> A list of command line arguments</param>
        static void Main(string[] args)
        {
            try
            {
                // Creating an object of the PatientList class.
                PatientList objPatientList = new PatientList();

                // Invoking the AcceptDetails method of the PatientList class 
                // to accept the names of patients
                objPatientList.AcceptDetails();

                // Invoking the DisplayDetails method of the PatientList class 
                // to display the names of patients
                objPatientList.DisplayDetails();

                char input = 'Y';
                do
                {
                    int choice;
                    Console.WriteLine("\nSelect one of the following options:");
                    Console.WriteLine("  1. Sort\n  2. Remove\n  3. Reverse\n  4. Search\n  5. Exit");
                    Console.Write("Enter your choice : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            // Sorting the names of patients in the ascending order using the built-in method Sort
                            objPatientList.objPatientNames.Sort();
                            Console.Write("\n-----After Sorting-----");
                            objPatientList.DisplayDetails();
                            break;
                        case 2:
                            // Removing the name of patient
                            if (objPatientList.Remove())
                            {
                                Console.Write("\n-----After Removing-----");
                                objPatientList.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Patient with this name does not exist");
                            break;
                        case 3:
                            // Reversing the names of patients in the list using the built-in method Reverse
                            objPatientList.objPatientNames.Reverse();
                            Console.Write("\n-----After Reversing-----");
                            objPatientList.DisplayDetails();
                            break;
                        case 4:
                            // Searching for the name of patient
                            objPatientList.Search();
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Invalid Data Entry!");
                            break;
                    }
                } while (input == 'Y' || input == 'y');

            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
        }
    }
}
