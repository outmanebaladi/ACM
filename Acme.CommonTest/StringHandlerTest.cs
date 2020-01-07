using Acme.Common;
using System;
using Xunit;

namespace Acme.CommonTest
{
    public class StringHandlerTest
    {
        [Fact]
        public void InsertSpacesTestValid()
        {
            //arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            //act
            var actual = source.InsertSpaces();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertSpacesTestWithExistingSpace()
        {
            //arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            //act
            var actual = source.InsertSpaces();

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
