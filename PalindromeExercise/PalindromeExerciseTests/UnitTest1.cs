using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("raceCar", true)]
        [InlineData("hello", false)]
        [InlineData("madam", true)]
        [InlineData("step on no pets", true)] // With spaces
        [InlineData("world", false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            // Arrange
            var wordSmith = new WordSmith();

            // Act
            var actual = wordSmith.IsAPalindrome(word);

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
