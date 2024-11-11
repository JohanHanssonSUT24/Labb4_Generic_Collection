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
            foreach (var item in _menu)
            {
                Console.WriteLine(item);
            }
        }
        public void CreateOrder(Order order)
        {
            _order.Enqueue(order);
        }
        public void HandleOrder()
        {
            var order = _order.Dequeue();
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

        }
        public void ShowOrderCount()
        {

        }


    }
}
