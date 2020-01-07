using ACM.BL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ACM.BLTest
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "outmanebaladi22@gmail.com",
                FirstName = "Outmane",
                LastName = "BALADI"
            };

            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert
            Assert.Equal(expected.CustomerId, actual.CustomerId);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
        }

        [Fact]
        public void RetrieveExistingWithAddress()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "outmanebaladi22@gmail.com",
                FirstName = "Outmane",
                LastName = "BALADI",
                AddressList = new List<Address>()
                    {
                        new Address()
                        {
                            AddressType = 1,
                            StreetLine1 = "Bag End",
                            StreetLine2 = "Bagshot row",
                            City = "Hobbiton",
                            State = "Shire",
                            Country = "Middle Earth",
                            PostalCode = "144"
                        },
                        new Address()
                        {
                            AddressType = 2,
                            StreetLine1 = "Green Dragon",
                            City = "Bywater",
                            State = "Shire",
                            Country = "Middle Earth",
                            PostalCode = "146"
                        }
                    }
            };

            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            Assert.Equal(expected.CustomerId, actual.CustomerId);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);

            for (int i = 0; i < 2; i++)
            {
                Assert.Equal(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.Equal(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.Equal(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.Equal(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.Equal(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.Equal(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}
