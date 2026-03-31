namespace ProductApp.Models
{
    internal class Product
    {
        private string name;
        private double price;
        private int quantity;
        private static int productCount;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
            }
        }
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value >= 0)
                {
                    quantity = value;
                }
            }
        }

        public static int ProductCount
        {
            get { return productCount; }
        }

        public double TotalValue
        {
            get { return Price * Quantity; }
        }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            productCount++;
        }

        public double ApplyDiscount(double percent)
        {
            return Price - (Price * percent / 100);
        }

        public double ApplyDiscount(double percent, int minQuantity)
        {
            return Quantity >= minQuantity ? Price - (Price * percent / 100) : Price;
        }

        public double ApplyDiscount(double percent, int minQuantity, double maxPrice)
        {
            return (Quantity >= minQuantity && Price < maxPrice)
                ? Price - (Price * percent / 100)
                : Price; // cia galima butu mest Exception kazoki, kaip ir kituose metoduse
        }

        public static Product CreateDefault()
        {
            return new Product("Unknown", 0.01, 0);
        }

        public static Product CreateDefault(string name)
        {
            return new Product(name, 0.01, 0);
        }
    }
}
