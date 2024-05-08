using System;
using Xunit;
using System.IO;
using temperature_conversion_calculator;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace temperature_conversion_calculator.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void TestTemperatureConversionOutput()
        {
            // Arrange
            int fahrenheit = 94;
            decimal expectedOutput = 34.4m;

            // Act
            decimal actualOutput = Program.ConvertFahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}