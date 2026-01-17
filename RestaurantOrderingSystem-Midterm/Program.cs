namespace RestaurantOrderingSystem_Midterm
{
    // Data Models
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }

    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public decimal TotalPrice => Product.Price * Quantity;

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }

    // Global State Manager
    public static class OrderManager
    {
        public static List<OrderItem> Items { get; private set; } = new List<OrderItem>();

        public static void AddItem(string name, decimal price, int quantity)
        {
            if (quantity <= 0) return;

            var existingItem = Items.FirstOrDefault(i => i.Product.Name == name);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                Items.Add(new OrderItem(new Product(name, price), quantity));
            }
        }

        public static void RemoveItem(string name) 
        {
             var existingItem = Items.FirstOrDefault(i => i.Product.Name == name);
             if(existingItem != null)
             {
                 Items.Remove(existingItem);
             }
        }

        public static void UpdateQuantity(string name, int delta)
        {
            var existingItem = Items.FirstOrDefault(i => i.Product.Name == name);
            if (existingItem != null)
            {
                existingItem.Quantity += delta;
                if (existingItem.Quantity <= 0)
                {
                    Items.Remove(existingItem);
                }
            }
        }

        public static int GetTotalItems()
        {
            return Items.Sum(i => i.Quantity);
        }

        public static decimal GetGrandTotal()
        {
            return Items.Sum(i => i.TotalPrice);
        }

        public static void ClearOrder()
        {
            Items.Clear();
        }
    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LandingForm());
        }
    }
}