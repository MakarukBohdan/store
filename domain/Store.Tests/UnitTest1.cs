using System;
using Xunit;

namespace Store.Tests
{
    public class BookTests
    {
        [Fact]
        public void IsIsbn_WithNull_ReturnFalse()
        {
            bool actual = Book.IsIsbn(null);

            Assert.False(actual);

        }

        [Fact]
        public void IsIsbn_WithBlank_ReturnFalse()
        {
            bool actual = Book.IsIsbn("   ");

            Assert.False(actual);

        }

        [Fact]
        public void IsIsbn_With_InvalidIsbn_ReturnFalse()
        {
            bool actual = Book.IsIsbn("ISBN 132 ");

            Assert.False(actual);

        }


        [Fact]
        public void IsIsbn_With_InvalidIsbn10_ReturnTrue()
        {
            bool actual = Book.IsIsbn("isBn 132-223-432 7");

            Assert.True(actual);

        }

        [Fact]
        public void IsIsbn_With_InvalidIsbn13_ReturnTrue()
        {
            bool actual = Book.IsIsbn("isBn 132-223-432 7 -22 4");

            Assert.True(actual);

        }

        [Fact]
        public void IsIsbn_With_TrashStart_ReturnFalse()
        {
            bool actual = Book.IsIsbn("xxxisBn 132-223-432 7 -22 4 yyy");

            Assert.False(actual);

        }
    }
}
