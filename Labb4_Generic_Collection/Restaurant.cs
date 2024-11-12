namespace Labb4_Generic_Collection
{
    internal class Restaurant
    {
        public List<MenuItem> _menu = new List<MenuItem>();
        public Queue<Order> _order = new Queue<Order>();


        public void AddtoMenu(MenuItem menuItem)
        {
            _menu.Add(menuItem);
            Console.WriteLine($"New menu item added, {menuItem}");
        }
        public void ShowMenu()
        {
            Console.WriteLine("\n***Restaurant Menu***");
            Console.WriteLine("---------------------");
            foreach (var menu in _menu)
            {
                Console.WriteLine(menu);
            }
            Console.WriteLine("----------------------");
        }
        public void CreateOrder(Order order)
        {            
            _order.Enqueue(order);
            Console.WriteLine($"Ordernumber: {_order.Count} added.");
            
        }
        public void HandleOrder()
        {
            Console.WriteLine("Customer served!");
            _order.Dequeue();
            Console.WriteLine("");
        }
        public void ShowOrders()
        {
            foreach (var showOrder in _order)
            {
                Console.WriteLine(showOrder);
            }
        }
        public void ShowNextOrder()
        {
            Console.WriteLine("Next order in line:");
            Console.WriteLine(_order.Peek());
        }
        public void ShowOrderCount()
        {
            Console.WriteLine("The number of orders total: ");
            Console.WriteLine(_order.Count);
        }


    }
}
