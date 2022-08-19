using Encryption.CaesarCipher.Interfaces;
using Encryption.CaesarCipher.Services;
using System;
using Xunit;

namespace Encryption.CeasarCipher.Tests
{
    public class BasicShifterTests
    {
        [Fact]
        public void ShouldReturnCorrectValue()
        {
            // Arrange
            int shift = 3;
            string input = "GOODMORNING";

            IStringShifter service = new BasicStringShifter(shift, input);

            // Act
            var output = service.Shift();
            // Assert
            Assert.True(output.Length == input.Length);
            Assert.Equal("JRRGPRUQLQJ", output);
        }
        [Fact]
        public void ShouldThrowException()
        {
            // Arrange
            int shift = 3;
            string input = "GOOD MORNING WITH SPACE AND other charachters 123#";

            // Act
            // Assert
            Assert.Throws<Exception>(() => new BasicStringShifter(shift, input));

        }
    }
}
