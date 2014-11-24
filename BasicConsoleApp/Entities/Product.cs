using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entities
{
    public class Product
    {
        private int identifier;

        public int Identifier
        {
            get { return identifier; }
            set { identifier = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
