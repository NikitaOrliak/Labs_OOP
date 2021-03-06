﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void EvaluateTest()
        {

            {
                string actual = "max(3 , 5) * min (3 , 5)";
                actual = actual.Replace(" ", "");
                string expected = "15";
                Assert.AreEqual(expected, Calculator.Evaluate(actual));
            }

            {
                string actual = "inc(2) * (1 + 30 + inc((49 + dec(3)))) - 21 * dec(2)";
                actual = actual.Replace(" ", "");
                string expected = "148";
                Assert.AreEqual(expected, Calculator.Evaluate(actual));
            }

            {
                string actual = "-(-1)";
                actual = actual.Replace(" ", "");
                string expected = "1";
                Assert.AreEqual(expected, Calculator.Evaluate(actual));
            }


            {
                string actual = "3 * 5 * inc(4)";
                actual = actual.Replace(" ", "");
                string expected = "75";
                Assert.AreEqual(expected, Calculator.Evaluate(actual));
            }


            try
            {
                string actual = "100 + 1 / 0";
                actual = actual.Replace(" ", "");
                string expected = Calculator.Evaluate(actual);

                Assert.Fail(); 
            }
            catch (DivideByZeroException)
            {
            }
        }
    }
}