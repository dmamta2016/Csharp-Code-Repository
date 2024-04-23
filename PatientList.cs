/*
 * PatientList.cs
 * 
 * Copyright © 2007 Aptech Software Limited. All rights reserved.
 */

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Hospital
{
    /// <summary>
    /// The program demonstrates the use of the ArrayList class 
    /// of the Collections namespace.
    /// 
    /// Class PatientList accepts and displays the names and number of patients.
    /// </summary>
    /// <remarks>The class also performs additional operations,
    /// such as removing or searching for the name of patient</remarks>
    class PatientList
    {
        /// <summary>
        /// Creating an object of the ArrayList class.
        /// </summary>
        public ArrayList objPatientNames = new ArrayList();

        /// <summary>
        /// Method to accept the names of patients.
        /// </summary>
        public void AcceptDetails()
        {
            char choice = 'Y';
            try
            {
                do
                {
                    Console.Write("Enter patient's name : ");
                    // Add() method of the ArrayList class is used to add patient’s name to the list
                    objPatientNames.Add(Console.ReadLine());
                    Console.Write("Do you want to add more names? [Y/N] : ");
                    choice = Convert.ToChar(Console.ReadLine());
                } while (choice == 'Y' || choice == 'y');
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
        }

        /// <summary>
        /// Method to display the names and number of patients.
        /// </summary>
        public void DisplayDetails()
        {
            Console.WriteLine("\nList of patients :");
            for (int i = 0; i < objPatientNames.Count; i++)
            {
                Console.WriteLine(objPatientNames[i]);
            }
            //Count property of the ArrayList class is used to display total count
            Console.WriteLine("Total number of patients : " + objPatientNames.Count);
        }

        /// <summary>
        /// Method to remove the name of patient.
        /// </summary>
        /// <returns>Returns true or false.</returns>
        public bool Remove()
        {
            string choice;
            Console.Write("Enter the name of the patient : ");
            choice = Console.ReadLine();
            // Contains() method of ArrayList class is used to check for patient’s name in the list
            if (objPatientNames.Contains(choice))
            {
                // Remove() method of ArrayList class is used to remove patient's name from the list
                objPatientNames.Remove(choice);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Method to search for the name of patient.
        /// </summary>
        public void Search()
        {
            string choice;
            Console.Write("Enter the name of the patient : ");
            choice = Console.ReadLine();
            if (choice != "")
            {
                if (objPatientNames.Contains(choice))
                {
                    Console.WriteLine("Record Found!");
                    // Displaying name of the patient using the Item property that can be accessed through IndexOf() method
                    Console.WriteLine(objPatientNames[objPatientNames.IndexOf(choice)]);
                }
                else
                    Console.WriteLine("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}
