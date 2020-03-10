using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculatorTestProject
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal annualSalary = sc.GetAnnualSalary(50);

            // Assert
            Assert.AreEqual(annualSalary, 104000);
        }

        [TestMethod]
        public void HourlyWageTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal hourlyWage = sc.GetHourlyWage(52000);

            // Assert
            Assert.AreEqual(hourlyWage, 25);
        }
    }
}
