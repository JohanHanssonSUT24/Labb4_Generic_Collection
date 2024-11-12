namespace Labb4_Generic_Collection
{
    internal class Restaurant
    {
        public List<MenuItem> _menu = new List<MenuItem>();
        public Queue<Order> _order = new Queue<Order>();


        public void AddtoMenu(MenuItem menuItem)
        {
            _menu.Add(menuItem);
            Console.WriteLine($"New menu-item: {menuItem}");
        }
        public void ShowMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("-------------");
            foreach (var menu in _menu)
            {
                Console.WriteLine(menu);
            }
        }
        public void CreateOrder(Order order)
        {
            _order.Enqueue(order);
            Console.WriteLine("----------------");
            Console.WriteLine($"Orders in line:\n{order}");
        }
        public void HandleOrder(Order order)
        {
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
            _order.Peek();
        }
        public void ShowOrderCount()
        {
            Console.WriteLine("The number of orders total: ");
            Console.WriteLine(_order.Count);
        }


    }
}
