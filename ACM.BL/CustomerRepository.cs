using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        public Customer Retrieve(int customerId)
        {
            // Create the instance of the Customer class
            // Pass in the requested id
            Customer customer = new Customer(customerId);

            // Code that retrieves the defined customer

            // Temporary hard-coded values to return 
            // a populated customer
            if (customerId == 1)
            {
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
                customer.EmailAddress = "outmanebaladi22@gmail.com";
                customer.FirstName = "Outmane";
                customer.LastName = "BALADI";
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            // Code that saves the passed in customer

            return true;
        }
    }
}
