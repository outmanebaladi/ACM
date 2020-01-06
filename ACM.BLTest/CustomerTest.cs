using ACM.BL;
using System;
using Xunit;

namespace ACM.BLTest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Outmane",
                LastName = "BALADI"
            };
            string expected = "BALADI, Outmane";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            Customer customer = new Customer
            {
                LastName = "BALADI"
            };
            string expected = "BALADI";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Outmane"
            };
            string expected = "Outmane";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StaticTest()
        {
            //Arrange
            var c1 = new Customer();
            Customer.instanceCount += 1;

            var c2 = new Customer();
            Customer.instanceCount += 1;

            var c3 = new Customer();
            Customer.instanceCount += 1;

            //Assert
            Assert.Equal(3, Customer.instanceCount);
        }

        [Fact]
        public void ValidateValid()
        {
            //Arrange
            var customer = new Customer
            {
                LastName = "BALADI",
                EmailAddress = "Outmanebaladi22@gmail.com"
            };

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void ValidateMissingLastName()
        {
            //Arrange
            var customer = new Customer
            {
                EmailAddress = "Outmanebaladi22@gmail.com"
            };

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.False(actual);
        }
    }
}
