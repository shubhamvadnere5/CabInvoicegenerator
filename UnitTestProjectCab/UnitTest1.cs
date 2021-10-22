﻿using CabInvoiceGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;




namespace UnitTestProjectCab
{
    [TestClass]
      //UC1 Given total distance and time should return total fair (NORMAL) of the journey 
        public class UnitTest1
        {
        //UC1 Given total distance and time should calculate and return total fare (NORMAL) of the journey 
        [TestMethod]
        [TestCategory("Fare")]
        public void GivenDistanceAndTimeShouldReturnNormalFare()
            {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
                double distance = 2.0;
                int time = 5;
            //Calculating Fair
            double fare = invoiceGenerator.CalculateFare(distance, time);
                double expected = 25;
            Assert.AreEqual(expected, fare);
            }
        }
    }