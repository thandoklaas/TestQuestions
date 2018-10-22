using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Questions;

namespace UnitTestQuestions
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Console.WriteLine("Question 3:");
            Questions.Question3.Execute(0, 0, 0, 0);
        }

        [TestMethod]
        public void CalculatePayment()
        {

            Console.WriteLine("Question 3:");
            Questions.Question3.Execute(5000, 10, 1, 500);

            var calc = new Question3.Calculator
            {
                PurchasePrice = 5000,
                InterestRate = 10,
                LoanTermYears = 1,
                DownPayment = 1
            };
            Assert.AreEqual(Math.Round(calc.CalculatePayment(), 2), 449.79); 
        }
    }
}
