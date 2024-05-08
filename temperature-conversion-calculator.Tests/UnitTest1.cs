using System;
using Xunit;
using temperature_conversion_calculator;

namespace temperature_conversion_calculator.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void TestGetTemperatureMessage()
        {
            // Arrange
            int fahrenheit = 94;

            // Act
            string message = Program.GetTemperatureMessage(fahrenheit);

            // Assert
            Assert.Contains("The temperature is", message);
        }
    }
}