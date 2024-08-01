using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("mom", true)]
        [InlineData("hello",false)]
        public void IsAPalindrome(string word, bool expected)
        {
          //arrange
          var test = new Wordsmith();

          //act
          var actual = test.IsAPalindrome(word);

          //assert
          Assert.Equal(expected, actual);


        }
    }
}
