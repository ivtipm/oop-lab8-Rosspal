using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryComplexNumb;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        ComplexNum testClass = new ComplexNum();
        [TestMethod]
        public void Test_sum()
        {
            ComplexNum temp = new ComplexNum(1,1);
            testClass = testClass + temp;
            Assert.AreEqual(testClass.ToString(),temp.ToString(),"неверный результат сложения");
        }
        [TestMethod]
        public void Test_sum_numb()
        {
            int a = 1;
            testClass = testClass + a;
            Assert.AreEqual(testClass.Re, 1, "неверный результат сложения c числом");
        }
        [TestMethod]
        public void Test_subtract_numb()
        {
            int a = 1;
            testClass = testClass - a;
            Assert.AreEqual(testClass.Re, -1, "неверный результат вычитания числа");
        }
        [TestMethod]
        public void Test_subtract()
        {
            ComplexNum temp = new ComplexNum(1, 1);
            String answer = "-1 + i-1";
            testClass = testClass - temp;
            Assert.AreEqual(testClass.ToString(), answer, "неверный результат разности");
        }
        [TestMethod]
        public void Test_multiplication()
        {
            ComplexNum temp = new ComplexNum(2, 2);
            testClass = new ComplexNum(2, 2);
            String answer = "0 + i8";
            testClass = testClass * temp;
            Assert.AreEqual(testClass.ToString(), answer, "неверный результат произведения");
        }
        [TestMethod]
        public void Test_multiplication_numb()
        {
            testClass = testClass * 5;
            Assert.AreEqual(testClass.ToString(), testClass.ToString(), "неверный результат произведения");
        }
        [TestMethod]
        public void Test_argument()
        {
            testClass = new ComplexNum(1, 1);
            Assert.AreEqual(testClass.argument(), 45.0, "неверный аргумент");
        }
    }
}
