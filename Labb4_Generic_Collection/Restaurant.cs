namespace Labb4_Generic_Collection
{
    internal class Restaurant
    {
        public List<MenuItem> _menu = new List<MenuItem>();
        public Queue<Order> _order = new Queue<Order>();

        //Add item to menu
        public void AddtoMenu(MenuItem menuItem)
        {
            _menu.Add(menuItem);
            Console.WriteLine($"¤ New menu item added, {menuItem}");
        }
        //Display menu with added menu items
        public void ShowMenu()
        {
            Console.WriteLine("\n***Restaurant Menu***");
            Console.WriteLine("----------------------");
            foreach (var menu in _menu)
            {
                Console.WriteLine(menu);
            }
            Console.WriteLine("----------------------");
        }
        //Create order with number
        public void CreateOrder(Order order)
        {
            _order.Enqueue(order);
            Console.WriteLine($"Order {order.OrderId()} added.");        
        }
        //Remove order from queue
        public void HandleOrder()
        {
            Order handleOrder = _order.Dequeue();
            Console.WriteLine($"[Order {handleOrder.OrderId()} is served]\n");
        }
        //Show orders in detail
        public void ShowOrders()
        {
            foreach (var showOrder in _order)
            {
                Console.WriteLine(showOrder);
            }
        }
        //Display next order with details
        public void ShowNextOrder()
        {
            Console.WriteLine("[Next order in line:]");
            Console.WriteLine(_order.Peek());
        }
        //Show number of total orders in queue
        public void ShowOrderCount()
        {
            if(_order.Count == 0)
            {
                Console.WriteLine("There are no orders in queue!");
            }
            else
            {
                Console.WriteLine($"[Total orders in queue: {_order.Count}]\n");
            }           
        }
    }
}
