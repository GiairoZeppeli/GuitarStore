using System;
using Xunit;
using GuitarStore;
namespace Store.Tests

{
    public class GuitarTests
    {
        [Fact]
        public void IsIsbn_WithNull_ReturnFalse()
        {
            bool actual = Guitar.IsIsbn(null);

            Assert.False(actual);
        }
        public void IsIsbn_WithBlankString_ReturnFalse()
        {
            bool actual = Guitar.IsIsbn("    ");

            Assert.False(actual);
        }
        public void IsIsbn_WithInvalidIsbn_ReturnFalse()
        {
            bool actual = Guitar.IsIsbn("ISBN 123");

            Assert.False(actual);
        }
        public void IsIsbn_WithIsbn10_ReturnTrue()
        {
            bool actual = Guitar.IsIsbn("ISBN 1234-2345");

            Assert.True(actual);
        }
    }
}