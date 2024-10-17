using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace YourProjectName.Tests
{
    [TestClass]
    public class ClaimsServiceTests
    {
        private ClaimsService _claimsService;

        [TestInitialize]
        public void Setup()
        {
            _claimsService = new ClaimsService();
        }

        [TestMethod]
        public void CalculateTotalAmount_ValidInputs_ReturnsCorrectTotal()
        {
            // Arrange
            decimal hoursWorked = 40;
            decimal hourlyRate = 50;

            // Act
            decimal totalAmount = _claimsService.CalculateTotalAmount(hoursWorked, hourlyRate);

            // Assert
            Assert.AreEqual(2000, totalAmount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateTotalAmount_NegativeInputs_ThrowsArgumentException()
        {
            // Act
            _claimsService.CalculateTotalAmount(-5, 50);
        }
    }
}
