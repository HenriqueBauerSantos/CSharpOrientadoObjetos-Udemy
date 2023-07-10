

namespace ExercAula201.Entities {
    class Product {
        public string Name { get; protected set; }
        public double Price { get; protected set; }
        public int Quantity { get; protected set; }

        public Product(string name, double price, int quantity) {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double Total() {
            return Price * Quantity;
        }
    }
}
