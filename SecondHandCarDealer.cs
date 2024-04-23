/*
 * SecondHandCarDealer.cs
 * 
 * Copyright © 2007 Aptech Software Limited. All rights reserved.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Automotive
{
    /// <summary>
    /// This program demonstrate the use of Iterators in C#.
    /// 
    /// Class SecondHandCarDealer stores the car names and its corresponding value.
    /// The program uses iterators to display the information according to the user preference.
    /// </summary>
    class SecondHandCarDealer
    {
        /// <summary>
        /// String array to store the car names.
        /// </summary>
        private string[] carNames = { "Audi A4", "BMW Roadster", "Corvette C6", "Ferrari 355", "Ford Fusion", "Bentley MKVI", "Cheverolet S10" };

        /// <summary>
        /// Double array to store the value of the cars.
        /// </summary>
        private double[] price = { 20250, 15620, 13250, 17300, 8600, 25680, 12250 };

        /// <summary>
        /// Boolean field to check the flag value.
        /// </summary>
        private bool _flag;

        /// <summary>
        /// Named Iterator GetCar to get the car names.
        /// </summary>
        /// <returns>List of car names</returns>
        public IEnumerable GetCar()
        {
            for (int i = 0; i < carNames.Length; i++)
            {
                yield return carNames[i];
            }
        }

        /// <summary>
        /// Named Iterator GetCar to get the car names and 
        /// corresponding values in the range specified by the user.
        /// </summary>
        /// <param name="start">Accepts the minimum budget of the user</param>
        /// <param name="end">Accepts the maximum budget of the user</param>
        /// <returns></returns>
        public IEnumerable GetCar(double start, double end)
        {
            for (int i = 0; i < carNames.Length; i++)
            {
                if ((price[i] >= start) && (price[i] <= end))
                {
                    yield return carNames[i];
                    yield return price[i].ToString();
                    _flag = true;
                }
            }
            if (!_flag)
            {
                Console.WriteLine("No cars available in this range");
            }
        }

        /// <summary>
        /// Named Iterator to display the car names and respective prices
        /// </summary>
        /// <returns>Name and Price for each car in the list</returns>
        public IEnumerable DisplayAll()
        {
            for (int i = 0; i < carNames.Length; i++)
            {
                yield return carNames[i];
                yield return price[i].ToString();
            }
        }
    }
}
