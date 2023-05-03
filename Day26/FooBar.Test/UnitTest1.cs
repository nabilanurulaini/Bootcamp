using System.Collections.Generic;
using Xunit;

namespace FooBar.Tests
{
    public class CheckDictionaryTests
    {
        [Fact]
        public void Add_ShouldAddKeyValuePairToDictionary()
        {
            // Arrange
            var check = new CheckDictionary();
            int key = 1;
            string value = "foo";
            
            // Act
            check.Add(key, value);

            // Assert
            Assert.Equal(value, check.dict[key]);
        }

        [Fact]
        public void Remove_ShouldRemoveKeyValuePairFromDictionary()
        {
            // Arrange
            var check = new CheckDictionary();
            int key = 1;
            string value = "foo";
            check.dict.Add(key, value);
            
            // Act
            check.Remove(key);

            // Assert
            Assert.Empty(check.dict);
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "foo")]
        [InlineData(4, "4")]
        [InlineData(5, "bar")]
        [InlineData(6, "foo")]
        [InlineData(7, "7")]
        [InlineData(8, "8")]
        [InlineData(9, "foo")]
        [InlineData(10, "bar")]
        [InlineData(11, "11")]
        [InlineData(12, "foo")]
        [InlineData(13, "13")]
        [InlineData(14, "foo")]
        [InlineData(15, "foobar")]
        public void DoCompare_ShouldReturnCorrectOutput(int input, string expected)
        {
            // Arrange
            var check = new CheckDictionary();
            check.dict.Add(3, "foo");
            check.dict.Add(5, "bar");
            //check.dict.Add(7, "buzz");
            var comparer = new Compare(check.dict);
            
            // Act
            var result = comparer.DoCompare(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
