using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entities
{
    public class Order
    {
        private Product[] products;
        private Customer customer;

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public Product[] Products
        {
            get { return products; }
            set { products = value; }
        }

    }
}
