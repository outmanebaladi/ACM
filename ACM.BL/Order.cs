using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        public Order Retrieve(int orderId)
        {
            // Code that retrieves the defined order

            return new Order();
        }

        public bool Save()
        {
            // Code that saves the defined order

            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}

