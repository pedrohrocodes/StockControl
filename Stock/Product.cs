using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock {
    public class Product {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        public Product() {

        }

        public Product(string name, double price, int quantity) {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public void SetName(string name) {
            this.Name = name;
        }

        public void SetPrice(double price) {
            this.Price = price;
        }

        public void SetQuantity(int quantity) {
            this.Quantity = quantity;
        }

        public double GetTotalPriceStock() {
            return this.Quantity * this.Price;
        }

        public void AddProduct(int quantity) {
            this.Quantity += quantity;
        }

        public void RemoveProduct(int quantity) {
            this.Quantity -= quantity;
        }

        public override string ToString() {
            return $"{this.Name}, R${this.Price:F2}, {this.Quantity} unidades, Total: R${this.GetTotalPriceStock():F2}";
        }
    }
}
