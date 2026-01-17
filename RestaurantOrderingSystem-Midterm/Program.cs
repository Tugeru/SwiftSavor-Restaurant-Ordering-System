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

        public static void ClearOrder()
        {
            Items.Clear();
        }

        public static bool IsBurger(Product p)
        {
            return p.Name.Contains("Burger");
        }

        public static bool IsDrink(Product p)
        {
            return p.Name == "Coca Cola" || p.Name == "Iced Tea" || p.Name == "Iced Coffee";
        }

        public static decimal GetSubtotal()
        {
            return Items.Sum(i => i.TotalPrice);
        }

        public static decimal GetBundleDiscount()
        {
            bool hasBurger = Items.Any(i => IsBurger(i.Product));
            bool hasDrink = Items.Any(i => IsDrink(i.Product));
            return (hasBurger && hasDrink) ? 10.00m : 0.00m;
        }

        public static decimal GetVolumeDiscount()
        {
            decimal subtotal = GetSubtotal();
            return (subtotal >= 200.00m) ? subtotal * 0.10m : 0.00m;
        }

        public static decimal GetTax()
        {
            decimal taxableAmount = GetSubtotal() - GetBundleDiscount() - GetVolumeDiscount();
            // Ensure taxable amount doesn't go negative (unlikely but safe)
            if (taxableAmount < 0) taxableAmount = 0;
            return taxableAmount * 0.08m;
        }

        public static decimal GetGrandTotal()
        {
            return GetSubtotal() - GetBundleDiscount() - GetVolumeDiscount() + GetTax();
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