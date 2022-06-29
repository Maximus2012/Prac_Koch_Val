using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculate;

namespace calcTest
{

   



    [TestClass]
    public class resultCalcTest
    {
        [TestMethod]
        public void TestMethodPlus()
        {
            fCalc calc = new fCalc();
            double a = 5; double b = 10;
            double expected = 15;
            double result;
            result = calc._bRavno_Click(a, b, 1);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethodMinus()
        {
            fCalc calc = new fCalc();
            double a = 10; double b = 5;
            double expected = 5;
            double result;
            result = calc._bRavno_Click(a, b, 2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethodMultiply()
        {
            fCalc calc = new fCalc();
            double a = 5; double b = 10;
            double expected = 50;
            double result;
            result = calc._bRavno_Click(a, b, 3);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethodDivide()
        {
            fCalc calc = new fCalc();
            double a = 10; double b = 5;
            double expected = 2;
            double result;
            result = calc._bRavno_Click(a, b, 4);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethodPow()
        {
            fCalc calc = new fCalc();
            double a = 5; double b = 10;
            double expected = Math.Pow(a, b);
            double result;
            result = calc._bRavno_Click(a, b, 5);
            Assert.AreEqual(expected, result);
        }
        
    }
    
}
