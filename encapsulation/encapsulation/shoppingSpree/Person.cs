using System;
using System.Collections.Generic;
using System.Text;

namespace shoppingSpree
{
    class Person
    {
        private string name;
        private decimal money;
        private List<Product> productList;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            productList = new List<Product>();
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == string.Empty || value == null || value == " ")
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public decimal Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }
        public List<Product> ProductList
        {
            get { return this.productList; }

        }
        public string BuyProduct(Product product)
        {
            if (this.Money >= product.Cost)
            {
                this.Money -= product.Cost;
                this.productList.Add(product);
                return $"{this.Name} bought {product.Name}";
            }
            else
            {
                return $"{ this.Name} can't afford {product.Name}";
            }
        }
        public override string ToString()
        {
            if (this.productList.Count > 0)
            {
                return $"{this.Name} - {string.Join(", ", this.productList)}";
            }
            else
            {
                return $"{this.Name} - Nothing bought";
            }
        }
    }
}
