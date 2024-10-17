using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace YourProjectName.Tests 
//Namespace for organizing the test classes within the project.
{
    [TestClass] //Attribute to indicate that this is a test class.
    public class ClaimsServiceTests
    {
        private ClaimsService _claimsService;

        [TestInitialize] //Attribute to indicate that this method runs before each test method.
        public void Setup()
        {
            _claimsService = new ClaimsService();
        }

        [TestMethod] //Attribute to indicate that this is a test method.
        public void CalculateTotalAmount_ValidInputs_ReturnsCorrectTotal()
        {
            // Arrange: Prepares the data needed for the test.
            decimal hoursWorked = 40;
            decimal hourlyRate = 50;

            // Act
            decimal totalAmount = _claimsService.CalculateTotalAmount(hoursWorked, hourlyRate);

            // Assert
            Assert.AreEqual(2000, totalAmount);
            //Ensure the calculated amount matches the expected value.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateTotalAmount_NegativeInputs_ThrowsArgumentException()
        {
            //Call the method with invalid inputs (negative hours), which should throw an exception error message.
            _claimsService.CalculateTotalAmount(-5, 50);
        }
    }
}
//Unit Testing the ClaimsServiceTests Class:
